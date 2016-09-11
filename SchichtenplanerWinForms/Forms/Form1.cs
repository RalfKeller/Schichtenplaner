using ComponentOwl.BetterListView;
using SchichtenplanerWinForms.Regeln;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchichtenplanerWinForms
{
    public partial class Form1 : Form
    {
        private CultureInfo culture = new CultureInfo("de-DE");

        private Dictionary<ContextMenuStrip, TreeNode> dictContextmenuToTreenode;
        private Dictionary<TreeNode, Schicht> dictTreenodeToSchicht;

        private BindingList<Mitarbeiter> blMitarbeiter;
        private BindingList<Arbeitsbereich> blArbeitsbereiche;
        private BindingList<Schichtart> blSchichtarten;
        private BindingList<Regel> blRegeln;
        private BindingList<Schicht> blSchichten;

        private Rectangle dragBoxFromMouseDown;
        private int rowIndexFromMouseDown;
        private object valueFromMouseDown;



        public Form1()
        {
            InitializeComponent();
            blArbeitsbereiche = new BindingList<Arbeitsbereich>();
            blMitarbeiter = new BindingList<Mitarbeiter>();
            blSchichtarten = new BindingList<Schichtart>();
            blSchichten = new BindingList<Schicht>();
            blRegeln = new BindingList<Regel>();

            dictContextmenuToTreenode = new Dictionary<ContextMenuStrip, TreeNode>();
            dictTreenodeToSchicht = new Dictionary<TreeNode, Schicht>();

            blArbeitsbereiche.ListChanged += BlArbeitsbereiche_ListChanged;
            blSchichtarten.ListChanged += BlSchichtarten_ListChanged;

            initializePlanView();
            initializeArbeitsbereichGrid();
            initializeMitarbeiterGrid();

            gcKalender.ShowCurrentCellBorderBehavior = GridShowCurrentCellBorder.HideAlways;
            gcKalender.DefaultGridBorderStyle = GridBorderStyle.None;
            gcKalender.RowStyles[0].Borders.All = new GridBorder(GridBorderStyle.None);

            //Mitarbeiterbinding an die Combobox
            BindingSource bs = new BindingSource();
            bs.DataSource = blMitarbeiter;
            comboMitarbeiter.DataSource = bs;
            comboMitarbeiter.DisplayMember = "Name";

            //Regelbinding an die Listview
            lstbxRegeln.DataSource = blRegeln;
        }

        private void initializePlanView()
        {
            int days = DateTime.DaysInMonth(dtpViewmonth.Value.Year, dtpViewmonth.Value.Month);
            gcKalender.ColCount = days;
            gcKalender.RowCount = 1;
            gcKalender.VScrollPixel = true;


            for (int i = 1; i <= days; i++)
            {
                DateTime dt = new DateTime(dtpViewmonth.Value.Year, dtpViewmonth.Value.Month, i);

                string text = i + "." + dt.Month + "." + dt.Year + ": " + culture.DateTimeFormat.GetDayName(dt.DayOfWeek);
                GridStyleInfo style = new GridStyleInfo();

                gcKalender.Model[0, i].CellValue = text;
                gcKalender.ColWidths.ResizeToFit(GridRangeInfo.Cell(0, i));

                FlowLayoutPanel flowLayout = new FlowLayoutPanel();
                flowLayout.FlowDirection = FlowDirection.TopDown;
                gcKalender[1, i].Control = flowLayout;
                gcKalender[1, i].CellType = "Control";

            }
        }

        private void BlSchichtarten_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
                Schichtart neueSchichtart = blSchichtarten[e.NewIndex];

                for (int i = 1; i < gcKalender.ColCount + 1; i++)
                {
                    if(neueSchichtart.Wochentage.Contains(gcKalender.Model[0, i].CellValue.ToString().Split(':')[1].Trim()))
                    {
                        FlowLayoutPanel flowLayout = gcKalender[1, i].Control as FlowLayoutPanel;
                        TreeViewAdv tv = new TreeViewAdv();
                        tv.Style = TreeStyle.Metro;

                        Schicht neueSchicht = neueSchichtart.getSchicht();
                        neueSchicht.Date = new DateTime(dtpViewmonth.Value.Year, dtpViewmonth.Value.Month, i);
                        blSchichten.Add(neueSchicht);
                        SchichtNode n = new SchichtNode(neueSchicht);
                        tv.Nodes.Add(n);
                        //n.Nodes.Add(new TreeNodeAdv("Just a test"));

                        int height = tv.Height + tv.Margin.All + flowLayout.Margin.All + flowLayout.Padding.All;
                        gcKalender.RowHeights.SetSize(1, height);
                        flowLayout.Controls.Add(tv);
                        
                        //gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Cell(1, i));
                    }
                }
                //foreach (TreeNode tag in lvPlanung.Nodes)
                //{
                //    if (neueSchichtart.Wochentage.Contains(tag.Text.Split(':')[1].Trim()))
                //    {
                //        SchichtNode schichtNode = new SchichtNode(neueSchichtart.getSchicht());
                //        //dictTreenodeToSchicht.Add(tag, neueSchichtart.getSchicht());
                //        tag.Nodes.Add(schichtNode);
                //    }
                //}

                foreach (TreeNode tnArbeitsbereich in tvSchichten.Nodes)
                {
                    if(tnArbeitsbereich.Text == neueSchichtart.Arbeitsbereich.Name)
                    {
                        tnArbeitsbereich.Nodes.Add(neueSchichtart.Name);
                    }
                }
            }

            if (e.ListChangedType == ListChangedType.ItemChanged)
            {
            }

        }


        /// <summary>
        /// Wird aufgerufen, wenn blArbeitsbereiche geändert wird.
        /// Aufgabe: Synchronisiert Änderungen mit tvSchichten
        /// </summary>
        private void BlArbeitsbereiche_ListChanged(object sender, ListChangedEventArgs e)
        {
            if(e.ListChangedType == ListChangedType.ItemAdded)
            {
                TreeNode newNode = new TreeNode(blArbeitsbereiche[e.NewIndex].Name);
                ContextMenuStrip contextMenu = new ContextMenuStrip();
                contextMenu.Items.Add("Schicht hinzufügen");

                contextMenu.ItemClicked += ctxtMenuSchichtView_ItemClicked;
                newNode.ContextMenuStrip = contextMenu;

                tvSchichten.Nodes.Add(newNode);

                dictContextmenuToTreenode.Add(contextMenu, newNode);
            }

            if(e.ListChangedType == ListChangedType.ItemDeleted)
            {
                foreach (TreeNode node in tvSchichten.Nodes)
                {
                    if(!blArbeitsbereiche.Any(a => a.Name == node.Text))
                    {
                        tvSchichten.Nodes.Remove(node);
                        break;
                    }
                }
            }

        }

        /// <summary>
        /// Initialisiert die Arbeitsbereichtabelle
        /// </summary>
        private void initializeArbeitsbereichGrid()
        {
            Arbeitsbereich k = new Arbeitsbereich() { Name = "Küche" };
            Arbeitsbereich b = new Arbeitsbereich() { Name = "Büro" };
            blArbeitsbereiche.Add(k);
            blArbeitsbereiche.Add(b);

            dgvArbeitsbereiche.DataSource = blArbeitsbereiche;
        }

        /// <summary>
        /// Initialisiert die Mitarbeitertabelle
        /// </summary>
        private void initializeMitarbeiterGrid()
        {
            Mitarbeiter ralf = new Mitarbeiter()
            {
                Name = "Ralf Keller",
                GeplanteArbeitszeit = 15,
            };

            Mitarbeiter rustam = new Mitarbeiter()
            {
                Name = "Rustam Karimov",
                GeplanteArbeitszeit = 30
            };

            Mitarbeiter stefan = new Mitarbeiter()
            {
                Name = "Stefan Mayer",
                GeplanteArbeitszeit = 15
            };

            List<Mitarbeiter> lstMitarbeiter = new List<Mitarbeiter>() { ralf, rustam, stefan };
            blMitarbeiter = new BindingList<Mitarbeiter>(lstMitarbeiter);

            mitarbeiterGrid.DataSource = blMitarbeiter;
            mitarbeiterGridSmall.DataSource = blMitarbeiter;

            ralf.Arbeitsbereiche.Add(blArbeitsbereiche[0]);
            rustam.Arbeitsbereiche.Add(blArbeitsbereiche[0]);
        }

        private void btnAddMitarbeiter_Click(object sender, EventArgs e)
        {
            Mitarbeiter neuerMitarbeiter = new Mitarbeiter();

            MitarbeiterDialog diag = new MitarbeiterDialog(neuerMitarbeiter, blArbeitsbereiche);
            diag.ShowDialog();
        }

        private void btnEditMitarbeiter_Click(object sender, EventArgs e)
        {
            if (mitarbeiterGrid.SelectedRows.Count == 0)
                return;

            Mitarbeiter m = (Mitarbeiter)mitarbeiterGrid.SelectedRows[0].DataBoundItem;
            MitarbeiterDialog diag = new MitarbeiterDialog(m, blArbeitsbereiche);
            diag.ShowDialog();
        }

        private void ctxtMenuSchichtView_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            TreeNode parent;
            dictContextmenuToTreenode.TryGetValue((ContextMenuStrip)sender, out parent);

            if(parent != null)
            {
                Schichtart s = new Schichtart();
                SchichtDialog diag = new SchichtDialog(s, blArbeitsbereiche, blArbeitsbereiche.First(a => a.Name == parent.Text));
                if(diag.ShowDialog() == DialogResult.OK)
                {
                    blSchichtarten.Add(s);
                }
            }
        }

        #region Drag & Drop Handler

        private void mitarbeiterGridSmall_MouseDown(object sender, MouseEventArgs e)
        {
            Point clientCoordinates = mitarbeiterGridSmall.PointToClient(new Point(e.X, e.Y));
            DataGridView.HitTestInfo hittestInfo = mitarbeiterGridSmall.HitTest(e.X, e.Y);

            if (hittestInfo.RowIndex != -1 && hittestInfo.ColumnIndex != -1)
            {
                valueFromMouseDown = mitarbeiterGridSmall.Rows[hittestInfo.RowIndex].DataBoundItem;
                if (valueFromMouseDown != null)
                {
                    rowIndexFromMouseDown = hittestInfo.RowIndex;

                    if (mitarbeiterGridSmall.SelectedRows.Count > 0)
                        mitarbeiterGridSmall.SelectedRows[0].Selected = false;

                    mitarbeiterGridSmall.Rows[hittestInfo.RowIndex].Selected = true;
                    Size dragSize = SystemInformation.DragSize;

                    dragBoxFromMouseDown = new Rectangle(new Point(clientCoordinates.X - (dragSize.Width / 2), clientCoordinates.Y - (dragSize.Height / 2)), dragSize);
                }
            }
            else
                // Reset the rectangle if the mouse is not over an item in the ListBox.
                dragBoxFromMouseDown = Rectangle.Empty;
        }


        private void gcKalender_DragOver(object sender, DragEventArgs e)
        {
            //e.Effect = DragDropEffects.Link;
        }

        private void gcKalender_DragDrop(object sender, DragEventArgs e)
        {
            int rowIndex;
            int colIndex;
            gcKalender.PointToRowCol(gcKalender.PointToClient(new Point(e.X, e.Y)), out rowIndex, out colIndex);

            if (rowIndex > 0 && colIndex > 0)
            {
                FlowLayoutPanel flowLayout = (FlowLayoutPanel)gcKalender[rowIndex, colIndex].Control;
                TreeViewAdv tv = (TreeViewAdv)flowLayout.Controls[0];

                TreeNodeAdv node = tv.GetNodeAtPoint(tv.PointToClient(new Point(e.X, e.Y)));

                if (node != null && node is SchichtNode)
                {
                    SchichtNode schichtNode = node as SchichtNode;
                    schichtNode.addMitarbeiter((Mitarbeiter)e.Data.GetData(typeof(Mitarbeiter)));
                    gcKalender.Refresh();
                }
            }
        }

        #endregion

        private void btnMakePlan_Click(object sender, EventArgs e)
        {
            List<Regel> lstAlleRegeln = new List<Regel>();
            lstAlleRegeln.AddRange(blRegeln);

            foreach (Mitarbeiter mArbeiter in blMitarbeiter)
            {
                lstAlleRegeln.AddRange(RegelInfo.getDefaultRegelnFürMitarbeiter(mArbeiter));
            }

            lstAlleRegeln.AddRange(RegelInfo.getFreieRegeln());

            List<Arbeitstag> lstTage = new List<Arbeitstag>();

            int year = dtpViewmonth.Value.Year;
            int month = dtpViewmonth.Value.Month;
            int daysInMonth = DateTime.DaysInMonth(year, month);

            for (int i = 0; i < daysInMonth; i++)
            {
                lstTage.Add(new Arbeitstag());
            }

            foreach (Schicht schicht in blSchichten)
            {
                if(schicht.Date.Year == year && schicht.Date.Month == month)
                {
                    lstTage[schicht.Date.Day - 1].lstSchichten.Add(schicht);
                }
            }

            int schichtCount = blSchichten.Count;

            Möglichkeit ersteMöglichkeit = new Möglichkeit(lstTage, 0, blMitarbeiter.ToList());
            PriorityQueue<Möglichkeit> pqMöglichkeiten = new PriorityQueue<Möglichkeit>();

            pqMöglichkeiten.add(ersteMöglichkeit, ersteMöglichkeit.punktzahl(lstAlleRegeln));

            while (pqMöglichkeiten.Count() > 0)
            {
                Möglichkeit currentMöglichkeit = pqMöglichkeiten.pop();

                if (currentMöglichkeit.linealisierterIndex == schichtCount)
                {
                    string tempFile = Path.GetTempFileName();
                    StreamWriter writer = new StreamWriter(tempFile);

                    foreach (Arbeitstag tag in currentMöglichkeit.lstArbeitstage)
                    {
                        writer.WriteLine("Tag: " + tag.dtDatum.ToString("dd.MM.yyyy"));
                        foreach (Schicht schicht in tag.lstSchichten)
                        {
                            writer.WriteLine("\tSchicht: " + schicht.Parent.Name);
                            foreach (Mitarbeiter mArbeiter in schicht.Mitarbeiter)
                            {
                                writer.WriteLine("\t\t" + mArbeiter.Name);
                            }
                        }

                    }
                    writer.Close();
                    Process.Start(tempFile);
                    return;
                }

                List<Möglichkeit> lstNeueMöglichkeiten = currentMöglichkeit.permutiere();

                foreach (Möglichkeit neueMöglichkeit in currentMöglichkeit.permutiere())
                {
                    pqMöglichkeiten.add(neueMöglichkeit, neueMöglichkeit.punktzahl(lstAlleRegeln));
                }


            }

        }

        private void gcKalender_CellClick(object sender, GridCellClickEventArgs e)
        {

        }

        private void gcKalender_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Link;
        }

        private void mitarbeiterGridSmall_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                // If the mouse moves outside the rectangle, start the drag.
                if (dragBoxFromMouseDown != Rectangle.Empty &&
                    !dragBoxFromMouseDown.Contains(e.X, e.Y))
                {

                    // Proceed with the drag and drop, passing in the list item.                    
                    DragDropEffects dropEffect = mitarbeiterGridSmall.DoDragDrop(
                    mitarbeiterGridSmall.Rows[rowIndexFromMouseDown].DataBoundItem,
                    DragDropEffects.Move);
                }
            }
        }

        private void gcKalender_CellMouseHover(object sender, GridCellMouseEventArgs e)
        {
            //gcKalender.CurrentCell.set
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Mitarbeiter mArbeiter = (Mitarbeiter)comboMitarbeiter.SelectedItem;
            DateTime dtStart = dtpVon.Value.Date;
            DateTime dtEnd = dtpBis.Value.Date;

            List<DateTime> lstDays = new List<DateTime>();

            for (DateTime dtCurrent = dtStart; dtCurrent <= dtEnd; dtCurrent = dtCurrent.AddDays(1))
            {
                lstDays.Add(dtCurrent);
            }

            Regel selectedRegel = null;
            switch (comboRegel.Text)
            {
                case "möchte arbeiten":
                    selectedRegel = new MöchteArbeitenRegel(mArbeiter, lstDays, Convert.ToInt32(comboPrio.Text), true);
                    break;
                case "Möchte nicht Arbeiten":
                    selectedRegel = new MöchteArbeitenRegel(mArbeiter, lstDays, Convert.ToInt32(comboPrio.Text), true);
                    break;
                default:
                    break;
            }

            blRegeln.Add(selectedRegel);
        }
    }
}

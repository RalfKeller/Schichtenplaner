using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchichtenplanerWinForms
{
    public partial class Form1 : Form
    {
        BindingList<Mitarbeiter> blMitarbeiter;
        private Rectangle dragBoxFromMouseDown;
        private int rowIndexFromMouseDown;
        private object valueFromMouseDown;

        public Form1()
        {
            InitializeComponent();

            initializeMitarbeiterGrid();
        }

        private void initializeMitarbeiterGrid()
        {
            string[] arrArbeiter = new string[] { "Ralf Keller", "Rustam Karimov", "Stefan Mayer" };
            Mitarbeiter ralf = new Mitarbeiter()
            {
                Name = "Ralf Keller",
                GeplanteArbeitszeit = 15
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
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Mitarbeiter neuerMitarbeiter = new Mitarbeiter();

            MitarbeiterDialog diag = new MitarbeiterDialog(neuerMitarbeiter);
            diag.ShowDialog();
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
                             DragDropEffects.Link);
                }
            }
        }

        private void mitarbeiterGridSmall_MouseDown(object sender, MouseEventArgs e)
        {
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

                    dragBoxFromMouseDown = new Rectangle(new Point(e.X - (dragSize.Width / 2), e.Y - (dragSize.Height / 2)), dragSize);
                }
            }
            else
                // Reset the rectangle if the mouse is not over an item in the ListBox.
                dragBoxFromMouseDown = Rectangle.Empty;
        }

        private void treeView1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Link;

            var pos = treeView1.PointToClient(new Point(e.X, e.Y));
            var hit = treeView1.HitTest(pos);
            if (hit.Node != null)
            {
                hit.Node.Expand();
                treeView1.SelectedNode = hit.Node;
                treeView1.Focus();
            }
        }

        private void treeView1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Link;
        }

        private void treeView1_DragDrop(object sender, DragEventArgs e)
        {
            Mitarbeiter a = new Mitarbeiter();
            Type t = a.GetType();
            TreeViewHitTestInfo hitInfo = treeView1.HitTest(treeView1.PointToClient(new Point(e.X, e.Y)));
            Mitarbeiter m = (Mitarbeiter)e.Data.GetData(t);
            hitInfo.Node.Nodes.Add(m.Name);
        }
    }
}

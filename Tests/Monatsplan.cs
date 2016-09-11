using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;

namespace Tests
{
    public partial class Monatsplan : UserControl
    {
        public Monatsplan()
        {
            InitializeComponent();

            gridControl1.RowCount = 2;
            for (int i = 1; i < 10; i++)
            {
                FlowLayoutPanel p = new FlowLayoutPanel();
                p.FlowDirection = FlowDirection.TopDown;
                p.AutoSize = true;

                gridControl1.AutoScrolling = ScrollBars.Both;
                GridControlBase.UseOldHiddenScrollLogic = true;
                //gridControl1.HScrollPixel = true;
                gridControl1.VScrollPixel = true;
                gridControl1.HScroll = true;
                gridControl1.HScrollBehavior = GridScrollbarMode.Enabled;
                gridControl1.Model[1, i].Control = p;
                gridControl1.Model[1, i].CellType = "Control";

                Button b2 = new Button();

                gridControl1.RowHeights.SetSize(1, 10 * (23 + 2 * (b2.Margin.All)) + 1* (p.Margin.All));
                gridControl1.ColWidths.SetSize(i, b2.Width + b2.Margin.All + p.Margin.All);
                gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Rows(0, 1), GridResizeToFitOptions.NoShrinkSize);

                for (int x = 0; x < 10; x++)
                {
                    Button b = new Button();
                    b.Text = "Tets";

                    b.Click += B_Click;
                    p.Controls.Add(b);
                }

            }
        }

        private void B_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;

            gridControl1.RowHeights.SetSize(1, gridControl1.RowHeights.GetSize(1) + 30);
            b.Height += 30;
            gridControl1.Refresh();
            
        }
    }
}

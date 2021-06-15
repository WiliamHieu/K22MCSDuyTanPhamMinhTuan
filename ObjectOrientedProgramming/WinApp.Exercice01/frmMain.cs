using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Exercice01
{
    public partial class frmMain : Form
    {
        private List<Ant> lstAnt = null;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            cmdCreate_Click(sender, e);
        }

        private void cmdCreate_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            var chars = "WDQ";
            var rdChar = string.Empty;

            lstAnt = new List<Ant>();

            Ant entAnt;
            for (int i = 0; i < 10; i++)
            {
                rdChar = chars[random.Next(chars.Length)].ToString();

                if (rdChar == "W")
                {
                    entAnt = new Worker();
                }
                else if (rdChar == "D")
                {
                    entAnt = new Drone();
                }
                else
                {
                    entAnt = new Queen();
                }
                lstAnt.Add(entAnt);
            }
            gridMain.DataSource = lstAnt;
        }

        private void cmdAttack_Click(object sender, EventArgs e)
        {
            Random random; int health;
            foreach (Ant entAnt in lstAnt)
            {
                random = new Random();
                health = random.Next(80);

                Thread.Sleep(10); 

                entAnt.Damage(health);
            }
            gridMain.Refresh();
        }

        private void gridMain_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(((DataGridView)sender).RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
    }
}

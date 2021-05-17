using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabRab15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtChooseFont_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChooseColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.FullOpen = true;
            dlg.ShowHelp = true;
            dlg.Color = panelChooseColor.BackColor;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                BackColor = dlg.Color;
            }
        }

        private void btnChooseFont_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            dlg.ShowColor = true;
            dlg.ShowHelp = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                btnChooseFont.Font = dlg.Font;
                
                btnChooseColor.Font = dlg.Font;
                
                btnChooseFC.Font = dlg.Font;

                btnCalc.Font = dlg.Font;

                label1.Font = dlg.Font;

                label2.Font = dlg.Font;

                label3.Font = dlg.Font;

                txtTerms.Font = dlg.Font;

                txtAnswer.Font = dlg.Font;

                textBoxX.Font = dlg.Font;
            }
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {

        }

        private void btnChooseFC_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.FullOpen = true;
            dlg.ShowHelp = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                btnChooseFont.ForeColor = dlg.Color;

                btnChooseColor.ForeColor = dlg.Color;

                btnChooseFC.ForeColor = dlg.Color;

                btnCalc.ForeColor = dlg.Color;

                label1.ForeColor = dlg.Color;

                label2.ForeColor = dlg.Color;

                label3.ForeColor = dlg.Color;

                txtTerms.ForeColor = dlg.Color;

                txtAnswer.ForeColor = dlg.Color;

                textBoxX.ForeColor = dlg.Color;
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBoxX.Text);
            int n = Convert.ToInt32(txtTerms.Text);
            double ans = 0;
            double item;
            int k = 2;
            double fac = 1;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= k; j++)
                {
                    fac *= j;
                }

                item = (i % 2 == 0) ? (Math.Sin(Math.Pow(x, i)) * Math.Pow(x, k)) / fac : (Math.Pow(x, i) * Math.Sin(Math.Pow(x, k))) / fac;
                ans += item;
                k++;
                fac = 1;
            }
            txtAnswer.Text = ans.ToString();

        }
    }
}

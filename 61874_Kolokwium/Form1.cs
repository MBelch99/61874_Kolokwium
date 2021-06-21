using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _61874_Kolokwium
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRec_Click(object sender, EventArgs e)
        {
            string Name = tbName.Text;

            float number = float.Parse(tbNumber.Text);
            float cena = 0;
            if (rdoS.Checked)
            {
                cena = cena + 16;
            }
            if (rdoM.Checked)
            {
                cena = cena + 20;
            }
            if (rdoL.Checked)
            {
                cena = cena + 24;
            }
            if (chbP1.Checked)
            {
                string top1;
                top1 = "Topping: "+chbP1.Text;
                cena = cena + 2;
            }
             if (chbP2.Checked)
            {
                string top2;
                top2 = "Topping: " + chbP2.Text;

                cena = cena + 2;
            }
             if (chbS.Checked)
            {
                string top3;
                top3 = "Topping: " +  chbS.Text;
                cena = cena + 3;
            }
            if (chbM.Checked)
            {
                string top4;
                top4 = "Topping: " + chbM.Text;
                cena = cena + 1;
            }
            if (chbO.Checked)
            {
                string top5;
                top5 = "Topping: " + chbO.Text;
                cena = cena + 1;
            }
            cena = cena * number;
            string newLine = Environment.NewLine;
            tbOreder.Text = "Name: " + Name.ToString()+newLine+
                "Number of Pizza's: " + number.ToString() + newLine +
                "Topping: " + chbP1.Text + newLine +
                "Topping: " + chbP2.Text + newLine +
                "Topping: " + chbS.Text + newLine +
                "Topping: " + chbM.Text + newLine +
                "Topping: " + chbO.Text + newLine +
                "Total: " + cena.ToString();
        }

        private void btnCom_Click(object sender, EventArgs e)
        {
            float cena = 0;
            float czasO = 0;
            if (rdoS.Checked)
            {
                cena = cena + 16;
                czasO = 30;
            }
            if (rdoM.Checked)
            {
                cena = cena + 20;
                czasO = 45;
            }
            if (rdoL.Checked)
            {
                cena = cena + 24;
                czasO = 60;
            }
            if (chbP1.Checked)
            {
                cena = cena + 2;
            }
            if (chbP2.Checked)
            {
                cena = cena + 2;
            }
            if (chbS.Checked)
            {
                cena = cena + 3;
            }
            if (chbM.Checked)
            {
                cena = cena + 1;
            }
            if (chbO.Checked)
            {
                cena = cena + 1;
            }
            float number = float.Parse(tbNumber.Text);
            cena = cena * number;
            MessageBox.Show("Czas Oczekiwania " + czasO + "minut, Kwota: " + cena+"zł.", "Zamówienie Zrealizowane", MessageBoxButtons.OK);
        }
    }
}

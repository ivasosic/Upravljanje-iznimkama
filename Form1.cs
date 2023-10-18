using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace upravljanjeIznimkamaForms
{
    public partial class Fo : Form
    {
        public Fo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int godRod = Convert.ToInt16(txtUnos.Text);
                txtIspis.Text = godRod.ToString();
                txtUnos.Clear();
            }
            catch (Exception greska)
            {
                DialogResult odabir = MessageBox.Show("Molim Vas da upisete broj; \n Da li zelite izbrisati Vas postojeci unos?",
                    "Pogresan unos", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                switch (odabir)
                {
                case DialogResult.Yes:
                    txtUnos.Clear(); break;

                case DialogResult.No:
                    break;
                }
                txtUnos.Select();
            }
        }
    }
}

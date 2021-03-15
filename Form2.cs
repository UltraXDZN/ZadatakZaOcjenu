using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZadatakZaOcjenu
{
    public partial class Form2 : Form
    {
        NotifyEvent notifyDel;
        Osoba osoba = new Osoba();

        public Form2(NotifyEvent notify)
        {
            InitializeComponent();
            notifyDel = notify;
        }

        private void PodaciUnos_Click(object sender, EventArgs e)
        {
            try
            {
                osoba.ime = imeText.Text;
                osoba.prezime = prezimeText.Text;
                osoba.godRod = int.Parse(godRodText.Text);
                osoba.spol = spolComboBox.Text;
                notifyDel.Invoke(osoba);
                Hide();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

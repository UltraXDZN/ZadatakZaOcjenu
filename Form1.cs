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
    public delegate void NotifyEvent(Osoba osoba);
    public partial class Form1 : Form
    {
        public NotifyEvent notifyDelegate;

        Form2 formaZaUnos = null;
        List<Osoba> podaci = new List<Osoba>();

        public Form1()
        {
            InitializeComponent();
            notifyDelegate += new NotifyEvent(inputOnAnotherForm);
        }

        private void UnosButton_Click(object sender, EventArgs e)
        {
            formaZaUnos = new Form2(notifyDelegate);
            formaZaUnos.Show();
        }

        public void inputOnAnotherForm(Osoba osoba)
        {
            podaci.Add(osoba);
        }

        private void IspisButton_Click(object sender, EventArgs e)
        {
            rjesenjeTextBox.Text = "";
            foreach (var osoba in podaci) {
                rjesenjeTextBox.Text += $"{osoba.ime}\t\t{osoba.prezime}\t\t{osoba.godRod}\t\t{osoba.spol}\t\t{osoba.brkovi}\r\n";
            }
        }

        private void ObradiButton_Click(object sender, EventArgs e)
        {
            foreach (var osoba in podaci)
            {
                osoba.brkovi = osoba.spol == "M" ? "Ima brkove" : "Nema brkove";
            }
        }
    }
}

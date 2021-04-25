using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KodUretici
{
    public partial class konsolForm : Form
    {

        public konsolForm()
        {
            InitializeComponent();
        }

        private void TamamButon_Click(object sender, EventArgs e)
        {
            Form1.konsolQuery = konsolText.Text;
            this.Close();
        }

        private void İptalButon_Click(object sender, EventArgs e)
        {
            Form1.konsolQuery = "";
            this.Close();
        }

        public void veritabani(string text)
        {
            veritbaniText.Text += text;
        }
    }
}

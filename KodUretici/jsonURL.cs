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
    public partial class jsonURL : Form
    {
        public jsonURL()
        {
            InitializeComponent();
        }

        private void OnaylaButon_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.url = urlText.Text;
            this.Close();
        }
    }
}

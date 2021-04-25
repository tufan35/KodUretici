using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KodUretici
{
    public partial class Baglan : Form
    {
        List<string> databaseList;
        SqlConnection con;
        public Baglan()
        {
            InitializeComponent();
        }

        private void Baglan_Load(object sender, EventArgs e)
        {
            serverText.Text = Properties.Settings.Default.serverName;
            userText.Text = Properties.Settings.Default.userName;
            passText.Text = Properties.Settings.Default.sifre;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = false;
            this.groupBox1.Enabled = false;
            this.button1.Text = "Bağlanıyor...";
            string baglantiString = "data source ="+serverText.Text+";user id ="+userText.Text+";password="+passText.Text+ ";MultipleActiveResultSets=True;initial catalog=master";

            try
            {
                databaseList = DatabaseIsimleri(baglantiString);
                baglantiString = "data source =" + serverText.Text + ";user id =" + userText.Text + ";password=" + passText.Text + ";MultipleActiveResultSets=True;initial catalog=";
                Properties.Settings.Default.baglanti = baglantiString;
                Properties.Settings.Default.serverName = serverText.Text;
                Properties.Settings.Default.userName = userText.Text;
                Properties.Settings.Default.sifre = passText.Text;
                Properties.Settings.Default.Save();
                this.Close();
            }
            catch
            {
                MessageBox.Show("SQL Server ile bağlantı kurulamadı!");
                this.button1.Enabled = true;
                this.groupBox1.Enabled = true;
                this.button1.Text = "Bağlan";
            }
        }

        public List<string> dbList()
        {
            return databaseList;
        }

        public List<string> DatabaseIsimleri(string conString)
        {
            List<string> list = new List<string>();
            using (con = new SqlConnection(conString))
            {
                con.Open();
                // Set up a command with the given query and associate
                // this with the current connection.
                using (SqlCommand cmd = new SqlCommand("SELECT name from sys.databases ORDER BY name ASC", con))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            list.Add(dr[0].ToString());
                        }
                    }
                }

                con.Close();
            }
            //list = list.OrderBy(i => i).ToList();
            return list;
        }
    }
}

using KodUretici.Models;
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
using KodUretici.Resources;
using System.IO;

namespace KodUretici
{
    public partial class SettingsFrameworkGenerate : Form
    {
        CodeGenerator cdg = new CodeGenerator();
        private readonly string _sablon;
        FileManager fileManager = new FileManager();
        public string DatabasName;
        public SqlConnection conn;

        public SettingsFrameworkGenerate(string sablon)
        {
            this._sablon = sablon;
            InitializeComponent();
        }
        public SettingsFrameworkGenerate()
        {
            InitializeComponent();
        }

        private void LoadTable()
        {
            try
            {
                System.Data.SqlClient.SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet ds = new DataSet();
                DataSet dsTablesInformations = new DataSet();
                //string command = string.Format("select st.TABLE_SCHEMA,st.TABLE_NAME from INFORMATION_SCHEMA.TABLES st");
                string command = string.Format("select st.TABLE_NAME from INFORMATION_SCHEMA.TABLES st order by st.TABLE_NAME asc ");

                SqlCommand comm = new SqlCommand(command, conn);
                adapter.SelectCommand = comm;
                adapter.Fill(ds);
                adapter.Dispose();
                comm.Dispose();
                conn.Close();

                checkedListBox1.DataSource = ds.Tables[0];
                this.checkedListBox1.DisplayMember = "TABLE_NAME";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nİç Hata:" + ex.InnerException?.Message);
            }
        }

        private void ButtonFileGenerate_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                fileManager.ClearTempDirectory();

            foreach (object itemChecked in checkedListBox1.CheckedItems)
            {
                DataRowView castedItem = itemChecked as DataRowView;
                string tableName = castedItem["TABLE_NAME"].ToString();
                ListView tekrarListView = new ListView();
                ListView degiskenListView = new ListView();
                degiskenListView.Items.Add(new ListViewItem(new string[] { "var" + 1 + ",tip" + 1, tableName, tableName }));
                foreach (DataRow item in PullData(tableName).Rows)
                {
                    var tip = tipDegistirme.tipDegis(item.ItemArray[1].ToString());
                    if (tip.Contains("varchar"))
                        tip = "string";
                    else if (tip.Contains("decimal("))
                        tip = "decimal";
                    if (tip != "string" && item.ItemArray[2].Equals("YES"))
                        tip += "?";
                    tekrarListView.Items.Add(new ListViewItem(new string[] { item.ItemArray[0].ToString(), tip }));
                }
                var text = cdg.GenerateFromToThemplate(_sablon, tekrarListView, degiskenListView);
                fileManager.CreateFile(textBoxGeneralFileName.Text.Replace("@TName", tableName), text);
            }
            MessageBox.Show("Dosyalar Başarıyla Oluşturuldu");
        }



        public DataTable PullData(string tableName)
        {
            var query = $@"SELECT 
sc.COLUMN_NAME,
sc.DATA_TYPE,
sc.IS_NULLABLE 
FROM INFORMATION_SCHEMA.COLUMNS sc
                                where sc.TABLE_NAME = '{tableName}'
                                order by sc.ORDINAL_POSITION";
            DataTable dtTable = new DataTable();
            SqlCommand cmd2 = new SqlCommand(query, conn);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            conn.Open();
            da2.Fill(dtTable);
            conn.Close();
            return dtTable;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, checkBox1.Checked);
            }
        }

        private void SettingsFrameworkGenerate_Load(object sender, EventArgs e)
        {
            LoadThemplateCombobox();
        }

        private void LoadThemplateCombobox()
        {
            LoadTable();
        }


    }
}


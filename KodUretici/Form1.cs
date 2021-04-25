using KodUretici.Resources;
using Newtonsoft.Json.Linq;
using ScintillaNET;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using System.Xml.Linq;

namespace KodUretici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            degiskenListView.View = View.Details;
            degiskenListView.GridLines = true;
            //degiskenListView.Columns.Add("ID");
            degiskenListView.Columns.Add("Değişken");
            degiskenListView.Columns.Add("Tip");

            tekrarListView.View = View.Details;
            tekrarListView.GridLines = true;

            degiskenListView.Items.Add(new ListViewItem(new string[] { "var1,tip1", "Musteri", "" }));
            tekrarListView.Items.Add(new ListViewItem(new string[] { "ID", "int" }));
            tekrarListView.Items.Add(new ListViewItem(new string[] { "Name", "string" }));
            tekrarListView.Items.Add(new ListViewItem(new string[] { "Surname", "string" }));

            yazi1.Hide();
            dbComboBox.Hide();
            yazi2.Hide();
            tabloComboBox.Hide();
            tabloEkleButton.Hide();
        }

        Scintilla sablonTextArea, ciktiTextArea;
        List<string> sablonIsim;
        private void Form1_Load(object sender, EventArgs e)
        {
            sablonTextArea = new Scintilla();
            ciktiTextArea = new Scintilla();
            sablonTextPanel.Controls.Add(sablonTextArea);
            ciktiTextPanel.Controls.Add(ciktiTextArea);
            ScintillaAyarlar(sablonTextArea);
            ScintillaAyarlar(ciktiTextArea);

            sablonTextArea.Text = Properties.Resources.merhaba.ToString();

            kodUretButon.PerformClick();
            yenileButon.PerformClick();
        }

        private void EkleButon_Click(object sender, EventArgs e)
        {
            bool itemYok = true;
            foreach (ListViewItem item in degiskenListView.Items)
            {
                if (item.SubItems[1].Text == degiskenIsimText.Text)
                {
                    item.SubItems[2].Text = degiskenTipText.Text;
                    itemYok = false;
                }
            }
            if (itemYok)
            {
                int id = degiskenListView.Items.Count + 1;
                degiskenListView.Items.Add(new ListViewItem(new string[] { "var" + id.ToString() + ",tip" + id.ToString(), degiskenIsimText.Text, degiskenTipText.Text }));
            }
        }

        private void SilButon_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in degiskenListView.Items)
                if (item.Selected)
                    degiskenListView.Items.Remove(item);
            int id = 1;
            foreach (ListViewItem item in degiskenListView.Items)
            {
                item.Text = "var" + id + ",tip" + id;
                id++;
            }
        }

        private void TekrarEkleButon_Click(object sender, EventArgs e)
        {
            bool itemYok = true;
            foreach (ListViewItem item in tekrarListView.Items)
            {
                if (item.Text == tekrarIsimText.Text)
                {
                    item.SubItems[1].Text = tekrarTipText.Text;
                    itemYok = false;
                }
            }
            if (itemYok)
                tekrarListView.Items.Add(new ListViewItem(new string[] { tekrarIsimText.Text, tekrarTipText.Text }));
        }

        private void TekrarSilButon_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in tekrarListView.Items)
                if (item.Selected)
                    tekrarListView.Items.Remove(item);
        }

        private void KopyalaButon_Click(object sender, EventArgs e)
        {
            if (ciktiTextArea.Text != "")
                Clipboard.SetText(ciktiTextArea.Text);
        }

        private void KodUretButon_Click(object sender, EventArgs e)
        {
            CodeGenerator generator = new CodeGenerator();
            ciktiTextArea.Text = generator.GenerateFromToThemplate(sablonTextArea.Text, tekrarListView, degiskenListView);
            //int id;
            //string[] ciktiListe = sablonTextArea.Text.Split(new string[] { "@tr", "@etr" }, StringSplitOptions.None);
            //List<string> list = new List<string>();
            //string[] kopyala = list.ToArray();
            //int y = 0;
            //for (int i = 1; i < ciktiListe.Length - 1; i = i + 2)
            //{
            //    list.Add(ciktiListe[i]);
            //    kopyala = list.ToArray();
            //    ciktiListe[i] = ciktiListe[i].Replace("@ktvar", tekrarListView.Items[0].Text.ToLower());
            //    ciktiListe[i] = ciktiListe[i].Replace("@kttip", tekrarListView.Items[0].SubItems[1].Text.ToLower());
            //    ciktiListe[i] = ciktiListe[i].Replace("@tvar", tekrarListView.Items[0].Text);
            //    ciktiListe[i] = ciktiListe[i].Replace("@ttip", tekrarListView.Items[0].SubItems[1].Text);
            //    for (int x = 1; x < tekrarListView.Items.Count; x++)
            //    {
            //        if (x == tekrarListView.Items.Count - 1 && kopyala[y].Substring(kopyala[y].Length - 1) == ",")
            //            kopyala[y] = kopyala[y].Substring(0, kopyala[y].Length - 1);
            //        ciktiListe[i] = ciktiListe[i] + kopyala[y];
            //        ciktiListe[i] = ciktiListe[i].Replace("@tvar", tekrarListView.Items[x].Text);
            //        ciktiListe[i] = ciktiListe[i].Replace("@ttip", tekrarListView.Items[x].SubItems[1].Text);
            //        ciktiListe[i] = ciktiListe[i].Replace("@ktvar", tekrarListView.Items[x].Text.ToLower());
            //        ciktiListe[i] = ciktiListe[i].Replace("@kttip", tekrarListView.Items[x].SubItems[1].Text.ToLower());
            //    }
            //    y++;
            //}

            //string cikti = "";
            //for (int i = 0; i < ciktiListe.Length; i++)
            //    cikti += ciktiListe[i];

            //foreach (ListViewItem item in degiskenListView.Items)
            //{
            //    id = item.Index + 1;
            //    cikti = cikti.Replace("@var" + id.ToString(), item.SubItems[1].Text);
            //    cikti = cikti.Replace("@tip" + id.ToString(), item.SubItems[2].Text);
            //    cikti = cikti.Replace("@kvar" + id.ToString(), item.SubItems[1].Text.ToLower());
            //    cikti = cikti.Replace("@ktip" + id.ToString(), item.SubItems[2].Text.ToLower());
            //}
            //ciktiTextArea.Text = cikti;
        }

        #region ScintillaYapilandirmalari
        private void ScintillaAyarlar(Scintilla TextArea)
        {
            TextArea.Dock = System.Windows.Forms.DockStyle.Fill;
            TextArea.TextChanged += (this.OnTextChanged);
            TextArea.WrapMode = WrapMode.None;
            TextArea.IndentationGuides = IndentView.LookBoth;
            InitSyntaxColoring(TextArea);
            InitNumberMargin(TextArea);
            KisaYollar(TextArea);
        }

        private void KisaYollar(Scintilla TextArea)
        {
            HotKeyManager.AddHotKey(this, TextArea.ZoomIn, Keys.Oemplus, true);
            HotKeyManager.AddHotKey(this, TextArea.ZoomOut, Keys.OemMinus, true);
            HotKeyManager.AddHotKey(this, KodUret, Keys.F5);

            TextArea.ClearCmdKey(Keys.Control | Keys.F);
            TextArea.ClearCmdKey(Keys.Control | Keys.R);
            TextArea.ClearCmdKey(Keys.Control | Keys.H);
            TextArea.ClearCmdKey(Keys.Control | Keys.L);
            TextArea.ClearCmdKey(Keys.Control | Keys.U);
            TextArea.ClearCmdKey(Keys.Control | Keys.S);

            void KodUret()
            {
                kodUretButon.PerformClick();
            }
        }

        private void InitSyntaxColoring(Scintilla TextArea)
        {
            TextArea.SetSelectionBackColor(true, IntToColor(0x114D9C));
            // Configure the default style
            TextArea.StyleResetDefault();
            TextArea.Styles[Style.Default].Font = "Consolas";
            TextArea.Styles[Style.Default].Size = 12;
            TextArea.Styles[Style.Default].BackColor = IntToColor(0x212121);
            TextArea.Styles[Style.Default].ForeColor = IntToColor(0xFFFFFF);
            TextArea.CaretForeColor = Color.White;
            TextArea.StyleClearAll();

            // Configure the CPP (C#) lexer styles
            TextArea.Styles[Style.Cpp.Identifier].ForeColor = IntToColor(0xD0DAE2);
            TextArea.Styles[Style.Cpp.Comment].ForeColor = IntToColor(0xBD758B);
            TextArea.Styles[Style.Cpp.CommentLine].ForeColor = IntToColor(0x40BF57);
            TextArea.Styles[Style.Cpp.CommentDoc].ForeColor = IntToColor(0x2FAE35);
            TextArea.Styles[Style.Cpp.Number].ForeColor = IntToColor(0xFFFF00);
            TextArea.Styles[Style.Cpp.String].ForeColor = IntToColor(0xFFFF00);
            TextArea.Styles[Style.Cpp.Character].ForeColor = IntToColor(0xE95454);
            TextArea.Styles[Style.Cpp.Preprocessor].ForeColor = IntToColor(0x8AAFEE);
            TextArea.Styles[Style.Cpp.Operator].ForeColor = IntToColor(0xE0E0E0);
            TextArea.Styles[Style.Cpp.Regex].ForeColor = IntToColor(0xff00ff);
            TextArea.Styles[Style.Cpp.CommentLineDoc].ForeColor = IntToColor(0x77A7DB);
            TextArea.Styles[Style.Cpp.Word].ForeColor = IntToColor(0x48A8EE);
            TextArea.Styles[Style.Cpp.Word2].ForeColor = IntToColor(0xF98906);
            TextArea.Styles[Style.Cpp.CommentDocKeyword].ForeColor = IntToColor(0xB3D991);
            TextArea.Styles[Style.Cpp.CommentDocKeywordError].ForeColor = IntToColor(0xFF0000);
            TextArea.Styles[Style.Cpp.GlobalClass].ForeColor = IntToColor(0x48A8EE);


            TextArea.Lexer = Lexer.Cpp;

            TextArea.SetKeywords(0, "class extends implements import interface new case do while else if for in switch throw get set function var try catch finally while with default break continue delete return each const namespace package include use is as instanceof typeof author copy default deprecated eventType example exampleText exception haxe inheritDoc internal link mtasc mxmlc param private return see serial serialData serialField since throws usage version langversion playerversion productversion dynamic private public partial static intrinsic internal native override protected AS3 final super this arguments null Infinity NaN undefined true false abstract as base bool break by byte case catch char checked class const continue decimal default delegate do double descending explicit event extern else enum false finally fixed float for foreach from goto group if implicit in int interface internal into is lock long new null namespace object operator out override orderby params private protected public readonly ref return switch struct sbyte sealed short sizeof stackalloc static string select this throw true try typeof uint ulong unchecked unsafe ushort using var virtual volatile void while where yield");
            TextArea.SetKeywords(1, "void Null ArgumentError arguments Array Boolean Class Date DefinitionError Error EvalError Function int Math Namespace Number Object RangeError ReferenceError RegExp SecurityError String SyntaxError TypeError uint XML XMLList Boolean Byte Char DateTime Decimal Double Int16 Int32 Int64 IntPtr SByte Single UInt16 UInt32 UInt64 UIntPtr Void Path File System Windows Forms ScintillaNET");

        }

        public static Color IntToColor(int rgb)
        {
            return Color.FromArgb(255, (byte)(rgb >> 16), (byte)(rgb >> 8), (byte)rgb);
        }

        private const int BACK_COLOR = 0x2A211C;
        private const int FORE_COLOR = 0xB7B7B7;
        private const int NUMBER_MARGIN = 1;
        private const int BOOKMARK_MARGIN = 2;
        private const int BOOKMARK_MARKER = 2;
        private const int FOLDING_MARGIN = 3;
        private const bool CODEFOLDING_CIRCULAR = true;

        private void InitNumberMargin(Scintilla TextArea)
        {

            TextArea.Styles[Style.LineNumber].BackColor = IntToColor(BACK_COLOR);
            TextArea.Styles[Style.LineNumber].ForeColor = IntToColor(FORE_COLOR);
            TextArea.Styles[Style.IndentGuide].ForeColor = IntToColor(FORE_COLOR);
            TextArea.Styles[Style.IndentGuide].BackColor = IntToColor(BACK_COLOR);

            var nums = TextArea.Margins[NUMBER_MARGIN];
            nums.Width = 30;
            nums.Type = MarginType.Number;
            nums.Sensitive = true;
            nums.Mask = 0;

            TextArea.MarginClick += TextArea_MarginClick;

            void TextArea_MarginClick(object sender, MarginClickEventArgs e)
            {
                if (e.Margin == BOOKMARK_MARGIN)
                {
                    // Do we have a marker for this line?
                    const uint mask = (1 << BOOKMARK_MARKER);
                    var line = TextArea.Lines[TextArea.LineFromPosition(e.Position)];
                    if ((line.MarkerGet() & mask) > 0)
                    {
                        // Remove existing bookmark
                        line.MarkerDelete(BOOKMARK_MARKER);
                    }
                    else
                    {
                        // Add bookmark
                        line.MarkerAdd(BOOKMARK_MARKER);
                    }
                }
            }
        }

        private void OnTextChanged(object sender, EventArgs e)
        {

        }

        #endregion

        private void ŞablonAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "\\Şablonlar");
            OpenFileDialog sec = new OpenFileDialog();
            sec.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory + "Şablonlar";
            sec.Title = "Şablon Seçin...";
            sec.Filter = "Metin Dosyaları|*.txt;*.cs;*.dart;*.cshtml|Tüm Dosyalar|*.*";
            sec.Multiselect = false;
            if (sec.ShowDialog() == DialogResult.OK)
            {
                sablonTextArea.Text = File.ReadAllText(sec.FileName);
            }
        }

        private void ŞablonuKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "\\Şablonlar");
            SaveFileDialog save = new SaveFileDialog();
            save.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory + "Şablonlar";
            save.Filter = "Text Dosyası (*.txt)|*.txt|Class (*.cs)|*.cs|Dart (*.dart)|*.dart|Cshtml (*.cshtml)|*.cshtml|Tüm Dosyalar|*.*";
            if (save.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(save.FileName, sablonTextArea.Text);
            }
        }

        private void ÇıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BağlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Baglan baglan = new Baglan();
            baglan.ShowDialog();

            if (baglan.dbList() != null)
            {
                dbComboBox.DataSource = baglan.dbList();

                yazi1.Show();
                dbComboBox.Show();
                yazi2.Show();
                tabloComboBox.Show();
                tabloEkleButton.Show();
            }
        }

        SqlConnection con;
        List<string> tables;
        private void DbComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(Properties.Settings.Default.baglanti + dbComboBox.SelectedValue);
                con.Open();
                tabloComboBox.DataSource = ListTables();
                con.Close();
            }
            catch
            {
                MessageBox.Show("SQL Server ile bağlantı kurulamadı.\nLütfen tekrar bağlanmayı deneyin.");
                yazi1.Hide();
                dbComboBox.Hide();
                yazi2.Hide();
                tabloComboBox.Hide();
                tabloEkleButton.Hide();
            }

        }

        int ayiriciIndex;
        public IList<string> ListTables()
        {
            tables = new List<string>();
            DataTable dt = con.GetSchema("Tables");
            foreach (DataRow row in dt.Rows)
            {
                string tablename = (string)row[2];
                tables.Add(tablename);
            }
            tables = tables.OrderBy(i => i).ToList();
            ayiriciIndex = tables.Count();
            tables.Add("  ----------------------------------");
            using (SqlCommand cmd = new SqlCommand("SELECT name from sys.procedures ORDER BY name ASC", con))
            {
                using (IDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        tables.Add(dr[0].ToString());
                    }
                }
            }
            return tables;
        }

        string tip;
        private void TabloEkleButton_Click(object sender, EventArgs e)
        {
            try
            {
                PullData();
                degiskenListView.Items.Clear();
                degiskenListView.Items.Add(new ListViewItem(new string[] { "var1,tip1", tabloComboBox.Text, "" }));
                tekrarListView.Items.Clear();
                foreach (DataRow item in dataTable.Rows)
                {
                    tip = tipDegistirme.tipDegis(item.ItemArray[1].ToString());
                    if (tip.Contains("varchar"))
                        tip = "string";
                    else if (tip.Contains("decimal("))
                        tip = "decimal";
                    if (tabloComboBox.SelectedIndex < ayiriciIndex && item.ItemArray[2].Equals("YES"))
                        tip += "?";
                    if (tabloComboBox.SelectedIndex < ayiriciIndex && pkTable.Rows.Count > 0 && pkTable.Rows[0].ItemArray[0].Equals(item.ItemArray[0].ToString()))
                        tekrarListView.Items.Add(new ListViewItem(new string[] { item.ItemArray[0].ToString(), tip, "PK" }));
                    else
                        tekrarListView.Items.Add(new ListViewItem(new string[] { item.ItemArray[0].ToString(), tip }));
                }

            }
            catch
            {
                MessageBox.Show("SQL Server ile bağlantı kurulamadı.\nLütfen tekrar bağlanmayı deneyin.");
                yazi1.Hide();
                dbComboBox.Hide();
                yazi2.Hide();
                tabloComboBox.Hide();
                tabloEkleButton.Hide();
            }
        }

        DataTable dataTable;
        DataTable pkTable;
        public void PullData()
        {
            string query, query2;
            dataTable = new DataTable();
            pkTable = new DataTable();
            if (tabloComboBox.SelectedIndex < ayiriciIndex)
            {
                query = "SELECT COLUMN_NAME,DATA_TYPE,IS_NULLABLE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + tabloComboBox.Text + "' ORDER BY ORDINAL_POSITION";
                query2 = "SELECT Col.Column_Name from INFORMATION_SCHEMA.TABLE_CONSTRAINTS Tab, INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE Col WHERE Col.Constraint_Name = Tab.Constraint_Name AND Col.Table_Name = Tab.Table_Name AND Constraint_Type = 'PRIMARY KEY' AND Col.Table_Name = '" + tabloComboBox.Text + "'";
                SqlCommand cmd2 = new SqlCommand(query2, con);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                con.Open();
                da2.Fill(pkTable);
                con.Close();
            }
            else
                query = "SELECT name, system_type_name FROM sys.dm_exec_describe_first_result_set_for_object ( OBJECT_ID('[" + tabloComboBox.Text + "]'), NULL);";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            con.Open();
            da.Fill(dataTable);
            con.Close();
            da.Dispose();
        }

        private void XMLToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TekrarListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tekrarListView.SelectedItems.Count == 1)
            {
                tekrarIsimText.Text = tekrarListView.SelectedItems[0].SubItems[0].Text;
                tekrarTipText.Text = tekrarListView.SelectedItems[0].SubItems[1].Text;
            }
        }

        private void DegiskenListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (degiskenListView.SelectedItems.Count == 1)
            {
                degiskenIsimText.Text = degiskenListView.SelectedItems[0].SubItems[1].Text;
                degiskenTipText.Text = degiskenListView.SelectedItems[0].SubItems[2].Text;
            }
        }

        private void JSONToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            urlForm url = new urlForm();
            url.ShowDialog();

            try
            {
                using (WebClient wc = new WebClient())
                {
                    var json = wc.DownloadString(Properties.Settings.Default.url);
                    JToken token = JToken.Parse(json);
                    JObject obj;
                    if (token.Type.ToString() == "Object")
                        obj = token.Value<JObject>();
                    else
                        obj = token.First.Value<JObject>();
                    List<string> keys = obj.Properties().Select(p => p.Name).ToList();
                    tekrarListView.Items.Clear();
                    foreach (string k in keys)
                    {
                        tekrarListView.Items.Add(new ListViewItem(new string[] { k, "string" }));
                    }
                }
            }
            catch
            {
                MessageBox.Show("Lütfen JSON türü döndüren bir url kopyalayın.", "Uyarı!");
            }
        }

        private void YenileButon_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "\\Şablonlar");
            sablonIsim = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + "\\Şablonlar", "*.txt").Select(Path.GetFileName).ToList();
            sablonComboBox.DataSource = sablonIsim;
        }

        private void SablonEkleButon_Click(object sender, EventArgs e)
        {
            try
            {
                sablonTextArea.Text = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "\\Şablonlar\\" + sablonComboBox.SelectedValue); ;
            }
            catch
            {
                MessageBox.Show("Seçilen şablon dosyası bulunamadı.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void XmlUrl_Click(object sender, EventArgs e)
        {
            urlForm url = new urlForm();
            url.ShowDialog();

            try
            {
                using (WebClient wc = new WebClient())
                {
                    var xmlString = wc.DownloadString(Properties.Settings.Default.url);
                    XDocument doc = XDocument.Parse(xmlString);
                    xmlIslemleri(doc);
                }
            }
            catch
            {
                MessageBox.Show("Lütfen XML türü döndüren bir url kopyalayın.", "Uyarı!");
            }
        }

        private void XmlDosya_Click(object sender, EventArgs e)
        {
            OpenFileDialog sec = new OpenFileDialog();
            //sec.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory + "Şablonlar";
            sec.Title = "XML Dosyası Seçin...";
            sec.Filter = "XML Dosyası |*.xml|Tüm Dosyalar|*.*";
            sec.Multiselect = false;
         
            if (sec.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    XDocument doc = XDocument.Load(sec.FileName);
                    xmlIslemleri(doc);
                }
                catch (Exception xx)
                {
                    MessageBox.Show("XML dosyası hatalı formatlanmış.\n\n" + xx.Message, "Hata!");
                }

            }
        }

        public void xmlIslemleri(XDocument doc)
        {
            List<string> keys = new List<string>();
            XElement element = doc.Elements().FirstOrDefault();
            while (element.Elements().Count() != 0)
            {
                element = element.Elements().FirstOrDefault();
            }
            element = element.Parent;
            degiskenListView.Items.Clear();
            degiskenListView.Items.Add(new ListViewItem(new string[] { "var1,tip1", element.Name.ToString(), "" }));
            tekrarListView.Items.Clear();
            foreach (XElement degisken in element.Elements())
            {
                tekrarListView.Items.Add(new ListViewItem(new string[] { degisken.Name.ToString(), "string" }));
            }
        }

        private void frameworkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsFrameworkGenerate fr = new SettingsFrameworkGenerate(sablonTextArea.Text);
            if(dbComboBox.Items.Count==0)
            { MessageBox.Show("Veri Tabanı Bulunamadi");return; }
            fr.DatabasName = dbComboBox.SelectedItem.ToString();
            fr.conn = con;
            fr.ShowDialog();
        }

        private void HakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kodlayan: Anıl Canberk DURAN\n\tVersiyon: 1.4.5", "Hakkında", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
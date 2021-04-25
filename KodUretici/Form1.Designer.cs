namespace KodUretici
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sablonTextPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ciktiTextPanel = new System.Windows.Forms.Panel();
            this.kodUretButon = new System.Windows.Forms.Button();
            this.kopyalaButon = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.silButon = new System.Windows.Forms.Button();
            this.ekleButon = new System.Windows.Forms.Button();
            this.degiskenListView = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.degiskenTipText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.degiskenIsimText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tekrarSilButon = new System.Windows.Forms.Button();
            this.tekrarEkleButon = new System.Windows.Forms.Button();
            this.tekrarListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tekrarTipText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tekrarIsimText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şablonAçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şablonuKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLBağlantısıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bağlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mySQLBaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.jSONToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xmlUrl = new System.Windows.Forms.ToolStripMenuItem();
            this.xmlDosya = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazi1 = new System.Windows.Forms.Label();
            this.dbComboBox = new System.Windows.Forms.ComboBox();
            this.tabloComboBox = new System.Windows.Forms.ComboBox();
            this.yazi2 = new System.Windows.Forms.Label();
            this.tabloEkleButton = new System.Windows.Forms.Button();
            this.sablonEkleButon = new System.Windows.Forms.Button();
            this.sablonComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.yenileButon = new System.Windows.Forms.Button();
            this.frameworkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.sablonTextPanel);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 514);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Şablon";
            // 
            // sablonTextPanel
            // 
            this.sablonTextPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sablonTextPanel.Location = new System.Drawing.Point(6, 16);
            this.sablonTextPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sablonTextPanel.Name = "sablonTextPanel";
            this.sablonTextPanel.Size = new System.Drawing.Size(370, 491);
            this.sablonTextPanel.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ciktiTextPanel);
            this.groupBox1.Location = new System.Drawing.Point(391, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 514);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Çıktı";
            // 
            // ciktiTextPanel
            // 
            this.ciktiTextPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ciktiTextPanel.Location = new System.Drawing.Point(6, 16);
            this.ciktiTextPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ciktiTextPanel.Name = "ciktiTextPanel";
            this.ciktiTextPanel.Size = new System.Drawing.Size(371, 491);
            this.ciktiTextPanel.TabIndex = 2;
            // 
            // kodUretButon
            // 
            this.kodUretButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kodUretButon.Location = new System.Drawing.Point(678, 1);
            this.kodUretButon.Name = "kodUretButon";
            this.kodUretButon.Size = new System.Drawing.Size(98, 23);
            this.kodUretButon.TabIndex = 10;
            this.kodUretButon.Text = "Kod Üret (F5)";
            this.kodUretButon.UseVisualStyleBackColor = true;
            this.kodUretButon.Click += new System.EventHandler(this.KodUretButon_Click);
            // 
            // kopyalaButon
            // 
            this.kopyalaButon.Location = new System.Drawing.Point(782, 1);
            this.kopyalaButon.Name = "kopyalaButon";
            this.kopyalaButon.Size = new System.Drawing.Size(91, 23);
            this.kopyalaButon.TabIndex = 11;
            this.kopyalaButon.Text = "Çıktıyı Kopyala";
            this.kopyalaButon.UseVisualStyleBackColor = true;
            this.kopyalaButon.Click += new System.EventHandler(this.KopyalaButon_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.silButon);
            this.groupBox4.Controls.Add(this.ekleButon);
            this.groupBox4.Controls.Add(this.degiskenListView);
            this.groupBox4.Controls.Add(this.degiskenTipText);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.degiskenIsimText);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(12, 30);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(201, 517);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sabit Değişkenler";
            // 
            // silButon
            // 
            this.silButon.Location = new System.Drawing.Point(111, 73);
            this.silButon.Name = "silButon";
            this.silButon.Size = new System.Drawing.Size(64, 23);
            this.silButon.TabIndex = 9;
            this.silButon.Text = "Sil";
            this.silButon.UseVisualStyleBackColor = true;
            this.silButon.Click += new System.EventHandler(this.SilButon_Click);
            // 
            // ekleButon
            // 
            this.ekleButon.Location = new System.Drawing.Point(30, 73);
            this.ekleButon.Name = "ekleButon";
            this.ekleButon.Size = new System.Drawing.Size(75, 23);
            this.ekleButon.TabIndex = 6;
            this.ekleButon.Text = "Ekle/Değiş";
            this.ekleButon.UseVisualStyleBackColor = true;
            this.ekleButon.Click += new System.EventHandler(this.EkleButon_Click);
            // 
            // degiskenListView
            // 
            this.degiskenListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.degiskenListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.degiskenListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.degiskenListView.HideSelection = false;
            this.degiskenListView.Location = new System.Drawing.Point(9, 102);
            this.degiskenListView.Name = "degiskenListView";
            this.degiskenListView.Size = new System.Drawing.Size(186, 409);
            this.degiskenListView.TabIndex = 6;
            this.degiskenListView.UseCompatibleStateImageBehavior = false;
            this.degiskenListView.SelectedIndexChanged += new System.EventHandler(this.DegiskenListView_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ID";
            this.columnHeader3.Width = 45;
            // 
            // degiskenTipText
            // 
            this.degiskenTipText.Location = new System.Drawing.Point(95, 47);
            this.degiskenTipText.Name = "degiskenTipText";
            this.degiskenTipText.Size = new System.Drawing.Size(100, 20);
            this.degiskenTipText.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Değişken Tipi:";
            // 
            // degiskenIsimText
            // 
            this.degiskenIsimText.Location = new System.Drawing.Point(95, 21);
            this.degiskenIsimText.Name = "degiskenIsimText";
            this.degiskenIsimText.Size = new System.Drawing.Size(100, 20);
            this.degiskenIsimText.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Değişken Adı:";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox5.Controls.Add(this.tekrarSilButon);
            this.groupBox5.Controls.Add(this.tekrarEkleButon);
            this.groupBox5.Controls.Add(this.tekrarListView);
            this.groupBox5.Controls.Add(this.tekrarTipText);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.tekrarIsimText);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(219, 30);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(201, 517);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tekrarlı Değişkenler";
            // 
            // tekrarSilButon
            // 
            this.tekrarSilButon.Location = new System.Drawing.Point(115, 73);
            this.tekrarSilButon.Name = "tekrarSilButon";
            this.tekrarSilButon.Size = new System.Drawing.Size(64, 23);
            this.tekrarSilButon.TabIndex = 9;
            this.tekrarSilButon.Text = "Sil";
            this.tekrarSilButon.UseVisualStyleBackColor = true;
            this.tekrarSilButon.Click += new System.EventHandler(this.TekrarSilButon_Click);
            // 
            // tekrarEkleButon
            // 
            this.tekrarEkleButon.Location = new System.Drawing.Point(34, 73);
            this.tekrarEkleButon.Name = "tekrarEkleButon";
            this.tekrarEkleButon.Size = new System.Drawing.Size(75, 23);
            this.tekrarEkleButon.TabIndex = 6;
            this.tekrarEkleButon.Text = "Ekle/Değiş";
            this.tekrarEkleButon.UseVisualStyleBackColor = true;
            this.tekrarEkleButon.Click += new System.EventHandler(this.TekrarEkleButon_Click);
            // 
            // tekrarListView
            // 
            this.tekrarListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tekrarListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4});
            this.tekrarListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tekrarListView.HideSelection = false;
            this.tekrarListView.Location = new System.Drawing.Point(9, 102);
            this.tekrarListView.Name = "tekrarListView";
            this.tekrarListView.Size = new System.Drawing.Size(186, 409);
            this.tekrarListView.TabIndex = 6;
            this.tekrarListView.UseCompatibleStateImageBehavior = false;
            this.tekrarListView.SelectedIndexChanged += new System.EventHandler(this.TekrarListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Değişken";
            this.columnHeader1.Width = -1;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tip";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "";
            // 
            // tekrarTipText
            // 
            this.tekrarTipText.Location = new System.Drawing.Point(95, 47);
            this.tekrarTipText.Name = "tekrarTipText";
            this.tekrarTipText.Size = new System.Drawing.Size(100, 20);
            this.tekrarTipText.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Değişken Tipi:";
            // 
            // tekrarIsimText
            // 
            this.tekrarIsimText.Location = new System.Drawing.Point(95, 21);
            this.tekrarIsimText.Name = "tekrarIsimText";
            this.tekrarIsimText.Size = new System.Drawing.Size(100, 20);
            this.tekrarIsimText.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Değişken Adı:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(426, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(777, 520);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.sQLBağlantısıToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1215, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.şablonAçToolStripMenuItem,
            this.şablonuKaydetToolStripMenuItem,
            this.toolStripSeparator1,
            this.çıkışToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.dosyaToolStripMenuItem.Text = "Şablon";
            // 
            // şablonAçToolStripMenuItem
            // 
            this.şablonAçToolStripMenuItem.Name = "şablonAçToolStripMenuItem";
            this.şablonAçToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.şablonAçToolStripMenuItem.Text = "Aç...";
            this.şablonAçToolStripMenuItem.Click += new System.EventHandler(this.ŞablonAçToolStripMenuItem_Click);
            // 
            // şablonuKaydetToolStripMenuItem
            // 
            this.şablonuKaydetToolStripMenuItem.Name = "şablonuKaydetToolStripMenuItem";
            this.şablonuKaydetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.şablonuKaydetToolStripMenuItem.Text = "Kaydet";
            this.şablonuKaydetToolStripMenuItem.Click += new System.EventHandler(this.ŞablonuKaydetToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.ÇıkışToolStripMenuItem_Click);
            // 
            // sQLBağlantısıToolStripMenuItem
            // 
            this.sQLBağlantısıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bağlanToolStripMenuItem,
            this.mySQLBaToolStripMenuItem,
            this.frameworkToolStripMenuItem,
            this.toolStripSeparator3,
            this.jSONToolStripMenuItem1,
            this.xMLToolStripMenuItem1});
            this.sQLBağlantısıToolStripMenuItem.Name = "sQLBağlantısıToolStripMenuItem";
            this.sQLBağlantısıToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.sQLBağlantısıToolStripMenuItem.Text = "Bağlantı";
            // 
            // bağlanToolStripMenuItem
            // 
            this.bağlanToolStripMenuItem.Name = "bağlanToolStripMenuItem";
            this.bağlanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bağlanToolStripMenuItem.Text = "MSSQL Bağlantısı...";
            this.bağlanToolStripMenuItem.Click += new System.EventHandler(this.BağlanToolStripMenuItem_Click);
            // 
            // mySQLBaToolStripMenuItem
            // 
            this.mySQLBaToolStripMenuItem.Enabled = false;
            this.mySQLBaToolStripMenuItem.Name = "mySQLBaToolStripMenuItem";
            this.mySQLBaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mySQLBaToolStripMenuItem.Text = "MySQL Bağlantısı...";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // jSONToolStripMenuItem1
            // 
            this.jSONToolStripMenuItem1.Name = "jSONToolStripMenuItem1";
            this.jSONToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.jSONToolStripMenuItem1.Text = "JSON";
            this.jSONToolStripMenuItem1.Click += new System.EventHandler(this.JSONToolStripMenuItem1_Click);
            // 
            // xMLToolStripMenuItem1
            // 
            this.xMLToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xmlUrl,
            this.xmlDosya});
            this.xMLToolStripMenuItem1.Name = "xMLToolStripMenuItem1";
            this.xMLToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.xMLToolStripMenuItem1.Text = "XML";
            // 
            // xmlUrl
            // 
            this.xmlUrl.Name = "xmlUrl";
            this.xmlUrl.Size = new System.Drawing.Size(106, 22);
            this.xmlUrl.Text = "URL";
            this.xmlUrl.Click += new System.EventHandler(this.XmlUrl_Click);
            // 
            // xmlDosya
            // 
            this.xmlDosya.Name = "xmlDosya";
            this.xmlDosya.Size = new System.Drawing.Size(106, 22);
            this.xmlDosya.Text = "Dosya";
            this.xmlDosya.Click += new System.EventHandler(this.XmlDosya_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hakkındaToolStripMenuItem});
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.HakkındaToolStripMenuItem_Click);
            // 
            // yazi1
            // 
            this.yazi1.AutoSize = true;
            this.yazi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yazi1.Location = new System.Drawing.Point(225, 6);
            this.yazi1.Name = "yazi1";
            this.yazi1.Size = new System.Drawing.Size(28, 13);
            this.yazi1.TabIndex = 14;
            this.yazi1.Text = "DB:";
            // 
            // dbComboBox
            // 
            this.dbComboBox.FormattingEnabled = true;
            this.dbComboBox.Location = new System.Drawing.Point(253, 3);
            this.dbComboBox.Name = "dbComboBox";
            this.dbComboBox.Size = new System.Drawing.Size(121, 21);
            this.dbComboBox.TabIndex = 15;
            this.dbComboBox.SelectedIndexChanged += new System.EventHandler(this.DbComboBox_SelectedIndexChanged);
            // 
            // tabloComboBox
            // 
            this.tabloComboBox.FormattingEnabled = true;
            this.tabloComboBox.Location = new System.Drawing.Point(423, 3);
            this.tabloComboBox.Name = "tabloComboBox";
            this.tabloComboBox.Size = new System.Drawing.Size(121, 21);
            this.tabloComboBox.TabIndex = 17;
            // 
            // yazi2
            // 
            this.yazi2.AutoSize = true;
            this.yazi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yazi2.Location = new System.Drawing.Point(380, 6);
            this.yazi2.Name = "yazi2";
            this.yazi2.Size = new System.Drawing.Size(43, 13);
            this.yazi2.TabIndex = 16;
            this.yazi2.Text = "Tablo:";
            // 
            // tabloEkleButton
            // 
            this.tabloEkleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabloEkleButton.Location = new System.Drawing.Point(550, 1);
            this.tabloEkleButton.Name = "tabloEkleButton";
            this.tabloEkleButton.Size = new System.Drawing.Size(64, 23);
            this.tabloEkleButton.TabIndex = 18;
            this.tabloEkleButton.Text = "Ekle";
            this.tabloEkleButton.UseVisualStyleBackColor = true;
            this.tabloEkleButton.Click += new System.EventHandler(this.TabloEkleButton_Click);
            // 
            // sablonEkleButon
            // 
            this.sablonEkleButon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sablonEkleButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sablonEkleButon.Location = new System.Drawing.Point(1069, 1);
            this.sablonEkleButon.Name = "sablonEkleButon";
            this.sablonEkleButon.Size = new System.Drawing.Size(64, 23);
            this.sablonEkleButon.TabIndex = 21;
            this.sablonEkleButon.Text = "Ekle";
            this.sablonEkleButon.UseVisualStyleBackColor = true;
            this.sablonEkleButon.Click += new System.EventHandler(this.SablonEkleButon_Click);
            // 
            // sablonComboBox
            // 
            this.sablonComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sablonComboBox.FormattingEnabled = true;
            this.sablonComboBox.Location = new System.Drawing.Point(942, 3);
            this.sablonComboBox.Name = "sablonComboBox";
            this.sablonComboBox.Size = new System.Drawing.Size(121, 21);
            this.sablonComboBox.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(886, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Şablon:";
            // 
            // yenileButon
            // 
            this.yenileButon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.yenileButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yenileButon.Location = new System.Drawing.Point(1139, 1);
            this.yenileButon.Name = "yenileButon";
            this.yenileButon.Size = new System.Drawing.Size(64, 23);
            this.yenileButon.TabIndex = 22;
            this.yenileButon.Text = "Yenile";
            this.yenileButon.UseVisualStyleBackColor = true;
            this.yenileButon.Click += new System.EventHandler(this.YenileButon_Click);
            // 
            // frameworkToolStripMenuItem
            // 
            this.frameworkToolStripMenuItem.Name = "frameworkToolStripMenuItem";
            this.frameworkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.frameworkToolStripMenuItem.Text = "Framework";
            this.frameworkToolStripMenuItem.Click += new System.EventHandler(this.frameworkToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 559);
            this.Controls.Add(this.yenileButon);
            this.Controls.Add(this.sablonEkleButon);
            this.Controls.Add(this.sablonComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabloEkleButton);
            this.Controls.Add(this.tabloComboBox);
            this.Controls.Add(this.yazi2);
            this.Controls.Add(this.dbComboBox);
            this.Controls.Add(this.yazi1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.kopyalaButon);
            this.Controls.Add(this.kodUretButon);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1231, 598);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kod Üretici";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button kodUretButon;
        private System.Windows.Forms.Button kopyalaButon;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button silButon;
        private System.Windows.Forms.Button ekleButon;
        private System.Windows.Forms.ListView degiskenListView;
        private System.Windows.Forms.TextBox degiskenTipText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox degiskenIsimText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button tekrarSilButon;
        private System.Windows.Forms.Button tekrarEkleButon;
        private System.Windows.Forms.ListView tekrarListView;
        private System.Windows.Forms.TextBox tekrarTipText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tekrarIsimText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Panel ciktiTextPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şablonAçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şablonuKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sQLBağlantısıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bağlanToolStripMenuItem;
        private System.Windows.Forms.Label yazi1;
        private System.Windows.Forms.ComboBox dbComboBox;
        private System.Windows.Forms.ComboBox tabloComboBox;
        private System.Windows.Forms.Label yazi2;
        private System.Windows.Forms.Button tabloEkleButton;
        private System.Windows.Forms.ToolStripMenuItem mySQLBaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem jSONToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem1;
        private System.Windows.Forms.Button sablonEkleButon;
        private System.Windows.Forms.ComboBox sablonComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button yenileButon;
        private System.Windows.Forms.ToolStripMenuItem xmlUrl;
        private System.Windows.Forms.ToolStripMenuItem xmlDosya;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        public System.Windows.Forms.Panel sablonTextPanel;
        private System.Windows.Forms.ToolStripMenuItem frameworkToolStripMenuItem;
    }
}


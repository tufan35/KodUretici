namespace KodUretici
{
    partial class konsolForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.konsolText = new System.Windows.Forms.RichTextBox();
            this.tamamButon = new System.Windows.Forms.Button();
            this.iptalButon = new System.Windows.Forms.Button();
            this.veritbaniText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // konsolText
            // 
            this.konsolText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.konsolText.Location = new System.Drawing.Point(12, 12);
            this.konsolText.Name = "konsolText";
            this.konsolText.Size = new System.Drawing.Size(549, 312);
            this.konsolText.TabIndex = 0;
            this.konsolText.Text = "";
            // 
            // tamamButon
            // 
            this.tamamButon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tamamButon.Location = new System.Drawing.Point(467, 330);
            this.tamamButon.Name = "tamamButon";
            this.tamamButon.Size = new System.Drawing.Size(94, 50);
            this.tamamButon.TabIndex = 1;
            this.tamamButon.Text = "Tamam";
            this.tamamButon.UseVisualStyleBackColor = true;
            this.tamamButon.Click += new System.EventHandler(this.TamamButon_Click);
            // 
            // iptalButon
            // 
            this.iptalButon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iptalButon.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.iptalButon.Location = new System.Drawing.Point(367, 330);
            this.iptalButon.Name = "iptalButon";
            this.iptalButon.Size = new System.Drawing.Size(94, 50);
            this.iptalButon.TabIndex = 2;
            this.iptalButon.Text = "İptal";
            this.iptalButon.UseVisualStyleBackColor = true;
            this.iptalButon.Click += new System.EventHandler(this.İptalButon_Click);
            // 
            // veritbaniText
            // 
            this.veritbaniText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.veritbaniText.AutoSize = true;
            this.veritbaniText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.veritbaniText.Location = new System.Drawing.Point(8, 344);
            this.veritbaniText.Name = "veritbaniText";
            this.veritbaniText.Size = new System.Drawing.Size(130, 20);
            this.veritbaniText.TabIndex = 3;
            this.veritbaniText.Text = "Seçili Veritabanı: ";
            // 
            // konsolForm
            // 
            this.AcceptButton = this.tamamButon;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.iptalButon;
            this.ClientSize = new System.Drawing.Size(573, 392);
            this.Controls.Add(this.veritbaniText);
            this.Controls.Add(this.iptalButon);
            this.Controls.Add(this.tamamButon);
            this.Controls.Add(this.konsolText);
            this.MinimumSize = new System.Drawing.Size(589, 431);
            this.Name = "konsolForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL Query Konsolu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox konsolText;
        private System.Windows.Forms.Button tamamButon;
        private System.Windows.Forms.Button iptalButon;
        private System.Windows.Forms.Label veritbaniText;
    }
}
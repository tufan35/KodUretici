namespace KodUretici
{
    partial class SettingsFrameworkGenerate
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.ButtonFileGenerate = new System.Windows.Forms.Button();
            this.textBoxGeneralFileName = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 57);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(426, 439);
            this.checkedListBox1.TabIndex = 5;
            // 
            // ButtonFileGenerate
            // 
            this.ButtonFileGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonFileGenerate.Location = new System.Drawing.Point(12, 555);
            this.ButtonFileGenerate.Name = "ButtonFileGenerate";
            this.ButtonFileGenerate.Size = new System.Drawing.Size(427, 37);
            this.ButtonFileGenerate.TabIndex = 6;
            this.ButtonFileGenerate.Text = "Dosyaları Üret";
            this.ButtonFileGenerate.UseVisualStyleBackColor = true;
            this.ButtonFileGenerate.Click += new System.EventHandler(this.ButtonFileGenerate_Click);
            // 
            // textBoxGeneralFileName
            // 
            this.textBoxGeneralFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxGeneralFileName.Location = new System.Drawing.Point(12, 513);
            this.textBoxGeneralFileName.Name = "textBoxGeneralFileName";
            this.textBoxGeneralFileName.Size = new System.Drawing.Size(426, 36);
            this.textBoxGeneralFileName.TabIndex = 10;
            this.textBoxGeneralFileName.Text = "I@TNameServices";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.Location = new System.Drawing.Point(12, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(186, 35);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Tümünü Seç";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox2.Location = new System.Drawing.Point(211, 16);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(227, 35);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.Text = "Klasörü Temizle";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // SettingsFrameworkGenerate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 615);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBoxGeneralFileName);
            this.Controls.Add(this.ButtonFileGenerate);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "SettingsFrameworkGenerate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsFrameworkGenerate";
            this.Load += new System.EventHandler(this.SettingsFrameworkGenerate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button ButtonFileGenerate;
        private System.Windows.Forms.TextBox textBoxGeneralFileName;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}
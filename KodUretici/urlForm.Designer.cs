namespace KodUretici
{
    partial class urlForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.urlText = new System.Windows.Forms.TextBox();
            this.onaylaButon = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.urlText);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 47);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL:";
            // 
            // urlText
            // 
            this.urlText.Location = new System.Drawing.Point(44, 19);
            this.urlText.Name = "urlText";
            this.urlText.Size = new System.Drawing.Size(262, 20);
            this.urlText.TabIndex = 0;
            // 
            // onaylaButon
            // 
            this.onaylaButon.Location = new System.Drawing.Point(330, 25);
            this.onaylaButon.Name = "onaylaButon";
            this.onaylaButon.Size = new System.Drawing.Size(75, 30);
            this.onaylaButon.TabIndex = 1;
            this.onaylaButon.Text = "Onayla";
            this.onaylaButon.UseVisualStyleBackColor = true;
            this.onaylaButon.Click += new System.EventHandler(this.OnaylaButon_Click);
            // 
            // urlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 71);
            this.Controls.Add(this.onaylaButon);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "urlForm";
            this.Text = "URL Formu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox urlText;
        private System.Windows.Forms.Button onaylaButon;
    }
}
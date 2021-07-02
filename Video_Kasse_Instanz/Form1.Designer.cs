namespace Video_Kasse_Instanz
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.bClose = new System.Windows.Forms.Button();
            this.bTest = new System.Windows.Forms.Button();
            this.rtbAusgabe = new System.Windows.Forms.RichTextBox();
            this.tbEingabe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bClose
            // 
            this.bClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClose.Location = new System.Drawing.Point(665, 364);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(123, 74);
            this.bClose.TabIndex = 0;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bTest
            // 
            this.bTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTest.Location = new System.Drawing.Point(665, 13);
            this.bTest.Name = "bTest";
            this.bTest.Size = new System.Drawing.Size(123, 96);
            this.bTest.TabIndex = 1;
            this.bTest.Text = "TEST";
            this.bTest.UseVisualStyleBackColor = true;
            this.bTest.Click += new System.EventHandler(this.bTest_Click);
            // 
            // rtbAusgabe
            // 
            this.rtbAusgabe.Location = new System.Drawing.Point(13, 13);
            this.rtbAusgabe.Name = "rtbAusgabe";
            this.rtbAusgabe.Size = new System.Drawing.Size(397, 425);
            this.rtbAusgabe.TabIndex = 2;
            this.rtbAusgabe.Text = "";
            this.rtbAusgabe.TextChanged += new System.EventHandler(this.rtbAusgabe_TextChanged);
            // 
            // tbEingabe
            // 
            this.tbEingabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEingabe.Location = new System.Drawing.Point(437, 383);
            this.tbEingabe.Name = "tbEingabe";
            this.tbEingabe.Size = new System.Drawing.Size(213, 38);
            this.tbEingabe.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbEingabe);
            this.Controls.Add(this.rtbAusgabe);
            this.Controls.Add(this.bTest);
            this.Controls.Add(this.bClose);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bTest;
        private System.Windows.Forms.RichTextBox rtbAusgabe;
        private System.Windows.Forms.TextBox tbEingabe;
    }
}


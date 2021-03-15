namespace ZadatakZaOcjenu
{
    partial class Form1
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
            this.unosButton = new System.Windows.Forms.Button();
            this.rjesenjeTextBox = new System.Windows.Forms.TextBox();
            this.obradiButton = new System.Windows.Forms.Button();
            this.ispisButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // unosButton
            // 
            this.unosButton.Location = new System.Drawing.Point(208, 12);
            this.unosButton.Name = "unosButton";
            this.unosButton.Size = new System.Drawing.Size(75, 23);
            this.unosButton.TabIndex = 0;
            this.unosButton.Text = "Unos";
            this.unosButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.unosButton.UseVisualStyleBackColor = true;
            this.unosButton.Click += new System.EventHandler(this.UnosButton_Click);
            // 
            // rjesenjeTextBox
            // 
            this.rjesenjeTextBox.Location = new System.Drawing.Point(12, 102);
            this.rjesenjeTextBox.Multiline = true;
            this.rjesenjeTextBox.Name = "rjesenjeTextBox";
            this.rjesenjeTextBox.Size = new System.Drawing.Size(476, 192);
            this.rjesenjeTextBox.TabIndex = 1;
            // 
            // obradiButton
            // 
            this.obradiButton.Location = new System.Drawing.Point(208, 46);
            this.obradiButton.Name = "obradiButton";
            this.obradiButton.Size = new System.Drawing.Size(75, 23);
            this.obradiButton.TabIndex = 2;
            this.obradiButton.Text = "Obradi";
            this.obradiButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.obradiButton.UseVisualStyleBackColor = true;
            this.obradiButton.Click += new System.EventHandler(this.ObradiButton_Click);
            // 
            // ispisButton
            // 
            this.ispisButton.Location = new System.Drawing.Point(208, 75);
            this.ispisButton.Name = "ispisButton";
            this.ispisButton.Size = new System.Drawing.Size(75, 22);
            this.ispisButton.TabIndex = 3;
            this.ispisButton.Text = "Ispis";
            this.ispisButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ispisButton.UseVisualStyleBackColor = true;
            this.ispisButton.Click += new System.EventHandler(this.IspisButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 308);
            this.Controls.Add(this.ispisButton);
            this.Controls.Add(this.obradiButton);
            this.Controls.Add(this.rjesenjeTextBox);
            this.Controls.Add(this.unosButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button unosButton;
        private System.Windows.Forms.TextBox rjesenjeTextBox;
        private System.Windows.Forms.Button obradiButton;
        private System.Windows.Forms.Button ispisButton;
    }
}


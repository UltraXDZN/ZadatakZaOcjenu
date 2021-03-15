namespace ZadatakZaOcjenu
{
    partial class Form2
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
            this.ImeLabel = new System.Windows.Forms.Label();
            this.imeText = new System.Windows.Forms.TextBox();
            this.prezimeText = new System.Windows.Forms.TextBox();
            this.PrezimeLabel = new System.Windows.Forms.Label();
            this.godRodText = new System.Windows.Forms.TextBox();
            this.godRodLabel = new System.Windows.Forms.Label();
            this.SpolLabel = new System.Windows.Forms.Label();
            this.podaciUnos = new System.Windows.Forms.Button();
            this.spolComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ImeLabel
            // 
            this.ImeLabel.AutoSize = true;
            this.ImeLabel.Location = new System.Drawing.Point(12, 12);
            this.ImeLabel.Name = "ImeLabel";
            this.ImeLabel.Size = new System.Drawing.Size(27, 13);
            this.ImeLabel.TabIndex = 0;
            this.ImeLabel.Text = "Ime:";
            // 
            // imeText
            // 
            this.imeText.Location = new System.Drawing.Point(65, 9);
            this.imeText.Name = "imeText";
            this.imeText.Size = new System.Drawing.Size(100, 20);
            this.imeText.TabIndex = 1;
            // 
            // prezimeText
            // 
            this.prezimeText.Location = new System.Drawing.Point(65, 37);
            this.prezimeText.Name = "prezimeText";
            this.prezimeText.Size = new System.Drawing.Size(100, 20);
            this.prezimeText.TabIndex = 3;
            // 
            // PrezimeLabel
            // 
            this.PrezimeLabel.AutoSize = true;
            this.PrezimeLabel.Location = new System.Drawing.Point(12, 40);
            this.PrezimeLabel.Name = "PrezimeLabel";
            this.PrezimeLabel.Size = new System.Drawing.Size(47, 13);
            this.PrezimeLabel.TabIndex = 2;
            this.PrezimeLabel.Text = "Prezime:";
            // 
            // godRodText
            // 
            this.godRodText.Location = new System.Drawing.Point(65, 63);
            this.godRodText.Name = "godRodText";
            this.godRodText.Size = new System.Drawing.Size(100, 20);
            this.godRodText.TabIndex = 5;
            // 
            // godRodLabel
            // 
            this.godRodLabel.AutoSize = true;
            this.godRodLabel.Location = new System.Drawing.Point(12, 66);
            this.godRodLabel.Name = "godRodLabel";
            this.godRodLabel.Size = new System.Drawing.Size(44, 13);
            this.godRodLabel.TabIndex = 4;
            this.godRodLabel.Text = "Godina:";
            // 
            // SpolLabel
            // 
            this.SpolLabel.AutoSize = true;
            this.SpolLabel.Location = new System.Drawing.Point(12, 92);
            this.SpolLabel.Name = "SpolLabel";
            this.SpolLabel.Size = new System.Drawing.Size(31, 13);
            this.SpolLabel.TabIndex = 6;
            this.SpolLabel.Text = "Spol:";
            // 
            // podaciUnos
            // 
            this.podaciUnos.Location = new System.Drawing.Point(48, 117);
            this.podaciUnos.Name = "podaciUnos";
            this.podaciUnos.Size = new System.Drawing.Size(75, 23);
            this.podaciUnos.TabIndex = 8;
            this.podaciUnos.Text = "Unesi!";
            this.podaciUnos.UseVisualStyleBackColor = true;
            this.podaciUnos.Click += new System.EventHandler(this.PodaciUnos_Click);
            // 
            // spolComboBox
            // 
            this.spolComboBox.FormattingEnabled = true;
            this.spolComboBox.Items.AddRange(new object[] {
            "M",
            "Ž"});
            this.spolComboBox.Location = new System.Drawing.Point(65, 89);
            this.spolComboBox.Name = "spolComboBox";
            this.spolComboBox.Size = new System.Drawing.Size(100, 21);
            this.spolComboBox.TabIndex = 9;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(174, 152);
            this.Controls.Add(this.spolComboBox);
            this.Controls.Add(this.podaciUnos);
            this.Controls.Add(this.SpolLabel);
            this.Controls.Add(this.godRodText);
            this.Controls.Add(this.godRodLabel);
            this.Controls.Add(this.prezimeText);
            this.Controls.Add(this.PrezimeLabel);
            this.Controls.Add(this.imeText);
            this.Controls.Add(this.ImeLabel);
            this.Name = "Form2";
            this.Text = "Unos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ImeLabel;
        private System.Windows.Forms.TextBox imeText;
        private System.Windows.Forms.TextBox prezimeText;
        private System.Windows.Forms.Label PrezimeLabel;
        private System.Windows.Forms.TextBox godRodText;
        private System.Windows.Forms.Label godRodLabel;
        private System.Windows.Forms.Label SpolLabel;
        private System.Windows.Forms.Button podaciUnos;
        private System.Windows.Forms.ComboBox spolComboBox;
    }
}
namespace TP01Threads
{
    partial class Horloge
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
            this.lblDateHeure = new System.Windows.Forms.Label();
            this.rbtnDate = new System.Windows.Forms.RadioButton();
            this.rbtnDateHeure = new System.Windows.Forms.RadioButton();
            this.rbtnHeure = new System.Windows.Forms.RadioButton();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnRaffraichir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDateHeure
            // 
            this.lblDateHeure.AutoSize = true;
            this.lblDateHeure.Location = new System.Drawing.Point(388, 57);
            this.lblDateHeure.Name = "lblDateHeure";
            this.lblDateHeure.Size = new System.Drawing.Size(35, 13);
            this.lblDateHeure.TabIndex = 0;
            this.lblDateHeure.Text = "label1";
            this.lblDateHeure.Click += new System.EventHandler(this.lblDateHeure_Click);
            // 
            // rbtnDate
            // 
            this.rbtnDate.AutoSize = true;
            this.rbtnDate.Location = new System.Drawing.Point(385, 95);
            this.rbtnDate.Name = "rbtnDate";
            this.rbtnDate.Size = new System.Drawing.Size(46, 17);
            this.rbtnDate.TabIndex = 3;
            this.rbtnDate.Text = "date";
            this.rbtnDate.UseVisualStyleBackColor = true;
            this.rbtnDate.CheckedChanged += new System.EventHandler(this.rbtnDate_CheckedChanged);
            // 
            // rbtnDateHeure
            // 
            this.rbtnDateHeure.AutoSize = true;
            this.rbtnDateHeure.Checked = true;
            this.rbtnDateHeure.Location = new System.Drawing.Point(152, 95);
            this.rbtnDateHeure.Name = "rbtnDateHeure";
            this.rbtnDateHeure.Size = new System.Drawing.Size(88, 17);
            this.rbtnDateHeure.TabIndex = 4;
            this.rbtnDateHeure.TabStop = true;
            this.rbtnDateHeure.Text = "date et heure";
            this.rbtnDateHeure.UseVisualStyleBackColor = true;
            this.rbtnDateHeure.CheckedChanged += new System.EventHandler(this.rbtnDateHeure_CheckedChanged);
            // 
            // rbtnHeure
            // 
            this.rbtnHeure.AutoSize = true;
            this.rbtnHeure.Location = new System.Drawing.Point(610, 95);
            this.rbtnHeure.Name = "rbtnHeure";
            this.rbtnHeure.Size = new System.Drawing.Size(52, 17);
            this.rbtnHeure.TabIndex = 5;
            this.rbtnHeure.Text = "heure";
            this.rbtnHeure.UseVisualStyleBackColor = true;
            this.rbtnHeure.CheckedChanged += new System.EventHandler(this.rbtnHeure_CheckedChanged);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(700, 137);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 6;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnRaffraichir
            // 
            this.btnRaffraichir.Location = new System.Drawing.Point(127, 137);
            this.btnRaffraichir.Name = "btnRaffraichir";
            this.btnRaffraichir.Size = new System.Drawing.Size(75, 23);
            this.btnRaffraichir.TabIndex = 7;
            this.btnRaffraichir.Text = "raffraichir";
            this.btnRaffraichir.UseVisualStyleBackColor = true;
            this.btnRaffraichir.Click += new System.EventHandler(this.btnRaffraichir_Click);
            // 
            // Horloge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 173);
            this.Controls.Add(this.btnRaffraichir);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.rbtnHeure);
            this.Controls.Add(this.rbtnDateHeure);
            this.Controls.Add(this.rbtnDate);
            this.Controls.Add(this.lblDateHeure);
            this.Name = "Horloge";
            this.Text = "Horloge";
            this.Load += new System.EventHandler(this.Horloge_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDateHeure;
        private System.Windows.Forms.RadioButton rbtnDate;
        private System.Windows.Forms.RadioButton rbtnDateHeure;
        private System.Windows.Forms.RadioButton rbtnHeure;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnRaffraichir;
    }
}


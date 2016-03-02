namespace TP01Thread
{
    partial class HorlogeV2
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
            this.components = new System.ComponentModel.Container();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.rbtnHeure = new System.Windows.Forms.RadioButton();
            this.rbtnDateHeure = new System.Windows.Forms.RadioButton();
            this.rbtnDate = new System.Windows.Forms.RadioButton();
            this.lblDateHeure = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(806, 160);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 12;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // rbtnHeure
            // 
            this.rbtnHeure.AutoSize = true;
            this.rbtnHeure.Location = new System.Drawing.Point(716, 118);
            this.rbtnHeure.Name = "rbtnHeure";
            this.rbtnHeure.Size = new System.Drawing.Size(52, 17);
            this.rbtnHeure.TabIndex = 11;
            this.rbtnHeure.Text = "heure";
            this.rbtnHeure.UseVisualStyleBackColor = true;
            this.rbtnHeure.CheckedChanged += new System.EventHandler(this.rbtnDateHeure_CheckedChanged);
            // 
            // rbtnDateHeure
            // 
            this.rbtnDateHeure.AutoSize = true;
            this.rbtnDateHeure.Checked = true;
            this.rbtnDateHeure.Location = new System.Drawing.Point(258, 118);
            this.rbtnDateHeure.Name = "rbtnDateHeure";
            this.rbtnDateHeure.Size = new System.Drawing.Size(88, 17);
            this.rbtnDateHeure.TabIndex = 10;
            this.rbtnDateHeure.TabStop = true;
            this.rbtnDateHeure.Text = "date et heure";
            this.rbtnDateHeure.UseVisualStyleBackColor = true;
            this.rbtnDateHeure.CheckedChanged += new System.EventHandler(this.rbtnDateHeure_CheckedChanged);
            // 
            // rbtnDate
            // 
            this.rbtnDate.AutoSize = true;
            this.rbtnDate.Location = new System.Drawing.Point(491, 118);
            this.rbtnDate.Name = "rbtnDate";
            this.rbtnDate.Size = new System.Drawing.Size(46, 17);
            this.rbtnDate.TabIndex = 9;
            this.rbtnDate.Text = "date";
            this.rbtnDate.UseVisualStyleBackColor = true;
            this.rbtnDate.CheckedChanged += new System.EventHandler(this.rbtnDateHeure_CheckedChanged);
            // 
            // lblDateHeure
            // 
            this.lblDateHeure.AutoSize = true;
            this.lblDateHeure.Location = new System.Drawing.Point(494, 80);
            this.lblDateHeure.Name = "lblDateHeure";
            this.lblDateHeure.Size = new System.Drawing.Size(35, 13);
            this.lblDateHeure.TabIndex = 8;
            this.lblDateHeure.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // HorlogeV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1115, 262);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.rbtnHeure);
            this.Controls.Add(this.rbtnDateHeure);
            this.Controls.Add(this.rbtnDate);
            this.Controls.Add(this.lblDateHeure);
            this.Name = "HorlogeV2";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HorlogeV2_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.RadioButton rbtnHeure;
        private System.Windows.Forms.RadioButton rbtnDateHeure;
        private System.Windows.Forms.RadioButton rbtnDate;
        private System.Windows.Forms.Label lblDateHeure;
        private System.Windows.Forms.Timer timer1;
    }
}


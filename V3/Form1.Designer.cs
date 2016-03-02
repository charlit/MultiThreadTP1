namespace V3
{
    partial class HorlogeV3
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
            this.btnQuitter.Location = new System.Drawing.Point(671, 160);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 17;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            // 
            // rbtnHeure
            // 
            this.rbtnHeure.AutoSize = true;
            this.rbtnHeure.Location = new System.Drawing.Point(581, 118);
            this.rbtnHeure.Name = "rbtnHeure";
            this.rbtnHeure.Size = new System.Drawing.Size(52, 17);
            this.rbtnHeure.TabIndex = 16;
            this.rbtnHeure.Text = "heure";
            this.rbtnHeure.UseVisualStyleBackColor = true;
            this.rbtnHeure.Click += new System.EventHandler(this.rbtnDateHeure_Click);
            // 
            // rbtnDateHeure
            // 
            this.rbtnDateHeure.AutoSize = true;
            this.rbtnDateHeure.Checked = true;
            this.rbtnDateHeure.Location = new System.Drawing.Point(123, 118);
            this.rbtnDateHeure.Name = "rbtnDateHeure";
            this.rbtnDateHeure.Size = new System.Drawing.Size(88, 17);
            this.rbtnDateHeure.TabIndex = 15;
            this.rbtnDateHeure.TabStop = true;
            this.rbtnDateHeure.Text = "date et heure";
            this.rbtnDateHeure.UseVisualStyleBackColor = true;
            this.rbtnDateHeure.CheckedChanged += new System.EventHandler(this.rbtnDateHeure_CheckedChanged);
            this.rbtnDateHeure.Click += new System.EventHandler(this.rbtnDateHeure_Click);
            // 
            // rbtnDate
            // 
            this.rbtnDate.AutoSize = true;
            this.rbtnDate.Location = new System.Drawing.Point(356, 118);
            this.rbtnDate.Name = "rbtnDate";
            this.rbtnDate.Size = new System.Drawing.Size(46, 17);
            this.rbtnDate.TabIndex = 14;
            this.rbtnDate.Text = "date";
            this.rbtnDate.UseVisualStyleBackColor = true;
            this.rbtnDate.Click += new System.EventHandler(this.rbtnDate_Click);
            // 
            // lblDateHeure
            // 
            this.lblDateHeure.AutoSize = true;
            this.lblDateHeure.Location = new System.Drawing.Point(359, 80);
            this.lblDateHeure.Name = "lblDateHeure";
            this.lblDateHeure.Size = new System.Drawing.Size(35, 13);
            this.lblDateHeure.TabIndex = 13;
            this.lblDateHeure.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // HorlogeV3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(869, 262);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.rbtnHeure);
            this.Controls.Add(this.rbtnDateHeure);
            this.Controls.Add(this.rbtnDate);
            this.Controls.Add(this.lblDateHeure);
            this.Name = "HorlogeV3";
            this.Text = "HorlogeV3";
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


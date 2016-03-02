namespace Tp_IHMv2
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
            this.SuspendLayout();
            // 
            // HorlogeV2
            // 
            this.ClientSize = new System.Drawing.Size(944, 271);
            this.Name = "HorlogeV2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.RadioButton rbtnHeure;
        private System.Windows.Forms.RadioButton rbtnDateHeure;
        private System.Windows.Forms.RadioButton rbtnDate;
        private System.Windows.Forms.Label lblDateHeure;
    }
}


namespace _2dGame
{
    partial class SecretScreen5
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.secretTimer5 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // secretTimer5
            // 
            this.secretTimer5.Interval = 20;
            this.secretTimer5.Tick += new System.EventHandler(this.secretTimer5_Tick);
            // 
            // SecretScreen5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.DoubleBuffered = true;
            this.Name = "SecretScreen5";
            this.Size = new System.Drawing.Size(800, 500);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SecretScreen5_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SecretScreen5_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.SecretScreen5_PreviewKeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer secretTimer5;
    }
}

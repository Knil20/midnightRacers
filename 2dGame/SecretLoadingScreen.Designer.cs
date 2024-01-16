namespace _2dGame
{
    partial class SecretLoadingScreen
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
            this.runLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // runLabel
            // 
            this.runLabel.Font = new System.Drawing.Font("MV Boli", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runLabel.ForeColor = System.Drawing.Color.Maroon;
            this.runLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.runLabel.Location = new System.Drawing.Point(3, 0);
            this.runLabel.Name = "runLabel";
            this.runLabel.Size = new System.Drawing.Size(797, 500);
            this.runLabel.TabIndex = 0;
            this.runLabel.Text = "HE\'S HERE!!!";
            this.runLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SecretLoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.runLabel);
            this.Name = "SecretLoadingScreen";
            this.Size = new System.Drawing.Size(800, 500);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label runLabel;
    }
}

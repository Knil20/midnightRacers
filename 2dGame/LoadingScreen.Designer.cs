namespace _2dGame
{
    partial class LoadingScreen
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
            this.loadingLabel = new System.Windows.Forms.Label();
            this.loadingTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // loadingLabel
            // 
            this.loadingLabel.BackColor = System.Drawing.Color.Transparent;
            this.loadingLabel.Font = new System.Drawing.Font("Niagara Engraved", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingLabel.ForeColor = System.Drawing.Color.White;
            this.loadingLabel.Location = new System.Drawing.Point(322, 176);
            this.loadingLabel.Name = "loadingLabel";
            this.loadingLabel.Size = new System.Drawing.Size(310, 106);
            this.loadingLabel.TabIndex = 6;
            this.loadingLabel.Text = "Loading...";
            this.loadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // loadingTimer
            // 
            this.loadingTimer.Tick += new System.EventHandler(this.loadingTimer_Tick);
            // 
            // LoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.loadingLabel);
            this.Name = "LoadingScreen";
            this.Size = new System.Drawing.Size(800, 500);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label loadingLabel;
        private System.Windows.Forms.Timer loadingTimer;
    }
}

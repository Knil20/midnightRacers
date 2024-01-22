namespace _2dGame
{
    partial class GoodEnding
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.wisdomLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::_2dGame.Properties.Resources.starImage;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(300, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // wisdomLabel
            // 
            this.wisdomLabel.BackColor = System.Drawing.Color.Transparent;
            this.wisdomLabel.Font = new System.Drawing.Font("Niagara Solid", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wisdomLabel.ForeColor = System.Drawing.Color.Yellow;
            this.wisdomLabel.Location = new System.Drawing.Point(294, 203);
            this.wisdomLabel.Name = "wisdomLabel";
            this.wisdomLabel.Size = new System.Drawing.Size(300, 300);
            this.wisdomLabel.TabIndex = 1;
            this.wisdomLabel.Text = "When In The Deepest of Dark, \r\nThere is Always a Way to Out. \r\nWell Done Hero, \r\n" +
    "You\'ve Escaped The Curse.";
            // 
            // GoodEnding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.wisdomLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GoodEnding";
            this.Size = new System.Drawing.Size(800, 500);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label wisdomLabel;
    }
}

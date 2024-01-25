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
            this.structionLabel = new System.Windows.Forms.Label();
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
            // 
            // structionLabel
            // 
            this.structionLabel.AutoSize = true;
            this.structionLabel.ForeColor = System.Drawing.Color.DimGray;
            this.structionLabel.Location = new System.Drawing.Point(726, 487);
            this.structionLabel.Name = "structionLabel";
            this.structionLabel.Size = new System.Drawing.Size(74, 13);
            this.structionLabel.TabIndex = 2;
            this.structionLabel.Text = "Click The Star";
            // 
            // GoodEnding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.structionLabel);
            this.Controls.Add(this.wisdomLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GoodEnding";
            this.Size = new System.Drawing.Size(800, 500);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label wisdomLabel;
        private System.Windows.Forms.Label structionLabel;
    }
}

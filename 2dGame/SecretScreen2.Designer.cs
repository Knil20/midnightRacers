﻿namespace _2dGame
{
    partial class SecretScreen2
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
            this.secretTimer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // secretTimer2
            // 
            this.secretTimer2.Interval = 20;
            this.secretTimer2.Tick += new System.EventHandler(this.secretTimer2_Tick);
            // 
            // SecretScreen2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.DoubleBuffered = true;
            this.Name = "SecretScreen2";
            this.Size = new System.Drawing.Size(800, 500);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SecretScreen2_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SecretScreen2_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.SecretScreen2_PreviewKeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer secretTimer2;
    }
}
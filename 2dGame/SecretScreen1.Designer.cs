﻿namespace _2dGame
{
    partial class SecretScreen1
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
            this.secretTimer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // secretTimer1
            // 
            this.secretTimer1.Interval = 20;
            this.secretTimer1.Tick += new System.EventHandler(this.secretTimer1_Tick);
            // 
            // SecretScreen1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.DoubleBuffered = true;
            this.Name = "SecretScreen1";
            this.Size = new System.Drawing.Size(800, 500);
            this.UseWaitCursor = true;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SecretScreen1_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SecretScreen1_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.SecretScreen1_PreviewKeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer secretTimer1;
    }
}
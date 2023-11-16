namespace _2dGame
{
    partial class InstructionScreen
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
            this.titleLabelOne = new System.Windows.Forms.Label();
            this.titleLabelTwo = new System.Windows.Forms.Label();
            this.helpLabel = new System.Windows.Forms.Label();
            this.helpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabelOne
            // 
            this.titleLabelOne.AutoSize = true;
            this.titleLabelOne.BackColor = System.Drawing.Color.Transparent;
            this.titleLabelOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleLabelOne.Font = new System.Drawing.Font("Niagara Engraved", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabelOne.ForeColor = System.Drawing.Color.DarkMagenta;
            this.titleLabelOne.Location = new System.Drawing.Point(221, 67);
            this.titleLabelOne.Name = "titleLabelOne";
            this.titleLabelOne.Size = new System.Drawing.Size(346, 53);
            this.titleLabelOne.TabIndex = 1;
            this.titleLabelOne.Text = "Welcome To Midnight Racers";
            this.titleLabelOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleLabelTwo
            // 
            this.titleLabelTwo.AutoSize = true;
            this.titleLabelTwo.BackColor = System.Drawing.Color.Transparent;
            this.titleLabelTwo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleLabelTwo.Font = new System.Drawing.Font("Niagara Engraved", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabelTwo.ForeColor = System.Drawing.Color.DarkMagenta;
            this.titleLabelTwo.Location = new System.Drawing.Point(286, 120);
            this.titleLabelTwo.Name = "titleLabelTwo";
            this.titleLabelTwo.Size = new System.Drawing.Size(233, 53);
            this.titleLabelTwo.TabIndex = 2;
            this.titleLabelTwo.Text = "Instruction Screen";
            this.titleLabelTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // helpLabel
            // 
            this.helpLabel.BackColor = System.Drawing.Color.Transparent;
            this.helpLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.helpLabel.Font = new System.Drawing.Font("Niagara Engraved", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpLabel.ForeColor = System.Drawing.Color.DarkMagenta;
            this.helpLabel.Location = new System.Drawing.Point(221, 185);
            this.helpLabel.Name = "helpLabel";
            this.helpLabel.Size = new System.Drawing.Size(346, 299);
            this.helpLabel.TabIndex = 3;
            this.helpLabel.Text = "Welcome To Midnight Racers";
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.Color.Transparent;
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpButton.Font = new System.Drawing.Font("Niagara Engraved", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpButton.ForeColor = System.Drawing.Color.DarkMagenta;
            this.helpButton.Location = new System.Drawing.Point(467, 434);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(100, 50);
            this.helpButton.TabIndex = 5;
            this.helpButton.Text = "Back?";
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // InstructionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.helpLabel);
            this.Controls.Add(this.titleLabelTwo);
            this.Controls.Add(this.titleLabelOne);
            this.Name = "InstructionScreen";
            this.Size = new System.Drawing.Size(800, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabelOne;
        private System.Windows.Forms.Label titleLabelTwo;
        private System.Windows.Forms.Label helpLabel;
        private System.Windows.Forms.Button helpButton;
    }
}

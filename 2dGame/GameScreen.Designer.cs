namespace _2dGame
{
    partial class GameScreen
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
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.pointLabel = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.pauseLabel = new System.Windows.Forms.Label();
            this.pauseMenuButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.Font = new System.Drawing.Font("Niagara Engraved", 36F);
            this.timeLabel.ForeColor = System.Drawing.Color.Red;
            this.timeLabel.Location = new System.Drawing.Point(3, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(300, 50);
            this.timeLabel.TabIndex = 0;
            // 
            // pointLabel
            // 
            this.pointLabel.BackColor = System.Drawing.Color.Transparent;
            this.pointLabel.Font = new System.Drawing.Font("Niagara Engraved", 36F);
            this.pointLabel.ForeColor = System.Drawing.Color.Red;
            this.pointLabel.Location = new System.Drawing.Point(597, 0);
            this.pointLabel.Name = "pointLabel";
            this.pointLabel.Size = new System.Drawing.Size(200, 50);
            this.pointLabel.TabIndex = 1;
            // 
            // speedLabel
            // 
            this.speedLabel.BackColor = System.Drawing.Color.Transparent;
            this.speedLabel.Font = new System.Drawing.Font("Niagara Engraved", 36F);
            this.speedLabel.ForeColor = System.Drawing.Color.Red;
            this.speedLabel.Location = new System.Drawing.Point(3, 50);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(300, 50);
            this.speedLabel.TabIndex = 2;
            // 
            // pauseLabel
            // 
            this.pauseLabel.BackColor = System.Drawing.Color.Transparent;
            this.pauseLabel.Font = new System.Drawing.Font("Niagara Engraved", 36F);
            this.pauseLabel.ForeColor = System.Drawing.Color.Aqua;
            this.pauseLabel.Location = new System.Drawing.Point(3, 141);
            this.pauseLabel.Name = "pauseLabel";
            this.pauseLabel.Size = new System.Drawing.Size(794, 50);
            this.pauseLabel.TabIndex = 3;
            this.pauseLabel.Tag = "";
            this.pauseLabel.Text = "Game Paused";
            this.pauseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pauseLabel.Visible = false;
            // 
            // pauseMenuButton
            // 
            this.pauseMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.pauseMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pauseMenuButton.Font = new System.Drawing.Font("Niagara Engraved", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseMenuButton.ForeColor = System.Drawing.Color.Aqua;
            this.pauseMenuButton.Location = new System.Drawing.Point(347, 297);
            this.pauseMenuButton.Name = "pauseMenuButton";
            this.pauseMenuButton.Size = new System.Drawing.Size(100, 50);
            this.pauseMenuButton.TabIndex = 5;
            this.pauseMenuButton.Text = "Main Menu";
            this.pauseMenuButton.UseVisualStyleBackColor = false;
            this.pauseMenuButton.Visible = false;
            this.pauseMenuButton.Click += new System.EventHandler(this.pauseMenuButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.Color.Transparent;
            this.quitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitButton.Font = new System.Drawing.Font("Niagara Engraved", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.ForeColor = System.Drawing.Color.Aqua;
            this.quitButton.Location = new System.Drawing.Point(347, 353);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(100, 50);
            this.quitButton.TabIndex = 6;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Visible = false;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // restartButton
            // 
            this.restartButton.BackColor = System.Drawing.Color.Transparent;
            this.restartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restartButton.Font = new System.Drawing.Font("Niagara Engraved", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartButton.ForeColor = System.Drawing.Color.Aqua;
            this.restartButton.Location = new System.Drawing.Point(347, 241);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(100, 50);
            this.restartButton.TabIndex = 7;
            this.restartButton.Text = "Try Again";
            this.restartButton.UseVisualStyleBackColor = false;
            this.restartButton.Visible = false;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.pauseMenuButton);
            this.Controls.Add(this.pauseLabel);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.pointLabel);
            this.Controls.Add(this.timeLabel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(800, 500);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameScreen_PreviewKeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label pointLabel;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label pauseLabel;
        private System.Windows.Forms.Button pauseMenuButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button restartButton;
    }
}

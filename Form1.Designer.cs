namespace Pong
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            player = new PictureBox();
            cpu = new PictureBox();
            ball = new PictureBox();
            gameTimer = new System.Windows.Forms.Timer(components);
            playerScore = new Label();
            cpuLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cpu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ball).BeginInit();
            SuspendLayout();
            // 
            // player
            // 
            player.BackColor = Color.Black;
            player.Location = new Point(12, 186);
            player.Name = "player";
            player.Size = new Size(27, 127);
            player.TabIndex = 0;
            player.TabStop = false;
            // 
            // cpu
            // 
            cpu.BackColor = Color.Black;
            cpu.Location = new Point(897, 230);
            cpu.Name = "cpu";
            cpu.Size = new Size(27, 127);
            cpu.TabIndex = 1;
            cpu.TabStop = false;
            // 
            // ball
            // 
            ball.BackColor = Color.Green;
            ball.Location = new Point(434, 239);
            ball.Name = "ball";
            ball.Size = new Size(27, 26);
            ball.TabIndex = 2;
            ball.TabStop = false;
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += timerTick;
            // 
            // playerScore
            // 
            playerScore.AutoSize = true;
            playerScore.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            playerScore.ForeColor = Color.FromArgb(192, 0, 192);
            playerScore.Location = new Point(105, 9);
            playerScore.Name = "playerScore";
            playerScore.Size = new Size(48, 32);
            playerScore.TabIndex = 3;
            playerScore.Text = "00";
            // 
            // cpuLabel
            // 
            cpuLabel.AutoSize = true;
            cpuLabel.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            cpuLabel.ForeColor = Color.FromArgb(0, 0, 192);
            cpuLabel.Location = new Point(735, 9);
            cpuLabel.Name = "cpuLabel";
            cpuLabel.Size = new Size(48, 32);
            cpuLabel.TabIndex = 4;
            cpuLabel.Text = "00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(935, 566);
            Controls.Add(cpuLabel);
            Controls.Add(playerScore);
            Controls.Add(ball);
            Controls.Add(cpu);
            Controls.Add(player);
            Name = "Form1";
            Text = "Form1";
            KeyDown += keyisdown;
            KeyUp += keyisup;
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)cpu).EndInit();
            ((System.ComponentModel.ISupportInitialize)ball).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox player;
        private PictureBox cpu;
        private PictureBox ball;
        private System.Windows.Forms.Timer gameTimer;
        private Label playerScore;
        private Label cpuLabel;
    }
}
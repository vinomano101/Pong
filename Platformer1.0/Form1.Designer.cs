namespace Platformer1._0
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.Up = new System.Windows.Forms.Timer(this.components);
            this.Ceiling = new System.Windows.Forms.PictureBox();
            this.LeftWall = new System.Windows.Forms.PictureBox();
            this.RightWall = new System.Windows.Forms.PictureBox();
            this.Down = new System.Windows.Forms.Timer(this.components);
            this.Player2 = new System.Windows.Forms.PictureBox();
            this.P2Up = new System.Windows.Forms.Timer(this.components);
            this.P2Down = new System.Windows.Forms.Timer(this.components);
            this.Ball = new System.Windows.Forms.PictureBox();
            this.RightUpCeiling = new System.Windows.Forms.Timer(this.components);
            this.RightDownGround = new System.Windows.Forms.Timer(this.components);
            this.LeftUp = new System.Windows.Forms.Timer(this.components);
            this.LeftDown = new System.Windows.Forms.Timer(this.components);
            this.RightUpWall = new System.Windows.Forms.Timer(this.components);
            this.RightDownWall = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ceiling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            this.SuspendLayout();
            // 
            // Ground
            // 
            this.Ground.BackColor = System.Drawing.Color.Green;
            this.Ground.Location = new System.Drawing.Point(-6, 427);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(848, 50);
            this.Ground.TabIndex = 0;
            this.Ground.TabStop = false;
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Black;
            this.Player.Location = new System.Drawing.Point(12, 192);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(19, 81);
            this.Player.TabIndex = 1;
            this.Player.TabStop = false;
            this.Player.Click += new System.EventHandler(this.Player_Click);
            // 
            // Up
            // 
            this.Up.Interval = 10;
            this.Up.Tick += new System.EventHandler(this.Up_Tick);
            // 
            // Ceiling
            // 
            this.Ceiling.BackColor = System.Drawing.Color.Green;
            this.Ceiling.Location = new System.Drawing.Point(-6, -26);
            this.Ceiling.Name = "Ceiling";
            this.Ceiling.Size = new System.Drawing.Size(848, 50);
            this.Ceiling.TabIndex = 2;
            this.Ceiling.TabStop = false;
            // 
            // LeftWall
            // 
            this.LeftWall.BackColor = System.Drawing.Color.Green;
            this.LeftWall.Location = new System.Drawing.Point(-7, 0);
            this.LeftWall.Name = "LeftWall";
            this.LeftWall.Size = new System.Drawing.Size(21, 457);
            this.LeftWall.TabIndex = 3;
            this.LeftWall.TabStop = false;
            // 
            // RightWall
            // 
            this.RightWall.BackColor = System.Drawing.Color.Green;
            this.RightWall.Location = new System.Drawing.Point(821, 0);
            this.RightWall.Name = "RightWall";
            this.RightWall.Size = new System.Drawing.Size(21, 457);
            this.RightWall.TabIndex = 4;
            this.RightWall.TabStop = false;
            this.RightWall.Click += new System.EventHandler(this.RightWall_Click);
            // 
            // Down
            // 
            this.Down.Interval = 10;
            this.Down.Tick += new System.EventHandler(this.Down_Tick);
            // 
            // Player2
            // 
            this.Player2.BackColor = System.Drawing.Color.White;
            this.Player2.Location = new System.Drawing.Point(803, 192);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(19, 81);
            this.Player2.TabIndex = 5;
            this.Player2.TabStop = false;
            this.Player2.Click += new System.EventHandler(this.Player2_Click);
            // 
            // P2Up
            // 
            this.P2Up.Interval = 10;
            this.P2Up.Tick += new System.EventHandler(this.P2Up_Tick);
            // 
            // P2Down
            // 
            this.P2Down.Interval = 10;
            this.P2Down.Tick += new System.EventHandler(this.P2Down_Tick);
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Ball.Location = new System.Drawing.Point(565, 76);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(11, 12);
            this.Ball.TabIndex = 6;
            this.Ball.TabStop = false;
            // 
            // RightUpCeiling
            // 
            this.RightUpCeiling.Interval = 10;
            this.RightUpCeiling.Tick += new System.EventHandler(this.RightUpCeiling_Tick);
            // 
            // RightDownGround
            // 
            this.RightDownGround.Interval = 10;
            this.RightDownGround.Tick += new System.EventHandler(this.RightDownGround_Tick);
            // 
            // LeftUp
            // 
            this.LeftUp.Interval = 10;
            this.LeftUp.Tick += new System.EventHandler(this.LeftUp_Tick);
            // 
            // LeftDown
            // 
            this.LeftDown.Interval = 10;
            this.LeftDown.Tick += new System.EventHandler(this.LeftDown_Tick);
            // 
            // RightUpWall
            // 
            this.RightUpWall.Interval = 10;
            this.RightUpWall.Tick += new System.EventHandler(this.RightUpWall_Tick);
            // 
            // RightDownWall
            // 
            this.RightDownWall.Interval = 10;
            this.RightDownWall.Tick += new System.EventHandler(this.RightDownWall_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(836, 450);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.RightWall);
            this.Controls.Add(this.LeftWall);
            this.Controls.Add(this.Ceiling);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ceiling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer Up;
        private System.Windows.Forms.PictureBox Ceiling;
        private System.Windows.Forms.PictureBox LeftWall;
        private System.Windows.Forms.PictureBox RightWall;
        private System.Windows.Forms.Timer Down;
        private System.Windows.Forms.PictureBox Player2;
        private System.Windows.Forms.Timer P2Up;
        private System.Windows.Forms.Timer P2Down;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.Timer RightUpCeiling;
        private System.Windows.Forms.Timer RightDownGround;
        private System.Windows.Forms.Timer LeftUp;
        private System.Windows.Forms.Timer LeftDown;
        private System.Windows.Forms.Timer RightUpWall;
        private System.Windows.Forms.Timer RightDownWall;
    }
}


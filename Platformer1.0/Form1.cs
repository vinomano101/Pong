using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Platformer1._0
{
    public partial class Form1 : Form
    {

        int movement = 0;
        Random rnd = new Random();
        int Dir_X = 0;
        int Dir_Y = 0;
        public Form1()
        {
            InitializeComponent();
            
        }

        

        private void Player_Click(object sender, EventArgs e)
        {

        }

        private void Player2_Click(object sender, EventArgs e)
        {

        }

        private void RightUpCeiling_Tick(object sender, EventArgs e)//Ball logic for up and right
        {
            movement = 2;
            if (!Ball.Bounds.IntersectsWith(Ceiling.Bounds) && !Ball.Bounds.IntersectsWith(RightWall.Bounds))
            {
                Dir_Y = rnd.Next(1, 4);
                Dir_X = rnd.Next(1, 4);
                Ball.Top -= Dir_Y;
                Ball.Left += Dir_X;
            }
            
        }
        private void RightUpWall_Tick(object sender, EventArgs e)//Ball logic for up and right
        {
            movement = 2;
            if (!Ball.Bounds.IntersectsWith(RightWall.Bounds) && !Ball.Bounds.IntersectsWith(Ceiling.Bounds))
            {
                Dir_Y = rnd.Next(1, 4);
                Dir_X = rnd.Next(1, 4);
                Ball.Top -= Dir_Y;
                Ball.Left += Dir_X;
            }
        }
        private void RightDownGround_Tick(object sender, EventArgs e)//Ball logic for down and right
        {
            movement = 4;
            if (!Ball.Bounds.IntersectsWith(Ground.Bounds) && !Ball.Bounds.IntersectsWith(RightWall.Bounds))
            {
                Dir_Y = rnd.Next(1, 4);
                Dir_X = rnd.Next(1, 4);
                Ball.Top += Dir_Y;
                Ball.Left += Dir_X;
            }
        }
        private void RightDownWall_Tick(object sender, EventArgs e)
        {
            movement = 4;
            if (!Ball.Bounds.IntersectsWith(RightWall.Bounds) && !Ball.Bounds.IntersectsWith(Ground.Bounds))
            {
                Dir_Y = rnd.Next(1, 4);
                Dir_X = rnd.Next(1, 4);
                Ball.Top += Dir_Y;
                Ball.Left += Dir_X;
            }
        }
        private void LeftUpCeiling_Tick(object sender, EventArgs e)
        {
            movement = 1;
            if(!Ball.Bounds.IntersectsWith(Ceiling.Bounds) && !Ball.Bounds.IntersectsWith(LeftWall.Bounds))
            {
                Dir_Y = rnd.Next(1, 4);
                Dir_X = rnd.Next(1, 4);
                Ball.Top -= Dir_Y;
                Ball.Left -= Dir_X;
            }
        }

        private void LeftUpWall_Tick(object sender, EventArgs e)
        {
            movement = 1;
            if (!Ball.Bounds.IntersectsWith(LeftWall.Bounds) && !Ball.Bounds.IntersectsWith(Ceiling.Bounds))
            {
                Dir_Y = rnd.Next(1, 4);
                Dir_X = rnd.Next(1, 4);
                Ball.Top -= Dir_Y;
                Ball.Left -= Dir_X;
            }
        }
        private void LeftDownWall_Tick(object sender, EventArgs e)
        {
            movement = 3;
            if (!Ball.Bounds.IntersectsWith(LeftWall.Bounds) && !Ball.Bounds.IntersectsWith(Ceiling.Bounds))
            {
                Dir_Y = rnd.Next(1, 4);
                Dir_X = rnd.Next(1, 4);
                Ball.Top += Dir_Y;
                Ball.Left -= Dir_X;
            }
        }
        private void LeftDownGround_Tick(object sender, EventArgs e)
        {
            movement = 3;
            if (!Ball.Bounds.IntersectsWith(Ground.Bounds) && !Ball.Bounds.IntersectsWith(LeftWall.Bounds))
            {
                Dir_Y = rnd.Next(1, 4);
                Dir_X = rnd.Next(1, 4);
                Ball.Top += Dir_Y;
                Ball.Left -= Dir_X;
            }
            
        }
        /*
        public enum direction
        {
            LeftUp = 1,
            RightUp = 2,
            LeftDown = 3,
            RightDown = 4
        }
        */
        private void Game_Timer_Tick(object sender, EventArgs e)
        {
            if(movement == 0)
            {
                LeftUpCeiling.Start();
                LeftUpWall.Start();
            }
            if(movement == 1)
            {
                if (Ball.Bounds.IntersectsWith(Ceiling.Bounds))
                {
                    LeftUpCeiling.Stop();
                    LeftUpWall.Stop();
                    LeftDownGround.Start();
                    LeftDownWall.Start();
                    return;
                }
                if (Ball.Bounds.IntersectsWith(LeftWall.Bounds))
                {
                    LeftUpCeiling.Stop();
                    LeftUpWall.Stop();
                    RightUpCeiling.Start();
                    RightUpWall.Start();
                }
                if (Ball.Bounds.IntersectsWith(Player.Bounds))
                {
                    LeftUpCeiling.Stop();
                    LeftUpWall.Stop();
                    RightUpCeiling.Start();
                    RightUpWall.Start();
                }
            }
            if(movement == 2)
            {
                if (Ball.Bounds.IntersectsWith(Ceiling.Bounds))
                {
                    RightUpCeiling.Stop();
                    RightUpWall.Stop();
                    RightDownGround.Start();
                    RightDownWall.Start();
                }
                if (Ball.Bounds.IntersectsWith(RightWall.Bounds))
                {
                    RightUpCeiling.Stop();
                    RightUpWall.Stop();
                    LeftUpCeiling.Start();
                    LeftUpWall.Start();
                }
                if (Ball.Bounds.IntersectsWith(Player2.Bounds))
                {
                    RightUpCeiling.Stop();
                    RightUpWall.Stop();
                    LeftUpCeiling.Start();
                    LeftUpWall.Start();
                }
            }
            if(movement == 3)
            {
                if (Ball.Bounds.IntersectsWith(Ground.Bounds))
                {
                    LeftDownGround.Stop();
                    LeftDownWall.Stop();
                    LeftUpCeiling.Start();
                    LeftUpWall.Start();
                }
                if (Ball.Bounds.IntersectsWith(LeftWall.Bounds))
                {
                    LeftDownGround.Stop();
                    LeftDownWall.Stop();
                    RightDownGround.Start();
                    RightDownWall.Start();
                }
                if (Ball.Bounds.IntersectsWith(Player.Bounds))
                {
                    LeftDownGround.Stop();
                    LeftDownWall.Stop();
                    RightDownGround.Start();
                    RightDownWall.Start();
                }

            }
            if(movement == 4)
            {
                if (Ball.Bounds.IntersectsWith(Ground.Bounds))
                {
                    RightDownGround.Stop();
                    RightDownWall.Stop();
                    RightUpCeiling.Start();
                    RightUpWall.Start();
                }
                if (Ball.Bounds.IntersectsWith(RightWall.Bounds))
                {
                    RightDownGround.Stop();
                    RightDownWall.Stop();
                    LeftDownGround.Start();
                    LeftDownWall.Start();
                }
                if (Ball.Bounds.IntersectsWith(Player2.Bounds))
                {
                    RightDownGround.Stop();
                    RightDownWall.Stop();
                    LeftDownGround.Start();
                    LeftDownWall.Start();
                }
            }


        }

        private void Player1_Collision_Tick(object sender, EventArgs e)
        {
            if (Ball.Bounds.IntersectsWith(Player.Bounds))
            {
                if(movement == 1)
                {

                }
            }
        }

        private void Up_Tick(object sender, EventArgs e)
        {
            if (!Player.Bounds.IntersectsWith(Ceiling.Bounds))
            {
                Player.Top -= 10;
            }
            
        }
        private void Down_Tick(object sender, EventArgs e)
        {
            if (!Player.Bounds.IntersectsWith(Ground.Bounds))
            {
                Player.Top += 10;
            }
        }

        

        private void P2Up_Tick(object sender, EventArgs e)
        {
            if (!Player2.Bounds.IntersectsWith(Ceiling.Bounds))
            {
                Player2.Top -= 10;
            }
        }

        

        private void P2Down_Tick(object sender, EventArgs e)
        {
            if (!Player2.Bounds.IntersectsWith(Ground.Bounds))
            {
                Player2.Top += 10;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.W)
            {
                Up.Start();
                Player.BackColor = Color.FromArgb(255, 255, 255);
            }
            if (e.KeyCode == Keys.S)
            {
                Down.Start();
            }
            if (e.KeyCode == Keys.D)//for ball logic
            {
                LeftUpCeiling.Start();
                LeftUpWall.Start();
            }
            if (e.KeyCode == Keys.A)
            {
                LeftDownGround.Start();
                LeftDownWall.Start();
            }

            if (e.KeyCode == Keys.Up)
            {
                P2Up.Start();
                Player2.BackColor = Color.FromArgb(0, 0, 0);
            }
            if (e.KeyCode == Keys.Down)
            {
                P2Down.Start();
                
            }
            

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.W)
            {
                Up.Stop();
                
                Player.BackColor = Color.FromArgb(0, 0, 0);
            }
            if(e.KeyCode == Keys.S)
            {
                Down.Stop();
            }
            if(e.KeyCode == Keys.D)//For ball logic practice
            {
                LeftUpCeiling.Stop();
                LeftUpWall.Stop();
            }
            if(e.KeyCode == Keys.A)//For ball logic testing 
            {
                LeftDownGround.Stop();
                LeftDownWall.Stop();
            }
            
            if (e.KeyCode == Keys.Up)
            {
                P2Up.Stop();

                Player2.BackColor = Color.FromArgb(255, 255, 255);
            }
            if (e.KeyCode == Keys.Down)
            {
                P2Down.Stop();
            }
            


        }
    }
}

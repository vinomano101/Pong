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

        public enum direction
        {
            LeftUp = 0,
            RightUp = 1,
            LeftDown = 2,
            RightDown = 3
        }

        direction InGame;
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

        private void RightWall_Click(object sender, EventArgs e)
        {

        }
        private void RightUpCeiling_Tick(object sender, EventArgs e)//Ball logic for up and right
        {
            if (!Ball.Bounds.IntersectsWith(Ceiling.Bounds) && !Ball.Bounds.IntersectsWith(RightWall.Bounds))
            {
                Ball.Top -= 1;
                Ball.Left += 1;
            }
            
        }
        private void RightUpWall_Tick(object sender, EventArgs e)//Ball logic for up and right
        {
            if (!Ball.Bounds.IntersectsWith(RightWall.Bounds) && !Ball.Bounds.IntersectsWith(Ceiling.Bounds))
            {
                Ball.Top -= 1;
                Ball.Left += 1;
            }
        }
        private void RightDownGround_Tick(object sender, EventArgs e)//Ball logic for down and right
        {
            if (!Ball.Bounds.IntersectsWith(Ground.Bounds) && !Ball.Bounds.IntersectsWith(RightWall.Bounds))
            {
                Ball.Top += 1;
                Ball.Left += 1;
            }
        }
        private void RightDownWall_Tick(object sender, EventArgs e)
        {
            if (!Ball.Bounds.IntersectsWith(RightWall.Bounds) && !Ball.Bounds.IntersectsWith(Ground.Bounds))
            {
                Ball.Top += 1;
                Ball.Left += 1;
            }
        }
        private void LeftUp_Tick(object sender, EventArgs e)//Ball logic for Up and left
        {
            if (!Ball.Bounds.IntersectsWith(LeftWall.Bounds))
            {

            }
        }

        private void LeftDown_Tick(object sender, EventArgs e)//Ball logic for down left
        {

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
                RightUpCeiling.Start();
                RightUpWall.Start();
            }
            if (e.KeyCode == Keys.A)
            {
                RightDownGround.Start();
                RightDownWall.Start();
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
                RightUpCeiling.Stop();
                RightUpWall.Stop();
            }
            if(e.KeyCode == Keys.A)//For ball logic testing 
            {
                RightDownGround.Stop();
                RightDownWall.Stop();
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

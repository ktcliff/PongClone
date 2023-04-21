using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pong
{
    public partial class Form1 : Form
    {
        bool goup; //boolean to be used to detect player up position
        bool godown; //boolean to be used to detect player down position
        int speed = 5; //integer called speed holding value of 5
        int ballx = 5; //horizontal X speed value for the ball object
        int bally = 5; //vertical Y speed value for the ball object
        int score = 0; //score for the player
        int cpuPoint = 0; //score for the CPU
        public Form1()
        {
            InitializeComponent();
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                // if player presses the up key
                // change the go up boolean to true
                goup = true;

            }
            if (e.KeyCode == Keys.Down)
            {
                // if player presses the down key
                // change the go down boolean to true
                godown = true;

            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                // if player leaves the up key
                // change the go up boolean to false
                goup = false;

            }
            if (e.KeyCode == Keys.Down)
            {
                // if player leaves the down key
                // change the go down boolean to false
                godown = false;

            }
        }

        private void timerTick(object sender, EventArgs e)
        {
            //this is the main timer event, this event will trigger every 20 miliseconds

            playerScore.Text = " " + score; //show player score on label 1
            cpuLabel.Text = " " + cpuPoint; //show CPU score on label 2

            ball.Top -= bally; //assign the ball TOP to ball y integer
            ball.Left -= ballx; //assign the ball LEFT to ball x integer

            cpu.Top += speed; //assignment the CPU top speed integer
      
           //if the score is less than 5
           if (score < 5)
            {
                //then do the following

                //if CPU has reached the top or gone to the bottom of the screen
                if (cpu.Top < 0 || cpu.Top > 455)
                {

                    //then
                    //change the speed direction so it moves back up or down
                    speed = -speed;

                }
            }
           else
            {
                //if the score is greater than 5
                //then make the game difficult by 
                //allowing the CPU follow the ball so it doesn't miss
                cpu.Top = ball.Top + 30;
            }

           //check the score
           //if the ball has gone pass the player through the left
           if (ball.Left < 0)
            {
                //then
                ball.Left = 434; //reset the ball to the middle of the screen
                ballx = -ballx; //change the balls direction
                ballx -= 2; //increase the speed
                cpuPoint++; //add 1 to the CPU score
            }

           //if the ball has gone past the right through CPU

           if (ball.Left + ball.Width > ClientSize.Width)
            {
                //then
                ball.Left = 434; //set the ball to the center of the screen
                ballx = -ballx; //change the direction of the ball
                ballx += 2; //increase the speed of the ball
                score++; //add one to the players score
            }

           //controlling the ball
           //if the ball either reaches the top of the screen or the bottom
           if (ball.Top < 0 || ball.Top + ball.Height > ClientSize.Height)
            {
                //then
                //reverse the speed of the ball so it stays within the screen
                bally = -bally;
            }

           //if the ball hits the player or the CPU
           if (ball.Bounds.IntersectsWith(player.Bounds) || ball.Bounds.IntersectsWith(cpu.Bounds))
            {
                //then bounce the ball in the other direction
                ballx = -ballx;
            }

           //controlling the player

           //if go up boolean is true and player is within the top boundary
           if (goup == true && player.Top > 0)
            {
                //then
                //move player towards the top
                player.Top -= 8;

            }

           //if go down boolean is true and player is within the bottom boundary
           if (godown == true && player.Top < 455)
            {

                //then
                //move player towards the bottom of screen
                player.Top += 8; 
            }

           //final score and ending the game
           //if the player score more than 10
           //then we will stop the timer and show a message box
           if(score > 10)
            {
                gameTimer.Stop();
                MessageBox.Show("You win this game");

            }
           //if the CPU scores more than 10
           //then we will stop the timer and show a message box
           if(cpuPoint > 10)
            {
                gameTimer.Stop();
                MessageBox.Show("CPU wins, you lose");

            }
        }
    }
}
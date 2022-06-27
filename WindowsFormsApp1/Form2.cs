using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        bool jumping = false;   //青蛙的跳躍狀態
        bool isGameOver = false;   //青蛙是否接觸到障礙物
        int jumpSpeed = 0;   //青蛙每毫秒上升量為0
        int obstacleSpeed = 8;   //障礙物每毫秒移動量
        int jumpCount;   //跳躍次數
        int force = 12;
        int gravity = 10;
        int position;
        int score = 0;
        Random rand = new Random();   //亂數種子

        public Form1()
        {
            InitializeComponent();
            GameReset();
        }


        private void GameReset()   //遊戲重置
        {
            txtScore.Text = score.ToString();
            
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    position = this.ClientSize.Width + rand.Next(500, 800) + (x.Width * 10);

                    x.Left = position;
                }
            }
            gameTimer.Start();
        }
        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            frog.Top = jumpSpeed + frog.Top;   //青蛙新高度 = 上升量 + 原高度
            
            txtScore.Text = "Score: " + score;   //分數

            if (jumping == true && force < 0)
            {
                jumping = false;
            }
            if (jumping == true)
            {
                jumpSpeed = -12;
                frog.Top -= force;
                force -= 1;
            }
            else//非跳躍時
            {
                jumpSpeed = 12;
            }
            if (frog.Top > 235 && jumping == false)
            {
                force = 12;
                frog.Top = 236;
                jumpSpeed = 0;
            }


            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Left -= obstacleSpeed;
                    if (x.Left < -100)
                    {
                        x.Left = this.ClientSize.Width + rand.Next(200, 500) + (x.Width * 15);

                        score += 2;   //通過一個障礙物，得兩分

                        /******通關******/

                        if (score == 20)   //當分數為20時
                        {
                            this.Close();   //關閉遊戲介面   

                            /*---顯示勝利畫面---*/

                            Form4 f4;
                            f4 = new Form4();
                            f4.Visible = true;
                        }
                    }

                    if (frog.Bounds.IntersectsWith(x.Bounds))   //當青蛙碰到障礙物
                    {
                        gameTimer.Stop();   //停止Timer
                        isGameOver = true;
                        frog.Visible = false;
                        pictureBox3.Visible = false;
                        ghost.Visible = true;
                        txtDead.Visible = true;
                        nextBottom.Visible = true;
                    }
                }
            }

            /*****障礙物移動*****/

            //得分大於5，障礙物速度變為15
            if (score > 5)
            {
                obstacleSpeed = 12;
            }
            //得分大於10，障礙物速度變為18
            if (score > 10)
            {
                obstacleSpeed = 16;
            }
            //得分大於15，障礙物速度變為20
            if (score > 15)
            {
                obstacleSpeed = 20;
            }
        }

        /******失敗******/

        private void next_Click(object sender, EventArgs e)   //遊戲結束，進行下一步
        {
            this.Hide();   //關閉遊戲介面    

            /*---顯示失敗畫面---*/

            Form3 f3;
            f3 = new Form3();
            f3.Visible = true;
        }

        


        private void keyisdown(object sender, KeyEventArgs e)   //指定物件上偵測到空白鍵被按下
        {
            if (e.KeyCode == Keys.Space && jumping == false && isGameOver == false)
            {
                jumping = true;
                force = gravity;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)   //指定物件上偵測到被按住的空白鍵已放開
        {
            if (jumping == true)   //停止跳躍
            {
                jumping = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        /*****以上參考自：https://www.youtube.com/watch?v=35RTKAFDjY0&ab_channel=MooICT *****/

    }
}

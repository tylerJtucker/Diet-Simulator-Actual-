//Tyler Tucker
//Diet Simulator
    
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Diet_Simulator
{
    public partial class gameScreen : UserControl
    {
        //variables and lists
        Boolean leftArrowDown, rightArrowDown, escDown;
        bool scalor = false;
        Random ranGen = new Random();
        public static int mouthX = 240;
        public static int mouthY = 550;
        public static int mouthSize = 100;
        int thres = 20;
        int timer = 20;
        int foodSpeed = 6;
        int score = 0;
        List<food> foods = new List<food>();
        List<food> goodFoods = new List<food>();

        public gameScreen()
        {
            InitializeComponent();
            loseLabel.Visible = false;

            //starts with a powerup
            food f2 = new food(200, 0, 65, 4);
            goodFoods.Add(f2);
        }

        private void gameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Escape:
                    escDown = true;
                    break;

            }
        }

        private void gameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Escape:
                    escDown = false;
                    break;
            }
        }


        private void gameTick_Tick(object sender, EventArgs e)
        {

            //displays score to screen
            scoreLabel.Text = "SCORE: " + score;

            //makes random number for the food to be added to list
            int powerUp = ranGen.Next(1, 60);


            //adds food to list
            if (timer >= thres)
            {
                int x = ranGen.Next(1, 525);
                int image = ranGen.Next(1, 4);
                food f1 = new food(x, 0, 65, image);
                foods.Add(f1);
                timer = 0;
            }

            //adds powerup to list
            if (powerUp == 7)
            {
                int x2 = ranGen.Next(1, 525);
                food f2 = new food(x2, 0, 65, 4);
                goodFoods.Add(f2);
            }

            //if esc is hit it will take you back to the mainscreen
            if (escDown == true)
            {
                Form F = this.FindForm();
                F.Controls.Remove(this);


                MainScreen ms = new MainScreen();
                F.Controls.Add(ms);
                this.Dispose();

            }

            //moves the mouth if its not past the right wall
            if ((mouthX + mouthSize) <= this.Width)
            {
                if (rightArrowDown == true)
                {
                    mouthX += 18;
                }
            }

            //moves the mouth if its not past the left wall
            if (mouthX > 0)
            {
                if (leftArrowDown == true)
                {
                    mouthX -= 18;
                }
            }

            //moves the food
            foreach (food F in foods)
            {
                F.Move(foodSpeed);
            }

            foreach (food GF in goodFoods)
            {
                GF.Move(foodSpeed);
            }


            //checks for collision
            foreach (food f in foods)
            {
                if (food.Collision(f) == true)
                {
                    f.Move(45);
                    foods[0].x = mouthSize / 2 + mouthX - 20;
                    Refresh();
                    gameTick.Stop();
                    endscoreLabel.Text = "Your Score: " + score;
                    loseLabel.Visible = true;
                    Refresh();
                    Thread.Sleep(3000);

                    Form F = this.FindForm();
                    F.Controls.Remove(this);

                    ScoreboardScreen ss = new ScoreboardScreen();
                    F.Controls.Add(ss);
                    ss.Focus();
                }
            }

            foreach (food gf in goodFoods)
            {
                if (food.Collision(gf) == true)
                {
                    gf.Move(45);
                    goodFoods[0].x = mouthSize / 2 + mouthX - 20;
                    score += 50;
                    break;
                }
            }

            //deletes food once it reaches past the mouth
            if (foods.Count > 0)
            {
                if (foods[0].y > mouthY)
                {
                    score += 10;
                    foods.RemoveAt(0);
                }
            }

            if (goodFoods.Count > 0)
            {
                if (goodFoods[0].y > mouthY)
                {
                    goodFoods.RemoveAt(0);

                }
            }

            #region  Dificulty scalor
            if(score % 100 == 0)
            {
                scalor = true;
            }

            if(score % 100 == 0 && score != 0 && scalor == true)
            {
                foodSpeed ++;

                if (thres > 5)
                {
                    thres--;
                }

                scalor = false;
            }


            #endregion

            timer++;
            Refresh();
        }

        private void gameScreen_Paint(object sender, PaintEventArgs e)
        {
            //draws images

            e.Graphics.DrawImage(Properties.Resources.Mouth, mouthX, mouthY, mouthSize, mouthSize);

            foreach (food f in foods)
            {
                if (f.image == 1)
                {
                    e.Graphics.DrawImage(Properties.Resources.popsicle, f.x, f.y, 20, 70);
                }

                if(f.image == 2)
                {
                    e.Graphics.DrawImage(Properties.Resources.hotdog, f.x, f.y, f.size, f.size);
                }

                if(f.image ==3)
                {
                    e.Graphics.DrawImage(Properties.Resources.chickenburger, f.x, f.y, f.size, f.size);
                }
            }

            foreach(food gf in goodFoods)
            {
                e.Graphics.DrawImage(Properties.Resources.Salad, gf.x, gf.y, 70, 70);
            }
        }
    }
}

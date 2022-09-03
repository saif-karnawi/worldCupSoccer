using System.Reflection;

namespace worldcupsoccer
{
    public partial class form1 : Form

    {
        Random random = new Random();
        List<string> position = new List<string> { "bottomLeft", "bottomRight", "middle", "topLeft", "topRight" };

        int x = 0;
        int y = 0;
        string target;
        string state;

        bool set = false;

        int miss;
        int goal;

        public form1()
        {
            InitializeComponent();
        }

        private void shootball(object sender, EventArgs e)
        {
            ball.Left -= x;
            ball.Top -= y;

            if (ball.Bounds.IntersectsWith(bottomRight.Bounds) && target == "bottomRight"
                || ball.Bounds.IntersectsWith(bottomLeft.Bounds) && target == "bottomLeft"
                || ball.Bounds.IntersectsWith(topLeft.Bounds) && target == "topLeft"
                || ball.Bounds.IntersectsWith(topRight.Bounds) && target == "topRight"
                || ball.Bounds.IntersectsWith(middle.Bounds) && target == "middle")

            {
                ball.Left = 431;
                ball.Top = 500;
                x = 0;
                y = 0;
                set = false;
                ballTimer.Stop();
            }

        }

        private void moveKeeper(object sender, EventArgs e)
        {
            switch (state)
            {

                case "bottomLeft":

                    if (goalKeeper.Left > 192)
                    {
                        goalKeeper.Left -= 6;
                        goalKeeper.Top = 209;
                    }
                    else
                    {
                        goalKeeper.Left = 421;
                        goalKeeper.Top = 162;
                        goalKeeper.Image = Properties.Resources.stand_small;
                        keeperTimer.Stop();
                    }
                    break;
                case "bottomRight":
                    if (goalKeeper.Left < 548)
                    {
                        goalKeeper.Left += 6;
                        goalKeeper.Top = 209;
                    }
                    else
                    {
                        goalKeeper.Left = 421;
                        goalKeeper.Top = 162;
                        goalKeeper.Image = Properties.Resources.stand_small;
                        keeperTimer.Stop();
                    }

                    break;

                case "topLeft":
                    if (goalKeeper.Top > 71)
                    {
                        goalKeeper.Left -= 8;
                        goalKeeper.Top -= 3;
                    }
                    else
                    {
                        goalKeeper.Left = 421;
                        goalKeeper.Top = 162;
                        goalKeeper.Image = Properties.Resources.stand_small;
                        keeperTimer.Stop();
                    }
                    break;
                case "topRight":
                    if (goalKeeper.Top > 71)
                    {
                        goalKeeper.Left -= 5;
                        goalKeeper.Top -= 3;
                    }
                    else
                    {
                        goalKeeper.Left = 421;
                        goalKeeper.Top = 162;
                        goalKeeper.Image = Properties.Resources.stand;
                        keeperTimer.Stop();
                    }
                    break;
                case "middle":
                    if (goalKeeper.Top > 71)
                    {
                        goalKeeper.Top -= 3;
                    }
                    else
                    {
                        goalKeeper.Left = 421;
                        goalKeeper.Top = 162;
                        goalKeeper.Image = Properties.Resources.stand;
                        keeperTimer.Stop();
                    }
                    break;

            }

        }

        private void setTarget(object sender, EventArgs e)
        {
            if (set) { return; }
            ballTimer.Start();
            keeperTimer.Start();
            changeState();

            var senderObject = (PictureBox)sender;
            senderObject.BackColor = Color.Beige;

            if (senderObject.Tag.ToString() == "topRight")
            {
                x = -7;
                y = 15;
                target = senderObject.Tag.ToString();
                set = true;
            }

            if (senderObject.Tag.ToString() == "right")
            {
                x = -11;
                y = 15;
                target = senderObject.Tag.ToString();
                set = true;
            }

            if (senderObject.Tag.ToString() == "middle")
            {
                x = 0;
                y = 20;
                target = senderObject.Tag.ToString();
                set = true;
            }

            if (senderObject.Tag.ToString() == "topLeft")
            {
                x = 8;
                y = 15;
                target = senderObject.Tag.ToString();
                set = true;
            }

            if (senderObject.Tag.ToString() == "left")
            {
                x = 8;
                y = 15;
                target = senderObject.Tag.ToString();
                set = true;
            }

            checkScore();

        }

        private void checkScore()
        {
            if (state == "bottomLeft" && target == "bottomLeft"
                || state == "bottomRight" && target == "bottomRight"
                || state == "middle" && target == "middle"
                || state == "topLeft" && target == "topLeft"
                || state == "topRight" && target == "topRight")
            {
                miss++;
                missText.Text = "Missed: " + miss;
            }
            else
            {
                goal++;
                goalText.Text = "Scored: " + goal;
            }
        }

        private void changeState()
        {
            keeperTimer.Start(); 
          
            int i = rnd.Next(0, keeperPosition.Count);

            
            state = keeperPosition[i].ToString();

            
            switch (i)
            {

                case 0:
                    
                    goalKeeper.Image = Properties.Resources.left_save_small;
                    break;
                case 1:
                   
                    goalKeeper.Image = Properties.Resources.right_save_small;
                    break;
                case 2:
                    
                    goalKeeper.Image = Properties.Resources.top_save_small;
                    break;
                case 3:
                    
                    goalKeeper.Image = Properties.Resources.top_left_save_small;
                    break;
                case 4:
                    
                    goalKeeper.Image = Properties.Resources.top_right_save_small;
                    break;

            }
        }
    }
}
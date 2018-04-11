using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        bool gunpressed;
        Label gun;
        bool noGunsOnMap;
        List<Label> labels = new List<Label>();
        private bool[] dirs = new bool[5];
        Random rnd = new Random();
        int score;
        public Form1()
        {
            InitializeComponent();
            score = 0;
            label1.Text = "score: " + score;
            gun = new Label();
            gun.Location = new Point(button1.Location.X + button1.Width / 2, button1.Location.Y - 10);
            gunpressed = false;
            noGunsOnMap = true;
            this.Controls.Add(gun);
            //gun.Visible = false;
            for (int i = 0; i < 5; i++)
            {
              //  dirs = new List<bool>();
                Label newLabel = new Label();
                newLabel.Text = "o";
                newLabel.Size = new Size(15, 20);
                int clr = rnd.Next(0, 2);
                if (clr == 0)
                    newLabel.ForeColor = Color.Green;
                else
                    newLabel.ForeColor = Color.Red;
                int x = rnd.Next(0, this.Width);
                int y = rnd.Next(0, 30);
                
                newLabel.Location = new Point(x, y);
                this.Controls.Add(newLabel);
                labels.Add(newLabel);
                if (x % 2 == 0)
                    dirs[i] = true;
                else
                    dirs[i] = false;
            }
            timer1.Start();
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {            
            if(e.KeyCode == Keys.A && button1.Location.X >= 0)
            {
                button1.Location = new Point(button1.Location.X - 10, button1.Location.Y);
            }
            else if(e.KeyCode == Keys.D && button1.Location.X + button1.Width + 20 < this.Width)
            {
                button1.Location = new Point(button1.Location.X + 10, button1.Location.Y);
            }
            else if(e.KeyCode == Keys.W)
            {
                if (noGunsOnMap)
                {
                    gun = new Label();
                    gun.Text = "|||";
                    gun.Size = new Size(15, 20);
                    gun.Location = new Point(button1.Location.X + button1.Width / 2, button1.Location.Y - 10);
                    this.Controls.Add(gun);
                    gunpressed = true;
                }
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(gunpressed)
            {
                gun.Visible = true;
                gun.Location = new Point(gun.Location.X, gun.Location.Y - 15);
                noGunsOnMap = false;

                if (gun.Location.Y <= 0)
                    noGunsOnMap = true;
            }

            for(int i = 0; i < labels.Count; i++)
            {
                if(i % 2 == 0)
                {
                    labels[i].Location = new Point(labels[i].Location.X, labels[i].Location.Y + 5);
                }
                else
                {
                    if (dirs[i])
                    {
                        labels[i].Location = new Point(labels[i].Location.X + 5, labels[i].Location.Y + 5);
                    }
                    else
                    {
                        labels[i].Location = new Point(labels[i].Location.X - 5, labels[i].Location.Y + 5);
                    }
                    if (labels[i].Location.X >= Width - 10)
                        dirs[i] = !dirs[i];
                    if (labels[i].Location.X <= 0)
                        dirs[i] = !dirs[i];
                }
                if (labels[i].Location.Y >= button1.Location.Y && labels[i].Location.Y <= button1.Location.Y + button1.Height && Collision(labels[i]) && labels[i].ForeColor == Color.Red) 
                {
                    //MessageBox.Show("ASD");
                    Environment.Exit(0);
                    //score = 0;
                }
                if (labels[i].Location.Y - button1.Location.Y <= 5 && labels[i].Location.Y - button1.Location.Y > 0 && labels[i].ForeColor == Color.Red)
                {
                    score++;
                    label1.Text = string.Format("score: " + score);
                }
                if (labels[i].ForeColor == Color.Green && Collision(labels[i]) && labels[i].Location.Y - button1.Location.Y <= 5 && labels[i].Location.Y - button1.Location.Y > 0)
                {
                    score++;
                    label1.Text = string.Format("score: " + score);
                    int x = rnd.Next(0, this.Width);
                    int y = rnd.Next(0, 30);
                    labels[i].Location = new Point(x, y);
                    int clr = rnd.Next(0, 2);
                    if (clr == 0)
                        labels[i].ForeColor = Color.Green;
                    else
                        labels[i].ForeColor = Color.Red;
                    continue;
                }
                if (labels[i].Location.Y >= Height)
                {
                    int x = rnd.Next(0, this.Width);
                    int y = rnd.Next(0, 30);
                    labels[i].Location = new Point(x, y);
                    labels[i].Visible = true;
                    int clr = rnd.Next(0, 2);
                    if (clr == 0)
                        labels[i].ForeColor = Color.Green;
                    else
                        labels[i].ForeColor = Color.Red;
                }
                if(gun.Location.Y >= labels[i].Location.Y && gun.Location.Y <= labels[i].Location.Y + labels[i].Height && labels[i].Location.Y - gun.Location.Y <= 5 && CollisionGun(labels[i]))
                {
                    //MessageBox.Show("Asd");
                    int x = rnd.Next(0, this.Width);
                    int y = rnd.Next(0, 30);
                    labels[i].Location = new Point(x, y);
                    labels[i].Visible = true;
                    int clr = rnd.Next(0, 2);
                    if (clr == 0)
                        labels[i].ForeColor = Color.Green;
                    else
                        labels[i].ForeColor = Color.Red;
                    score++;
                    label1.Text = string.Format("score: " + score);

                }
            }           
        }
        private bool Collision(Label lbl)
        {
            for(int i = button1.Location.X; i <= button1.Location.X + button1.Width; i++)
            {
                for(int j = lbl.Location.X - 5; j <= lbl.Location.X + lbl.Width + 5; j++)
                {
                    if (i == j)
                    {                        
                        return true;
                    }
                }
            }
            return false;
        }
        private bool CollisionGun(Label lbl)
        {
            for (int i = gun.Location.X; i <= gun.Location.X+ gun.Width; i++)
            {
                for (int j = lbl.Location.X - 5; j <= lbl.Location.X + lbl.Width + 5; j++)
                {
                    if (i == j)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
    
    
}

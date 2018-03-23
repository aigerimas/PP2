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
        List<Label> labels = new List<Label>();
        private bool[] dirs = new bool[5];
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            
            
            for (int i = 0; i < 5; i++)
            {
              //  dirs = new List<bool>();
                Label newLabel = new Label();
                newLabel.Text = "o";
                newLabel.Size = new Size(15, 20);
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
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
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
                if(labels[i].Location.Y >= Height)
                {
                    int x = rnd.Next(0, this.Width);
                    int y = rnd.Next(0, 30);
                    labels[i].Location = new Point(x, y);
                }
            }
        }
    }
}

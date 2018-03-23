using System;
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
        Calc calc = new Calc();
        public Form1()
        {
            InitializeComponent();
        }

        private void numbers_CLick(object sender, EventArgs e)
        {
            if (calc.mode_simple)
            {

                if (calc.isZeroOnDisplay)
                {
                    calc.clear = true;
                    calc.isZeroOnDisplay = false;
                }
                if (display_sim.Text == "0,")
                    calc.clear = false;
                if (calc.clear)
                {
                    display_sim.Text = "";
                    calc.clear = false;
                }


                Button btn = sender as Button;
                this.display_sim.Text += btn.Text;
            }
            else if(calc.mode_engin)
            {
                if (calc.isZeroOnDisplay)
                {
                    calc.clear = true;
                    calc.isZeroOnDisplay = false;
                }
                if (calc.clear)
                {
                    display_engin.Text = "";
                    calc.clear = false;
                }

                Button btn = sender as Button;
                this.display_engin.Text += btn.Text;

            }
        }
        private void operation_Click(object sender, EventArgs e)
        {
            if (calc.mode_simple)
            {
                Button btn = sender as Button;
                calc.firstNumber = double.Parse(display_sim.Text);
                calc.isFirstNumberEntered = true;
                calc.operation = btn.Text;
                calc.clear = true;
                calc.isFloat = true;
                calc.isResultEntered = false;
            }
            else if(calc.mode_engin)
            {
                Button btn = sender as Button;
                calc.firstNumber = double.Parse(display_engin.Text);
                calc.isFirstNumberEntered = true;
                calc.operation = btn.Text;
                calc.clear = true;
                calc.isFloat = true;
                calc.isResultEntered = false;
            }
        }
        private void result_Click(object sender, EventArgs e)
        {
            if (calc.mode_simple)
            {
                if (calc.isResultEntered)
                {
                    calc.result += calc.secondNumber;
                    display_sim.Text = calc.result.ToString();
                }
                else
                {
                    calc.isResultEntered = true;
                    calc.secondNumber = double.Parse(display_sim.Text);
                    calc.calculate();
                    display_sim.Text = calc.result.ToString();
                    calc.isSecondNumberEntered = true;
                }
            }
            else if(calc.mode_engin)
            {
                calc.secondNumber = double.Parse(display_engin.Text);
                calc.calculate();
                display_engin.Text = calc.result.ToString();
                calc.isSecondNumberEntered = true;
            }
        }
        private void percent_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            calc.secondNumber = double.Parse(display_sim.Text);
            calc.operation += btn.Text;
            calc.calculate();
            display_sim.Text = calc.result.ToString();
        }
        private void sqrt_Click(object sender, EventArgs e)
        {
            if (calc.mode_simple)
            {
                Button btn = sender as Button;
                calc.operation = btn.Text;
                calc.firstNumber = double.Parse(display_sim.Text);
                calc.calculate();
                display_sim.Text = calc.result.ToString();
            }
            else if(calc.mode_engin)
            {
                Button btn = sender as Button;
                calc.operation = btn.Text;
                calc.firstNumber = double.Parse(display_engin.Text);
                calc.calculate();
                display_engin.Text = calc.result.ToString();
            }
        }
        private void pow_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            calc.operation = btn.Text;
            calc.firstNumber = double.Parse(display_sim.Text);
            calc.calculate();
            display_sim.Text = calc.result.ToString();
        }
        private void onedividex_Click(object sender, EventArgs e)
        {

            calc.firstNumber = double.Parse(display_sim.Text);
            calc.operation = "1/x";
            calc.calculate();
            display_sim.Text = calc.result.ToString();
        }
        private void clear_Click(object sender, EventArgs e)
        {
            if (calc.mode_simple)
            {
                display_sim.Text = "0";
                calc.firstNumber = 0;
                calc.secondNumber = 0;
                calc.result = 0;
                calc.operation = "";
                calc.isZeroOnDisplay = true;
                calc.isFloat = true;
                calc.isResultEntered = false;
            }
            else if (calc.mode_engin)
            {
                display_engin.Text = "0";
                calc.firstNumber = 0;
                calc.secondNumber = 0;
                calc.result = 0;
                calc.operation = "";
                calc.isZeroOnDisplay = true;
                calc.isFloat = true;
                calc.isResultEntered = false;
            }
        }
        private void plusminus_Click(object sender, EventArgs e)
        {
            if (calc.mode_simple)
            {
                if (!calc.isFirstNumberEntered)
                {
                    calc.firstNumber = double.Parse(display_sim.Text);
                    calc.firstNumber *= -1;
                    display_sim.Text = calc.firstNumber.ToString();
                }
                else
                {
                    calc.secondNumber = double.Parse(display_sim.Text);
                    calc.secondNumber *= -1;
                    display_sim.Text = calc.secondNumber.ToString();
                }
            }
            else if(calc.mode_engin)
            {
                if (!calc.isFirstNumberEntered)
                {
                    calc.firstNumber = double.Parse(display_engin.Text);
                    calc.firstNumber *= -1;
                    display_engin.Text = calc.firstNumber.ToString();
                }
                else
                {
                    calc.secondNumber = double.Parse(display_engin.Text);
                    calc.secondNumber *= -1;
                    display_engin.Text = calc.secondNumber.ToString();
                }

            }
        }
        private void delete_Click(object sender, EventArgs e)
        {
            if (calc.mode_simple)
            {
                display_sim.Text = display_sim.Text.Substring(0, display_sim.Text.Length - 1);
                if(display_sim.Text.Length == 1 && display_sim.Text[0] == '-')
                {
                    display_sim.Text = display_sim.Text.Substring(1, display_sim.Text.Length - 1);
                }
                if (display_sim.Text == "")
                    display_sim.Text = "0";
                calc.isZeroOnDisplay = true;

            }
            else if (calc.mode_engin)
            {
                display_engin.Text = display_engin.Text.Substring(0, display_engin.Text.Length - 1);
                if(display_engin.Text.Length == 1 && display_engin.Text[0] == '-')
                {
                    display_engin.Text = display_engin.Text.Substring(1, display_engin.Text.Length - 1);
                }
                if (display_engin.Text == "")
                    display_engin.Text = "0";
                calc.isZeroOnDisplay = true;
            }
        }
        private void float_Click(object sender, EventArgs e)
        {
            if (calc.mode_simple)
            {
                if (calc.isFloat)
                {                    
                    display_sim.Text += ",";
                    calc.isFloat = false;
                }
            }
            else if (calc.mode_engin)
            {
                if (calc.isFloat)
                {
                    display_engin.Text += ",";
                    calc.isFloat = false;
                }
            }
        }
        private void menu_Click(object sender, EventArgs e)
        {
            this.panel_menu.Visible = !this.panel_menu.Visible;
            
            this.buttonMC.Visible = !this.buttonMC.Visible;
            this.buttonMR.Visible = !this.buttonMR.Visible;
            this.buttonMplus.Visible = !this.buttonMplus.Visible;
            this.buttonMminus.Visible = !this.buttonMminus.Visible;
            this.buttonMS.Visible = !this.buttonMS.Visible;
          //  this.panel_simple.Visible 
            
        }
        private void clear2_Click(object sender, EventArgs e)
        {
            if (calc.mode_simple)
            {
                if (!calc.isFirstNumberEntered)
                {
                    calc.firstNumber = 0;
                    display_sim.Text = calc.firstNumber.ToString();
                    calc.clear = true;

                }
                else
                {
                    calc.secondNumber = 0;
                    display_sim.Text = calc.secondNumber.ToString();
                    calc.clear = true;
                }
                calc.isFloat = true;
                calc.isResultEntered = false;
            }
            else if(calc.mode_engin)
            {
                if (!calc.isFirstNumberEntered)
                {
                    calc.firstNumber = 0;
                    display_engin.Text = calc.firstNumber.ToString();
                    calc.clear = true;
                }
                else
                {
                    calc.secondNumber = 0;
                    display_engin.Text = calc.secondNumber.ToString();
                    calc.clear = true;
                }
                calc.isFloat = true;
            }
        }
        private void buttonMC_Click(object sender, EventArgs e) // Memory Clear
        {
            if (calc.mode_simple)
            {
                calc.stSaved.Pop();
                if (calc.stSaved.Count() == 0)
                {
                    buttonMC.Enabled = false;
                    buttonMR.Enabled = false;
                    buttonM.Enabled = false;
                }
            }
            else if (calc.mode_engin)
            {
                calc.stSaved.Pop();
                if (calc.stSaved.Count() == 0)
                {
                    button_engin_MC.Enabled = false;
                    button_engin_MR.Enabled = false;
                    button_engin_M.Enabled = false;
                }
            }
        }
        private void buttonM_Click(object sender, EventArgs e) // History
        {
            this.panel_memory.Controls.Clear();
            this.panel_memory.Visible = !this.panel_memory.Visible;           
            double[] temp_arr = calc.stSaved.ToArray();
            for (int i = 0; i < calc.stSaved.Count(); i++)
            {

                this.label_MemoryStackShow = new System.Windows.Forms.Label
                {
                    AutoSize = true,
                    BackColor = System.Drawing.Color.LightGray,
                    BorderStyle = BorderStyle.None,
                    Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold),
                    Location = new System.Drawing.Point(270, 29 + i * 70),
                    Size = new System.Drawing.Size(168, 30),
                    TabIndex = 26,
                    Text = temp_arr[i].ToString(),
                    Visible = true                
            };
                this.panel_memory.Controls.Add(this.label_MemoryStackShow);
            }
            
        }
        private void buttonMR_Click(object sender, EventArgs e) // кнопка означает считать число из ячейки памяти и вывести его на дисплей.
        {
            if (calc.mode_simple)
                display_sim.Text = calc.stSaved.Peek().ToString();
            else if (calc.mode_engin)
                display_engin.Text = calc.stSaved.Peek().ToString();
        }
        private void buttonMplus_Click(object sender, EventArgs e) // прибавить к числу из памяти число, отображенное на дисплее и результат записать в память вместо предыдущего.
        {
            if (calc.mode_simple)
            {
                if (calc.stSaved.Count() == 0)
                {
                    calc.stSaved.Push(double.Parse(display_sim.Text));
                    buttonM.Enabled = true;
                    buttonMR.Enabled = true;
                    buttonMC.Enabled = true;
                }
                else
                {
                    double newValue = calc.stSaved.Peek() + double.Parse(display_sim.Text);
                    calc.stSaved.Pop();
                    calc.stSaved.Push(newValue);
                }
            }
            else if (calc.mode_engin)
            {
                if (calc.stSaved.Count() == 0)
                {
                    calc.stSaved.Push(double.Parse(display_engin.Text));
                    button_engin_M.Enabled = true;
                    button_engin_MR.Enabled = true;
                    button_engin_MC.Enabled = true;                   
                }
                else
                {
                    double newValue = calc.stSaved.Peek() + double.Parse(display_engin.Text);
                    calc.stSaved.Pop();
                    calc.stSaved.Push(newValue);
                }
            }
        }
        private void buttonMminus_Click(object sender, EventArgs e) //  вычесть из числа в памяти число, отображенное на дисплее калькулятора и результат записать в память.
        {
            if (calc.mode_simple)
            {
                double newValue = calc.stSaved.Peek() - double.Parse(display_sim.Text);
                calc.stSaved.Pop();
                calc.stSaved.Push(newValue);
            }
            else if(calc.mode_engin)
            {
                double newValue = calc.stSaved.Peek() - double.Parse(display_engin.Text);
                calc.stSaved.Pop();
                calc.stSaved.Push(newValue);
            }
        }
        private void buttonMS_Click(object sender, EventArgs e) // кнопка означает сохранить число, отображенное в данный момент на дисплее калькулятора в память.
        {
            if (calc.mode_simple)
            {
                buttonMC.Enabled = true;
                buttonMR.Enabled = true;
                buttonM.Enabled = true;
                calc.stSaved.Push(double.Parse(display_sim.Text));
            }
            else if (calc.mode_engin)
            {
                button_engin_MC.Enabled = true;
                button_engin_MR.Enabled = true;
                button_engin_M.Enabled = true;
                calc.stSaved.Push(double.Parse(display_engin.Text));
            }
        }
        private void simple_Click(object sender, EventArgs e)
        {
            calc.mode_simple = true;
            calc.isFloat = true;
            calc.mode_engin = false;
            calc.isZeroOnDisplay = true;
            calc.stSaved = new Stack<double>();
            calc.clear = false;
            display_sim.Text = "0";
            calc.stSaved.Clear();
            if (!this.panel_simple.Visible)
            {
                this.panel_simple.Visible = !this.panel_simple.Visible;
                this.panel_engin.Visible = !this.panel_engin.Visible;            
                this.ClientSize = new System.Drawing.Size(334, 438);
            }
            else
            {
                buttonMC.Visible = true;
                buttonMR.Visible = true;
                buttonMplus.Visible = true;
                buttonMminus.Visible = true;
                buttonMS.Visible = true;
            }
            this.panel_menu.Visible = !this.panel_menu.Visible;
            calc.mode_simple = true;
            calc.mode_engin = false;
        }
        private void engineering_Click(object sender, EventArgs e)
        {
            calc.mode_simple = true;
            calc.mode_engin = false;
            calc.isFloat = true;
            calc.isZeroOnDisplay = true;
            calc.stSaved = new Stack<double>();
            calc.clear = false;
            display_engin.Text = "0";
            calc.stSaved.Clear();
            if (!this.panel_engin.Visible)
            {                
                this.panel_simple.Visible = !this.panel_simple.Visible;
                this.panel_engin.Visible = !this.panel_engin.Visible;
                this.buttonMC.Visible = !this.buttonMC.Visible;
                this.buttonMR.Visible = !this.buttonMR.Visible;
                this.buttonMplus.Visible = !this.buttonMplus.Visible;
                this.buttonMminus.Visible = !this.buttonMminus.Visible;
                this.buttonMS.Visible = !this.buttonMS.Visible;
                this.ClientSize = new System.Drawing.Size(404, 478);
            }
            this.panel_menu.Visible = !this.panel_menu.Visible;
            calc.mode_engin = true;
            calc.mode_simple = false;
        }
        // ___________________________________________________________________________________


        // _______________________________________________________________________________
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void xpow2_Click(object sender, EventArgs e)
        {
            display_engin.Text = (Math.Pow(double.Parse(display_engin.Text), 2)).ToString();
        }
        private void button_engin_sin_Click(object sender, EventArgs e)
        {
            double d = (double.Parse(display_engin.Text) * 180) / Math.PI;
            display_engin.Text = Math.Sin(d).ToString();
        }

        private void button_engin_cos_Click(object sender, EventArgs e)
        {
            double d = double.Parse(display_engin.Text) * 180 / Math.PI;
            display_engin.Text = Math.Cos(d).ToString();
        }

        private void button_engin_tan_Click(object sender, EventArgs e)
        {
            display_engin.Text = Math.Tan(double.Parse(display_engin.Text)).ToString();
        }

        private void button_engin_10powx_Click(object sender, EventArgs e)
        {
            display_engin.Text = (Math.Pow(10, double.Parse(display_engin.Text))).ToString();
        }

        private void button_engin_log_Click(object sender, EventArgs e)
        {
            display_engin.Text = Math.Log10(double.Parse(display_engin.Text)).ToString();
        }

        private void button_engin_exp_Click(object sender, EventArgs e)
        {
            display_engin.Text = Math.Exp(double.Parse(display_engin.Text)).ToString();
        }

        private void button_engin_pi_Click(object sender, EventArgs e)
        {
            display_engin.Text = Math.PI.ToString();
        }

        private void button_engin_nfact_Click(object sender, EventArgs e)
        {
            double n = double.Parse(display_engin.Text);
            for(double i = n - 1; i > 1; i--)
            {
                n *= i;
            }
            display_engin.Text = n.ToString();
        }

        private void button_engin_M_Click(object sender, EventArgs e)
        {
            this.panel_engin_memory.Controls.Clear();
            this.panel_engin_memory.Visible = !this.panel_engin_memory.Visible;
            double[] temp_arr = calc.stSaved.ToArray();
            for (int i = 0; i < calc.stSaved.Count(); i++)
            {

                this.label_MemoryStackShow = new System.Windows.Forms.Label
                {
                    AutoSize = true,
                    BackColor = System.Drawing.Color.LightGray,
                    BorderStyle = BorderStyle.None,
                    Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold),
                    Location = new System.Drawing.Point(370, 29 + i * 70),
                    Size = new System.Drawing.Size(168, 30),
                    TabIndex = 26,
                    Text = temp_arr[i].ToString(),
                    Visible = true
                };
                this.panel_engin_memory.Controls.Add(this.label_MemoryStackShow);
            }

        }

        private void panel_engin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

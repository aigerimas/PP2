using System.Drawing;

namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.display_sim = new System.Windows.Forms.TextBox();
            this.button_percent = new System.Windows.Forms.Button();
            this.button_sqrt = new System.Windows.Forms.Button();
            this.button_pow = new System.Windows.Forms.Button();
            this.button_onedividex = new System.Windows.Forms.Button();
            this.typeOfCalc = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.Button();
            this.menubackground = new System.Windows.Forms.Button();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.engineering = new System.Windows.Forms.Button();
            this.label_calc = new System.Windows.Forms.Label();
            this.simple = new System.Windows.Forms.Button();
            this.panel_engin = new System.Windows.Forms.Panel();
            this.button_engin_menu = new System.Windows.Forms.Button();
            this.button_engin_MR = new System.Windows.Forms.Button();
            this.button_engin_MC = new System.Windows.Forms.Button();
            this.panel_engin_memory = new System.Windows.Forms.Panel();
            this.label_engin = new System.Windows.Forms.Label();
            this.display_engin = new System.Windows.Forms.TextBox();
            this.button_engin_Mplus = new System.Windows.Forms.Button();
            this.button_engin_xpow2 = new System.Windows.Forms.Button();
            this.button_engin_Mminus = new System.Windows.Forms.Button();
            this.button_engin_tan = new System.Windows.Forms.Button();
            this.button_engin_MS = new System.Windows.Forms.Button();
            this.button_engin_xpowy = new System.Windows.Forms.Button();
            this.button_engin_M = new System.Windows.Forms.Button();
            this.button_engin_cos = new System.Windows.Forms.Button();
            this.button_engin_sin = new System.Windows.Forms.Button();
            this.button_engin_sqrt = new System.Windows.Forms.Button();
            this.button_engin_mod = new System.Windows.Forms.Button();
            this.button_engin_10powx = new System.Windows.Forms.Button();
            this.button_engin_exp = new System.Windows.Forms.Button();
            this.button_engin_log = new System.Windows.Forms.Button();
            this.button_engin_plusminus = new System.Windows.Forms.Button();
            this.button_engin_uparrow = new System.Windows.Forms.Button();
            this.button_engin_pi = new System.Windows.Forms.Button();
            this.button_engin_nfact = new System.Windows.Forms.Button();
            this.button_engin_7 = new System.Windows.Forms.Button();
            this.button_engin_minus = new System.Windows.Forms.Button();
            this.button_engin_plus = new System.Windows.Forms.Button();
            this.button_engin_multiply = new System.Windows.Forms.Button();
            this.button_engin_divide = new System.Windows.Forms.Button();
            this.button_engin_9 = new System.Windows.Forms.Button();
            this.button_engin_8 = new System.Windows.Forms.Button();
            this.button_engin_6 = new System.Windows.Forms.Button();
            this.button_engin_5 = new System.Windows.Forms.Button();
            this.button_engin_4 = new System.Windows.Forms.Button();
            this.button_engin_3 = new System.Windows.Forms.Button();
            this.button_engin_2 = new System.Windows.Forms.Button();
            this.button_engin_1 = new System.Windows.Forms.Button();
            this.button_engin_0 = new System.Windows.Forms.Button();
            this.button_engin_equal = new System.Windows.Forms.Button();
            this.button_engin_clear = new System.Windows.Forms.Button();
            this.button_engin_delete = new System.Windows.Forms.Button();
            this.button_engin_clear2 = new System.Windows.Forms.Button();
            this.button_engin_float = new System.Windows.Forms.Button();
            this.button_engin_rightbracket = new System.Windows.Forms.Button();
            this.button_engin_leftbracket = new System.Windows.Forms.Button();
            this.buttonMC = new System.Windows.Forms.Button();
            this.buttonMR = new System.Windows.Forms.Button();
            this.buttonMplus = new System.Windows.Forms.Button();
            this.buttonMminus = new System.Windows.Forms.Button();
            this.buttonMS = new System.Windows.Forms.Button();
            this.buttonM = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_multiply = new System.Windows.Forms.Button();
            this.button_divide = new System.Windows.Forms.Button();
            this.button9_sim = new System.Windows.Forms.Button();
            this.button8_sim = new System.Windows.Forms.Button();
            this.button7_sim = new System.Windows.Forms.Button();
            this.button6_sim = new System.Windows.Forms.Button();
            this.button5_sim = new System.Windows.Forms.Button();
            this.button4_sim = new System.Windows.Forms.Button();
            this.button3_sim = new System.Windows.Forms.Button();
            this.button2_sim = new System.Windows.Forms.Button();
            this.button1_sim = new System.Windows.Forms.Button();
            this.button0_sim = new System.Windows.Forms.Button();
            this.button_result = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_clear2 = new System.Windows.Forms.Button();
            this.button_plusminus = new System.Windows.Forms.Button();
            this.button_float = new System.Windows.Forms.Button();
            this.panel_memory = new System.Windows.Forms.Panel();
            this.panel_simple = new System.Windows.Forms.Panel();
            this.panel_menu.SuspendLayout();
            this.panel_engin.SuspendLayout();
            this.panel_simple.SuspendLayout();
            this.SuspendLayout();
            // 
            // display_sim
            // 
            this.display_sim.BackColor = System.Drawing.Color.Silver;
            this.display_sim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.display_sim.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.display_sim.Location = new System.Drawing.Point(4, 78);
            this.display_sim.Margin = new System.Windows.Forms.Padding(0);
            this.display_sim.Name = "display_sim";
            this.display_sim.ReadOnly = true;
            this.display_sim.Size = new System.Drawing.Size(324, 38);
            this.display_sim.TabIndex = 14;
            this.display_sim.Text = "0";
            this.display_sim.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button_percent
            // 
            this.button_percent.BackColor = System.Drawing.Color.LightGray;
            this.button_percent.FlatAppearance.BorderSize = 0;
            this.button_percent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_percent.Location = new System.Drawing.Point(6, 160);
            this.button_percent.Name = "button_percent";
            this.button_percent.Size = new System.Drawing.Size(77, 43);
            this.button_percent.TabIndex = 19;
            this.button_percent.Text = "%";
            this.button_percent.UseVisualStyleBackColor = false;
            this.button_percent.Click += new System.EventHandler(this.percent_Click);
            // 
            // button_sqrt
            // 
            this.button_sqrt.BackColor = System.Drawing.Color.LightGray;
            this.button_sqrt.FlatAppearance.BorderSize = 0;
            this.button_sqrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_sqrt.Location = new System.Drawing.Point(88, 160);
            this.button_sqrt.Name = "button_sqrt";
            this.button_sqrt.Size = new System.Drawing.Size(77, 43);
            this.button_sqrt.TabIndex = 20;
            this.button_sqrt.Text = "√";
            this.button_sqrt.UseVisualStyleBackColor = false;
            this.button_sqrt.Click += new System.EventHandler(this.sqrt_Click);
            // 
            // button_pow
            // 
            this.button_pow.BackColor = System.Drawing.Color.LightGray;
            this.button_pow.FlatAppearance.BorderSize = 0;
            this.button_pow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_pow.Location = new System.Drawing.Point(169, 160);
            this.button_pow.Name = "button_pow";
            this.button_pow.Size = new System.Drawing.Size(77, 43);
            this.button_pow.TabIndex = 21;
            this.button_pow.Text = "x²";
            this.button_pow.UseVisualStyleBackColor = false;
            this.button_pow.Click += new System.EventHandler(this.pow_Click);
            // 
            // button_onedividex
            // 
            this.button_onedividex.BackColor = System.Drawing.Color.LightGray;
            this.button_onedividex.FlatAppearance.BorderSize = 0;
            this.button_onedividex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_onedividex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_onedividex.Location = new System.Drawing.Point(251, 160);
            this.button_onedividex.Name = "button_onedividex";
            this.button_onedividex.Size = new System.Drawing.Size(77, 43);
            this.button_onedividex.TabIndex = 22;
            this.button_onedividex.Text = "1/x";
            this.button_onedividex.UseVisualStyleBackColor = false;
            this.button_onedividex.Click += new System.EventHandler(this.onedividex_Click);
            // 
            // typeOfCalc
            // 
            this.typeOfCalc.BackColor = System.Drawing.Color.Silver;
            this.typeOfCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.5F);
            this.typeOfCalc.Location = new System.Drawing.Point(59, 11);
            this.typeOfCalc.Name = "typeOfCalc";
            this.typeOfCalc.Size = new System.Drawing.Size(138, 30);
            this.typeOfCalc.TabIndex = 26;
            this.typeOfCalc.Text = "Обычный";
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Silver;
            this.menu.FlatAppearance.BorderSize = 0;
            this.menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.5F);
            this.menu.Location = new System.Drawing.Point(7, 8);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(40, 37);
            this.menu.TabIndex = 27;
            this.menu.Text = "≡";
            this.menu.UseVisualStyleBackColor = true;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // menubackground
            // 
            this.menubackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.menubackground.FlatAppearance.BorderSize = 0;
            this.menubackground.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menubackground.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.5F);
            this.menubackground.Location = new System.Drawing.Point(12, 26);
            this.menubackground.Name = "menubackground";
            this.menubackground.Size = new System.Drawing.Size(40, 37);
            this.menubackground.TabIndex = 27;
            this.menubackground.Text = "≡";
            this.menubackground.UseVisualStyleBackColor = false;
            this.menubackground.Click += new System.EventHandler(this.menu_Click);
            // 
            // panel_menu
            // 
            this.panel_menu.AutoScroll = true;
            this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.panel_menu.Controls.Add(this.engineering);
            this.panel_menu.Controls.Add(this.label_calc);
            this.panel_menu.Controls.Add(this.menubackground);
            this.panel_menu.Controls.Add(this.simple);
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(271, 440);
            this.panel_menu.TabIndex = 28;
            this.panel_menu.Visible = false;
            // 
            // engineering
            // 
            this.engineering.FlatAppearance.BorderSize = 0;
            this.engineering.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.engineering.Font = new System.Drawing.Font("Calibri", 13.5F);
            this.engineering.Location = new System.Drawing.Point(2, 142);
            this.engineering.Name = "engineering";
            this.engineering.Size = new System.Drawing.Size(266, 64);
            this.engineering.TabIndex = 29;
            this.engineering.Text = "Инженерный";
            this.engineering.UseVisualStyleBackColor = true;
            this.engineering.Click += new System.EventHandler(this.engineering_Click);
            // 
            // label_calc
            // 
            this.label_calc.AutoSize = true;
            this.label_calc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.label_calc.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.5F);
            this.label_calc.Location = new System.Drawing.Point(64, 29);
            this.label_calc.Name = "label_calc";
            this.label_calc.Size = new System.Drawing.Size(168, 30);
            this.label_calc.TabIndex = 26;
            this.label_calc.Text = "Калькулятор";
            // 
            // simple
            // 
            this.simple.FlatAppearance.BorderSize = 0;
            this.simple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.simple.Font = new System.Drawing.Font("Calibri", 13.5F);
            this.simple.Location = new System.Drawing.Point(3, 75);
            this.simple.Name = "simple";
            this.simple.Size = new System.Drawing.Size(265, 64);
            this.simple.TabIndex = 28;
            this.simple.Text = "Обычный";
            this.simple.UseVisualStyleBackColor = true;
            this.simple.Click += new System.EventHandler(this.simple_Click);
            // 
            // panel_engin
            // 
            this.panel_engin.Controls.Add(this.button_engin_menu);
            this.panel_engin.Controls.Add(this.button_engin_MR);
            this.panel_engin.Controls.Add(this.button_engin_MC);
            this.panel_engin.Controls.Add(this.panel_engin_memory);
            this.panel_engin.Controls.Add(this.label_engin);
            this.panel_engin.Controls.Add(this.display_engin);
            this.panel_engin.Controls.Add(this.button_engin_Mplus);
            this.panel_engin.Controls.Add(this.button_engin_xpow2);
            this.panel_engin.Controls.Add(this.button_engin_Mminus);
            this.panel_engin.Controls.Add(this.button_engin_tan);
            this.panel_engin.Controls.Add(this.button_engin_MS);
            this.panel_engin.Controls.Add(this.button_engin_xpowy);
            this.panel_engin.Controls.Add(this.button_engin_M);
            this.panel_engin.Controls.Add(this.button_engin_cos);
            this.panel_engin.Controls.Add(this.button_engin_sin);
            this.panel_engin.Controls.Add(this.button_engin_sqrt);
            this.panel_engin.Controls.Add(this.button_engin_mod);
            this.panel_engin.Controls.Add(this.button_engin_10powx);
            this.panel_engin.Controls.Add(this.button_engin_exp);
            this.panel_engin.Controls.Add(this.button_engin_log);
            this.panel_engin.Controls.Add(this.button_engin_plusminus);
            this.panel_engin.Controls.Add(this.button_engin_uparrow);
            this.panel_engin.Controls.Add(this.button_engin_pi);
            this.panel_engin.Controls.Add(this.button_engin_nfact);
            this.panel_engin.Controls.Add(this.button_engin_7);
            this.panel_engin.Controls.Add(this.button_engin_minus);
            this.panel_engin.Controls.Add(this.button_engin_plus);
            this.panel_engin.Controls.Add(this.button_engin_multiply);
            this.panel_engin.Controls.Add(this.button_engin_divide);
            this.panel_engin.Controls.Add(this.button_engin_9);
            this.panel_engin.Controls.Add(this.button_engin_8);
            this.panel_engin.Controls.Add(this.button_engin_6);
            this.panel_engin.Controls.Add(this.button_engin_5);
            this.panel_engin.Controls.Add(this.button_engin_4);
            this.panel_engin.Controls.Add(this.button_engin_3);
            this.panel_engin.Controls.Add(this.button_engin_2);
            this.panel_engin.Controls.Add(this.button_engin_1);
            this.panel_engin.Controls.Add(this.button_engin_0);
            this.panel_engin.Controls.Add(this.button_engin_equal);
            this.panel_engin.Controls.Add(this.button_engin_clear);
            this.panel_engin.Controls.Add(this.button_engin_delete);
            this.panel_engin.Controls.Add(this.button_engin_clear2);
            this.panel_engin.Controls.Add(this.button_engin_float);
            this.panel_engin.Controls.Add(this.button_engin_rightbracket);
            this.panel_engin.Controls.Add(this.button_engin_leftbracket);
            this.panel_engin.Location = new System.Drawing.Point(0, 0);
            this.panel_engin.Name = "panel_engin";
            this.panel_engin.Size = new System.Drawing.Size(405, 472);
            this.panel_engin.TabIndex = 61;
            this.panel_engin.Visible = false;
            this.panel_engin.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_engin_Paint);
            // 
            // button_engin_menu
            // 
            this.button_engin_menu.BackColor = System.Drawing.Color.Silver;
            this.button_engin_menu.FlatAppearance.BorderSize = 0;
            this.button_engin_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_engin_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.5F);
            this.button_engin_menu.Location = new System.Drawing.Point(16, 21);
            this.button_engin_menu.Name = "button_engin_menu";
            this.button_engin_menu.Size = new System.Drawing.Size(40, 33);
            this.button_engin_menu.TabIndex = 30;
            this.button_engin_menu.Text = "≡";
            this.button_engin_menu.UseVisualStyleBackColor = true;
            this.button_engin_menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // button_engin_MR
            // 
            this.button_engin_MR.Enabled = false;
            this.button_engin_MR.FlatAppearance.BorderSize = 0;
            this.button_engin_MR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_engin_MR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_engin_MR.Location = new System.Drawing.Point(107, 122);
            this.button_engin_MR.Name = "button_engin_MR";
            this.button_engin_MR.Size = new System.Drawing.Size(44, 23);
            this.button_engin_MR.TabIndex = 38;
            this.button_engin_MR.Text = "MR";
            this.button_engin_MR.UseVisualStyleBackColor = false;
            this.button_engin_MR.Click += new System.EventHandler(this.buttonMR_Click);
            // 
            // button_engin_MC
            // 
            this.button_engin_MC.Enabled = false;
            this.button_engin_MC.FlatAppearance.BorderSize = 0;
            this.button_engin_MC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_engin_MC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_engin_MC.Location = new System.Drawing.Point(35, 122);
            this.button_engin_MC.Name = "button_engin_MC";
            this.button_engin_MC.Size = new System.Drawing.Size(43, 23);
            this.button_engin_MC.TabIndex = 37;
            this.button_engin_MC.Text = "MC";
            this.button_engin_MC.UseVisualStyleBackColor = false;
            this.button_engin_MC.Click += new System.EventHandler(this.buttonMC_Click);
            // 
            // panel_engin_memory
            // 
            this.panel_engin_memory.AutoScroll = true;
            this.panel_engin_memory.BackColor = System.Drawing.Color.LightGray;
            this.panel_engin_memory.Location = new System.Drawing.Point(1, 153);
            this.panel_engin_memory.Name = "panel_engin_memory";
            this.panel_engin_memory.Size = new System.Drawing.Size(404, 324);
            this.panel_engin_memory.TabIndex = 73;
            this.panel_engin_memory.Visible = false;
            // 
            // label_engin
            // 
            this.label_engin.AutoSize = true;
            this.label_engin.BackColor = System.Drawing.Color.Silver;
            this.label_engin.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.5F);
            this.label_engin.Location = new System.Drawing.Point(62, 24);
            this.label_engin.Name = "label_engin";
            this.label_engin.Size = new System.Drawing.Size(168, 30);
            this.label_engin.TabIndex = 30;
            this.label_engin.Text = "Инженерный";
            // 
            // display_engin
            // 
            this.display_engin.BackColor = System.Drawing.Color.Silver;
            this.display_engin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.display_engin.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.display_engin.Location = new System.Drawing.Point(76, 64);
            this.display_engin.Margin = new System.Windows.Forms.Padding(0);
            this.display_engin.Name = "display_engin";
            this.display_engin.ReadOnly = true;
            this.display_engin.Size = new System.Drawing.Size(324, 38);
            this.display_engin.TabIndex = 36;
            this.display_engin.Text = "0";
            this.display_engin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button_engin_Mplus
            // 
            this.button_engin_Mplus.FlatAppearance.BorderSize = 0;
            this.button_engin_Mplus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_engin_Mplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_engin_Mplus.Location = new System.Drawing.Point(182, 122);
            this.button_engin_Mplus.Name = "button_engin_Mplus";
            this.button_engin_Mplus.Size = new System.Drawing.Size(35, 23);
            this.button_engin_Mplus.TabIndex = 39;
            this.button_engin_Mplus.Text = "M+";
            this.button_engin_Mplus.UseVisualStyleBackColor = false;
            this.button_engin_Mplus.Click += new System.EventHandler(this.buttonMplus_Click);
            // 
            // button_engin_xpow2
            // 
            this.button_engin_xpow2.BackColor = System.Drawing.Color.LightGray;
            this.button_engin_xpow2.FlatAppearance.BorderSize = 0;
            this.button_engin_xpow2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_engin_xpow2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_engin_xpow2.Location = new System.Drawing.Point(2, 153);
            this.button_engin_xpow2.Name = "button_engin_xpow2";
            this.button_engin_xpow2.Size = new System.Drawing.Size(77, 43);
            this.button_engin_xpow2.TabIndex = 68;
            this.button_engin_xpow2.Text = "x^2";
            this.button_engin_xpow2.UseVisualStyleBackColor = false;
            this.button_engin_xpow2.Click += new System.EventHandler(this.xpow2_Click);
            // 
            // button_engin_Mminus
            // 
            this.button_engin_Mminus.FlatAppearance.BorderSize = 0;
            this.button_engin_Mminus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_engin_Mminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_engin_Mminus.Location = new System.Drawing.Point(247, 122);
            this.button_engin_Mminus.Name = "button_engin_Mminus";
            this.button_engin_Mminus.Size = new System.Drawing.Size(41, 23);
            this.button_engin_Mminus.TabIndex = 40;
            this.button_engin_Mminus.Text = "M-";
            this.button_engin_Mminus.UseVisualStyleBackColor = false;
            this.button_engin_Mminus.Click += new System.EventHandler(this.buttonMminus_Click);
            // 
            // button_engin_tan
            // 
            this.button_engin_tan.BackColor = System.Drawing.Color.LightGray;
            this.button_engin_tan.FlatAppearance.BorderSize = 0;
            this.button_engin_tan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_engin_tan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_engin_tan.Location = new System.Drawing.Point(329, 153);
            this.button_engin_tan.Name = "button_engin_tan";
            this.button_engin_tan.Size = new System.Drawing.Size(77, 43);
            this.button_engin_tan.TabIndex = 69;
            this.button_engin_tan.Text = "tan";
            this.button_engin_tan.UseVisualStyleBackColor = false;
            this.button_engin_tan.Click += new System.EventHandler(this.button_engin_tan_Click);
            // 
            // button_engin_MS
            // 
            this.button_engin_MS.FlatAppearance.BorderSize = 0;
            this.button_engin_MS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_engin_MS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_engin_MS.Location = new System.Drawing.Point(303, 122);
            this.button_engin_MS.Name = "button_engin_MS";
            this.button_engin_MS.Size = new System.Drawing.Size(45, 23);
            this.button_engin_MS.TabIndex = 41;
            this.button_engin_MS.Text = "MS";
            this.button_engin_MS.UseVisualStyleBackColor = false;
            this.button_engin_MS.Click += new System.EventHandler(this.buttonMS_Click);
            // 
            // button_engin_xpowy
            // 
            this.button_engin_xpowy.BackColor = System.Drawing.Color.LightGray;
            this.button_engin_xpowy.FlatAppearance.BorderSize = 0;
            this.button_engin_xpowy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_engin_xpowy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_engin_xpowy.Location = new System.Drawing.Point(85, 153);
            this.button_engin_xpowy.Name = "button_engin_xpowy";
            this.button_engin_xpowy.Size = new System.Drawing.Size(77, 43);
            this.button_engin_xpowy.TabIndex = 70;
            this.button_engin_xpowy.Text = "x^y";
            this.button_engin_xpowy.UseVisualStyleBackColor = false;
            this.button_engin_xpowy.Click += new System.EventHandler(this.operation_Click);
            // 
            // button_engin_M
            // 
            this.button_engin_M.Enabled = false;
            this.button_engin_M.FlatAppearance.BorderSize = 0;
            this.button_engin_M.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_engin_M.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_engin_M.Location = new System.Drawing.Point(354, 121);
            this.button_engin_M.Name = "button_engin_M";
            this.button_engin_M.Size = new System.Drawing.Size(46, 23);
            this.button_engin_M.TabIndex = 36;
            this.button_engin_M.Text = "M";
            this.button_engin_M.UseVisualStyleBackColor = false;
            this.button_engin_M.Click += new System.EventHandler(this.button_engin_M_Click);
            // 
            // button_engin_cos
            // 
            this.button_engin_cos.BackColor = System.Drawing.Color.LightGray;
            this.button_engin_cos.FlatAppearance.BorderSize = 0;
            this.button_engin_cos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_engin_cos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_engin_cos.Location = new System.Drawing.Point(247, 153);
            this.button_engin_cos.Name = "button_engin_cos";
            this.button_engin_cos.Size = new System.Drawing.Size(77, 43);
            this.button_engin_cos.TabIndex = 71;
            this.button_engin_cos.Text = "cos";
            this.button_engin_cos.UseVisualStyleBackColor = false;
            this.button_engin_cos.Click += new System.EventHandler(this.button_engin_cos_Click);
            // 
            // button_engin_sin
            // 
            this.button_engin_sin.BackColor = System.Drawing.Color.LightGray;
            this.button_engin_sin.FlatAppearance.BorderSize = 0;
            this.button_engin_sin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_engin_sin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_engin_sin.Location = new System.Drawing.Point(167, 153);
            this.button_engin_sin.Name = "button_engin_sin";
            this.button_engin_sin.Size = new System.Drawing.Size(77, 43);
            this.button_engin_sin.TabIndex = 72;
            this.button_engin_sin.Text = "sin";
            this.button_engin_sin.UseVisualStyleBackColor = false;
            this.button_engin_sin.Click += new System.EventHandler(this.button_engin_sin_Click);
            // 
            // button_engin_sqrt
            // 
            this.button_engin_sqrt.BackColor = System.Drawing.Color.LightGray;
            this.button_engin_sqrt.FlatAppearance.BorderSize = 0;
            this.button_engin_sqrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_engin_sqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F);
            this.button_engin_sqrt.Location = new System.Drawing.Point(1, 200);
            this.button_engin_sqrt.Name = "button_engin_sqrt";
            this.button_engin_sqrt.Size = new System.Drawing.Size(77, 43);
            this.button_engin_sqrt.TabIndex = 62;
            this.button_engin_sqrt.Text = "√";
            this.button_engin_sqrt.UseVisualStyleBackColor = false;
            this.button_engin_sqrt.Click += new System.EventHandler(this.sqrt_Click);
            // 
            // button_engin_mod
            // 
            this.button_engin_mod.BackColor = System.Drawing.Color.LightGray;
            this.button_engin_mod.FlatAppearance.BorderSize = 0;
            this.button_engin_mod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_engin_mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_engin_mod.Location = new System.Drawing.Point(328, 200);
            this.button_engin_mod.Name = "button_engin_mod";
            this.button_engin_mod.Size = new System.Drawing.Size(77, 43);
            this.button_engin_mod.TabIndex = 64;
            this.button_engin_mod.Text = "Mod";
            this.button_engin_mod.UseVisualStyleBackColor = false;
            this.button_engin_mod.Click += new System.EventHandler(this.operation_Click);
            // 
            // button_engin_10powx
            // 
            this.button_engin_10powx.BackColor = System.Drawing.Color.LightGray;
            this.button_engin_10powx.FlatAppearance.BorderSize = 0;
            this.button_engin_10powx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_engin_10powx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_engin_10powx.Location = new System.Drawing.Point(84, 200);
            this.button_engin_10powx.Name = "button_engin_10powx";
            this.button_engin_10powx.Size = new System.Drawing.Size(77, 43);
            this.button_engin_10powx.TabIndex = 65;
            this.button_engin_10powx.Text = "10^x";
            this.button_engin_10powx.UseVisualStyleBackColor = false;
            this.button_engin_10powx.Click += new System.EventHandler(this.button_engin_10powx_Click);
            // 
            // button_engin_exp
            // 
            this.button_engin_exp.BackColor = System.Drawing.Color.LightGray;
            this.button_engin_exp.FlatAppearance.BorderSize = 0;
            this.button_engin_exp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_engin_exp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_engin_exp.Location = new System.Drawing.Point(247, 200);
            this.button_engin_exp.Name = "button_engin_exp";
            this.button_engin_exp.Size = new System.Drawing.Size(77, 43);
            this.button_engin_exp.TabIndex = 66;
            this.button_engin_exp.Text = "Exp";
            this.button_engin_exp.UseVisualStyleBackColor = false;
            this.button_engin_exp.Click += new System.EventHandler(this.button_engin_exp_Click);
            // 
            // button_engin_log
            // 
            this.button_engin_log.BackColor = System.Drawing.Color.LightGray;
            this.button_engin_log.FlatAppearance.BorderSize = 0;
            this.button_engin_log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_engin_log.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_engin_log.Location = new System.Drawing.Point(166, 200);
            this.button_engin_log.Name = "button_engin_log";
            this.button_engin_log.Size = new System.Drawing.Size(77, 43);
            this.button_engin_log.TabIndex = 67;
            this.button_engin_log.Text = "log";
            this.button_engin_log.UseVisualStyleBackColor = false;
            this.button_engin_log.Click += new System.EventHandler(this.button_engin_log_Click);
            // 
            // button_engin_plusminus
            // 
            this.button_engin_plusminus.BackColor = System.Drawing.Color.LightGray;
            this.button_engin_plusminus.FlatAppearance.BorderSize = 0;
            this.button_engin_plusminus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_engin_plusminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_engin_plusminus.Location = new System.Drawing.Point(1, 388);
            this.button_engin_plusminus.Name = "button_engin_plusminus";
            this.button_engin_plusminus.Size = new System.Drawing.Size(77, 43);
            this.button_engin_plusminus.TabIndex = 62;
            this.button_engin_plusminus.Text = "±";
            this.button_engin_plusminus.UseVisualStyleBackColor = false;
            this.button_engin_plusminus.Click += new System.EventHandler(this.plusminus_Click);
            // 
            // button_engin_uparrow
            // 
            this.button_engin_uparrow.BackColor = System.Drawing.Color.LightGray;
            this.button_engin_uparrow.FlatAppearance.BorderSize = 0;
            this.button_engin_uparrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_engin_uparrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_engin_uparrow.Location = new System.Drawing.Point(1, 247);
            this.button_engin_uparrow.Name = "button_engin_uparrow";
            this.button_engin_uparrow.Size = new System.Drawing.Size(77, 43);
            this.button_engin_uparrow.TabIndex = 63;
            this.button_engin_uparrow.Text = "↑";
            this.button_engin_uparrow.UseVisualStyleBackColor = false;
            // 
            // button_engin_pi
            // 
            this.button_engin_pi.BackColor = System.Drawing.Color.LightGray;
            this.button_engin_pi.FlatAppearance.BorderSize = 0;
            this.button_engin_pi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_engin_pi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_engin_pi.Location = new System.Drawing.Point(1, 294);
            this.button_engin_pi.Name = "button_engin_pi";
            this.button_engin_pi.Size = new System.Drawing.Size(77, 43);
            this.button_engin_pi.TabIndex = 62;
            this.button_engin_pi.Text = "π";
            this.button_engin_pi.UseVisualStyleBackColor = false;
            this.button_engin_pi.Click += new System.EventHandler(this.button_engin_pi_Click);
            // 
            // button_engin_nfact
            // 
            this.button_engin_nfact.BackColor = System.Drawing.Color.LightGray;
            this.button_engin_nfact.FlatAppearance.BorderSize = 0;
            this.button_engin_nfact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_engin_nfact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_engin_nfact.Location = new System.Drawing.Point(1, 341);
            this.button_engin_nfact.Name = "button_engin_nfact";
            this.button_engin_nfact.Size = new System.Drawing.Size(77, 43);
            this.button_engin_nfact.TabIndex = 61;
            this.button_engin_nfact.Text = "n!";
            this.button_engin_nfact.UseVisualStyleBackColor = false;
            this.button_engin_nfact.Click += new System.EventHandler(this.button_engin_nfact_Click);
            // 
            // button_engin_7
            // 
            this.button_engin_7.BackColor = System.Drawing.Color.White;
            this.button_engin_7.FlatAppearance.BorderSize = 0;
            this.button_engin_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_engin_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.button_engin_7.Location = new System.Drawing.Point(84, 294);
            this.button_engin_7.Name = "button_engin_7";
            this.button_engin_7.Size = new System.Drawing.Size(77, 43);
            this.button_engin_7.TabIndex = 42;
            this.button_engin_7.Text = "7";
            this.button_engin_7.UseVisualStyleBackColor = false;
            this.button_engin_7.Click += new System.EventHandler(this.numbers_CLick);
            // 
            // button_engin_minus
            // 
            this.button_engin_minus.BackColor = System.Drawing.Color.LightGray;
            this.button_engin_minus.FlatAppearance.BorderSize = 0;
            this.button_engin_minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_engin_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_engin_minus.Location = new System.Drawing.Point(329, 341);
            this.button_engin_minus.Name = "button_engin_minus";
            this.button_engin_minus.Size = new System.Drawing.Size(77, 43);
            this.button_engin_minus.TabIndex = 48;
            this.button_engin_minus.Text = "-";
            this.button_engin_minus.UseVisualStyleBackColor = false;
            this.button_engin_minus.Click += new System.EventHandler(this.operation_Click);
            // 
            // button_engin_plus
            // 
            this.button_engin_plus.BackColor = System.Drawing.Color.LightGray;
            this.button_engin_plus.FlatAppearance.BorderSize = 0;
            this.button_engin_plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_engin_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_engin_plus.Location = new System.Drawing.Point(329, 388);
            this.button_engin_plus.Name = "button_engin_plus";
            this.button_engin_plus.Size = new System.Drawing.Size(77, 43);
            this.button_engin_plus.TabIndex = 47;
            this.button_engin_plus.Text = "+";
            this.button_engin_plus.UseVisualStyleBackColor = false;
            this.button_engin_plus.Click += new System.EventHandler(this.operation_Click);
            // 
            // button_engin_multiply
            // 
            this.button_engin_multiply.BackColor = System.Drawing.Color.LightGray;
            this.button_engin_multiply.FlatAppearance.BorderSize = 0;
            this.button_engin_multiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_engin_multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_engin_multiply.Location = new System.Drawing.Point(328, 294);
            this.button_engin_multiply.Name = "button_engin_multiply";
            this.button_engin_multiply.Size = new System.Drawing.Size(79, 43);
            this.button_engin_multiply.TabIndex = 46;
            this.button_engin_multiply.Text = "X";
            this.button_engin_multiply.UseVisualStyleBackColor = false;
            this.button_engin_multiply.Click += new System.EventHandler(this.operation_Click);
            // 
            // button_engin_divide
            // 
            this.button_engin_divide.BackColor = System.Drawing.Color.LightGray;
            this.button_engin_divide.FlatAppearance.BorderSize = 0;
            this.button_engin_divide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_engin_divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_engin_divide.Location = new System.Drawing.Point(329, 247);
            this.button_engin_divide.Name = "button_engin_divide";
            this.button_engin_divide.Size = new System.Drawing.Size(77, 43);
            this.button_engin_divide.TabIndex = 45;
            this.button_engin_divide.Text = "÷";
            this.button_engin_divide.UseVisualStyleBackColor = false;
            this.button_engin_divide.Click += new System.EventHandler(this.operation_Click);
            // 
            // button_engin_9
            // 
            this.button_engin_9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.button_engin_9.FlatAppearance.BorderSize = 0;
            this.button_engin_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_engin_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.button_engin_9.Location = new System.Drawing.Point(247, 294);
            this.button_engin_9.Name = "button_engin_9";
            this.button_engin_9.Size = new System.Drawing.Size(77, 43);
            this.button_engin_9.TabIndex = 44;
            this.button_engin_9.Text = "9";
            this.button_engin_9.UseVisualStyleBackColor = false;
            this.button_engin_9.Click += new System.EventHandler(this.numbers_CLick);
            // 
            // button_engin_8
            // 
            this.button_engin_8.BackColor = System.Drawing.Color.White;
            this.button_engin_8.FlatAppearance.BorderSize = 0;
            this.button_engin_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_engin_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.button_engin_8.Location = new System.Drawing.Point(166, 294);
            this.button_engin_8.Name = "button_engin_8";
            this.button_engin_8.Size = new System.Drawing.Size(77, 43);
            this.button_engin_8.TabIndex = 43;
            this.button_engin_8.Text = "8";
            this.button_engin_8.UseVisualStyleBackColor = false;
            this.button_engin_8.Click += new System.EventHandler(this.numbers_CLick);
            // 
            // button_engin_6
            // 
            this.button_engin_6.BackColor = System.Drawing.Color.White;
            this.button_engin_6.FlatAppearance.BorderSize = 0;
            this.button_engin_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_engin_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.button_engin_6.Location = new System.Drawing.Point(247, 341);
            this.button_engin_6.Name = "button_engin_6";
            this.button_engin_6.Size = new System.Drawing.Size(77, 43);
            this.button_engin_6.TabIndex = 41;
            this.button_engin_6.Text = "6";
            this.button_engin_6.UseVisualStyleBackColor = false;
            this.button_engin_6.Click += new System.EventHandler(this.numbers_CLick);
            // 
            // button_engin_5
            // 
            this.button_engin_5.BackColor = System.Drawing.Color.White;
            this.button_engin_5.FlatAppearance.BorderSize = 0;
            this.button_engin_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_engin_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.button_engin_5.Location = new System.Drawing.Point(166, 341);
            this.button_engin_5.Name = "button_engin_5";
            this.button_engin_5.Size = new System.Drawing.Size(77, 43);
            this.button_engin_5.TabIndex = 40;
            this.button_engin_5.Text = "5";
            this.button_engin_5.UseVisualStyleBackColor = false;
            this.button_engin_5.Click += new System.EventHandler(this.numbers_CLick);
            // 
            // button_engin_4
            // 
            this.button_engin_4.BackColor = System.Drawing.Color.White;
            this.button_engin_4.FlatAppearance.BorderSize = 0;
            this.button_engin_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_engin_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.button_engin_4.Location = new System.Drawing.Point(84, 341);
            this.button_engin_4.Name = "button_engin_4";
            this.button_engin_4.Size = new System.Drawing.Size(77, 43);
            this.button_engin_4.TabIndex = 39;
            this.button_engin_4.Text = "4";
            this.button_engin_4.UseVisualStyleBackColor = false;
            this.button_engin_4.Click += new System.EventHandler(this.numbers_CLick);
            // 
            // button_engin_3
            // 
            this.button_engin_3.BackColor = System.Drawing.Color.White;
            this.button_engin_3.FlatAppearance.BorderSize = 0;
            this.button_engin_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_engin_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.button_engin_3.Location = new System.Drawing.Point(247, 388);
            this.button_engin_3.Name = "button_engin_3";
            this.button_engin_3.Size = new System.Drawing.Size(77, 43);
            this.button_engin_3.TabIndex = 38;
            this.button_engin_3.Text = "3";
            this.button_engin_3.UseVisualStyleBackColor = false;
            this.button_engin_3.Click += new System.EventHandler(this.numbers_CLick);
            // 
            // button_engin_2
            // 
            this.button_engin_2.BackColor = System.Drawing.Color.White;
            this.button_engin_2.FlatAppearance.BorderSize = 0;
            this.button_engin_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_engin_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.button_engin_2.Location = new System.Drawing.Point(166, 388);
            this.button_engin_2.Name = "button_engin_2";
            this.button_engin_2.Size = new System.Drawing.Size(77, 43);
            this.button_engin_2.TabIndex = 37;
            this.button_engin_2.Text = "2";
            this.button_engin_2.UseVisualStyleBackColor = false;
            this.button_engin_2.Click += new System.EventHandler(this.numbers_CLick);
            // 
            // button_engin_1
            // 
            this.button_engin_1.BackColor = System.Drawing.Color.White;
            this.button_engin_1.FlatAppearance.BorderSize = 0;
            this.button_engin_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_engin_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.button_engin_1.Location = new System.Drawing.Point(84, 388);
            this.button_engin_1.Name = "button_engin_1";
            this.button_engin_1.Size = new System.Drawing.Size(77, 43);
            this.button_engin_1.TabIndex = 36;
            this.button_engin_1.Text = "1";
            this.button_engin_1.UseVisualStyleBackColor = false;
            this.button_engin_1.Click += new System.EventHandler(this.numbers_CLick);
            // 
            // button_engin_0
            // 
            this.button_engin_0.BackColor = System.Drawing.Color.White;
            this.button_engin_0.FlatAppearance.BorderSize = 0;
            this.button_engin_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_engin_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_engin_0.Location = new System.Drawing.Point(166, 435);
            this.button_engin_0.Name = "button_engin_0";
            this.button_engin_0.Size = new System.Drawing.Size(77, 43);
            this.button_engin_0.TabIndex = 35;
            this.button_engin_0.Text = "0";
            this.button_engin_0.UseVisualStyleBackColor = false;
            this.button_engin_0.Click += new System.EventHandler(this.numbers_CLick);
            // 
            // button_engin_equal
            // 
            this.button_engin_equal.BackColor = System.Drawing.Color.LightGray;
            this.button_engin_equal.FlatAppearance.BorderSize = 0;
            this.button_engin_equal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_engin_equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_engin_equal.Location = new System.Drawing.Point(329, 435);
            this.button_engin_equal.Name = "button_engin_equal";
            this.button_engin_equal.Size = new System.Drawing.Size(77, 43);
            this.button_engin_equal.TabIndex = 50;
            this.button_engin_equal.Text = "=";
            this.button_engin_equal.UseVisualStyleBackColor = false;
            this.button_engin_equal.Click += new System.EventHandler(this.result_Click);
            // 
            // button_engin_clear
            // 
            this.button_engin_clear.BackColor = System.Drawing.Color.LightGray;
            this.button_engin_clear.FlatAppearance.BorderSize = 0;
            this.button_engin_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_engin_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_engin_clear.Location = new System.Drawing.Point(84, 247);
            this.button_engin_clear.Name = "button_engin_clear";
            this.button_engin_clear.Size = new System.Drawing.Size(77, 43);
            this.button_engin_clear.TabIndex = 49;
            this.button_engin_clear.Text = "CE";
            this.button_engin_clear.UseVisualStyleBackColor = false;
            this.button_engin_clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // button_engin_delete
            // 
            this.button_engin_delete.BackColor = System.Drawing.Color.LightGray;
            this.button_engin_delete.FlatAppearance.BorderSize = 0;
            this.button_engin_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_engin_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_engin_delete.Location = new System.Drawing.Point(247, 247);
            this.button_engin_delete.Name = "button_engin_delete";
            this.button_engin_delete.Size = new System.Drawing.Size(77, 43);
            this.button_engin_delete.TabIndex = 51;
            this.button_engin_delete.Text = "←";
            this.button_engin_delete.UseVisualStyleBackColor = false;
            this.button_engin_delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // button_engin_clear2
            // 
            this.button_engin_clear2.BackColor = System.Drawing.Color.LightGray;
            this.button_engin_clear2.FlatAppearance.BorderSize = 0;
            this.button_engin_clear2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_engin_clear2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_engin_clear2.Location = new System.Drawing.Point(166, 247);
            this.button_engin_clear2.Name = "button_engin_clear2";
            this.button_engin_clear2.Size = new System.Drawing.Size(77, 43);
            this.button_engin_clear2.TabIndex = 52;
            this.button_engin_clear2.Text = "C";
            this.button_engin_clear2.UseVisualStyleBackColor = false;
            this.button_engin_clear2.Click += new System.EventHandler(this.clear2_Click);
            // 
            // button_engin_float
            // 
            this.button_engin_float.BackColor = System.Drawing.Color.LightGray;
            this.button_engin_float.FlatAppearance.BorderSize = 0;
            this.button_engin_float.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_engin_float.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F);
            this.button_engin_float.Location = new System.Drawing.Point(247, 435);
            this.button_engin_float.Name = "button_engin_float";
            this.button_engin_float.Size = new System.Drawing.Size(77, 43);
            this.button_engin_float.TabIndex = 58;
            this.button_engin_float.Text = ",";
            this.button_engin_float.UseVisualStyleBackColor = false;
            this.button_engin_float.Click += new System.EventHandler(this.float_Click);
            // 
            // button_engin_rightbracket
            // 
            this.button_engin_rightbracket.BackColor = System.Drawing.Color.LightGray;
            this.button_engin_rightbracket.FlatAppearance.BorderSize = 0;
            this.button_engin_rightbracket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_engin_rightbracket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_engin_rightbracket.Location = new System.Drawing.Point(84, 435);
            this.button_engin_rightbracket.Name = "button_engin_rightbracket";
            this.button_engin_rightbracket.Size = new System.Drawing.Size(77, 43);
            this.button_engin_rightbracket.TabIndex = 59;
            this.button_engin_rightbracket.Text = ")";
            this.button_engin_rightbracket.UseVisualStyleBackColor = false;
            // 
            // button_engin_leftbracket
            // 
            this.button_engin_leftbracket.BackColor = System.Drawing.Color.LightGray;
            this.button_engin_leftbracket.FlatAppearance.BorderSize = 0;
            this.button_engin_leftbracket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_engin_leftbracket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_engin_leftbracket.Location = new System.Drawing.Point(1, 435);
            this.button_engin_leftbracket.Name = "button_engin_leftbracket";
            this.button_engin_leftbracket.Size = new System.Drawing.Size(77, 43);
            this.button_engin_leftbracket.TabIndex = 60;
            this.button_engin_leftbracket.Text = "(";
            this.button_engin_leftbracket.UseVisualStyleBackColor = false;
            // 
            // buttonMC
            // 
            this.buttonMC.Enabled = false;
            this.buttonMC.FlatAppearance.BorderSize = 0;
            this.buttonMC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMC.Location = new System.Drawing.Point(18, 132);
            this.buttonMC.Name = "buttonMC";
            this.buttonMC.Size = new System.Drawing.Size(43, 23);
            this.buttonMC.TabIndex = 30;
            this.buttonMC.Text = "MC";
            this.buttonMC.UseVisualStyleBackColor = false;
            this.buttonMC.Click += new System.EventHandler(this.buttonMC_Click);
            // 
            // buttonMR
            // 
            this.buttonMR.Enabled = false;
            this.buttonMR.FlatAppearance.BorderSize = 0;
            this.buttonMR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMR.Location = new System.Drawing.Point(68, 132);
            this.buttonMR.Name = "buttonMR";
            this.buttonMR.Size = new System.Drawing.Size(44, 23);
            this.buttonMR.TabIndex = 31;
            this.buttonMR.Text = "MR";
            this.buttonMR.UseVisualStyleBackColor = false;
            this.buttonMR.Click += new System.EventHandler(this.buttonMR_Click);
            // 
            // buttonMplus
            // 
            this.buttonMplus.FlatAppearance.BorderSize = 0;
            this.buttonMplus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMplus.Location = new System.Drawing.Point(130, 132);
            this.buttonMplus.Name = "buttonMplus";
            this.buttonMplus.Size = new System.Drawing.Size(35, 23);
            this.buttonMplus.TabIndex = 32;
            this.buttonMplus.Text = "M+";
            this.buttonMplus.UseVisualStyleBackColor = false;
            this.buttonMplus.Click += new System.EventHandler(this.buttonMplus_Click);
            // 
            // buttonMminus
            // 
            this.buttonMminus.FlatAppearance.BorderSize = 0;
            this.buttonMminus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMminus.Location = new System.Drawing.Point(173, 132);
            this.buttonMminus.Name = "buttonMminus";
            this.buttonMminus.Size = new System.Drawing.Size(41, 23);
            this.buttonMminus.TabIndex = 33;
            this.buttonMminus.Text = "M-";
            this.buttonMminus.UseVisualStyleBackColor = false;
            this.buttonMminus.Click += new System.EventHandler(this.buttonMminus_Click);
            // 
            // buttonMS
            // 
            this.buttonMS.FlatAppearance.BorderSize = 0;
            this.buttonMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMS.Location = new System.Drawing.Point(223, 132);
            this.buttonMS.Name = "buttonMS";
            this.buttonMS.Size = new System.Drawing.Size(45, 23);
            this.buttonMS.TabIndex = 34;
            this.buttonMS.Text = "MS";
            this.buttonMS.UseVisualStyleBackColor = false;
            this.buttonMS.Click += new System.EventHandler(this.buttonMS_Click);
            // 
            // buttonM
            // 
            this.buttonM.Enabled = false;
            this.buttonM.FlatAppearance.BorderSize = 0;
            this.buttonM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonM.Location = new System.Drawing.Point(274, 131);
            this.buttonM.Name = "buttonM";
            this.buttonM.Size = new System.Drawing.Size(46, 23);
            this.buttonM.TabIndex = 29;
            this.buttonM.Text = "M";
            this.buttonM.UseVisualStyleBackColor = false;
            this.buttonM.Click += new System.EventHandler(this.buttonM_Click);
            // 
            // button_minus
            // 
            this.button_minus.BackColor = System.Drawing.Color.LightGray;
            this.button_minus.FlatAppearance.BorderSize = 0;
            this.button_minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_minus.Location = new System.Drawing.Point(251, 300);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(77, 43);
            this.button_minus.TabIndex = 13;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = false;
            this.button_minus.Click += new System.EventHandler(this.operation_Click);
            // 
            // button_plus
            // 
            this.button_plus.BackColor = System.Drawing.Color.LightGray;
            this.button_plus.FlatAppearance.BorderSize = 0;
            this.button_plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_plus.Location = new System.Drawing.Point(251, 347);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(77, 43);
            this.button_plus.TabIndex = 12;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = false;
            this.button_plus.Click += new System.EventHandler(this.operation_Click);
            // 
            // button_multiply
            // 
            this.button_multiply.BackColor = System.Drawing.Color.LightGray;
            this.button_multiply.FlatAppearance.BorderSize = 0;
            this.button_multiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_multiply.Location = new System.Drawing.Point(251, 253);
            this.button_multiply.Name = "button_multiply";
            this.button_multiply.Size = new System.Drawing.Size(79, 43);
            this.button_multiply.TabIndex = 11;
            this.button_multiply.Text = "X";
            this.button_multiply.UseVisualStyleBackColor = false;
            this.button_multiply.Click += new System.EventHandler(this.operation_Click);
            // 
            // button_divide
            // 
            this.button_divide.BackColor = System.Drawing.Color.LightGray;
            this.button_divide.FlatAppearance.BorderSize = 0;
            this.button_divide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_divide.Location = new System.Drawing.Point(251, 206);
            this.button_divide.Name = "button_divide";
            this.button_divide.Size = new System.Drawing.Size(77, 43);
            this.button_divide.TabIndex = 10;
            this.button_divide.Text = "÷";
            this.button_divide.UseVisualStyleBackColor = false;
            this.button_divide.Click += new System.EventHandler(this.operation_Click);
            // 
            // button9_sim
            // 
            this.button9_sim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.button9_sim.FlatAppearance.BorderSize = 0;
            this.button9_sim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9_sim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.button9_sim.Location = new System.Drawing.Point(169, 253);
            this.button9_sim.Name = "button9_sim";
            this.button9_sim.Size = new System.Drawing.Size(77, 43);
            this.button9_sim.TabIndex = 9;
            this.button9_sim.Text = "9";
            this.button9_sim.UseVisualStyleBackColor = false;
            this.button9_sim.Click += new System.EventHandler(this.numbers_CLick);
            // 
            // button8_sim
            // 
            this.button8_sim.BackColor = System.Drawing.Color.White;
            this.button8_sim.FlatAppearance.BorderSize = 0;
            this.button8_sim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8_sim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.button8_sim.Location = new System.Drawing.Point(88, 253);
            this.button8_sim.Name = "button8_sim";
            this.button8_sim.Size = new System.Drawing.Size(77, 43);
            this.button8_sim.TabIndex = 8;
            this.button8_sim.Text = "8";
            this.button8_sim.UseVisualStyleBackColor = false;
            this.button8_sim.Click += new System.EventHandler(this.numbers_CLick);
            // 
            // button7_sim
            // 
            this.button7_sim.BackColor = System.Drawing.Color.White;
            this.button7_sim.FlatAppearance.BorderSize = 0;
            this.button7_sim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7_sim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.button7_sim.Location = new System.Drawing.Point(6, 253);
            this.button7_sim.Name = "button7_sim";
            this.button7_sim.Size = new System.Drawing.Size(77, 43);
            this.button7_sim.TabIndex = 7;
            this.button7_sim.Text = "7";
            this.button7_sim.UseVisualStyleBackColor = false;
            this.button7_sim.Click += new System.EventHandler(this.numbers_CLick);
            // 
            // button6_sim
            // 
            this.button6_sim.BackColor = System.Drawing.Color.White;
            this.button6_sim.FlatAppearance.BorderSize = 0;
            this.button6_sim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6_sim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.button6_sim.Location = new System.Drawing.Point(169, 300);
            this.button6_sim.Name = "button6_sim";
            this.button6_sim.Size = new System.Drawing.Size(77, 43);
            this.button6_sim.TabIndex = 6;
            this.button6_sim.Text = "6";
            this.button6_sim.UseVisualStyleBackColor = false;
            this.button6_sim.Click += new System.EventHandler(this.numbers_CLick);
            // 
            // button5_sim
            // 
            this.button5_sim.BackColor = System.Drawing.Color.White;
            this.button5_sim.FlatAppearance.BorderSize = 0;
            this.button5_sim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5_sim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.button5_sim.Location = new System.Drawing.Point(88, 300);
            this.button5_sim.Name = "button5_sim";
            this.button5_sim.Size = new System.Drawing.Size(77, 43);
            this.button5_sim.TabIndex = 5;
            this.button5_sim.Text = "5";
            this.button5_sim.UseVisualStyleBackColor = false;
            this.button5_sim.Click += new System.EventHandler(this.numbers_CLick);
            // 
            // button4_sim
            // 
            this.button4_sim.BackColor = System.Drawing.Color.White;
            this.button4_sim.FlatAppearance.BorderSize = 0;
            this.button4_sim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4_sim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.button4_sim.Location = new System.Drawing.Point(6, 300);
            this.button4_sim.Name = "button4_sim";
            this.button4_sim.Size = new System.Drawing.Size(77, 43);
            this.button4_sim.TabIndex = 4;
            this.button4_sim.Text = "4";
            this.button4_sim.UseVisualStyleBackColor = false;
            this.button4_sim.Click += new System.EventHandler(this.numbers_CLick);
            // 
            // button3_sim
            // 
            this.button3_sim.BackColor = System.Drawing.Color.White;
            this.button3_sim.FlatAppearance.BorderSize = 0;
            this.button3_sim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3_sim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.button3_sim.Location = new System.Drawing.Point(169, 347);
            this.button3_sim.Name = "button3_sim";
            this.button3_sim.Size = new System.Drawing.Size(77, 43);
            this.button3_sim.TabIndex = 3;
            this.button3_sim.Text = "3";
            this.button3_sim.UseVisualStyleBackColor = false;
            this.button3_sim.Click += new System.EventHandler(this.numbers_CLick);
            // 
            // button2_sim
            // 
            this.button2_sim.BackColor = System.Drawing.Color.White;
            this.button2_sim.FlatAppearance.BorderSize = 0;
            this.button2_sim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2_sim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.button2_sim.Location = new System.Drawing.Point(88, 347);
            this.button2_sim.Name = "button2_sim";
            this.button2_sim.Size = new System.Drawing.Size(77, 43);
            this.button2_sim.TabIndex = 2;
            this.button2_sim.Text = "2";
            this.button2_sim.UseVisualStyleBackColor = false;
            this.button2_sim.Click += new System.EventHandler(this.numbers_CLick);
            // 
            // button1_sim
            // 
            this.button1_sim.BackColor = System.Drawing.Color.White;
            this.button1_sim.FlatAppearance.BorderSize = 0;
            this.button1_sim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_sim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.button1_sim.Location = new System.Drawing.Point(6, 347);
            this.button1_sim.Name = "button1_sim";
            this.button1_sim.Size = new System.Drawing.Size(77, 43);
            this.button1_sim.TabIndex = 1;
            this.button1_sim.Text = "1";
            this.button1_sim.UseVisualStyleBackColor = false;
            this.button1_sim.Click += new System.EventHandler(this.numbers_CLick);
            // 
            // button0_sim
            // 
            this.button0_sim.BackColor = System.Drawing.Color.White;
            this.button0_sim.FlatAppearance.BorderSize = 0;
            this.button0_sim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button0_sim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0_sim.Location = new System.Drawing.Point(88, 394);
            this.button0_sim.Name = "button0_sim";
            this.button0_sim.Size = new System.Drawing.Size(77, 43);
            this.button0_sim.TabIndex = 0;
            this.button0_sim.Text = "0";
            this.button0_sim.UseVisualStyleBackColor = false;
            this.button0_sim.Click += new System.EventHandler(this.numbers_CLick);
            // 
            // button_result
            // 
            this.button_result.BackColor = System.Drawing.Color.LightGray;
            this.button_result.FlatAppearance.BorderSize = 0;
            this.button_result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_result.Location = new System.Drawing.Point(251, 394);
            this.button_result.Name = "button_result";
            this.button_result.Size = new System.Drawing.Size(77, 43);
            this.button_result.TabIndex = 16;
            this.button_result.Text = "=";
            this.button_result.UseVisualStyleBackColor = false;
            this.button_result.Click += new System.EventHandler(this.result_Click);
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.Color.LightGray;
            this.button_clear.FlatAppearance.BorderSize = 0;
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_clear.Location = new System.Drawing.Point(6, 206);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(77, 43);
            this.button_clear.TabIndex = 15;
            this.button_clear.Text = "CE";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.LightGray;
            this.button_delete.FlatAppearance.BorderSize = 0;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_delete.Location = new System.Drawing.Point(169, 206);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(77, 43);
            this.button_delete.TabIndex = 17;
            this.button_delete.Text = "←";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // button_clear2
            // 
            this.button_clear2.BackColor = System.Drawing.Color.LightGray;
            this.button_clear2.FlatAppearance.BorderSize = 0;
            this.button_clear2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clear2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_clear2.Location = new System.Drawing.Point(88, 206);
            this.button_clear2.Name = "button_clear2";
            this.button_clear2.Size = new System.Drawing.Size(77, 43);
            this.button_clear2.TabIndex = 18;
            this.button_clear2.Text = "C";
            this.button_clear2.UseVisualStyleBackColor = false;
            this.button_clear2.Click += new System.EventHandler(this.clear2_Click);
            // 
            // button_plusminus
            // 
            this.button_plusminus.BackColor = System.Drawing.Color.LightGray;
            this.button_plusminus.FlatAppearance.BorderSize = 0;
            this.button_plusminus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_plusminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_plusminus.Location = new System.Drawing.Point(7, 394);
            this.button_plusminus.Name = "button_plusminus";
            this.button_plusminus.Size = new System.Drawing.Size(77, 43);
            this.button_plusminus.TabIndex = 23;
            this.button_plusminus.Text = "±";
            this.button_plusminus.UseVisualStyleBackColor = false;
            this.button_plusminus.Click += new System.EventHandler(this.plusminus_Click);
            // 
            // button_float
            // 
            this.button_float.BackColor = System.Drawing.Color.LightGray;
            this.button_float.FlatAppearance.BorderSize = 0;
            this.button_float.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_float.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_float.Location = new System.Drawing.Point(169, 394);
            this.button_float.Name = "button_float";
            this.button_float.Size = new System.Drawing.Size(77, 43);
            this.button_float.TabIndex = 24;
            this.button_float.Text = ",";
            this.button_float.UseVisualStyleBackColor = false;
            this.button_float.Click += new System.EventHandler(this.float_Click);
            // 
            // panel_memory
            // 
            this.panel_memory.AutoScroll = true;
            this.panel_memory.BackColor = System.Drawing.Color.LightGray;
            this.panel_memory.Location = new System.Drawing.Point(1, 160);
            this.panel_memory.Name = "panel_memory";
            this.panel_memory.Size = new System.Drawing.Size(333, 277);
            this.panel_memory.TabIndex = 28;
            this.panel_memory.Visible = false;
            // 
            // panel_simple
            // 
            this.panel_simple.Controls.Add(this.panel_memory);
            this.panel_simple.Controls.Add(this.button_minus);
            this.panel_simple.Controls.Add(this.buttonMR);
            this.panel_simple.Controls.Add(this.button_plus);
            this.panel_simple.Controls.Add(this.typeOfCalc);
            this.panel_simple.Controls.Add(this.menu);
            this.panel_simple.Controls.Add(this.buttonMC);
            this.panel_simple.Controls.Add(this.display_sim);
            this.panel_simple.Controls.Add(this.button_multiply);
            this.panel_simple.Controls.Add(this.button_divide);
            this.panel_simple.Controls.Add(this.buttonMplus);
            this.panel_simple.Controls.Add(this.button9_sim);
            this.panel_simple.Controls.Add(this.buttonMminus);
            this.panel_simple.Controls.Add(this.button8_sim);
            this.panel_simple.Controls.Add(this.buttonMS);
            this.panel_simple.Controls.Add(this.button7_sim);
            this.panel_simple.Controls.Add(this.buttonM);
            this.panel_simple.Controls.Add(this.button6_sim);
            this.panel_simple.Controls.Add(this.button5_sim);
            this.panel_simple.Controls.Add(this.button_float);
            this.panel_simple.Controls.Add(this.button4_sim);
            this.panel_simple.Controls.Add(this.button_plusminus);
            this.panel_simple.Controls.Add(this.button3_sim);
            this.panel_simple.Controls.Add(this.button_onedividex);
            this.panel_simple.Controls.Add(this.button2_sim);
            this.panel_simple.Controls.Add(this.button_pow);
            this.panel_simple.Controls.Add(this.button1_sim);
            this.panel_simple.Controls.Add(this.button_sqrt);
            this.panel_simple.Controls.Add(this.button0_sim);
            this.panel_simple.Controls.Add(this.button_percent);
            this.panel_simple.Controls.Add(this.button_result);
            this.panel_simple.Controls.Add(this.button_clear2);
            this.panel_simple.Controls.Add(this.button_clear);
            this.panel_simple.Controls.Add(this.button_delete);
            this.panel_simple.Location = new System.Drawing.Point(0, 0);
            this.panel_simple.Name = "panel_simple";
            this.panel_simple.Size = new System.Drawing.Size(334, 440);
            this.panel_simple.TabIndex = 62;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(334, 438);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.panel_simple);
            this.Controls.Add(this.panel_engin);
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            this.panel_engin.ResumeLayout(false);
            this.panel_engin.PerformLayout();
            this.panel_simple.ResumeLayout(false);
            this.panel_simple.PerformLayout();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.TextBox display_sim;
        private System.Windows.Forms.Button button_percent;
        private System.Windows.Forms.Button button_sqrt;
        private System.Windows.Forms.Button button_pow;
        private System.Windows.Forms.Button button_onedividex;
        #endregion
        private System.Windows.Forms.Label typeOfCalc;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.Button menubackground;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Label label_calc;        
        private System.Windows.Forms.Button buttonMC;
        private System.Windows.Forms.Button buttonMR;
        private System.Windows.Forms.Button buttonMplus;
        private System.Windows.Forms.Button buttonMminus;
        private System.Windows.Forms.Button buttonMS;
        private System.Windows.Forms.Button buttonM;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_multiply;
        private System.Windows.Forms.Button button_divide;
        private System.Windows.Forms.Button button9_sim;
        private System.Windows.Forms.Button button8_sim;
        private System.Windows.Forms.Button button7_sim;
        private System.Windows.Forms.Button button6_sim;
        private System.Windows.Forms.Button button5_sim;
        private System.Windows.Forms.Button button4_sim;
        private System.Windows.Forms.Button button3_sim;
        private System.Windows.Forms.Button button2_sim;
        private System.Windows.Forms.Button button1_sim;
        private System.Windows.Forms.Button button0_sim;
        private System.Windows.Forms.Button button_result;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_clear2;
        private System.Windows.Forms.Button button_plusminus;
        private System.Windows.Forms.Button button_float;
        private System.Windows.Forms.Panel panel_memory;
        private System.Windows.Forms.Label label_MemoryStackShow;
        private System.Windows.Forms.Button engineering;
        private System.Windows.Forms.Button simple;
        private System.Windows.Forms.Panel panel_engin;
        private System.Windows.Forms.Button button_engin_sqrt;
        private System.Windows.Forms.Button button_engin_mod;
        private System.Windows.Forms.Button button_engin_10powx;
        private System.Windows.Forms.Button button_engin_exp;
        private System.Windows.Forms.Button button_engin_log;
        private System.Windows.Forms.Button button_engin_plusminus;
        private System.Windows.Forms.Button button_engin_uparrow;
        private System.Windows.Forms.Button button_engin_pi;
        private System.Windows.Forms.Button button_engin_nfact;
        private System.Windows.Forms.Button button_engin_7;
        private System.Windows.Forms.Button button_engin_minus;
        private System.Windows.Forms.Button button_engin_plus;
        private System.Windows.Forms.Button button_engin_multiply;
        private System.Windows.Forms.Button button_engin_divide;
        private System.Windows.Forms.Button button_engin_9;
        private System.Windows.Forms.Button button_engin_8;
        private System.Windows.Forms.Button button_engin_6;
        private System.Windows.Forms.Button button_engin_5;
        private System.Windows.Forms.Button button_engin_4;
        private System.Windows.Forms.Button button_engin_3;
        private System.Windows.Forms.Button button_engin_2;
        private System.Windows.Forms.Button button_engin_1;
        private System.Windows.Forms.Button button_engin_0;
        private System.Windows.Forms.Button button_engin_equal;
        private System.Windows.Forms.Button button_engin_clear;
        private System.Windows.Forms.Button button_engin_delete;
        private System.Windows.Forms.Button button_engin_clear2;
        private System.Windows.Forms.Button button_engin_float;
        private System.Windows.Forms.Button button_engin_rightbracket;
        private System.Windows.Forms.Button button_engin_leftbracket;
        private System.Windows.Forms.Panel panel_simple;
        private System.Windows.Forms.Button button_engin_MR;
        private System.Windows.Forms.Button button_engin_MC;
        private System.Windows.Forms.TextBox display_engin;
        private System.Windows.Forms.Button button_engin_Mplus;
        private System.Windows.Forms.Button button_engin_xpow2;
        private System.Windows.Forms.Button button_engin_Mminus;
        private System.Windows.Forms.Button button_engin_tan;
        private System.Windows.Forms.Button button_engin_MS;
        private System.Windows.Forms.Button button_engin_xpowy;
        private System.Windows.Forms.Button button_engin_M;
        private System.Windows.Forms.Button button_engin_cos;
        private System.Windows.Forms.Button button_engin_sin;
        private System.Windows.Forms.Label label_engin;
        private System.Windows.Forms.Button button_engin_menu;
        private System.Windows.Forms.Panel panel_engin_memory;
    }
}


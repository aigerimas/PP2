using System.Drawing;

namespace Paint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.main_panel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.colorDialog = new System.Windows.Forms.Button();
            this.button_color7 = new System.Windows.Forms.Button();
            this.button_color16 = new System.Windows.Forms.Button();
            this.button_color8 = new System.Windows.Forms.Button();
            this.button_color15 = new System.Windows.Forms.Button();
            this.button_color5 = new System.Windows.Forms.Button();
            this.button_color14 = new System.Windows.Forms.Button();
            this.button_color6 = new System.Windows.Forms.Button();
            this.button_color13 = new System.Windows.Forms.Button();
            this.button_color3 = new System.Windows.Forms.Button();
            this.button_color12 = new System.Windows.Forms.Button();
            this.button_color4 = new System.Windows.Forms.Button();
            this.button_color11 = new System.Windows.Forms.Button();
            this.button_color1 = new System.Windows.Forms.Button();
            this.button_color10 = new System.Windows.Forms.Button();
            this.button_color2 = new System.Windows.Forms.Button();
            this.button_color9 = new System.Windows.Forms.Button();
            this.current_color = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.hexagon = new System.Windows.Forms.Button();
            this.right_triangle = new System.Windows.Forms.Button();
            this.line = new System.Windows.Forms.Button();
            this.triangle = new System.Windows.Forms.Button();
            this.curve = new System.Windows.Forms.Button();
            this.rectangle = new System.Windows.Forms.Button();
            this.circle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_tool_lense = new System.Windows.Forms.Button();
            this.button_tool_palette = new System.Windows.Forms.Button();
            this.button_tool_erase = new System.Windows.Forms.Button();
            this.button_tool_text = new System.Windows.Forms.Button();
            this.button_tool_fill = new System.Windows.Forms.Button();
            this.button_tool_pencil = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.main_panel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1096, 400);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picturebox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picturebox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picturebox1_MouseUp);
            // 
            // main_panel
            // 
            this.main_panel.Controls.Add(this.panel3);
            this.main_panel.Controls.Add(this.comboBox1);
            this.main_panel.Controls.Add(this.panel2);
            this.main_panel.Controls.Add(this.panel1);
            this.main_panel.Controls.Add(this.button2);
            this.main_panel.Controls.Add(this.button1);
            this.main_panel.Location = new System.Drawing.Point(0, 27);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(1096, 94);
            this.main_panel.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.colorDialog);
            this.panel3.Controls.Add(this.button_color7);
            this.panel3.Controls.Add(this.button_color16);
            this.panel3.Controls.Add(this.button_color8);
            this.panel3.Controls.Add(this.button_color15);
            this.panel3.Controls.Add(this.button_color5);
            this.panel3.Controls.Add(this.button_color14);
            this.panel3.Controls.Add(this.button_color6);
            this.panel3.Controls.Add(this.button_color13);
            this.panel3.Controls.Add(this.button_color3);
            this.panel3.Controls.Add(this.button_color12);
            this.panel3.Controls.Add(this.button_color4);
            this.panel3.Controls.Add(this.button_color11);
            this.panel3.Controls.Add(this.button_color1);
            this.panel3.Controls.Add(this.button_color10);
            this.panel3.Controls.Add(this.button_color2);
            this.panel3.Controls.Add(this.button_color9);
            this.panel3.Controls.Add(this.current_color);
            this.panel3.Location = new System.Drawing.Point(571, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(378, 84);
            this.panel3.TabIndex = 3;
            // 
            // colorDialog
            // 
            this.colorDialog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("colorDialog.BackgroundImage")));
            this.colorDialog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.colorDialog.FlatAppearance.BorderSize = 0;
            this.colorDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorDialog.Location = new System.Drawing.Point(283, 8);
            this.colorDialog.Name = "colorDialog";
            this.colorDialog.Size = new System.Drawing.Size(44, 56);
            this.colorDialog.TabIndex = 33;
            this.colorDialog.UseVisualStyleBackColor = true;
            this.colorDialog.Click += new System.EventHandler(this.colorDialog_Click);
            // 
            // button_color7
            // 
            this.button_color7.BackColor = System.Drawing.Color.Green;
            this.button_color7.FlatAppearance.BorderSize = 0;
            this.button_color7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_color7.Location = new System.Drawing.Point(219, 8);
            this.button_color7.Name = "button_color7";
            this.button_color7.Size = new System.Drawing.Size(19, 25);
            this.button_color7.TabIndex = 29;
            this.button_color7.UseVisualStyleBackColor = false;
            this.button_color7.Click += new System.EventHandler(this.color_button_Click);
            // 
            // button_color16
            // 
            this.button_color16.BackColor = System.Drawing.Color.Lime;
            this.button_color16.FlatAppearance.BorderSize = 0;
            this.button_color16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_color16.Location = new System.Drawing.Point(240, 34);
            this.button_color16.Name = "button_color16";
            this.button_color16.Size = new System.Drawing.Size(19, 25);
            this.button_color16.TabIndex = 32;
            this.button_color16.UseVisualStyleBackColor = false;
            this.button_color16.Click += new System.EventHandler(this.color_button_Click);
            // 
            // button_color8
            // 
            this.button_color8.BackColor = System.Drawing.Color.Blue;
            this.button_color8.FlatAppearance.BorderSize = 0;
            this.button_color8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_color8.Location = new System.Drawing.Point(240, 8);
            this.button_color8.Name = "button_color8";
            this.button_color8.Size = new System.Drawing.Size(19, 25);
            this.button_color8.TabIndex = 30;
            this.button_color8.UseVisualStyleBackColor = false;
            this.button_color8.Click += new System.EventHandler(this.color_button_Click);
            // 
            // button_color15
            // 
            this.button_color15.BackColor = System.Drawing.Color.LightGreen;
            this.button_color15.FlatAppearance.BorderSize = 0;
            this.button_color15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_color15.Location = new System.Drawing.Point(219, 34);
            this.button_color15.Name = "button_color15";
            this.button_color15.Size = new System.Drawing.Size(19, 25);
            this.button_color15.TabIndex = 31;
            this.button_color15.UseVisualStyleBackColor = false;
            this.button_color15.Click += new System.EventHandler(this.color_button_Click);
            // 
            // button_color5
            // 
            this.button_color5.BackColor = System.Drawing.Color.Orange;
            this.button_color5.FlatAppearance.BorderSize = 0;
            this.button_color5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_color5.Location = new System.Drawing.Point(176, 8);
            this.button_color5.Name = "button_color5";
            this.button_color5.Size = new System.Drawing.Size(19, 25);
            this.button_color5.TabIndex = 25;
            this.button_color5.UseVisualStyleBackColor = false;
            this.button_color5.Click += new System.EventHandler(this.color_button_Click);
            // 
            // button_color14
            // 
            this.button_color14.BackColor = System.Drawing.Color.Pink;
            this.button_color14.FlatAppearance.BorderSize = 0;
            this.button_color14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_color14.Location = new System.Drawing.Point(197, 34);
            this.button_color14.Name = "button_color14";
            this.button_color14.Size = new System.Drawing.Size(19, 25);
            this.button_color14.TabIndex = 28;
            this.button_color14.UseVisualStyleBackColor = false;
            this.button_color14.Click += new System.EventHandler(this.color_button_Click);
            // 
            // button_color6
            // 
            this.button_color6.BackColor = System.Drawing.Color.Yellow;
            this.button_color6.FlatAppearance.BorderSize = 0;
            this.button_color6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_color6.Location = new System.Drawing.Point(197, 8);
            this.button_color6.Name = "button_color6";
            this.button_color6.Size = new System.Drawing.Size(19, 25);
            this.button_color6.TabIndex = 26;
            this.button_color6.UseVisualStyleBackColor = false;
            this.button_color6.Click += new System.EventHandler(this.color_button_Click);
            // 
            // button_color13
            // 
            this.button_color13.BackColor = System.Drawing.Color.Purple;
            this.button_color13.FlatAppearance.BorderSize = 0;
            this.button_color13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_color13.Location = new System.Drawing.Point(176, 34);
            this.button_color13.Name = "button_color13";
            this.button_color13.Size = new System.Drawing.Size(19, 25);
            this.button_color13.TabIndex = 27;
            this.button_color13.UseVisualStyleBackColor = false;
            this.button_color13.Click += new System.EventHandler(this.color_button_Click);
            // 
            // button_color3
            // 
            this.button_color3.BackColor = System.Drawing.Color.DarkRed;
            this.button_color3.FlatAppearance.BorderSize = 0;
            this.button_color3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_color3.Location = new System.Drawing.Point(134, 8);
            this.button_color3.Name = "button_color3";
            this.button_color3.Size = new System.Drawing.Size(19, 25);
            this.button_color3.TabIndex = 21;
            this.button_color3.UseVisualStyleBackColor = false;
            this.button_color3.Click += new System.EventHandler(this.color_button_Click);
            // 
            // button_color12
            // 
            this.button_color12.BackColor = System.Drawing.Color.LightGray;
            this.button_color12.FlatAppearance.BorderSize = 0;
            this.button_color12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_color12.Location = new System.Drawing.Point(155, 34);
            this.button_color12.Name = "button_color12";
            this.button_color12.Size = new System.Drawing.Size(19, 25);
            this.button_color12.TabIndex = 24;
            this.button_color12.UseVisualStyleBackColor = false;
            this.button_color12.Click += new System.EventHandler(this.color_button_Click);
            // 
            // button_color4
            // 
            this.button_color4.BackColor = System.Drawing.Color.Red;
            this.button_color4.FlatAppearance.BorderSize = 0;
            this.button_color4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_color4.Location = new System.Drawing.Point(155, 8);
            this.button_color4.Name = "button_color4";
            this.button_color4.Size = new System.Drawing.Size(19, 25);
            this.button_color4.TabIndex = 22;
            this.button_color4.UseVisualStyleBackColor = false;
            this.button_color4.Click += new System.EventHandler(this.color_button_Click);
            // 
            // button_color11
            // 
            this.button_color11.BackColor = System.Drawing.Color.White;
            this.button_color11.FlatAppearance.BorderSize = 0;
            this.button_color11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_color11.Location = new System.Drawing.Point(134, 34);
            this.button_color11.Name = "button_color11";
            this.button_color11.Size = new System.Drawing.Size(19, 25);
            this.button_color11.TabIndex = 23;
            this.button_color11.UseVisualStyleBackColor = false;
            this.button_color11.Click += new System.EventHandler(this.color_button_Click);
            // 
            // button_color1
            // 
            this.button_color1.BackColor = System.Drawing.Color.Black;
            this.button_color1.FlatAppearance.BorderSize = 0;
            this.button_color1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_color1.Location = new System.Drawing.Point(91, 8);
            this.button_color1.Name = "button_color1";
            this.button_color1.Size = new System.Drawing.Size(19, 25);
            this.button_color1.TabIndex = 16;
            this.button_color1.UseVisualStyleBackColor = false;
            this.button_color1.Click += new System.EventHandler(this.color_button_Click);
            // 
            // button_color10
            // 
            this.button_color10.BackColor = System.Drawing.Color.Violet;
            this.button_color10.FlatAppearance.BorderSize = 0;
            this.button_color10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_color10.Location = new System.Drawing.Point(112, 34);
            this.button_color10.Name = "button_color10";
            this.button_color10.Size = new System.Drawing.Size(19, 25);
            this.button_color10.TabIndex = 20;
            this.button_color10.UseVisualStyleBackColor = false;
            this.button_color10.Click += new System.EventHandler(this.color_button_Click);
            // 
            // button_color2
            // 
            this.button_color2.BackColor = System.Drawing.Color.SlateGray;
            this.button_color2.FlatAppearance.BorderSize = 0;
            this.button_color2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_color2.Location = new System.Drawing.Point(112, 8);
            this.button_color2.Name = "button_color2";
            this.button_color2.Size = new System.Drawing.Size(19, 25);
            this.button_color2.TabIndex = 17;
            this.button_color2.UseVisualStyleBackColor = false;
            this.button_color2.Click += new System.EventHandler(this.color_button_Click);
            // 
            // button_color9
            // 
            this.button_color9.BackColor = System.Drawing.Color.DarkBlue;
            this.button_color9.FlatAppearance.BorderSize = 0;
            this.button_color9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_color9.Location = new System.Drawing.Point(91, 34);
            this.button_color9.Name = "button_color9";
            this.button_color9.Size = new System.Drawing.Size(19, 25);
            this.button_color9.TabIndex = 19;
            this.button_color9.UseVisualStyleBackColor = false;
            this.button_color9.Click += new System.EventHandler(this.color_button_Click);
            // 
            // current_color
            // 
            this.current_color.Location = new System.Drawing.Point(12, 7);
            this.current_color.Name = "current_color";
            this.current_color.Size = new System.Drawing.Size(44, 56);
            this.current_color.TabIndex = 3;
            this.current_color.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2",
            "4",
            "6",
            "8",
            "10",
            "12"});
            this.comboBox1.Location = new System.Drawing.Point(452, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(99, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "Толщина";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.button18);
            this.panel2.Controls.Add(this.button19);
            this.panel2.Controls.Add(this.button20);
            this.panel2.Controls.Add(this.button15);
            this.panel2.Controls.Add(this.button16);
            this.panel2.Controls.Add(this.hexagon);
            this.panel2.Controls.Add(this.right_triangle);
            this.panel2.Controls.Add(this.line);
            this.panel2.Controls.Add(this.triangle);
            this.panel2.Controls.Add(this.curve);
            this.panel2.Controls.Add(this.rectangle);
            this.panel2.Controls.Add(this.circle);
            this.panel2.Location = new System.Drawing.Point(321, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(107, 67);
            this.panel2.TabIndex = 3;
            // 
            // button18
            // 
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Location = new System.Drawing.Point(64, 99);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(19, 25);
            this.button18.TabIndex = 20;
            this.button18.Text = "button18";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.FlatAppearance.BorderSize = 0;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Location = new System.Drawing.Point(37, 99);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(19, 25);
            this.button19.TabIndex = 19;
            this.button19.Text = "button19";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.FlatAppearance.BorderSize = 0;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Location = new System.Drawing.Point(12, 99);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(19, 25);
            this.button20.TabIndex = 18;
            this.button20.Text = "button20";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Location = new System.Drawing.Point(64, 68);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(19, 25);
            this.button15.TabIndex = 17;
            this.button15.Text = "button15";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Location = new System.Drawing.Point(37, 68);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(19, 25);
            this.button16.TabIndex = 16;
            this.button16.Text = "button16";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // hexagon
            // 
            this.hexagon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hexagon.BackgroundImage")));
            this.hexagon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.hexagon.FlatAppearance.BorderSize = 0;
            this.hexagon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hexagon.Location = new System.Drawing.Point(62, 37);
            this.hexagon.Name = "hexagon";
            this.hexagon.Size = new System.Drawing.Size(19, 25);
            this.hexagon.TabIndex = 15;
            this.hexagon.UseVisualStyleBackColor = true;
            this.hexagon.Click += new System.EventHandler(this.tools_Clicked);
            // 
            // right_triangle
            // 
            this.right_triangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("right_triangle.BackgroundImage")));
            this.right_triangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.right_triangle.FlatAppearance.BorderSize = 0;
            this.right_triangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.right_triangle.Location = new System.Drawing.Point(12, 67);
            this.right_triangle.Name = "right_triangle";
            this.right_triangle.Size = new System.Drawing.Size(19, 25);
            this.right_triangle.TabIndex = 14;
            this.right_triangle.UseVisualStyleBackColor = true;
            // 
            // line
            // 
            this.line.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("line.BackgroundImage")));
            this.line.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.line.FlatAppearance.BorderSize = 0;
            this.line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.line.Location = new System.Drawing.Point(12, 6);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(19, 25);
            this.line.TabIndex = 9;
            this.line.UseVisualStyleBackColor = true;
            this.line.Click += new System.EventHandler(this.tools_Clicked);
            // 
            // triangle
            // 
            this.triangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("triangle.BackgroundImage")));
            this.triangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.triangle.FlatAppearance.BorderSize = 0;
            this.triangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.triangle.Location = new System.Drawing.Point(37, 37);
            this.triangle.Name = "triangle";
            this.triangle.Size = new System.Drawing.Size(19, 25);
            this.triangle.TabIndex = 13;
            this.triangle.UseVisualStyleBackColor = true;
            this.triangle.Click += new System.EventHandler(this.tools_Clicked);
            // 
            // curve
            // 
            this.curve.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("curve.BackgroundImage")));
            this.curve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.curve.FlatAppearance.BorderSize = 0;
            this.curve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.curve.Location = new System.Drawing.Point(37, 6);
            this.curve.Name = "curve";
            this.curve.Size = new System.Drawing.Size(19, 25);
            this.curve.TabIndex = 10;
            this.curve.UseVisualStyleBackColor = true;
            this.curve.Click += new System.EventHandler(this.tools_Clicked);
            // 
            // rectangle
            // 
            this.rectangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rectangle.BackgroundImage")));
            this.rectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rectangle.FlatAppearance.BorderSize = 0;
            this.rectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rectangle.Location = new System.Drawing.Point(12, 37);
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(19, 25);
            this.rectangle.TabIndex = 12;
            this.rectangle.UseVisualStyleBackColor = true;
            this.rectangle.Click += new System.EventHandler(this.tools_Clicked);
            // 
            // circle
            // 
            this.circle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circle.BackgroundImage")));
            this.circle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.circle.FlatAppearance.BorderSize = 0;
            this.circle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circle.Location = new System.Drawing.Point(64, 6);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(19, 25);
            this.circle.TabIndex = 11;
            this.circle.UseVisualStyleBackColor = true;
            this.circle.Click += new System.EventHandler(this.tools_Clicked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_tool_lense);
            this.panel1.Controls.Add(this.button_tool_palette);
            this.panel1.Controls.Add(this.button_tool_erase);
            this.panel1.Controls.Add(this.button_tool_text);
            this.panel1.Controls.Add(this.button_tool_fill);
            this.panel1.Controls.Add(this.button_tool_pencil);
            this.panel1.Location = new System.Drawing.Point(182, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(90, 77);
            this.panel1.TabIndex = 2;
            // 
            // button_tool_lense
            // 
            this.button_tool_lense.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_tool_lense.BackgroundImage")));
            this.button_tool_lense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_tool_lense.FlatAppearance.BorderSize = 0;
            this.button_tool_lense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_tool_lense.Location = new System.Drawing.Point(63, 37);
            this.button_tool_lense.Name = "button_tool_lense";
            this.button_tool_lense.Size = new System.Drawing.Size(24, 25);
            this.button_tool_lense.TabIndex = 8;
            this.button_tool_lense.UseVisualStyleBackColor = true;
            this.button_tool_lense.Click += new System.EventHandler(this.tools_Clicked);
            // 
            // button_tool_palette
            // 
            this.button_tool_palette.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_tool_palette.BackgroundImage")));
            this.button_tool_palette.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_tool_palette.FlatAppearance.BorderSize = 0;
            this.button_tool_palette.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_tool_palette.Location = new System.Drawing.Point(33, 37);
            this.button_tool_palette.Name = "button_tool_palette";
            this.button_tool_palette.Size = new System.Drawing.Size(24, 25);
            this.button_tool_palette.TabIndex = 7;
            this.button_tool_palette.UseVisualStyleBackColor = true;
            this.button_tool_palette.Click += new System.EventHandler(this.tools_Clicked);
            // 
            // button_tool_erase
            // 
            this.button_tool_erase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_tool_erase.BackgroundImage")));
            this.button_tool_erase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_tool_erase.FlatAppearance.BorderSize = 0;
            this.button_tool_erase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_tool_erase.Location = new System.Drawing.Point(3, 37);
            this.button_tool_erase.Name = "button_tool_erase";
            this.button_tool_erase.Size = new System.Drawing.Size(24, 25);
            this.button_tool_erase.TabIndex = 6;
            this.button_tool_erase.UseVisualStyleBackColor = true;
            this.button_tool_erase.Click += new System.EventHandler(this.tools_Clicked);
            // 
            // button_tool_text
            // 
            this.button_tool_text.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_tool_text.BackgroundImage")));
            this.button_tool_text.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_tool_text.FlatAppearance.BorderSize = 0;
            this.button_tool_text.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_tool_text.Location = new System.Drawing.Point(63, 6);
            this.button_tool_text.Name = "button_tool_text";
            this.button_tool_text.Size = new System.Drawing.Size(24, 25);
            this.button_tool_text.TabIndex = 5;
            this.button_tool_text.UseVisualStyleBackColor = true;
            this.button_tool_text.Click += new System.EventHandler(this.tools_Clicked);
            // 
            // button_tool_fill
            // 
            this.button_tool_fill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_tool_fill.BackgroundImage")));
            this.button_tool_fill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_tool_fill.FlatAppearance.BorderSize = 0;
            this.button_tool_fill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_tool_fill.Location = new System.Drawing.Point(33, 6);
            this.button_tool_fill.Name = "button_tool_fill";
            this.button_tool_fill.Size = new System.Drawing.Size(24, 25);
            this.button_tool_fill.TabIndex = 4;
            this.button_tool_fill.UseVisualStyleBackColor = true;
            this.button_tool_fill.Click += new System.EventHandler(this.tools_Clicked);
            // 
            // button_tool_pencil
            // 
            this.button_tool_pencil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_tool_pencil.BackgroundImage")));
            this.button_tool_pencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_tool_pencil.FlatAppearance.BorderSize = 0;
            this.button_tool_pencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_tool_pencil.Location = new System.Drawing.Point(3, 6);
            this.button_tool_pencil.Name = "button_tool_pencil";
            this.button_tool_pencil.Size = new System.Drawing.Size(24, 25);
            this.button_tool_pencil.TabIndex = 3;
            this.button_tool_pencil.UseVisualStyleBackColor = true;
            this.button_tool_pencil.Click += new System.EventHandler(this.tools_Clicked);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 66);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1092, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(153, 22);
            this.toolStripMenuItem2.Text = "Создать";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(153, 22);
            this.toolStripMenuItem3.Text = "Открыть";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(153, 22);
            this.toolStripMenuItem4.Text = "Сохранить";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(153, 22);
            this.toolStripMenuItem5.Text = "Сохранить как";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(153, 22);
            this.toolStripMenuItem6.Text = "Печать";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(153, 22);
            this.toolStripMenuItem7.Text = "Выход";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(63, 20);
            this.toolStripMenuItem8.Text = "Главная";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(39, 20);
            this.toolStripMenuItem9.Text = "Вид";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 523);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.main_panel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button hexagon;
        private System.Windows.Forms.Button right_triangle;
        private System.Windows.Forms.Button line;
        private System.Windows.Forms.Button triangle;
        private System.Windows.Forms.Button curve;
        private System.Windows.Forms.Button rectangle;
        private System.Windows.Forms.Button circle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_tool_pencil;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button colorDialog;
        private System.Windows.Forms.Button button_color7;
        private System.Windows.Forms.Button button_color16;
        private System.Windows.Forms.Button button_color8;
        private System.Windows.Forms.Button button_color15;
        private System.Windows.Forms.Button button_color5;
        private System.Windows.Forms.Button button_color14;
        private System.Windows.Forms.Button button_color6;
        private System.Windows.Forms.Button button_color13;
        private System.Windows.Forms.Button button_color3;
        private System.Windows.Forms.Button button_color12;
        private System.Windows.Forms.Button button_color4;
        private System.Windows.Forms.Button button_color11;
        private System.Windows.Forms.Button button_color1;
        private System.Windows.Forms.Button button_color10;
        private System.Windows.Forms.Button button_color2;
        private System.Windows.Forms.Button button_color9;
        private System.Windows.Forms.Button current_color;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button_tool_lense;
        private System.Windows.Forms.Button button_tool_palette;
        private System.Windows.Forms.Button button_tool_erase;
        private System.Windows.Forms.Button button_tool_text;
        private System.Windows.Forms.Button button_tool_fill;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}


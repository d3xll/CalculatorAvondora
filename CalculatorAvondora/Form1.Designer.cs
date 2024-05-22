namespace CalculatorAvondora
{
    partial class Avondora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Avondora));
            Header = new Panel();
            label1 = new Label();
            but_debug = new Button();
            but_turn = new Button();
            but_close = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            but_result = new Button();
            but_minus = new Button();
            but_divide = new Button();
            but_multiply = new Button();
            but_plus = new Button();
            button18 = new Button();
            but_raiseTP = new Button();
            but_root = new Button();
            button21 = new Button();
            panel2 = new Panel();
            tablecalculator = new Label();
            label2 = new Label();
            label3 = new Label();
            label_currentActive = new Label();
            label_num1 = new Label();
            label_numCurrent = new Label();
            button13 = new Button();
            button14 = new Button();
            Header.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // Header
            // 
            Header.BackColor = Color.FromArgb(71, 78, 104);
            Header.Controls.Add(label1);
            Header.Controls.Add(but_debug);
            Header.Controls.Add(but_turn);
            Header.Controls.Add(but_close);
            Header.Controls.Add(panel1);
            Header.Dock = DockStyle.Top;
            Header.Location = new Point(0, 0);
            Header.Margin = new Padding(4, 3, 4, 3);
            Header.Name = "Header";
            Header.Size = new Size(348, 30);
            Header.TabIndex = 0;
            Header.MouseDown += Header_MouseDown;
            Header.MouseMove += Header_MouseMove;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Cascadia Code SemiBold", 7.5F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(33, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(132, 30);
            label1.TabIndex = 2;
            label1.Text = "Avondora Calculator";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // but_debug
            // 
            but_debug.BackColor = Color.Transparent;
            but_debug.BackgroundImageLayout = ImageLayout.Zoom;
            but_debug.Dock = DockStyle.Right;
            but_debug.FlatAppearance.BorderSize = 0;
            but_debug.FlatStyle = FlatStyle.Flat;
            but_debug.Font = new Font("Cascadia Code SemiBold", 10F, FontStyle.Bold);
            but_debug.ForeColor = Color.CornflowerBlue;
            but_debug.Location = new Point(258, 0);
            but_debug.Margin = new Padding(4, 3, 4, 3);
            but_debug.Name = "but_debug";
            but_debug.Size = new Size(30, 30);
            but_debug.TabIndex = 3;
            but_debug.Text = "D";
            but_debug.TextImageRelation = TextImageRelation.ImageAboveText;
            but_debug.UseVisualStyleBackColor = false;
            but_debug.Click += but_debugModeEnable;
            // 
            // but_turn
            // 
            but_turn.BackColor = Color.Transparent;
            but_turn.BackgroundImageLayout = ImageLayout.Zoom;
            but_turn.Dock = DockStyle.Right;
            but_turn.FlatAppearance.BorderSize = 0;
            but_turn.FlatStyle = FlatStyle.Flat;
            but_turn.Font = new Font("Cascadia Code SemiBold", 10F, FontStyle.Bold);
            but_turn.ForeColor = SystemColors.ActiveBorder;
            but_turn.Location = new Point(288, 0);
            but_turn.Margin = new Padding(4, 3, 4, 3);
            but_turn.Name = "but_turn";
            but_turn.Size = new Size(30, 30);
            but_turn.TabIndex = 1;
            but_turn.Text = "_";
            but_turn.TextImageRelation = TextImageRelation.ImageAboveText;
            but_turn.UseVisualStyleBackColor = false;
            but_turn.Click += but_minimaze;
            // 
            // but_close
            // 
            but_close.BackColor = Color.Transparent;
            but_close.BackgroundImageLayout = ImageLayout.Zoom;
            but_close.Dock = DockStyle.Right;
            but_close.FlatAppearance.BorderSize = 0;
            but_close.FlatStyle = FlatStyle.Flat;
            but_close.Font = new Font("Cascadia Code SemiBold", 10F, FontStyle.Bold);
            but_close.ForeColor = SystemColors.ActiveCaption;
            but_close.Location = new Point(318, 0);
            but_close.Margin = new Padding(4, 3, 4, 3);
            but_close.Name = "but_close";
            but_close.Size = new Size(30, 30);
            but_close.TabIndex = 0;
            but_close.Text = "X";
            but_close.TextImageRelation = TextImageRelation.ImageAboveText;
            but_close.UseVisualStyleBackColor = false;
            but_close.Click += but_closeApp;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(33, 30);
            panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(80, 87, 122);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Cascadia Code", 12F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ActiveCaption;
            button1.Location = new Point(11, 117);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(59, 60);
            button1.TabIndex = 1;
            button1.Tag = "clearCurrentNumber";
            button1.Text = "CE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += but_clear;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(80, 87, 122);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Cascadia Code", 12F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ActiveCaption;
            button2.Location = new Point(77, 117);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(59, 60);
            button2.TabIndex = 2;
            button2.Tag = "clearAll";
            button2.Text = "C";
            button2.UseVisualStyleBackColor = false;
            button2.Click += but_clear;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(80, 87, 122);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button3.ForeColor = SystemColors.ActiveCaption;
            button3.Location = new Point(144, 117);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(191, 60);
            button3.TabIndex = 3;
            button3.Tag = "clearSymbol";
            button3.Text = " ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += but_clear;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(80, 87, 122);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Cascadia Code", 12F, FontStyle.Bold);
            button4.ForeColor = SystemColors.AppWorkspace;
            button4.Location = new Point(11, 183);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(59, 60);
            button4.TabIndex = 4;
            button4.Text = "7";
            button4.UseVisualStyleBackColor = false;
            button4.Click += but_number;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(80, 87, 122);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Cascadia Code", 12F, FontStyle.Bold);
            button5.ForeColor = SystemColors.AppWorkspace;
            button5.Location = new Point(77, 183);
            button5.Margin = new Padding(4, 3, 4, 3);
            button5.Name = "button5";
            button5.Size = new Size(59, 60);
            button5.TabIndex = 5;
            button5.Text = "8";
            button5.UseVisualStyleBackColor = false;
            button5.Click += but_number;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(80, 87, 122);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Cascadia Code", 12F, FontStyle.Bold);
            button6.ForeColor = SystemColors.AppWorkspace;
            button6.Location = new Point(143, 183);
            button6.Margin = new Padding(4, 3, 4, 3);
            button6.Name = "button6";
            button6.Size = new Size(59, 60);
            button6.TabIndex = 6;
            button6.Text = "9";
            button6.UseVisualStyleBackColor = false;
            button6.Click += but_number;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(80, 87, 122);
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Cascadia Code", 12F, FontStyle.Bold);
            button7.ForeColor = SystemColors.AppWorkspace;
            button7.Location = new Point(11, 249);
            button7.Margin = new Padding(4, 3, 4, 3);
            button7.Name = "button7";
            button7.Size = new Size(59, 60);
            button7.TabIndex = 7;
            button7.Text = "4";
            button7.UseVisualStyleBackColor = false;
            button7.Click += but_number;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(80, 87, 122);
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Cascadia Code", 12F, FontStyle.Bold);
            button8.ForeColor = SystemColors.AppWorkspace;
            button8.Location = new Point(77, 249);
            button8.Margin = new Padding(4, 3, 4, 3);
            button8.Name = "button8";
            button8.Size = new Size(59, 60);
            button8.TabIndex = 8;
            button8.Text = "5";
            button8.UseVisualStyleBackColor = false;
            button8.Click += but_number;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(80, 87, 122);
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Cascadia Code", 12F, FontStyle.Bold);
            button9.ForeColor = SystemColors.AppWorkspace;
            button9.Location = new Point(143, 249);
            button9.Margin = new Padding(4, 3, 4, 3);
            button9.Name = "button9";
            button9.Size = new Size(59, 60);
            button9.TabIndex = 9;
            button9.Text = "6";
            button9.UseVisualStyleBackColor = false;
            button9.Click += but_number;
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(80, 87, 122);
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Cascadia Code", 12F, FontStyle.Bold);
            button10.ForeColor = SystemColors.AppWorkspace;
            button10.Location = new Point(77, 315);
            button10.Margin = new Padding(4, 3, 4, 3);
            button10.Name = "button10";
            button10.Size = new Size(59, 60);
            button10.TabIndex = 10;
            button10.Text = "2";
            button10.UseVisualStyleBackColor = false;
            button10.Click += but_number;
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(80, 87, 122);
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Cascadia Code", 12F, FontStyle.Bold);
            button11.ForeColor = SystemColors.AppWorkspace;
            button11.Location = new Point(11, 315);
            button11.Margin = new Padding(4, 3, 4, 3);
            button11.Name = "button11";
            button11.Size = new Size(59, 60);
            button11.TabIndex = 11;
            button11.Text = "1";
            button11.UseVisualStyleBackColor = false;
            button11.Click += but_number;
            // 
            // button12
            // 
            button12.BackColor = Color.FromArgb(80, 87, 122);
            button12.FlatAppearance.BorderSize = 0;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Font = new Font("Cascadia Code", 12F, FontStyle.Bold);
            button12.ForeColor = SystemColors.AppWorkspace;
            button12.Location = new Point(143, 315);
            button12.Margin = new Padding(4, 3, 4, 3);
            button12.Name = "button12";
            button12.Size = new Size(59, 60);
            button12.TabIndex = 12;
            button12.Text = "3";
            button12.UseVisualStyleBackColor = false;
            button12.Click += but_number;
            // 
            // but_result
            // 
            but_result.BackColor = Color.FromArgb(107, 114, 142);
            but_result.FlatAppearance.BorderSize = 0;
            but_result.FlatStyle = FlatStyle.Flat;
            but_result.Font = new Font("Cascadia Code", 12F, FontStyle.Bold);
            but_result.ForeColor = SystemColors.ActiveCaption;
            but_result.Location = new Point(276, 381);
            but_result.Margin = new Padding(4, 3, 4, 3);
            but_result.Name = "but_result";
            but_result.Size = new Size(59, 60);
            but_result.TabIndex = 16;
            but_result.Tag = "=";
            but_result.Text = "=";
            but_result.UseVisualStyleBackColor = false;
            but_result.Click += but_getResult;
            // 
            // but_minus
            // 
            but_minus.BackColor = Color.FromArgb(80, 87, 122);
            but_minus.FlatAppearance.BorderSize = 0;
            but_minus.FlatStyle = FlatStyle.Flat;
            but_minus.Font = new Font("Cascadia Code", 12F, FontStyle.Bold);
            but_minus.ForeColor = SystemColors.ActiveCaption;
            but_minus.Location = new Point(209, 249);
            but_minus.Margin = new Padding(4, 3, 4, 3);
            but_minus.Name = "but_minus";
            but_minus.Size = new Size(59, 60);
            but_minus.TabIndex = 15;
            but_minus.Tag = "-";
            but_minus.Text = "-";
            but_minus.UseVisualStyleBackColor = false;
            but_minus.Click += but_arithmeticOperation_WaitNextInput;
            // 
            // but_divide
            // 
            but_divide.BackColor = Color.FromArgb(80, 87, 122);
            but_divide.FlatAppearance.BorderSize = 0;
            but_divide.FlatStyle = FlatStyle.Flat;
            but_divide.Font = new Font("Cascadia Code", 12F, FontStyle.Bold);
            but_divide.ForeColor = SystemColors.ActiveCaption;
            but_divide.Location = new Point(276, 249);
            but_divide.Margin = new Padding(4, 3, 4, 3);
            but_divide.Name = "but_divide";
            but_divide.Size = new Size(59, 60);
            but_divide.TabIndex = 14;
            but_divide.Tag = "/";
            but_divide.Text = "/";
            but_divide.UseVisualStyleBackColor = false;
            but_divide.Click += but_arithmeticOperation_WaitNextInput;
            // 
            // but_multiply
            // 
            but_multiply.BackColor = Color.FromArgb(80, 87, 122);
            but_multiply.FlatAppearance.BorderSize = 0;
            but_multiply.FlatStyle = FlatStyle.Flat;
            but_multiply.Font = new Font("Cascadia Code", 12F, FontStyle.Bold);
            but_multiply.ForeColor = SystemColors.ActiveCaption;
            but_multiply.Location = new Point(276, 315);
            but_multiply.Margin = new Padding(4, 3, 4, 3);
            but_multiply.Name = "but_multiply";
            but_multiply.Size = new Size(59, 60);
            but_multiply.TabIndex = 13;
            but_multiply.Tag = "*";
            but_multiply.Text = "*";
            but_multiply.UseVisualStyleBackColor = false;
            but_multiply.Click += but_arithmeticOperation_WaitNextInput;
            // 
            // but_plus
            // 
            but_plus.BackColor = Color.FromArgb(80, 87, 122);
            but_plus.FlatAppearance.BorderSize = 0;
            but_plus.FlatStyle = FlatStyle.Flat;
            but_plus.Font = new Font("Cascadia Code", 12F, FontStyle.Bold);
            but_plus.ForeColor = SystemColors.ActiveCaption;
            but_plus.Location = new Point(209, 315);
            but_plus.Margin = new Padding(4, 3, 4, 3);
            but_plus.Name = "but_plus";
            but_plus.Size = new Size(59, 60);
            but_plus.TabIndex = 17;
            but_plus.Tag = "+";
            but_plus.Text = "+";
            but_plus.UseVisualStyleBackColor = false;
            but_plus.Click += but_arithmeticOperation_WaitNextInput;
            // 
            // button18
            // 
            button18.BackColor = Color.FromArgb(80, 87, 122);
            button18.FlatAppearance.BorderSize = 0;
            button18.FlatStyle = FlatStyle.Flat;
            button18.Font = new Font("Cascadia Code", 12F, FontStyle.Bold);
            button18.ForeColor = SystemColors.AppWorkspace;
            button18.Location = new Point(11, 381);
            button18.Margin = new Padding(4, 3, 4, 3);
            button18.Name = "button18";
            button18.Size = new Size(59, 60);
            button18.TabIndex = 18;
            button18.Text = "0";
            button18.UseVisualStyleBackColor = false;
            button18.Click += but_number;
            // 
            // but_raiseTP
            // 
            but_raiseTP.BackColor = Color.FromArgb(80, 87, 122);
            but_raiseTP.FlatAppearance.BorderSize = 0;
            but_raiseTP.FlatStyle = FlatStyle.Flat;
            but_raiseTP.Font = new Font("Cascadia Code", 12F, FontStyle.Bold);
            but_raiseTP.ForeColor = SystemColors.ActiveCaption;
            but_raiseTP.Location = new Point(210, 183);
            but_raiseTP.Margin = new Padding(4, 3, 4, 3);
            but_raiseTP.Name = "but_raiseTP";
            but_raiseTP.Size = new Size(59, 60);
            but_raiseTP.TabIndex = 19;
            but_raiseTP.Tag = "pow^2";
            but_raiseTP.Text = "x²";
            but_raiseTP.UseVisualStyleBackColor = false;
            but_raiseTP.Click += but_arithmeticOperation_SkipNextInput;
            // 
            // but_root
            // 
            but_root.BackColor = Color.FromArgb(80, 87, 122);
            but_root.FlatAppearance.BorderSize = 0;
            but_root.FlatStyle = FlatStyle.Flat;
            but_root.Font = new Font("Cascadia Code", 12F, FontStyle.Bold);
            but_root.ForeColor = SystemColors.ActiveCaption;
            but_root.Location = new Point(276, 183);
            but_root.Margin = new Padding(4, 3, 4, 3);
            but_root.Name = "but_root";
            but_root.Size = new Size(59, 60);
            but_root.TabIndex = 20;
            but_root.Tag = "sqrt";
            but_root.Text = "√";
            but_root.UseVisualStyleBackColor = false;
            but_root.Click += but_arithmeticOperation_SkipNextInput;
            // 
            // button21
            // 
            button21.BackColor = Color.FromArgb(80, 87, 122);
            button21.FlatAppearance.BorderSize = 0;
            button21.FlatStyle = FlatStyle.Flat;
            button21.Font = new Font("Cascadia Code", 12F, FontStyle.Bold);
            button21.ForeColor = SystemColors.AppWorkspace;
            button21.Location = new Point(78, 381);
            button21.Margin = new Padding(4, 3, 4, 3);
            button21.Name = "button21";
            button21.Size = new Size(59, 60);
            button21.TabIndex = 21;
            button21.Text = ",";
            button21.UseVisualStyleBackColor = false;
            button21.Click += but_comma;
            // 
            // panel2
            // 
            panel2.Controls.Add(tablecalculator);
            panel2.Location = new Point(13, 42);
            panel2.Name = "panel2";
            panel2.Size = new Size(322, 63);
            panel2.TabIndex = 23;
            // 
            // tablecalculator
            // 
            tablecalculator.BackColor = Color.FromArgb(71, 78, 104);
            tablecalculator.Dock = DockStyle.Fill;
            tablecalculator.Font = new Font("Cascadia Mono SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            tablecalculator.Location = new Point(0, 0);
            tablecalculator.Name = "tablecalculator";
            tablecalculator.Size = new Size(322, 63);
            tablecalculator.TabIndex = 0;
            tablecalculator.Text = "0";
            tablecalculator.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 7F, FontStyle.Bold);
            label2.Location = new Point(13, 453);
            label2.Name = "label2";
            label2.Size = new Size(85, 13);
            label2.TabIndex = 24;
            label2.Text = "made by @snji";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 488);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 25;
            label3.Text = "debug:";
            // 
            // label_currentActive
            // 
            label_currentActive.AutoSize = true;
            label_currentActive.Location = new Point(57, 490);
            label_currentActive.Name = "label_currentActive";
            label_currentActive.Size = new Size(14, 15);
            label_currentActive.TabIndex = 26;
            label_currentActive.Text = "+";
            // 
            // label_num1
            // 
            label_num1.AutoSize = true;
            label_num1.Location = new Point(13, 513);
            label_num1.Name = "label_num1";
            label_num1.Size = new Size(39, 15);
            label_num1.TabIndex = 27;
            label_num1.Text = "num1";
            // 
            // label_numCurrent
            // 
            label_numCurrent.AutoSize = true;
            label_numCurrent.Location = new Point(58, 513);
            label_numCurrent.Name = "label_numCurrent";
            label_numCurrent.Size = new Size(51, 15);
            label_numCurrent.TabIndex = 28;
            label_numCurrent.Text = "curNum";
            // 
            // button13
            // 
            button13.BackColor = Color.FromArgb(80, 87, 122);
            button13.FlatAppearance.BorderSize = 0;
            button13.FlatStyle = FlatStyle.Flat;
            button13.Font = new Font("Cascadia Code", 12F, FontStyle.Bold);
            button13.ForeColor = SystemColors.ActiveCaption;
            button13.Location = new Point(210, 381);
            button13.Margin = new Padding(4, 3, 4, 3);
            button13.Name = "button13";
            button13.Size = new Size(59, 60);
            button13.TabIndex = 29;
            button13.Tag = "1/x";
            button13.Text = "1/x";
            button13.UseVisualStyleBackColor = false;
            button13.Click += but_arithmeticOperation_SkipNextInput;
            // 
            // button14
            // 
            button14.BackColor = Color.FromArgb(80, 87, 122);
            button14.FlatAppearance.BorderSize = 0;
            button14.FlatStyle = FlatStyle.Flat;
            button14.Font = new Font("Cascadia Code", 12F, FontStyle.Bold);
            button14.ForeColor = SystemColors.ActiveCaption;
            button14.Location = new Point(143, 381);
            button14.Margin = new Padding(4, 3, 4, 3);
            button14.Name = "button14";
            button14.Size = new Size(59, 60);
            button14.TabIndex = 30;
            button14.Tag = "pow";
            button14.Text = "xⁿ";
            button14.UseVisualStyleBackColor = false;
            button14.Click += but_arithmeticOperation_WaitNextInput;
            // 
            // Avondora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 66, 88);
            ClientSize = new Size(348, 480);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(label_numCurrent);
            Controls.Add(label_num1);
            Controls.Add(label_currentActive);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(button21);
            Controls.Add(but_root);
            Controls.Add(but_raiseTP);
            Controls.Add(button18);
            Controls.Add(but_plus);
            Controls.Add(but_result);
            Controls.Add(but_minus);
            Controls.Add(but_divide);
            Controls.Add(but_multiply);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Header);
            Font = new Font("Microsoft Sans Serif", 9F);
            ForeColor = SystemColors.ActiveBorder;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Avondora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            Header.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Header;
        private Button but_close;
        private Button but_turn;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button but_result;
        private Button but_minus;
        private Button but_divide;
        private Button but_multiply;
        private Button but_plus;
        private Button button18;
        private Button but_raiseTP;
        private Button but_root;
        private Button button21;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private Label label_currentActive;
        private Label label_num1;
        private Label label_numCurrent;
        private Button button13;
        private Button but_debug;
        private Label tablecalculator;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button14;
    }
}

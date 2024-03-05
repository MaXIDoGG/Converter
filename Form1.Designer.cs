namespace Converter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            trackBar1 = new TrackBar();
            trackBar2 = new TrackBar();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            label1 = new Label();
            label3 = new Label();
            menuStrip1 = new MenuStrip();
            exitToolStripMenuItem = new ToolStripMenuItem();
            historyToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
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
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(12, 75);
            trackBar1.Maximum = 16;
            trackBar1.Minimum = 2;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(298, 45);
            trackBar1.TabIndex = 4;
            trackBar1.Value = 10;
            trackBar1.Scroll += new System.EventHandler(trackBar1_Scroll);
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(12, 158);
            trackBar2.Maximum = 16;
            trackBar2.Minimum = 2;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(298, 45);
            trackBar2.TabIndex = 5;
            trackBar2.Value = 2;
            trackBar2.Scroll += new System.EventHandler(trackBar2_Scroll);
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(308, 75);
            numericUpDown1.Maximum = new decimal(new int[] { 16, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(32, 23);
            numericUpDown1.TabIndex = 6;
            numericUpDown1.Value = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.ValueChanged += new System.EventHandler(numericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(308, 158);
            numericUpDown2.Maximum = new decimal(new int[] { 16, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(32, 23);
            numericUpDown2.TabIndex = 7;
            numericUpDown2.Value = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown2.ValueChanged += new System.EventHandler(numericUpDown2_ValueChanged);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 57);
            label1.Name = "label1";
            label1.Size = new Size(196, 15);
            label1.TabIndex = 8;
            label1.Text = "Основание с. сч. исходного числа";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 140);
            label3.Name = "label3";
            label3.Size = new Size(155, 15);
            label3.TabIndex = 10;
            label3.Text = "Основание с. сч. результат";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { exitToolStripMenuItem, historyToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(352, 24);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(38, 20);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += new System.EventHandler(ExitToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem
            // 
            historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            historyToolStripMenuItem.Size = new Size(57, 20);
            historyToolStripMenuItem.Text = "History";
            historyToolStripMenuItem.Click += new System.EventHandler(HistoryToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += new System.EventHandler(AboutToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 27);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(328, 23);
            textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 114);
            textBox2.Name = "textBox2";
            textBox1.ReadOnly = true;
            textBox2.Size = new Size(328, 23);
            textBox2.TabIndex = 14;
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.MenuHighlight;
            button1.Location = new Point(12, 209);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 15;
            button1.Tag = "10";
            button1.Text = "A";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_Click;
            // 
            // button2
            // 
            button2.ForeColor = SystemColors.MenuHighlight;
            button2.Location = new Point(93, 209);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 16;
            button2.Tag = "11";
            button2.Text = "B";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button_Click;
            // 
            // button3
            // 
            button3.ForeColor = SystemColors.MenuHighlight;
            button3.Location = new Point(177, 209);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 17;
            button3.Tag = "12";
            button3.Text = "C";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button_Click;
            // 
            // button4
            // 
            button4.ForeColor = SystemColors.MenuHighlight;
            button4.Location = new Point(258, 209);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 18;
            button4.Tag = "13";
            button4.Text = "D";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button_Click;
            // 
            // button5
            // 
            button5.ForeColor = SystemColors.MenuHighlight;
            button5.Location = new Point(12, 238);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 19;
            button5.Tag = "7";
            button5.Text = "7";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button_Click;
            // 
            // button6
            // 
            button6.ForeColor = SystemColors.MenuHighlight;
            button6.Location = new Point(92, 238);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 20;
            button6.Tag = "8";
            button6.Text = "8";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button_Click;
            // 
            // button7
            // 
            button7.ForeColor = SystemColors.MenuHighlight;
            button7.Location = new Point(177, 238);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 21;
            button7.Tag = "9";
            button7.Text = "9";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button_Click;
            // 
            // button8
            // 
            button8.ForeColor = SystemColors.MenuHighlight;
            button8.Location = new Point(258, 238);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 22;
            button8.Tag = "14";
            button8.Text = "E";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button_Click;
            // 
            // button9
            // 
            button9.ForeColor = SystemColors.MenuHighlight;
            button9.Location = new Point(12, 267);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 23;
            button9.Tag = "4";
            button9.Text = "4";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button_Click;
            // 
            // button10
            // 
            button10.ForeColor = SystemColors.MenuHighlight;
            button10.Location = new Point(92, 267);
            button10.Name = "button10";
            button10.Size = new Size(75, 23);
            button10.TabIndex = 24;
            button10.Tag = "5";
            button10.Text = "5";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button_Click;
            // 
            // button11
            // 
            button11.ForeColor = SystemColors.MenuHighlight;
            button11.Location = new Point(177, 267);
            button11.Name = "button11";
            button11.Size = new Size(75, 23);
            button11.TabIndex = 25;
            button11.Tag = "6";
            button11.Text = "6";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button_Click;
            // 
            // button12
            // 
            button12.ForeColor = SystemColors.MenuHighlight;
            button12.Location = new Point(258, 267);
            button12.Name = "button12";
            button12.Size = new Size(75, 23);
            button12.TabIndex = 26;
            button12.Tag = "15";
            button12.Text = "F";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button_Click;
            // 
            // button13
            // 
            button13.ForeColor = SystemColors.MenuHighlight;
            button13.Location = new Point(12, 296);
            button13.Name = "button13";
            button13.Size = new Size(75, 23);
            button13.TabIndex = 27;
            button13.Tag = "1";
            button13.Text = "1";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button_Click;
            // 
            // button14
            // 
            button14.ForeColor = SystemColors.MenuHighlight;
            button14.Location = new Point(93, 296);
            button14.Name = "button14";
            button14.Size = new Size(75, 23);
            button14.TabIndex = 28;
            button14.Tag = "2";
            button14.Text = "2";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button_Click;
            // 
            // button15
            // 
            button15.ForeColor = SystemColors.MenuHighlight;
            button15.Location = new Point(177, 296);
            button15.Name = "button15";
            button15.Size = new Size(75, 23);
            button15.TabIndex = 29;
            button15.Tag = "3";
            button15.Text = "3";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button_Click;
            // 
            // button16
            // 
            button16.ForeColor = Color.Red;
            button16.Location = new Point(258, 296);
            button16.Name = "button16";
            button16.Size = new Size(75, 23);
            button16.TabIndex = 30;
            button16.Tag = "18";
            button16.Text = "CE";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button_Click;
            // 
            // button17
            // 
            button17.ForeColor = SystemColors.MenuHighlight;
            button17.Location = new Point(12, 325);
            button17.Name = "button17";
            button17.Size = new Size(75, 23);
            button17.TabIndex = 31;
            button17.Tag = "0";
            button17.Text = "0";
            button17.UseVisualStyleBackColor = true;
            button17.Click += button_Click;
            // 
            // button18
            // 
            button18.Location = new Point(93, 325);
            button18.Name = "button18";
            button18.Size = new Size(75, 23);
            button18.TabIndex = 32;
            button18.Tag = "16";
            button18.Text = ".";
            button18.UseVisualStyleBackColor = true;
            button18.Click += button_Click;
            // 
            // button19
            // 
            button19.ForeColor = Color.Red;
            button19.Location = new Point(177, 325);
            button19.Name = "button19";
            button19.Size = new Size(75, 23);
            button19.TabIndex = 33;
            button19.Tag = "17";
            button19.Text = "BS";
            button19.UseVisualStyleBackColor = true;
            button19.Click += button_Click;
            // 
            // button20
            // 
            button20.Location = new Point(258, 325);
            button20.Name = "button20";
            button20.Size = new Size(75, 23);
            button20.TabIndex = 34;
            button20.Tag = "19";
            button20.Text = "Execute";
            button20.UseVisualStyleBackColor = true;
            button20.Click += button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 388);
            Controls.Add(button20);
            Controls.Add(button19);
            Controls.Add(button18);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
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
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(trackBar2);
            Controls.Add(trackBar1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Converter";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TrackBar trackBar1;
        private TrackBar trackBar2;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Label label1;
        private Label label3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem historyToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private TextBox textBox1;
        private TextBox textBox2;
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
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button20;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Converter
{
    public partial class Form1 : Form
    {
        Control_ ctl = new Control_();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_load(object sender, EventArgs e)
        {
            textBox1.Text = ctl.ed.Number;

            trackBar1.Value = ctl.Pin;

            trackBar2.Value = ctl.Pout;

            label1.Text = "Основание с. сч. исходного числа" + trackBar1.Value;

            label3.Text = "Основание с. сч. резудьтата" + trackBar2.Value;

            textBox2.Text = "0";

            this.UpdateButtons();
        }

        private void Do(int j)
        {
            if (j == 19) { textBox2.Text = ctl.Do(j); }
            else
            {
                if (ctl.St == Control_.State.Transform)
                {
                    textBox1.Text = ctl.Do(18);
                }

                textBox1.Text = ctl.Do(j);
                textBox2.Text = "0";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Button but = (Button)sender;

            int j = Convert.ToInt16(but.Tag.ToString());

            Do(j);
        }

        private void UpdateButtons()
        {
            foreach (Control i in this.Controls)
            {
                if (i is Button)
                {
                    int j = Convert.ToInt16(i.Tag.ToString());
                    if (j < trackBar1.Value) { i.Enabled = true; }
                    if ((j >= trackBar1.Value) && (j <= 15)) { i.Enabled = false; }
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            numericUpDown1.Value = trackBar1.Value;
            this.UpdateP1();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            trackBar1.Value = Convert.ToByte(numericUpDown1.Value);
            this.UpdateP1();
        }

        private void UpdateP1()
        {
            label3.Text = "Основание с. сч. исходного числа " + trackBar1.Value;
            ctl.Pin = trackBar1.Value;
            this.UpdateButtons();
            textBox1.Text = ctl.Do(18);
            textBox2.Text = "0";
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            numericUpDown2.Value = trackBar2.Value;
            this.UpdateP2();
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            trackBar2.Value = Convert.ToByte(numericUpDown2.Value);
            this.UpdateP2();
        }
        private void UpdateP2()
        {
            ctl.Pout = trackBar2.Value;
            //Пересчитать результат. 
            textBox2.Text = ctl.Do(19);
            label3.Text = "Основание с. сч. результата " + trackBar2.Value;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AboutToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            //AboutBox1 a = new AboutBox1();
            //a.show();
        }

        private void HistoryToolStripMenuItem1_Click(Object sender, EventArgs e)
        {
            //Form2 history = new Form2();
            //history.show();
            if (ctl.his.Count() == 0)
            {
                //history.textBox1.Appendtext("Empty");
                return;
            }

            for (int i = 0; i < ctl.his.Count(); i++)
            {
                //history.textBox1.Appendtext(ctl.his[i].ToString());
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int i = -1;
            if (e.KeyChar >= 'A' && e.KeyChar <= 'F') i = (int)e.KeyChar - 'A' + 10;
            if (e.KeyChar >= 'a' && e.KeyChar <= 'f') i = (int)e.KeyChar - 'a' + 10;
            if (e.KeyChar >= '0' && e.KeyChar <= '9') i = (int)e.KeyChar - '0';
            if (e.KeyChar == '.') i = 16;
            if ((int)e.KeyChar == 8) i = 17;
            if ((int)e.KeyChar == 13) i = 19;
            if ((i < ctl.Pin) || (i >= 16)) Do(i);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                //Клавиша Delete.
                Do(18);
            if (e.KeyCode == Keys.Execute)
                //Клавиша Execute Separator.
                Do(19);
            if (e.KeyCode == Keys.Decimal)
                //Клавиша Decimal.
                Do(16);
        }
    }
}

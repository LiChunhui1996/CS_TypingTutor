using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypingTutor
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            timer1.Start();
        }

        int time = 100;
        int achievementAll = 0;
        string note1 = "Pain and joy of the individual,must blend in the era of pain and joy.";
        string note2 = "When a man use work to welcome the light,the light will soon come over him.";
        string note3 = "The road in life, not only help you is noble,sometimes just the opposite.";

    

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            time--;
            if (time > 0)
            {
                label1.Text = "时间剩余：" + time + "秒";
                progressBar1.Value = time %100;
            }
            else
            {
                progressBar1.Value = time % 100;
                textBox2.Enabled = false;
                textBox4.Enabled = false;
                textBox6.Enabled = false;
                timer1.Stop();
                if (MessageBox.Show("您的分数是：" + achievementAll + "分。", "得分情况", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Close();
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int count = textBox2.Text.Length;

            if (count <= note1.Length)
            {

                string anwser = note1.Substring(0, count);

                if (textBox2.Text.ToString().Equals(anwser))
                {
                    textBox2.ForeColor = System.Drawing.Color.Green;
                    achievementAll++;
                    label2.Text = "按Tab键快速换行，您的成绩是：" + achievementAll;
                    if (count == note1.Length)
                    {
                        textBox4.Focus();
                    }
                }
                else
                {
                    textBox2.ForeColor = System.Drawing.Color.Red;
                    achievementAll--;
                    label2.Text = "按Tab键快速换行，您的成绩是：" + achievementAll;
                }
            }
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            int count = textBox4.Text.Length;

            if (count <= note2.Length)
            {
                string anwser = note2.Substring(0, count);

                if (textBox4.Text.ToString().Equals(anwser))
                {
                    textBox4.ForeColor = System.Drawing.Color.Green;
                    achievementAll++;
                    label2.Text = "按Tab键快速换行，您的成绩是：" + achievementAll;
                    if (count == note2.Length)
                    {
                        textBox6.Focus();
                    }
                }
                else
                {
                    textBox4.ForeColor = System.Drawing.Color.Red;
                    achievementAll--;
                    label2.Text = "按Tab键快速换行，您的成绩是：" + achievementAll;
                }
            }
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            int count = textBox6.Text.Length;
            if (count <= note3.Length)
            {
                string anwser = note3.Substring(0, count);

                if (textBox6.Text.ToString().Equals(anwser))
                {
                    textBox6.ForeColor = System.Drawing.Color.Green;
                    achievementAll++;
                    label2.Text = "您即将完成任务，您的成绩是：" + achievementAll;
                    if (count == note3.Length)
                    {
                        MessageBox.Show("您完成了本次挑战，您的成绩是" + achievementAll + "分。", "恭喜", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    textBox6.ForeColor = System.Drawing.Color.Red;
                    achievementAll--;
                    label2.Text = "您即将完成任务，您的成绩是：" + achievementAll;
                }
            }
        }

        private void Form3_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}

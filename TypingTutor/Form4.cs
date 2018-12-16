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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            timer1.Start();
        }
        int time = 100;
        int achievementAll = 0;
        string note1 = "人生的旅途，前途很远，也很暗。然而不要怕，不怕的人的面前才有路。";
        string note2 = "自觉心是进步之母，自贱心是堕落之源，故自觉心不可无，自贱心不可有。";
        string note3 = "懒惰象生锈一样，比操劳更能消耗身体；经常用的钥匙，总是亮闪闪的。 ";

        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            if (time > 0)
            {
                label1.Text = "时间剩余：" + time + "秒";
                progressBar1.Value = time % 100;
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
                    label2.Text = "您即将完成任务您的成绩是：" + achievementAll;
                    if (count == note3.Length)
                    {
                        MessageBox.Show("您完成了本次挑战，您的成绩是" + achievementAll + "分。", "恭喜", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    textBox6.ForeColor = System.Drawing.Color.Red;
                    achievementAll--;
                    label2.Text = "您即将完成任务您的成绩是：" + achievementAll;
                }
            }
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}

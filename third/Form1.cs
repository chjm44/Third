using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace third
{
    public partial class Form1 : Form
    {
        public static string TextForm1;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("빈칸을 채워주시오.");
            }
            else if (comboBox1.Items.Contains(textBox1.Text))
            {
                MessageBox.Show("이미 있는 항목입니다.");
            }
            else
            {
                comboBox1.Items.Add(textBox1.Text);
            }
            textBox1.Clear();
            textBox1.Focus();


        }

        private void button2_Click(object sender, EventArgs e)
        {//아이템 개수메세지 박스로
            MessageBox.Show(comboBox1.Items.Count.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Remove(comboBox1.SelectedItem);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Remove(comboBox1.SelectedItem);
            comboBox1.Items.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = comboBox1.SelectedItem.ToString();
            label2.Visible = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TextForm1 = textBox2.Text;

            //Process.Start("https://www.google.com");
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();

            //form2.FormClosed += (s, args) => this.Show();
            form2.FormClosed += Form2_ForClosecd;

            //form2.FormClosed()
            //FormClosed 됐을 때 (이벤트)
            //this.Show() (핸들러)
            //핸들러 실행
            //+= 핸들러 추가
            //(s,args) => 람다식: 코드를 더 간결하게 쓸 수 있는 문법
            //js python 등등 많은 프로그래밍 언어에서도 추가됐음
            //람다식 문법 : () => {}
            //(파라미터)=> {수행할 함수 내용}
            //(파라미터) => 한줄;
            //void 함수이름 (파라미터) {수행할 함수 내용}

        }
        private void Form2_ForClosecd(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}

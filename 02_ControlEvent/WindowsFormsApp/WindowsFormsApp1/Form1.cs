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
        public Form1()
        {
            InitializeComponent();
        }
        // フォームが開かれた時
        private void Form1_Load(object sender, EventArgs e)
        {
            // 初期値を各ラベルに反映する
            labelChk1.Text = "チェックボックス１：" + Chk1.Checked;
            labelChk2.Text = "チェックボックス１：" + Chk2.Checked;
            labelChk3.Text = "チェックボックス１：" + Chk3.Checked;
            radioChk.Text = "ラジオボタン：";
            labelNumUD1.Text = "数値１：" + numericUpDown1.Value;
            labelNumUD2.Text = "数値２：" + numericUpDown2.Value;

        }
        //Chk1のチェックが変更された時
        private void Chk1_CheckedChanged(object sender, EventArgs e)
        {
            //labelChk1のテキストを変更する（チェック時：True,非チェック時：False）
            labelChk1.Text = "チェックボックス１：" + Chk1.Checked;
        }

        //Chk2のチェックが変更された時
        private void Chk2_CheckedChanged(object sender, EventArgs e)
        {
            //labelChk2のテキストを変更する（チェック時：True,非チェック時：False）
            labelChk2.Text = "チェックボックス１：" + Chk2.Checked;
        }

        //Chk3のチェックが変更された時
        private void Chk3_CheckedChanged(object sender, EventArgs e)
        {
            //labelChk3のテキストを変更する（チェック時：True,非チェック時：False）
            labelChk3.Text = "チェックボックス１：" + Chk3.Checked;
        }

        //Radio1のチェックが変更された時
        private void Radio1_CheckedChanged(object sender, EventArgs e)
        {
            //radioChkのテキストを変更する（チェックされているラジオボタンのテキスト名）
            radioChk.Text = "ラジオボタン：" + Radio1.Text;
        }

        //Radio2のチェックが変更された時
        private void Radio2_CheckedChanged(object sender, EventArgs e)
        {
            //radioChkのテキストを変更する（チェックされているラジオボタンのテキスト名）
            radioChk.Text = "ラジオボタン：" + Radio2.Text;
        }

        //Radio3のチェックが変更された時
        private void Radio3_CheckedChanged(object sender, EventArgs e)
        {
            //radioChkのテキストを変更する（チェックされているラジオボタンのテキスト名）
            radioChk.Text = "ラジオボタン：" + Radio3.Text;
        }

        //numericUpDown1の値が変更された時
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //numericUpDown1の値を更新する
            labelNumUD1.Text = "数値１：" + numericUpDown1.Value;
        }

        //numericUpDown2の値が変更された時
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            //numericUpDown2の値を更新する
            labelNumUD2.Text = "数値２：" + numericUpDown2.Value;
        }


        //button1がクリックされた時
        private void button1_Click(object sender, EventArgs e)
        {
            //テキストボックスに入力された値をラベルに反映する
            labelTex.Text = "テキスト：" + textBox1.Text;
            //押したボタンの情報をラベルに反映する
            labelButton.Text = "押したボタン：" + button1.Text;
        }

        //button2がクリックされた時
        private void button2_Click(object sender, EventArgs e)
        {
            //テキストボックスに入力された値をラベルに反映する
            labelTex.Text = "テキスト：" + textBox1.Text;
            //押したボタンの情報をラベルに反映する
            labelButton.Text = "押したボタン：" + button2.Text;
        }

        //button3がクリックされた時
        private void button3_Click(object sender, EventArgs e)
        {
            //テキストボックスに入力された値をラベルに反映する
            labelTex.Text = "テキスト：" + textBox1.Text;
            //押したボタンの情報をラベルに反映する
            labelButton.Text = "押したボタン：" + button3.Text;
        }

        //button4がクリックされた時
        private void button4_Click(object sender, EventArgs e)
        {
            //テキストボックスに入力された値をラベルに反映する
            labelTex.Text = "テキスト：" + textBox1.Text;
            //押したボタンの情報をラベルに反映する
            labelButton.Text = "押したボタン：" + button4.Text;
        }
    }
}

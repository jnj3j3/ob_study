using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
using System.Collections;
using Microsoft.Win32;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
		public MainForm(int abc)
		{
			moveLine = abc;
			InitializeComponent();
		}

		// 전역 변수
		public TextBox tb;
		public int txtLine = 1;
		public int moveLine = 0;
		public char[] txt = null;
		public int cLength = 0;
		public string search = null;
		private Font printFont;
		private string streamToPrint = null;
		private bool SaveCheck = false;
		private bool EditText = false;

		private void TextBox_TextChanged(object sender, EventArgs e)
        {
            EditText = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (EditText == false)
			{
				e.Cancel = true;
				return;
			}
			else if (EditText == true)
			{

			}

			if (EditText == false)
			{
				if (MessageBox.Show("저장", "나가기", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
				{
					SaveFileDialog sfd = new SaveFileDialog();

					sfd.Filter = "텍스트 파일 (*.txt) | *.txt";

					if (sfd.ShowDialog() == DialogResult.OK)

					{


						FileStream fs = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write);

						StreamWriter sw = new StreamWriter(fs);

						sw.WriteLine(TextBox.Text); // 파일 저장
						sw.Close();




					}
				}
			}
		}

        private void menu_File_Click(object sender, EventArgs e)
        {

        }
    }
}

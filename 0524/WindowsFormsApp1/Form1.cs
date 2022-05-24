using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog(); // form2를 모달 방식으로 띄운다.
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Open_Click(object sender, EventArgs e)
        {
            //파일오픈창 생성 및 설정
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "파일 오픈창";
            ofd.FileName = "";
            ofd.Filter = "텍스트 파일 (*.txt) | *.txt";

            //파일 오픈창 로드
            DialogResult dr = ofd.ShowDialog();

            //OK버튼 클릭시
            if (dr == DialogResult.OK)
            {

                //프로퍼티
                //File명만 뽑는다
                string fileNamel = ofd.SafeFileName.Substring(0, ofd.SafeFileName.Length - 4);
                StreamReader sr = new StreamReader(ofd.FileName, Encoding.UTF8);

                int position = ofd.FileName.LastIndexOf("\\");

                string textFileName = ofd.FileName.Substring(position + 1);

                this.Text = textFileName + " - Libo메모장";

                //출력 로직

                contents.Text = sr.ReadToEnd();
                sr.Close();


            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            contents.Text = string.Empty;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "텍스트 파일 (*.txt) | *.txt";

            if (sfd.ShowDialog() == DialogResult.OK)

            {


                FileStream fs = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write);

                StreamWriter sw = new StreamWriter(fs);

                sw.WriteLine(contents.Text); // 파일 저장
                sw.Close();




            }
        }
    }
}

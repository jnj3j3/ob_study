
namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.menu_File = new System.Windows.Forms.Button();
            this.menu_Edit = new System.Windows.Forms.Button();
            this.menu_Ori = new System.Windows.Forms.Button();
            this.menu_View = new System.Windows.Forms.Button();
            this.menu_Help = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // menu_File
            // 
            this.menu_File.Font = new System.Drawing.Font("나눔고딕", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menu_File.Location = new System.Drawing.Point(22, 0);
            this.menu_File.Name = "menu_File";
            this.menu_File.Size = new System.Drawing.Size(83, 31);
            this.menu_File.TabIndex = 0;
            this.menu_File.Text = "파일(F)";
            this.menu_File.UseVisualStyleBackColor = true;
            this.menu_File.Click += new System.EventHandler(this.menu_File_Click);
            // 
            // menu_Edit
            // 
            this.menu_Edit.Font = new System.Drawing.Font("나눔고딕", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menu_Edit.Location = new System.Drawing.Point(111, 0);
            this.menu_Edit.Name = "menu_Edit";
            this.menu_Edit.Size = new System.Drawing.Size(83, 31);
            this.menu_Edit.TabIndex = 6;
            this.menu_Edit.Text = "편집(E)";
            this.menu_Edit.UseVisualStyleBackColor = true;
            // 
            // menu_Ori
            // 
            this.menu_Ori.Font = new System.Drawing.Font("나눔고딕", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menu_Ori.Location = new System.Drawing.Point(200, 0);
            this.menu_Ori.Name = "menu_Ori";
            this.menu_Ori.Size = new System.Drawing.Size(83, 31);
            this.menu_Ori.TabIndex = 7;
            this.menu_Ori.Text = "서식(O)";
            this.menu_Ori.UseVisualStyleBackColor = true;
            // 
            // menu_View
            // 
            this.menu_View.Font = new System.Drawing.Font("나눔고딕", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menu_View.Location = new System.Drawing.Point(289, 0);
            this.menu_View.Name = "menu_View";
            this.menu_View.Size = new System.Drawing.Size(83, 31);
            this.menu_View.TabIndex = 8;
            this.menu_View.Text = "보기(V)";
            this.menu_View.UseVisualStyleBackColor = true;
            // 
            // menu_Help
            // 
            this.menu_Help.Font = new System.Drawing.Font("나눔고딕", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menu_Help.Location = new System.Drawing.Point(378, 0);
            this.menu_Help.Name = "menu_Help";
            this.menu_Help.Size = new System.Drawing.Size(83, 31);
            this.menu_Help.TabIndex = 9;
            this.menu_Help.Text = "도움말(H)";
            this.menu_Help.UseVisualStyleBackColor = true;
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(12, 37);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(796, 377);
            this.TextBox.TabIndex = 10;
            this.TextBox.Text = "";
            this.TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(820, 426);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.menu_Help);
            this.Controls.Add(this.menu_View);
            this.Controls.Add(this.menu_Ori);
            this.Controls.Add(this.menu_Edit);
            this.Controls.Add(this.menu_File);
            this.Font = new System.Drawing.Font("굴림", 8F);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "MainForm";
            this.Text = "메모장";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button menu_File;
        private System.Windows.Forms.Button menu_Edit;
        private System.Windows.Forms.Button menu_Ori;
        private System.Windows.Forms.Button menu_View;
        private System.Windows.Forms.Button menu_Help;
        private System.Windows.Forms.RichTextBox TextBox;
    }
}
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


namespace carantin_dz_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool ind = false;
            string location = textBox1.Text;


            for (int i = 0; i <= 99; i++)
            {
                DirectoryInfo folder = new DirectoryInfo($@"{location}\Folder_{i}"); //D:

                if (!folder.Exists)
                {
                    folder.Create();
                }
                else
                {
                    string message = $"Папка Folder_{i} не має існувати до початку створення";
                    string caption = "Виберіть шлях до папки іншої назви";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                }
                ind = true;
            }
            

            if (ind == true)
            {
                string message_1 = "Папки створені";
                string caption_1 = "Папки були створені";
                MessageBoxButtons buttons_1 = MessageBoxButtons.OK;
                DialogResult result_1;
                result_1 = MessageBox.Show(message_1, caption_1, buttons_1);
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string location = textBox1.Text;
            for (int i = 0; i <= 99; i++)
            {
                DirectoryInfo folder = new DirectoryInfo($@"{location}\Folder_{i}");
                folder.Delete(true);
            }
            string message_1 = "Папки видалені";
            string caption_1 = "Папки були видалені";
            MessageBoxButtons buttons_1 = MessageBoxButtons.OK;
            DialogResult result_1;
            result_1 = MessageBox.Show(message_1, caption_1, buttons_1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool ind = false;
            string location = textBox2.Text;
            string loc = $@"{location}\Folder_{0}";

            for (int i = 0; i <= 99; i++)
            {
                DirectoryInfo folder = new DirectoryInfo(loc); //D:

                if (!folder.Exists)
                {
                    folder.Create();
                }
                
                if(i != 99)
                {
                    loc += $@"\Folder_{i + 1}";
                }
                
                ind = true;
            }


            if (ind == true)
            {
                string message_1 = "Папки створені";
                string caption_1 = "Папки були створені";
                MessageBoxButtons buttons_1 = MessageBoxButtons.OK;
                DialogResult result_1;
                result_1 = MessageBox.Show(message_1, caption_1, buttons_1);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string location = textBox2.Text;
            DirectoryInfo folder = new DirectoryInfo($@"{location}\Folder_{0}");
            folder.Delete(true);
            string message_1 = "Папки видалені";
            string caption_1 = "Папки були видалені";
            MessageBoxButtons buttons_1 = MessageBoxButtons.OK;
            DialogResult result_1;
            result_1 = MessageBox.Show(message_1, caption_1, buttons_1);
        }
    }
}

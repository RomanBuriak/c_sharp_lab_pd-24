using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Form1 : Form
    {
        int counter = 0;
        int i = 0;
        Timer Timer1 = new Timer();
        public Form1()
        {
            InitializeComponent();
            this.MouseMove += Button_Move;
            Text = " ";
            if (Timer1.Enabled)
            {
                Timer1.Enabled = false;
            }
            else
            {
                Timer1.Interval = 1000;
                Timer1.Tick += new EventHandler(Timer1_Tick);
                Timer1.Start();
            }

        }

        

        private void Timer1_Tick(object sender, EventArgs e)
        {
            i++;
            
            if (this.Text == " ")
            {
                this.Text = "Натисніть кнопку “ОK”!!!";
            }
            else if (this.Text == "Натисніть кнопку “ОK”!!!")
            {
                this.Text = " ";
            }
            if (i == 15)
            {
                Timer1.Stop();
            }
        }

        private void Button_Move(object sender, MouseEventArgs e)
        {
            int speed = 2;
            int field = 30;
            int cursor_x = Cursor.Position.X;
            int cursor_y = Cursor.Position.Y;
            int button_x = button1.Location.X;
            int button_y = button1.Location.Y;
            //->
            if (cursor_x - field >= button_x)
            {
                button1.Location = new System.Drawing.Point(button_x + speed, button_y);
            }
            //<-
            if (cursor_x + button1.Width + field <= button_x)
            {
                button1.Location = new System.Drawing.Point(button_x - speed, button_y);
            }
            //down
            if (cursor_y - field >= button_x)
            {
                button1.Location = new System.Drawing.Point(button_x, button_y + speed);
            }
            //up
            if (cursor_y + button1.Height + field == button_x)
            {
                button1.Location = new System.Drawing.Point(button_x, button_y + speed);
            }
            //down and right
            
            if (button1.Size.Width < 1 || button1.Size.Height < 1)
                this.Text = "Кнопка “Ок” не може бути натиснута";
            bool move = false;

            bool Limit_X = e.X > button_x - field && e.X < button_x;//->
            bool Limit_Y = e.Y > button_y - field && e.Y < button_y;//down
            bool Limit_And_Size_Button_X = e.X > button_x - field + 100 && e.X < button_x + 100;//->
            bool Limit_And_Size_Button_Y = e.Y > button_y - field + 50 && e.Y < button_y + 50;//
            bool Limit_X_Revers = e.X > button_x && e.X < button_x - field + 100;//
            bool Limit_Y_Revers = e.Y > button_y && e.Y < button_y - field + 50;//
            if (Limit_X && Limit_Y)
            {
                this.button1.Location = new System.Drawing.Point(button_x + speed, button_y + speed);
                move = true; counter++;
            }
            else if (Limit_And_Size_Button_X && Limit_And_Size_Button_Y)
            {
                this.button1.Location = new System.Drawing.Point(button_x - speed, button_y - speed);
                move = true; counter++;
            }
            else if (Limit_X && Limit_And_Size_Button_Y)
            {
                this.button1.Location = new System.Drawing.Point(button_x + speed, button_y - speed);
                move = true; counter++;
            }
            else if (Limit_And_Size_Button_X && Limit_Y)
            {
                this.button1.Location = new System.Drawing.Point(button_x - speed, button_y + speed);
                move = true; counter++;
            }
            else if (Limit_X_Revers && Limit_Y)
            {
                this.button1.Location = new System.Drawing.Point(button_x, button_y + speed);
                move = true; counter++;
            }
            else if (Limit_X_Revers && Limit_And_Size_Button_Y)
            {
                this.button1.Location = new System.Drawing.Point(button_x, button_y - speed);
                move = true; counter++;
            }
            else if (Limit_And_Size_Button_X && Limit_Y_Revers)
            {
                this.button1.Location = new System.Drawing.Point(button_x - speed, button_y);
                move = true; counter++;
            }
            else if (Limit_X && Limit_Y_Revers)
            {
                this.button1.Location = new System.Drawing.Point(button_x + speed, button_y);
                move = true; counter++;
            }



            //Край форми
            field = 50;
            if (button1.Location.X > this.Size.Width - 80)
                button_x -= field;
            else if (button1.Location.Y > this.Size.Height - 80)
                button_y -= field;
            else if (button1.Location.Y < 0)
                button_y += field;
            else if (button1.Location.X < 0)
                button_x += field;
            this.button1.Location = new System.Drawing.Point(button_x, button_y);

            //Зменшння кнопки
            if (move && counter % 10 == 0)
            {
                this.button1.Size = new System.Drawing.Size(button1.Width, --button1.Height);
            }

        }


        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}

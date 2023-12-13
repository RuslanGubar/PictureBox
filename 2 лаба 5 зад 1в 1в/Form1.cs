using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_лаба_5_зад_1в_1в
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
 switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Пользователь\source\repos\2 лаба 5 зад 1в 1в\2 лаба 5 зад 1в 1в\Picture\Зима.jpg");
                        label1.Text = "Зима"; break;
                    }
                case 1:
                    {
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Пользователь\source\repos\2 лаба 5 зад 1в 1в\2 лаба 5 зад 1в 1в\Picture\Зима.jpg");
                        label1.Text = "Зима"; break;
                    }
                case 2:
                    {
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Пользователь\source\repos\2 лаба 5 зад 1в 1в\2 лаба 5 зад 1в 1в\Picture\Весна.jpg");
                        label1.Text = "Весна"; break;
                    }
                case 3:
                    {
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Пользователь\source\repos\2 лаба 5 зад 1в 1в\2 лаба 5 зад 1в 1в\Picture\Весна.jpg");
                        label1.Text = "Весна"; break;
                    }
                case 4:
                    {
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Пользователь\source\repos\2 лаба 5 зад 1в 1в\2 лаба 5 зад 1в 1в\Picture\Весна.jpg");
                        label1.Text = "Весна"; break;
                    }
                case 5:
                    {
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Пользователь\source\repos\2 лаба 5 зад 1в 1в\2 лаба 5 зад 1в 1в\Picture\Лето.jpg");
                        label1.Text = "Лето"; break;
                    }
                case 6:
                    {
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Пользователь\source\repos\2 лаба 5 зад 1в 1в\2 лаба 5 зад 1в 1в\Picture\Лето.jpg");
                        label1.Text = "Лето"; break;
                    }
                case 7:
                    {
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Пользователь\source\repos\2 лаба 5 зад 1в 1в\2 лаба 5 зад 1в 1в\Picture\Лето.jpg");
                        label1.Text = "Лето"; break;
                    }
                case 8:
                    {
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Пользователь\source\repos\2 лаба 5 зад 1в 1в\2 лаба 5 зад 1в 1в\Picture\Осень.jpg");
                        label1.Text = "Осень"; break;
                    }
                case 9:
                    {
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Пользователь\source\repos\2 лаба 5 зад 1в 1в\2 лаба 5 зад 1в 1в\Picture\Осень.jpg");
                        label1.Text = "Осень"; break;
                    }
                case 10:
                    {
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Пользователь\source\repos\2 лаба 5 зад 1в 1в\2 лаба 5 зад 1в 1в\Picture\Осень.jpg");
                        label1.Text = "Осень"; break;
                    }
                case 11:
                    {
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Пользователь\source\repos\2 лаба 5 зад 1в 1в\2 лаба 5 зад 1в 1в\Picture\Зима.jpg");
                        label1.Text = "Зима"; break;
                    }
            }
        }
    }
}

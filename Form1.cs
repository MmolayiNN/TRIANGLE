using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRIANGLE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (int.TryParse(textBox1.Text, out int rows))
            {
                textBox2.Text = GeneratePascalTriangle(rows);
            }
            else
            {
                MessageBox.Show("Please enter a valid integer number of rows.", "Pascal's Triangle Generator");
            }
        }

            private string GeneratePascalTriangle(int rows)
            {
                string triangle = "";
                int[,] pascalArray = new int[rows, rows];

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        if (j == 0 || j == i)
                        {
                            pascalArray[i, j] = 1;
                        }
                        else
                        {
                            pascalArray[i, j] = pascalArray[i - 1, j - 1] + pascalArray[i - 1, j];
                        }
                        triangle += pascalArray[i, j] + " ";
                    }
                    triangle += Environment.NewLine;
                }

                return triangle;
            }

        }
    }


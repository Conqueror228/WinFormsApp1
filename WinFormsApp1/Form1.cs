using System;
using FastReport.DataVisualization;
using FastReport.DataVisualization.Charting;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(tba.Text);
            double b = Convert.ToDouble(tbb.Text);
            double c = Convert.ToDouble(tbc.Text);
            double d = (b * b) - 4 * a * c;

            if (d < 0)
            {
                MessageBox.Show("Дискриминант меньше нуля. Корней нет.");
            }
            else if (d == 0)
            {
                double x = (-b / (2 * a));
                MessageBox.Show("Дискриминант равен нулю. Корень равен " + x + ".");
            }

            else
            {
                double x1 = ((-b - Math.Sqrt(d)) / (2 * a));
                double x2 = ((-b + Math.Sqrt(d)) / (2 * a));
                MessageBox.Show("Дискриминант равен " + d + ". Первый корень равен " + x1 + ". Второй корень равен " + x2 + ".");
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.ChartAreas.Add(new ChartArea("parabola"));

            chart1.Series[0].Points.Clear();
            chart1.Series[0].Points.AddXY(-4,5);
            chart1.Series[0].Points.AddXY(-3,0);
            chart1.Series[0].Points.AddXY(-2,-3);
            chart1.Series[0].Points.AddXY(-1,-4);
            chart1.Series[0].Points.AddXY(0,-3);
            chart1.Series[0].Points.AddXY(1,0);
            chart1.Series[0].Points.AddXY(2,5);
            chart1.Titles.Add("График функции");

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
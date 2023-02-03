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
                MessageBox.Show("������������ ������ ����. ������ ���.");
            }
            else if (d == 0)
            {
                double x = (-b / (2 * a));
                MessageBox.Show("������������ ����� ����. ������ ��� " + x + ".");
            }

            else
            {
                double x1 = ((-b - Math.Sqrt(d)) / (2 * a));
                double x2 = ((-b + Math.Sqrt(d)) / (2 * a));
                MessageBox.Show("������������ ����� " + d + ". ������ ������ ����� " + x1 + ". ������ ������ ����� " + x2 + ".");
                tB1.Text = x1.ToString();
                tB2.Text = x2.ToString();
                discr1.Text = d.ToString();
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
            chart1.Titles.Add("������ �������");

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

        private void button2_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(tba2.Text);
            double b = Convert.ToDouble(tbb2.Text);
            double c = Convert.ToDouble(tbc2.Text);
            double d2 = (b * b) - 4 * a * c;

            if (d2 < 0)
            {
                MessageBox.Show("������������ ������ ����. ������ ���.");
            }
            else if (d2 == 0)
            {
                double y = (-b / (2 * a));
                MessageBox.Show("������������ ����� ����. ������ ��� " + y + ".");
            }

            else
            {
                double y1 = ((-b - Math.Sqrt(d2)) / (2 * a));
                double y2 = ((-b + Math.Sqrt(d2)) / (2 * a));
                MessageBox.Show("������������ ����� " + d2 + ". ������ ������ ����� " + y1 + ". ������ ������ ����� " + y2 + ".");
                tB3.Text = y1.ToString();
                tB4.Text = y2.ToString();
                discr2.Text = d2.ToString();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[0].Points.AddXY(-4, 5);
            chart1.Series[0].Points.AddXY(-3, 0);
            chart1.Series[0].Points.AddXY(-2, -3);
            chart1.Series[0].Points.AddXY(-1, -4);
            chart1.Series[0].Points.AddXY(0, -3);
            chart1.Series[0].Points.AddXY(1, 0);
            chart1.Series[0].Points.AddXY(2, 5);
            chart1.Palette = ChartColorPalette.Berry;

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[0].Points.AddXY(0, -1);
            chart1.Series[0].Points.AddXY(-3, 0);
            chart1.Series[0].Points.AddXY(-4, 1);
            chart1.Series[0].Points.AddXY(-3, 2);
            chart1.Series[0].Points.AddXY(0, 3);
            chart1.Palette = ChartColorPalette.SeaGreen;
        }
    }
}
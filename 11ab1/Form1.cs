using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _11ab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int n = scrollBar.Value;

            long sumLoop = CalculateSumLoop(n);

            long sumFormula = CalculateSumFormula(n);

            lblSumLoop.Text = $"Сумма ряда (цикл): {sumLoop}";
            lblSumFormula.Text = $"Сумма ряда (формула): {sumFormula}";
            richTextBox1.Text = $"n = {n}";
        }
        private long CalculateSumLoop(int n)
        {
            long sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += (long)Math.Pow(2 * i - 1, 3);
            }
            return sum;
        }
        private long CalculateSumFormula(int n)
        {
            long sum = n * n * (2 * n * n - 1);
            return sum;
        }
    }
}

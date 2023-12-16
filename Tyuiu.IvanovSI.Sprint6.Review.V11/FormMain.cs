using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.IvanovSI.Sprint6.Review.V11.Lib;
namespace Tyuiu.IvanovSI.Sprint6.Review.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelDO_ISI_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelSize_ISI_Click(object sender, EventArgs e)
        {

        }

        private void buttonDo_ISI_Click(object sender, EventArgs e)
        {

            int n = Convert.ToInt32(textBoxN_ISI.Text);
            int m = Convert.ToInt32(textBoxM_ISI.Text);
            int n1 = Convert.ToInt32(textBoxN1_ISI.Text);
            int n2 = Convert.ToInt32(textBoxN2_ISI.Text);
            int k = Convert.ToInt32(textBoxK_ISI.Text);
            int l = Convert.ToInt32(textBoxL_ISI.Text);
            int c = Convert.ToInt32(textBoxC_ISI.Text);


            if ((n1 < n2) && (n > 1) && (m > 1))
            {
                int[,] matrix = ds.GetMatrix(n, m, n1, n2);
                int rows = matrix.GetUpperBound(0) + 1;
                int columns = matrix.Length / rows;
                dataGridViewMas_ISI.ColumnCount = columns;
                dataGridViewMas_ISI.RowCount = rows;

                for (int i = 0; i < columns; i++)
                {
                    dataGridViewMas_ISI.Columns[i].Width = 50;
                }
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewMas_ISI.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                    }
                }

                if ((n1 < n2) && (n > 1) && (m > 1) && (k < l) && (c <= m))
                {
                    textBoxRes_ISI.Text = Convert.ToString(ds.GetMax(matrix, c, k, l));
                }


            }

            else
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }

 

    
}

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
using Tyuiu.PimenovaTS.Sprint6.TaskReview.V6.Lib;

namespace Tyuiu.PimenovaTS.Sprint6.TaskReview.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        static int m;
        static int n;
        static int n1;
        static int n2;
        static int k;
        static int l;
        static int c;
        static int[,] arrayValues;
        Random rand = new Random();

        private void panelOne_PTS_Paint(object sender, PaintEventArgs e)
        {
            //
        }

        private void buttonCreat_PTS_Click(object sender, EventArgs e)
        {
            try
            {
                int k = Convert.ToInt32(textBoxK_PTS.Text);
                int l = Convert.ToInt32(textBoxL_PTS.Text);
                int c = Convert.ToInt32(textBoxC_PTS.Text);

                int pr = 1;
                for (int i = k; i <= l; i++)
                {
                    if (arrayValues[i, c] % 2 != 0)
                    {
                        pr *= arrayValues[i, c];
                    }
                }
                textBoxResult_PTS.Text = Convert.ToString(pr);
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void buttonHelp_PTS_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonChange_PTS_Click(object sender, EventArgs e)
        {
            int m = Convert.ToInt32(textBoxShir_PTS.Text);
            int n = Convert.ToInt32(textBoxVisot_PTS.Text);
            int n1 = Convert.ToInt32(textBoxStart_PTS.Text);
            int n2 = Convert.ToInt32(textBoxStop_PTS.Text);

            arrayValues = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arrayValues[i, j] = rand.Next(n1, n2 - 1);
                }
            }

            dataGridViewMatrix_PTS.RowCount = n;
            dataGridViewMatrix_PTS.ColumnCount = m;

            for (int i = 0; i < m; i++)
            {
                dataGridViewMatrix_PTS.Columns[i].Width = 50;
            }

            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < m; c++)
                {
                    dataGridViewMatrix_PTS.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

        }
    }
}

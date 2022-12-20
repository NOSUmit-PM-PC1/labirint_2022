using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labirint
{
    public partial class FormGame : Form
    {
        int[,] field;
        int sizeCell = 30;
        int userI, userJ;

        bool Mark(int metka, int rowEnd, int columnEnd)
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    if (field[i, j] == metka)
                    {
                        if (j > 0 && field[i, j - 1] == 0) field[i, j - 1] = metka + 1;
                        if (i > 0 && field[i - 1, j] == 0) field[i - 1, j] = metka + 1;
                        if (i < field.GetLength(0)-1 && field[i + 1, j] == 0) field[i + 1, j] = metka + 1;
                        if (j < field.GetLength(1) - 1 && field[i, j + 1] == 0) field[i, j + 1] = metka + 1;
                    }
                }
            }
            if (field[rowEnd, columnEnd] == 0)
                return false;
            else
                return true;
        }
        
        int CountStep(int rowBegin, int columnBegin, int rowEnd, int columnEnd)
        {
            int metka = 1;
            field[rowBegin, columnBegin] = metka;

            while (!Mark(metka, rowEnd, columnEnd))
            {
                metka++;
            }
            return metka;
        }

        public FormGame()
        {
            InitializeComponent();
        }

        void CreateViewLabirint()
        {
            // добавить колонки
            for (int i = 0; i < field.GetLength(1); i++)
            {
                dataGridViewLabirint.Columns.Add("", "");
                dataGridViewLabirint.Columns[i].Width = sizeCell;
            }
            // добавить строки
            dataGridViewLabirint.Rows.Add(field.GetLength(0));
            dataGridViewLabirint.Width = field.GetLength(1) * (sizeCell + 5);
            dataGridViewLabirint.Height = field.GetLength(0) * sizeCell;
        }
        void ShowLabirint()
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    if (field[i, j] == -1)
                        dataGridViewLabirint.Rows[i].Cells[j].Style.BackColor = Color.Red;
                    else
                        if (field[i, j] == -2)
                    {
                        dataGridViewLabirint.Rows[i].Cells[j].Value = "*";
                        dataGridViewLabirint.CurrentCell = dataGridViewLabirint[j, i];
                        userI = i;
                        userJ = j;
                    }
                    else
                    {
                        //dataGridViewLabirint.Rows[i].Cells[j].Value = "";
                        dataGridViewLabirint.Rows[i].Cells[j].Value = field[i,j];
                    }
                }
            }   
        }

        bool checkMove(int i, int j)
        {
            if (field[i, j] == 0)
                if (Math.Abs(i - userI) <= 1 && Math.Abs(j - userJ) <= 1)
                {
                    field[userI, userJ] = 0;
                    field[i, j] = -2;
                    userI = i; userJ = j;
                }
            return true;
        }
        private void FormGame_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("level1.txt");
            string[] temp = sr.ReadLine().Split();
            int n = Convert.ToInt32(temp[0]);
            int m = Convert.ToInt32(temp[1]);
            field = new int[n, m];
            // 0 - пустые клетки, -1 - стенки
            for (int i = 0; i < n; i++)
            {
                string tempStr = sr.ReadLine();
                for (int j = 0; j < m; j++)
                {
                    if (tempStr[j] == '*') field[i, j] = -1;
                }
            }
            sr.Close();
            // положение игрока в лабиринте
            field[1, 0] = -2;

            CreateViewLabirint();
            ShowLabirint();
            
        }

        private void dataGridViewLabirint_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int col = e.ColumnIndex;
            int row = e.RowIndex;

            int k = CountStep(1, 0, 5, 4);
            ShowLabirint();
            //if (checkMove(row, col))
            //{
            //    ShowLabirint();
            //}
        }
    }
}

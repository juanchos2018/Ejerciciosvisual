using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicioLp2_u2
{
    public partial class Ejercicio8 : Form
    {
        public Ejercicio8()
        {
            InitializeComponent();
        }

        private void Ejercicio8_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[1].Width = 60;
            dataGridView1.Columns[2].Width = 60;
            dataGridView1.Columns[3].Width = 60;


            dataGridView2.ColumnCount = 4;
            dataGridView2.Columns[0].Width = 60;
            dataGridView2.Columns[1].Width = 60;
            dataGridView2.Columns[2].Width = 60;
            dataGridView2.Columns[3].Width = 60;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var data = new int[4, 4]
               {
                       { 1, 2, 3, 3},
                       { 4, 5, 6, 3},
                       { 7, 8, 9, 1},
                       { 10,11,12,3},
               };

            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();

            int[,] matriz = new int[4, 4];

            Random rd = new Random();

            int numero;
            int filas;
            int columnas;
            for (filas = 0; filas < 4; filas++)
            {
                
              //  numero = rd.Next(2, 20);
                for (columnas = 0; columnas < 4; columnas++)
                {
                    // Console.Write("ingrese el numero: ");
                    matriz[filas, columnas] = rd.Next(2, 20);
                    //if (filas == columnas)
                    //{
                    //    matriz[filas, columnas] = rd.Next(2, 20);
                    //}
                    //else
                    //{

                    //}
                }
            }



            var rowCount = matriz.GetLength(0);
            var rowLength = matriz.GetLength(1);

            for (int rowIndex = 0; rowIndex < rowCount; ++rowIndex)
            {
                var row = new DataGridViewRow();

                for (int columnIndex = 0; columnIndex < rowLength; ++columnIndex)
                {
                    row.Cells.Add(new DataGridViewTextBoxCell()
                    {
                        Value = matriz[rowIndex, columnIndex]
                    });
                }

                dataGridView1.Rows.Add(row);
            }

            int f=0;
            int c=0;
            int[] diagonal = new int[4];
            int contador=0;
            for (int k = 0; k < 4; k++)
            {
                
             //   var row = new DataGridViewRow();
              //  Console.WriteLine(data[k, k] + " ");
                diagonal[contador] = matriz[k, k];
                contador++;
                //row.Cells.Add(new DataGridViewTextBoxCell()
                //{
                //    Value = data[k, k]
                //}) ;
          

            }

           // MessageBox.Show("acabo");

            //   dataGridView2.Rows[0].Cells[0].Value=diagonal[0];
          //  string v1 = diagonal[0].ToString();
            //dataGridView2.Rows.Add(v1,"-","-","-");
            //dataGridView2.Rows.Add("-", diagonal[1],"-","-");
            //dataGridView2.Rows.Add("-", "-", diagonal[2],"-");
            //dataGridView2.Rows.Add("-", "-", "-", diagonal[3]);

            string espacio = "-";
            int can_espacio = 0;
            for (int i = 0; i < diagonal.Length; i++)
            {
                if (can_espacio==0)
                {
                    dataGridView2.Rows.Add(diagonal[i].ToString());
                }
                  
                if (can_espacio==1)
                {
                    dataGridView2.Rows.Add(espacio, diagonal[i].ToString());
                }
                if (can_espacio == 2)
                {
                    dataGridView2.Rows.Add(espacio, espacio, diagonal[i].ToString());
                }
                if (can_espacio == 3)
                {
                    dataGridView2.Rows.Add(espacio, espacio,espacio, diagonal[i].ToString());
                }
                if (can_espacio == 4)
                {
                    dataGridView2.Rows.Add(espacio, espacio,espacio, espacio,diagonal[i].ToString());
                }
                //   dataGridView2.Rows.Add(espacio, diagonal[i].ToString());
                can_espacio++;
            }
            //    dataGridView2.Rows[1].Cells[1].Value = diagonal[1];

            //for (filas = 0; filas < 4; filas++)
            //{
            //    Console.WriteLine();
            //    for (columnas = 0; columnas < 4; columnas++)
            //    {
            //        Console.WriteLine(matriz[filas, columnas]);
            //    }
            //}

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

      
    }
}

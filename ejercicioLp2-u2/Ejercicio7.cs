using ejercicioLp2_u2.Entidad;
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

namespace ejercicioLp2_u2
{
    public partial class Ejercicio7 : Form
    {
        public Ejercicio7()
        {
            InitializeComponent();
        }

        private void Ejercicio7_Load(object sender, EventArgs e)
        {
          


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] array1 = { "pepe", "lucho", "lupe", "sofia" };

            string[] array2 = { "andres", "calamaro", "jefe", "hurtado" };

            for (int i = 0; i < array1.Length; i++)
            {
                StreamWriter escribe = new StreamWriter(@"array1.txt", true);
                escribe.WriteLine(array1[i]);
                escribe.Close();
            }
            for (int i = 0; i < array2.Length; i++)
            {
                StreamWriter escribe = new StreamWriter(@"array2.txt", true);
                escribe.WriteLine(array2[i]);
                escribe.Close();
            }

            MessageBox.Show("REgistrado dos aRRays");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            // juntar dos arrays
            string path = @"array1.txt";
            string path2 = @"array2.txt";
            List<string> lineas1 = new List<string>();
            List<string> lineas2 = new List<string>();
            List<string> lineas3 = new List<string>();

            lineas1 = (from l in File.ReadAllLines(path)
                      select l).ToList();

            lineas2 = (from l in File.ReadAllLines(path2)
                      select l).ToList();

            string datos = "";

            var    Elevations = lineas1.Union(lineas2).ToList();
            foreach (var item in Elevations)
            {          
                
                StreamWriter escribe = new StreamWriter(@"array3.txt", true);
                escribe.WriteLine(item);
                escribe.Close();

            }
            string path3 = @"array3.txt";
            lineas3 = (from l in File.ReadAllLines(path3)
                       select l).ToList();

            foreach (var item in lineas3)
            {
                datos += item + "-";
            }
             txt1.Text = datos;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ejercicio8 f = new Ejercicio8();
            f.Show();
            this.Hide();
        }

        private void nadaBorrar()
        {
            List<string> lineas = new List<string>();
            List<ClsProductos> lineas1 = new List<ClsProductos>();

            string path = @"productos.txt";
            lineas = (from l in File.ReadAllLines(path)
                      select l).ToList();

            var data = new List<Int32> { 1, 20, 30, 40, 50, 70 };

            var result = lineas1.Select(d => new ClsProductos
            {

                nombre_producto = d.nombre_producto

            }).ToList();

            int ca = lineas.Count;
            //    string[] a3 = new string[ca];
            Console.WriteLine(ca);
            //  int contador = 0;
            foreach (var item in lineas)
            {
                //    Console.WriteLine(item+",");
                Console.WriteLine(item);
                //   a3[contador] = item + ",";

                // contador++;

            }
        }
    }
}

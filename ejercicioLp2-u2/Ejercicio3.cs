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
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void Ejercicio3_Load(object sender, EventArgs e)
        {

        }

        private  void mostrardatos(string direcory)
        {
            int can_directorios = 0;
            int can_archivos = 0;
            int total = 0;
            int Numero = 1;
                     

            List<ClsArchivo> lista = new List<ClsArchivo>();

            //try

            //{

          //  DirectoryInfo
                DirectoryInfo directory = new DirectoryInfo(direcory);
                FileInfo[] files = directory.GetFiles("*.*");
                DirectoryInfo[] directories = directory.GetDirectories();
                string[] suf = { "B", "KB", "MB", "GB", "TB", "PB", "EB" };
            for (int i = 0; i < files.Length; i++)

            {
                string atribues1 = "";
                long byteCount = 0;
                string extension = "";
                FileInfo infos = new FileInfo(files[i].FullName);
                FileAttributes attributes = infos.Attributes;
                extension = Path.GetExtension(files[i].FullName);
                byteCount = ((FileInfo)files[i]).Length;

                string tamano = "";
                string lectura = "r";
                string escritura = "w";
                string ejecucion = "x";
                string oculto = "h";
                string compirmido = "c";

                FileAttributes atributesficheros = File.GetAttributes(files[i].FullName);
                if ((atributesficheros & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
                {


                    atribues1 += lectura;

                }
                else
                {
                    atribues1 = infos.Attributes.ToString();


                }

                if ((atributesficheros & FileAttributes.Hidden) == FileAttributes.Hidden)
                {

                    atribues1 += oculto;

                }
                else
                {
                    atribues1 = infos.Attributes.ToString();

                }
                if ((atributesficheros & FileAttributes.Compressed) == FileAttributes.Compressed)
                {


                    atribues1 += compirmido;

                }
                else
                {
                    atribues1 = infos.Attributes.ToString();

                }
                long bytes = Math.Abs(((FileInfo)files[i]).Length);
                int place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
                double num = Math.Round(bytes / Math.Pow(1024, place), 1);
                Console.WriteLine((Math.Sign(byteCount) * num).ToString() + suf[place]);
                tamano = ((Math.Sign(byteCount) * num).ToString() + suf[place]);

                lista.Add(new ClsArchivo()
                {
                    Numero = Numero,
                    Nombre = ((FileInfo)files[i]).Name,
                    Extension = extension,
                    Tipo = "Archivo",
                    tamano = tamano,
                    Permisos = atribues1


                }); ;
                can_archivos++;
                Numero++;
            }


            for (int i = 0; i < directories.Length; i++)
                {
                    long suma = 0;
                    string tamano = "";
                    DirectoryInfo di = new DirectoryInfo(directories[i].FullName);
                    string atribues1 = "";
                    string lectura = "r";
                    string escritura = "w";
                    string ejecucion = "x";
                    string oculto = "h";
                    string compirmido = "c";

                    FileAttributes atributesficheros = File.GetAttributes(files[i].FullName);
                    if ((atributesficheros & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
                    {


                        atribues1 += lectura;

                    }
                    else
                    {
                        atribues1 = di.Attributes.ToString();


                    }

                    if ((atributesficheros & FileAttributes.Hidden) == FileAttributes.Hidden)
                    {

                        atribues1 += oculto;

                    }
                    else
                    {
                        atribues1 = di.Attributes.ToString();

                    }
                    if ((atributesficheros & FileAttributes.Compressed) == FileAttributes.Compressed)
                    {


                        atribues1 += compirmido;

                    }
                    else
                    {
                        atribues1 = di.Attributes.ToString();

                    }

                    foreach (FileInfo info in di.GetFiles("*", SearchOption.AllDirectories))
                    {
                        long byteCount = 0;
                        suma += info.Length;                      
                        byteCount = suma;
                        long bytes = Math.Abs(suma);
                        int place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
                        double num = Math.Round(bytes / Math.Pow(1024, place), 1);
                        Console.WriteLine((Math.Sign(byteCount) * num).ToString() + suf[place]);
                        tamano = ((Math.Sign(byteCount) * num).ToString() + suf[place]);


                    }

                    FileAttributes attributes = di.Attributes;
                    lista.Add(new ClsArchivo()
                    {
                        Numero = Numero,
                        Nombre = ((DirectoryInfo)directories[i]).Name,
                        Tipo = "Directorio",                        
                        tamano = tamano,
                        Permisos = atribues1

                    });;


                    can_directorios++;
                    Numero++;

                }


                //int s = 0;
                //long size = fileInfo.Length;

                //while (size >= 1024)
                //{
                //    s++;
                //    size /= 1024;
                //}

                //string humanReadable = String.Format("{0} {1}", size, suffixes[s]);


                dgv.DataSource = lista;
                total = can_archivos + can_directorios;
                lbl1.Text = can_directorios.ToString();
                lbl2.Text = can_archivos.ToString();
                lbl3.Text = total.ToString();
          


         //   }

            //catch (Exception ex)

            //{

            //    Console.WriteLine(ex.ToString());

            //}

        }
        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = txtruta.Text;
            DialogResult drResult = folderBrowserDialog1.ShowDialog();
            if (drResult == System.Windows.Forms.DialogResult.OK)
                txtruta.Text = folderBrowserDialog1.SelectedPath;
            mostrardatos(folderBrowserDialog1.SelectedPath);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ejercicio4 f = new Ejercicio4();
            f.Show();
            this.Hide();
        }
    }
}

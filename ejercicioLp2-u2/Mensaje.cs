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
    public partial class Mensaje : Form
    {
        string ruta;
        string direc;
        string fullpaths;
        string disco;
      
        public Mensaje()
        {
            InitializeComponent();
        }

        public void setDatos(string path,string directorio,string fullpath)
        {
            txtnombre.Text = directorio;
            direc = directorio;
            ruta =directorio + "\\" + path;
            txtarchivo.Text = path;
          txttodo.Text = "C:\\"+fullpath;
            fullpaths = fullpath;

          
        }

        private void Mensaje_Load(object sender, EventArgs e)
        {
            txtnuevo.Visible = false;
            btnopen.Visible = false;
            txtarchivo.Enabled = false;
          //  txttodo.Visible = false;
            txtnombre.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbd0.Checked==true)
            {// crear archivo o directorio
                string tipo = getExtension(txtnuevo.Text);

                if (tipo.Equals("txt"))
                {

                    //C:\nuevo\carpertaeeliminar\corerafic
                    string full = "C:\\" + fullpaths;   

                    string path = full + "\\" + txtnuevo.Text;
                    var myFile = File.Create(path);                
                    myFile.Close();
                    MessageBox.Show("Creado Archivo");
                }

                else
                {

                    string full = "C:\\" + fullpaths;

               //     string path = full + "\\" + txtnuevo.Text;
                    string rutaa = full + "\\" + txtnuevo.Text;


                    if (!Directory.Exists(rutaa))
                    {
                        DirectoryInfo di = Directory.CreateDirectory(rutaa);
                        
                        MessageBox.Show("CReado Carpeta");
                    }

                }
            }


            if (rbd1.Checked == true)
            {
                //Elininar

                try
                {
                    string tipo = getExtension(txtarchivo.Text);
                    if (tipo.Equals("txt"))
                    {
                        File.Delete("C:\\"+fullpaths);
                        MessageBox.Show("Eliminado archivo");
                    }
                    else
                    {
                     
                        bool directoryExists = Directory.Exists("C:\\"+fullpaths);
                      
                        if (directoryExists)
                        {

                            Directory.Delete("C:\\"+fullpaths, true);
                            MessageBox.Show("Eliminado sub Carpeta");

                        }
                        else
                        {
                            MessageBox.Show("No existe Carpeta");
                        }

                    }
                                                

                }
                catch (Exception)
                {

                    throw;
                }
            }

            //REnombbrar
            if (rbd2.Checked==true)
            {
                string tipo = getExtension(txtarchivo.Text);
                if (tipo.Equals("txt"))
                {
                    string full = "C:\\" + fullpaths;                
                    string nuew = nuevacandea(full);
                    string newpath = nuew + "\\" + txtnuevo.Text;
                    ///------------------------------------------------------------
                    File.Move(full, newpath);                   
                    MessageBox.Show("Cambio de nombre we");
                }
                else
                {
                   // string newpath = direc + "\\" + txtnuevo.Text;

                    string full = "C:\\" + fullpaths;
                    string nuew = nuevacandea(full);
                    string newpath = nuew + "\\" + txtnuevo.Text;
                    ///------------------------------------------------------------
                  //  File.Move(full, newpath);
                    System.IO.Directory.Move(full, newpath);
                    MessageBox.Show("CAmbio de nombre we");
                }
            }
            if (rbd3.Checked==true)
            {
                //para mover archivo we
                string tipo = getExtension(txtarchivo.Text);
                if (tipo.Equals("txt"))
                {

                    string full = "C:\\" + fullpaths;
                    string nuevaruta = txtnuevo.Text + "\\" + txtarchivo.Text;
                    File.Move(full, nuevaruta);
                    MessageBox.Show("SE movio archivo");
                }
                else
                {
                    string full = "C:\\" + fullpaths;
                    //C:\nuevo\carpertaeeliminar\corerafic
                    //  string nuew = nuevacandea(full);
                    ///  string newpath = nuew + "\\" + txtnuevo.Text;


                    string nuevaruta = txtnuevo.Text + "\\" + txtarchivo.Text;
                    System.IO.Directory.Move(full, nuevaruta);
                    MessageBox.Show("SE movio directorio");
                }

            }
            if (rbd5.Checked==true)
            {
                string tipo = getExtension(txtarchivo.Text);

                if (tipo.Equals("txt"))
                {

                    string full = "C:\\" + fullpaths;
                    string readText = File.ReadAllText(full);
                    Mensaje2 f = new Mensaje2();
                    f.setRuta(readText);
                    f.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("No es un archivo");
                }

            }
            if (rbd4.Checked==true)
            {
                string tipo = getExtension(txtarchivo.Text);
                if (tipo.Equals("txt"))
                {

                    string full = "C:\\" + fullpaths;
                    if (File.Exists(full))
                    {
                                           

                        string texto = txtnuevo.Text + Environment.NewLine;
                        File.WriteAllText(full, texto);

                      //  var myFile = File.WriteAllText(full, texto);

                        //StreamWriter escribe = new StreamWriter(ruta, true);
                        //escribe.WriteLine(texto);
                        //escribe.Close();

                        //   var myFile = File.WriteAllText(ruta, texto);

                        /// myFile.Close();
                        MessageBox.Show("SE escibo el el fichero");

                    }
                }
                else
                {
                    MessageBox.Show("No sepuede escribr en eun directorio WE !!!!!  AAAAAAAAAaaaaalv");

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Directory.Delete(txttodo.Text);
            //File.Delete(@"C:\prueba\Docentes.txt");
            
        }

        private void rbd2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbd2.Checked==true)
            {
                txtnuevo.Visible = true;
            }
        }
        private void rbd3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbd3.Checked == true)
            {
                txtnuevo.Visible = true;
                btnopen.Visible = true;
            }
        }

        private void EmptyFolder(DirectoryInfo directoryInfo)
        {
            foreach (FileInfo file in directoryInfo.GetFiles())
            {
                file.Delete();
            }

            foreach (DirectoryInfo subfolder in directoryInfo.GetDirectories())
            {
                EmptyFolder(subfolder);
            }
        }
        public static string getExtension(string filename)
        {
            int index = filename.LastIndexOf('.');

            if (index == -1)
            {
                return "";
            }
            else
            {
                return filename.Substring(index + 1);
            }
        }


      


        private void btnopen_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = txtnuevo.Text;
            DialogResult drResult = folderBrowserDialog1.ShowDialog();
            if (drResult == System.Windows.Forms.DialogResult.OK)
                txtnuevo.Text = folderBrowserDialog1.SelectedPath;
        }

        private void rbd0_CheckedChanged(object sender, EventArgs e)
        {
            txtnuevo.Visible = true;
        }

        private void rbd4_CheckedChanged(object sender, EventArgs e)
        {
            txtnuevo.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
        //    string s = @"C:\nuevo\carpertaeeliminar\ficher.txt";
        //    int idx = s.LastIndexOf(@"\");
        //    string nuevo = "";
        //    if (idx != -1)
        //    {
        //        nuevo = s.Substring(0, idx);             
        //    }

           
        //    MessageBox.Show(nuevo);
        }

        private string nuevacandea(string cadena)
        {
          
            int idx = cadena.LastIndexOf(@"\");
            string nuevo = "";
            if (idx != -1)
            {
                nuevo = cadena.Substring(0, idx);
            }
            return nuevo;
        }
    }
 }


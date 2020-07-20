using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicioLp2_u2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtDirectoryPath.Text = @"C:\nuevo";
            LoadDirectory(txtDirectoryPath.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = txtDirectoryPath.Text;
            DialogResult drResult = folderBrowserDialog1.ShowDialog();
            if (drResult == System.Windows.Forms.DialogResult.OK)
                txtDirectoryPath.Text = folderBrowserDialog1.SelectedPath;

         //   txtDirectoryPath.Text = "C:\nuevo";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            // Clear All Nodes if Already Exists  
            treeView1.Nodes.Clear();
            toolTip1.ShowAlways = true;
            if (txtDirectoryPath.Text != "" && Directory.Exists(txtDirectoryPath.Text))
                LoadDirectory(txtDirectoryPath.Text);
            else
                MessageBox.Show("Select Directory!!");
        }
        public void LoadDirectory(string Dir)
        {
            DirectoryInfo di = new DirectoryInfo(Dir);
            //Setting ProgressBar Maximum Value  
            progressBar1.Maximum = Directory.GetFiles(Dir, "*.*", SearchOption.AllDirectories).Length + Directory.GetDirectories(Dir, "**", SearchOption.AllDirectories).Length;
            TreeNode tds = treeView1.Nodes.Add(di.Name);
            tds.Tag = di.FullName;
            tds.StateImageIndex = 0;
            LoadFiles(Dir, tds);
            LoadSubDirectories(Dir, tds);
             
        }
            
        private void LoadSubDirectories(string dir, TreeNode td)
        {
            // Get all subdirectories  
            string[] subdirectoryEntries = Directory.GetDirectories(dir);
            // Loop through them to see if they have any other subdirectories  
            foreach (string subdirectory in subdirectoryEntries)
            {

                DirectoryInfo di = new DirectoryInfo(subdirectory);
                TreeNode tds = td.Nodes.Add(di.Name);
                tds.StateImageIndex = 0;
                tds.Tag = di.FullName;
                LoadFiles(subdirectory, tds);
                LoadSubDirectories(subdirectory, tds);
                UpdateProgress();

            }
        }
        private void LoadFiles(string dir, TreeNode td)
        {
            string[] Files = Directory.GetFiles(dir, "*.*");

            // Loop through them to see files  
            foreach (string file in Files)
            {
                FileInfo fi = new FileInfo(file);
                TreeNode tds = td.Nodes.Add(fi.Name);
                tds.Tag = fi.FullName;
                tds.StateImageIndex = 1;
                UpdateProgress();

            }
        }

        private void UpdateProgress() { 
  
           if (progressBar1.Value<progressBar1.Maximum)  
           {  
               progressBar1.Value++;  
               int percent = (int)(((double)progressBar1.Value / (double)progressBar1.Maximum) * 100);
                progressBar1.CreateGraphics().DrawString(percent.ToString() + "%", new Font("Arial", (float)8.25, FontStyle.Regular), Brushes.Black, new PointF(progressBar1.Width / 2 - 10, progressBar1.Height / 2 - 7));  
  
               Application.DoEvents();  
           }
        }

        private void treeView1_MouseMove(object sender, MouseEventArgs e)
        {
            // Get the node at the current mouse pointer location.  
            TreeNode theNode = this.treeView1.GetNodeAt(e.X, e.Y);

            // Set a ToolTip only if the mouse pointer is actually paused on a node.  
            if (theNode != null && theNode.Tag != null)
            {
                // Change the ToolTip only if the pointer moved to a new node.  
                if (theNode.Tag.ToString() != this.toolTip1.GetToolTip(this.treeView1))
                    this.toolTip1.SetToolTip(this.treeView1, theNode.Tag.ToString());

            }
            else     // Pointer is not over a node so clear the ToolTip.  
            {
                this.toolTip1.SetToolTip(this.treeView1, "");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {


            string ruta0 = txtDirectoryPath.Text;
            string nombrecarpeta = txtnombrecarpeta.Text;


            string name = txtnombrecarpeta.Text;
            string tipo = getExtension2(name);
            //asdfsda.dock
            if (tipo.Equals("txt"))
            {

                string path = ruta0 + "\\" + name;
                var myFile = File.Create(path);
                //   File.Create(myFile);
                myFile.Close();
                MessageBox.Show("CReado Archivo");
            }
            else if (tipo.Equals("dock"))
            {

                string path = ruta0 + "\\" + name;
                var myFile = File.Create(path);
                //   File.Create(myFile);
                myFile.Close();
                MessageBox.Show("CReado Archivo");
            }
         

            else
            {

            //   asdfsda.dock
                string rutaa = ruta0 + "\\" + name;

                if (!Directory.Exists(rutaa))
                {
                    DirectoryInfo di = Directory.CreateDirectory(rutaa);
                    MessageBox.Show("CReado Carpeta");
                }

            }



            // string ruta = @"D:\dev\proyCs\archivos\directorio_nuevo";
         //   if (!Directory.Exists(ruta))
           // {
             //   Console.WriteLine("Creando el directorio: {0}", ruta);
               // DirectoryInfo di = Directory.CreateDirectory(ruta);
           // }

          treeView1.Nodes.Clear();
            LoadDirectory(txtDirectoryPath.Text);
           

        }

        

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            

            string selectedTVI = treeView1.SelectedNode.ToString();
            string path = selectedTVI;
            string parenonde = treeView1.SelectedNode.Parent.ToString();
            string fullpath = treeView1.SelectedNode.FullPath;
        //    TextBox1.Text = TreeView1.SelectedNode.ValuePath;



            string pa = getExtension(path);
        //   MessageBox.Show(parenonde);
         //   txt1.Text = pa.Trim();

             Mensaje f = new Mensaje();
            f.setDatos(pa.Trim(), txtDirectoryPath.Text,fullpath);
          

         f.ShowDialog();

        }
        public static string getExtension2(string filename)
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

        public static string getExtension(string filename)
        {
            int index = filename.LastIndexOf(':');
            
            if (index == -1)
            {
                return "";
            }
            else
            {
                return filename.Substring(index + 1);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Mensaje2 f = new Mensaje2();
            //f.setRuta(txtDirectoryPath.Text);
            //f.ShowDialog();

            Ejercicio2 f = new Ejercicio2();
            f.Show();
            this.Hide();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void txtnombrecarpeta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

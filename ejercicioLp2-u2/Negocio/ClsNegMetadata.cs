using ejercicioLp2_u2.Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicioLp2_u2.Negocio
{
    class ClsNegMetadata
    {
        public void RegistarMetadata(ClsMetadata obj)
        {

            StreamWriter escribe = new StreamWriter(@"Metadata.txt", true);
            escribe.WriteLine(obj.nombre + "," + obj.tipo + "," + obj.ubicacion + "," + obj.size + "," + obj.creacion + "," + obj.modificacion+","+obj.leido);

            escribe.Close();
            //objEnAlumno.estudCodigo.clear(); txtNombre.Clear(); txtApellido.Clear(); txtDireccion.Clear(); txtFecha.Clear(); txtTelefono.Clear(); pcbFoto.Image = null;

        }
        public List<ClsMetadata> ListarMetadata()
        {
            
            List<ClsMetadata> Lista = new List<ClsMetadata>();
            var meta = new List<ClsMetadata>();
     
            StreamReader leer = new StreamReader(@"Metadata.txt", true);

            while (leer.EndOfStream != true)
            {
                ClsMetadata pro = new ClsMetadata();                
                string[] cadena = leer.ReadLine().Split(',');
                    pro.nombre = cadena[0];
                    pro.tipo = cadena[1];
                    pro.ubicacion =cadena[2];
                    pro.size = long.Parse(cadena[3]);
                    pro.creacion = DateTime.Parse(cadena[4]);
                    pro.modificacion = DateTime.Parse(cadena[5]);
                    Lista.Add(pro);
              


                //    Lista.Add(new ClsArchivo()
                //    {

                //     pro.tipo = cadena[0],
                //    pro.nombre = cadena[1],
                //    pro.ubicacion = cadena[2];
                //    pro.size = long.Parse(cadena[3]);
                //    pro.creacion = DateTime.Parse(cadena[4]);
                //    pro.modificacion = DateTime.Parse(cadena[5]);


                //});




            }

            leer.Close();

            return Lista;

        }

       
    }
}

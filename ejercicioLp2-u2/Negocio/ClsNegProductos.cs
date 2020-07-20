using ejercicioLp2_u2.Entidad;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioLp2_u2.Negocio
{
    class ClsNegProductos
    {

        public static List<ClsProductos> obtenerProductos()
        {
            var query = new List<ClsProductos>();
            List<ClsProductos> Lista = new List<ClsProductos>();
            StreamReader leer = new StreamReader(@"productos.txt", true);

            while (leer.EndOfStream != true)
            {
                ClsProductos pro = new ClsProductos();
                string[] cadena = leer.ReadLine().Split(',');
                pro.id_producto = int.Parse(cadena[0]);
                pro.nombre_producto = cadena[1];
             //   Lista.Add(pro);
                query.Add(pro);

            }
            leer.Close();

            return query;

        }

       

        public List<ClsProductos> ParseCountryList()
        {
            string ruta = @"productos.txt";
            var result = new List<ClsProductos>();
            using (var tfp = new TextFieldParser(ruta)
            {
                Delimiters = new string[] { "," },
                HasFieldsEnclosedInQuotes = true
            })
            {
                while (!tfp.EndOfData)
                {
                    var fila = tfp.ReadFields();
                   
                        var item = new ClsProductos
                        {
                            id_producto = int.Parse(fila[0].Trim()),
                            nombre_producto = fila[1].Trim()
                        };
                        result.Add(item);
                    
                }
            }
            return result;
        }

        public List<ClsProductos> lista2() { 


             string ruta = @"productos.txt";
            char[] delimiters = new char[] { ',' };
            var fileLines = File.ReadLines(ruta)                                
                                .Select(line => {
                                    string[] ss = line.Split(delimiters);
                                    return (ss.Length == 2)
                                           ? new ClsProductos() { id_producto = int.Parse(ss[0]),
                                                               nombre_producto = ss[1]
                                                           }
                                           : null;              
                                              })
                              //  .Where(x => x != null)     
                                .ToList();
            return fileLines;
        }


        public  List<ClsKardex> ListarKardex(ClsProductos o)
        {

            //ti.tipo = cbotipo.SelectedItem.ToString();
            //o.tipo = ti;
            List<ClsKardex> Lista = new List<ClsKardex>();
            StreamReader leer = new StreamReader(@"kardex.txt", true);

            while (leer.EndOfStream != true)
            {
                ClsKardex pro = new ClsKardex();
                ClsTIpo ti = new ClsTIpo();
                string[] cadena = leer.ReadLine().Split(',');

                if (o.id_producto== int.Parse(cadena[0]))
                {
                    pro.fecha =Convert.ToDateTime( cadena[1].ToString());
                    pro.nombre_producto = cadena[2];
                    ti.tipo = cadena[3];
                    pro.tipo = ti;
                    pro.saldo_anterior =       int.Parse(cadena[4]);
                    pro.entradas =        int.Parse(cadena[5]);
                    pro.salidas =   int.Parse(cadena[6]);
                    pro.saldo_actual = int.Parse(cadena[7]);
                    Lista.Add(pro);
                    
                }

            }
            leer.Close();

            return Lista;

        }
        public void RegistarKardex (ClsKardex obj)
        {

            StreamWriter escribe = new StreamWriter(@"kardex.txt", true);
            escribe.WriteLine(obj.id_producto + "," +obj.fecha+"," + obj.nombre_producto + "," + obj.tipo.tipo + "," + obj.saldo_anterior + "," + obj.entradas + "," + obj.salidas + "," + obj.saldo_actual);
            escribe.Close();
            //objEnAlumno.estudCodigo.clear(); txtNombre.Clear(); txtApellido.Clear(); txtDireccion.Clear(); txtFecha.Clear(); txtTelefono.Clear(); pcbFoto.Image = null;

        }
    }
}

﻿using System;
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
    public partial class Ejercicio5 : Form
    {
        public Ejercicio5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          

            //foreach (var item in lis)
            //{
            //    Console.WriteLine(item);
            //}

            // MessageBox.Show(lis.ToString());

            string text = @"Historically, the world of data and the world of objects" +
       @" have not been well integrated. Programmers work in C# or Visual Basic" +
       @" and also in SQL or XQuery. On the one side are concepts such as classes," +
       @" objects, fields, inheritance, and .NET Framework APIs. On the other side" +
       @" are tables, columns, rows, nodes, and separate languages for dealing with" +
       @" them. Data types often require translation between the two worlds; there are" +
       @" different standard functions. Because the object world has no notion of query, a" +
       @" query can only be represented as a string without compile-time type checking or" +
       @" IntelliSense support in the IDE. Transferring data from SQL tables or XML trees to" +
       @" objects in memory is often tedious and error-prone.";

            string searchTerm = "data";

            //Convert the string into an array of words  
            //string[] source = text.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);

            //// Create the query.  Use ToLowerInvariant to match "data" and "Data"
            //var matchQuery = from word in source
            //                 where word.ToLowerInvariant() == searchTerm.ToLowerInvariant()
            //                 select word;

            //// Count the matches, which executes the query.  
            //int wordCount = matchQuery.Count();
            //Console.WriteLine("{0} occurrences(s) of the search term \"{1}\" were found.", wordCount, searchTerm);

            //// Keep console window open in debug mode  
            //Console.WriteLine("Press any key to exit");
            string[] source = text.Split(new char[] {' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
        
            List<string> lis = new List<string>();
            string path = "C:\\nuevo\\noticia.txt";
            lis = (from l in File.ReadAllLines(path)
                   select l).ToList();

           // var list = new List<string> { "a", "b", "a", "c", "a", "b" };
            var q = from x in lis
                    group x by x into g
                    let count = g.Count()
                    orderby count descending
                    select new { Value = g.Key, Count = count };
            foreach (var x in q)
            {
                Console.WriteLine("Value: " + x.Value + " Count: " + x.Count);
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ejercicio6 f = new Ejercicio6();
            f.Show();
            this.Hide();
        }

        private void Ejercicio5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

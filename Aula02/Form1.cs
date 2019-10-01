using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula02
{
 
    public partial class Form1 : Form
    {
        decimal Altura;
        decimal Peso;
        int[] Dias;
        List<int> Anos;
        Dictionary<int, string> Meses;




        public Form1()
        {
            InitializeComponent();

            Dias = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31 };
            Anos = new List<int>()
        { 1993, 1994, 1995, 1996, 1997, 1998, 1999, 2000, 2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010,
        2011, 2012, 2013, 2014, 2015, 2016, 2017, 2018
        };
            Anos.Add(2019);

            Meses = new Dictionary<int, string>() {
        { 1 , "Janeiro"},
        { 2 , "Fevereiro"},
        { 3 , "Março"},
        { 4 , "Abril"},
        { 5 , "Maio"},
        { 6 , "Junho"},
        { 7 , "Julho"},
        { 8, "Agosto"},
        { 9 , "Setembro"},
        { 10 , "Outubro"},
        { 11 , "Novembro"}
        };
            Meses.Add(12, "Dezembro");

            //int indice = 0;
            //while (indice < Dias.Length)
            //{
            //    cbxDias.Items.Add(Dias[indice]);
            //    indice++;
            //    }
            for (int i = 0; i < Dias.Length; i++)
            {
                cbxDias.Items.Add(Dias[i]);

            }

            foreach (int ano in Anos)
            {
                cbxAnos.Items.Add(ano);

            }
            cbxMeses.DataSource = new BindingSource(Meses, null);
            cbxMeses.DisplayMember = "Value";
            cbxMeses.ValueMember = "Key";


        }
                
    }
}

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



        private void BtmCalcular_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            //Altura = decimal.Parse(txtAltura.Text);

            if (!decimal.TryParse(txtAltura.Text, out Altura))
            {
                MessageBox.Show("Altura inválida!");
            }

            if (!decimal.TryParse(txtPeso.Text, out Peso))
            {
                MessageBox.Show("Peso inválido!");
            }
        
       

            var descricao = VerificarImc(Peso, Altura, out var imc);
            MessageBox.Show($"Nome: {nome}\nNascimento: {cbxDias.Text} de {cbxMeses.Text} de {cbxAnos.Text}\nIMC: {imc.ToString("N2")}\n\n{descricao}");


            MessageBox.Show($@"Nome: {nome}
           {Environment.NewLine}Nascimento: {cbxDias.Text} de {cbxMeses.Text} de {cbxAnos.Text}
           {Environment.NewLine}IMC: {imc.ToString("N2")}
           {Environment.NewLine}
           {Environment.NewLine}{descricao}");

        }

        private string TraduzirMes(int mes)
        {
            string descricao = string.Empty;
            switch (mes)
            {
                case 1:
                    descricao = "Janeiro";
                    break;
                case 2:
                    descricao = "Feveriero";
                    break;
                case 3:
                    descricao = "Março";
                    break;
                case 4:
                    descricao = "Abril";
                    break;
                case 5:
                    descricao = "Maio";
                    break;
                case 6:
                    descricao = "Junho";
                    break;
                case 7:
                    descricao = "Julho";
                    break;
                case 8:
                    descricao = "Agosto";
                    break;
                case 9:
                    descricao = "Setembro";
                    break;
                case 10:
                    descricao = "Outubro";
                    break;
                case 11:
                    descricao = "Novembro";
                    break;
                case 12:
                    descricao = "Dezembro";
                    break;
                default:
                    descricao = "Mês não encontrado";
                    break;
            }
            return descricao;
        }

        string VerificarImc(decimal peso, decimal altura, out decimal imc)
        {
            imc = peso / (altura * altura);
            if (imc < (decimal)18.5)
            {
                return "Abaixo do peso";
            }
            else if (imc >= (decimal)18.5 && imc < 25)
            {
                return "Peso normal";
            }
            else if (imc >= 25 && imc < 30)
            {
                return "Sobrepeso";
            }
            else if (imc >= 30 && imc < 35)
            {
                return "Feliz";
            }
            else if (imc >= 35 && imc < 39)
            {
                return "Obesidade grau 2";
            }
            else
            {
                return "Obesidade grau 3";
            }

        }

    }
}

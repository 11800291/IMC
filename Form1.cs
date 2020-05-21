using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAtleta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                string nome, idade,peso, altura;

                nome = txtNome.Text;
                idade = txtIdade.Text;
                peso = txtPeso.Text;
                altura = txtAltura.Text;
                Atleta atleta = new Atleta();
                atleta.setNome(nome);
                atleta.setIdade(idade);
                atleta.setPeso(peso);
                atleta.setAltura(altura);

                lblResposta.Text = atleta.CalcularIMC().ToString("0.00"); 
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = String.Empty;
            txtIdade.Text = String.Empty;
            txtPeso.Text = String.Empty;
            txtAltura.Text = String.Empty;
        }
    }
}

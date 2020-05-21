using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAtleta
{
    class Atleta
    {
        public string Nome;
        public int Idade;
        public double Altura;
        public double Peso;

    
        public void setNome(string Nome){
            if(Nome == String.Empty)
            {
                throw new Exception("Preencha o campo Nome");
            }
            else
            {
                this.Nome = Nome;
            }

        }
         public string getNome()
        {
            return this.Nome;
        }

        //----------------------------------------------------------------//
        public void setIdade(string Idade)
        {
            if (Idade == String.Empty)
            {
                throw new Exception("Preencha o campo Idade");
            } 
            else if(int.Parse(Idade) <= 0 )
            {
                throw new Exception("Idade tem de ser Maior que 0");
            }
            else
            {
                this.Idade = int.Parse(Idade);
            }

        }
        public int getIdade()
        {
            return this.Idade;
        }
        //-------------------------------------------------------------------------//
        public void setAltura(string Altura)
        {
            if (Altura == String.Empty)
            {
                throw new Exception("Preencha o campo Altura");
            }
            else if (double.Parse(Altura) <= 0)
            {
                throw new Exception("Altura tem de ser Maior que 0");
            }
            else
            {
                this.Altura = double.Parse(Altura);
            }

        }
        public double getAltura()
        {
            return this.Altura;
        }
        //-------------------------------------------------------------------------//
        public void setPeso(string Peso)
        {
            if (Peso == String.Empty)
            {
                throw new Exception("Preencha o campo Peso");
            }
            else if (double.Parse(Peso) <= 0)
            {
                throw new Exception("Peso tem de ser Maior que 0");
            }
            else
            {
                this.Peso = double.Parse(Peso);
                
            }
           
        }
        public double getPeso()
        {
            return this.Peso;
        }
        //imc = peso / (altura * altura);

        public double CalcularIMC()
        {
            return this.Peso / (this.Altura * this.Altura);
        }
    }
}

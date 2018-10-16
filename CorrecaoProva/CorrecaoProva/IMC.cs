using System;

namespace CorrecaoProva
{
    class IMC
    {
        private double peso;
        private double altura;
        
        public IMC()
        {
            this.peso = 0.0;
            this.altura = 0.0;
        }
    
    public double Calcular(double peso, double altura)
    {
        return peso / (altura * altura);
    }
        public double Classificar(double imc)
        {
            return 0.0;
        }
  }
}
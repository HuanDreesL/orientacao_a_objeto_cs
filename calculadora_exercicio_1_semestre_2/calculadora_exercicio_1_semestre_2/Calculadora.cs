namespace calculadora_exercicio_1_semestre_2
{
    public class Calculadora
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }

        public Calculadora(double num1, double num2) 
        {
            Num1 = num1;
            Num2 = num2;
        }

        public double Somar() 
        {
            return Num1 + Num2;
        }
    }
}


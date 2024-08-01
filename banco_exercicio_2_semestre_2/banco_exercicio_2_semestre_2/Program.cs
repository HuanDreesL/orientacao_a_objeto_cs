namespace banco_exercicio_2_semestre_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Banco huandres = new Banco();
            
            huandres.saldo = 500;
            huandres.nome = "Huandres";
            huandres.numeroConta = 146;
            huandres.limite = 5000;

            huandres.Sacar(250);
            huandres.Depositar(250);
            huandres.Consultar();
        }
    }
}

namespace Exercicio_POO
{
    public class Funcionario
    {
        public string? Nome { get; set; }        
        public string? Cargo { get; set; }        
        public decimal salario { get; private set; }

        public void inserirSalario(decimal valorSalario)
        {
            if (valorSalario > 0)
            {
                salario = valorSalario;
            }

            else
            {
                Console.WriteLine("Valor invalido");
            }
        }

        public void aumentarSalario(decimal porcentagem)
        {
            salario =  salario * (1 +(porcentagem / 100));
            Console.WriteLine(salario);
        }        

        public void consultarSalario()
        {
           Console.WriteLine($"O salário atual é de: {salario}");
        }
    }
}
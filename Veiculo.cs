namespace Exercicio_POO
{
    public class Veiculo
    {
        public int velocidade { get; private set; }

        public int alterarVelocidade(int novaVelocidade)
        {
            if (novaVelocidade <= 200)
            {
                velocidade = novaVelocidade;
                Console.WriteLine($"Velocidade alterada para: {velocidade}");
            }

            else
            {
                Console.WriteLine("Valor de velocidade acima do permitido!");
            }

            return velocidade;
        }        
    }
}
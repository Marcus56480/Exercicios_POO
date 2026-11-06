using Exercicio_POO;

Pessoa p1 = new Pessoa();

p1.Nome = "Marcus";
p1.Idade = 18;
p1.Cidade = "Diadema";

p1.Apresentar();

int resultado = Calculadora.Divisao(10, 5);
Console.WriteLine($"o resultado é: {resultado}");

Veiculo v1 = new Veiculo();

Console.WriteLine(v1.alterarVelocidade(200));

Funcionario f1 = new Funcionario();

f1.Nome = "Marcus";
f1.Cargo = "Algum";

f1.inserirSalario(1000);
f1.aumentarSalario(10);
f1.consultarSalario();

//* f1.Salario = 1000;
// Não funciona por causa de que na minha classe eu declarei a escrita do salario como privada, então só pode ser alterada dentro da minha classe

Livro l1 = new Livro();
Console.WriteLine($"Titulo: {l1.Nome} - Autor: {l1.Autor} - Numero de Paginas: {l1.numeroPaginas}");

Livro l2 = new Livro("Memorias Postumas de Brás cubas");
Console.WriteLine($"Titulo: {l2.Nome} - Autor: {l2.Autor} - Numero de Paginas: {l2.numeroPaginas}");

Livro l3 = new Livro("Memorias Postumas de Brás cubas", "Machado de Assis");
Console.WriteLine($"Titulo: {l3.Nome} - Autor: {l3.Autor} - Numero de Paginas: {l3.numeroPaginas}");

Livro l4 = new Livro("Memorias Postumas de Brás cubas", "Machado de Assis", 384);
Console.WriteLine($"Titulo: {l4.Nome} - Autor: {l4.Autor} - Numero de Paginas: {l4.numeroPaginas}");

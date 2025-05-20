int senha = 1234;

Console.Write("Digite a senha: ");

int tentativa = int.Parse(Console.ReadLine());

while (tentativa != senha)

{

    Console.WriteLine("Senha INCORRETA");

    senha = int.Parse(Console.ReadLine());

}

Console.WriteLine("Senha CORRETA!");
 
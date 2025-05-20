Console.Write("Insira um número para parar: ");

double n1 = double.Parse(Console.ReadLine());

double resultado = 0;

Console.Write("0");

for (int i = 0; 1 + (i * 2) <= n1; i++)

{

    Console.Write(",");

    Console.Write(1 + (i*2));

}
 
 
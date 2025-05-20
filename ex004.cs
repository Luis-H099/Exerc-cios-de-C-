Console.Write("Informe a primeira nota: ");
double nota1 = double.Parse(Console.ReadLine());
 
Console.Write("Informe a segunda nota: ");
double nota2 = double.Parse(Console.ReadLine());
 
double media = (nota1 + nota2)/ 2;
if (media >= 6) {
    Console.WriteLine("Você foi APROVADO!");
}
else {
    Console.WriteLine("Você foi REPROVADO!");
}
 
Console.WriteLine($"Sua média foi {media}");

 
 
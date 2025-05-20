Console.Write("Informe um primeiro número: ");
double n1 = double.Parse(Console.ReadLine());
 
Console.Write("Informe um segundo número: ");
double n2 = double.Parse(Console.ReadLine());
 
Console.Write("Informe um terceiro número: ");
double n3 = double.Parse(Console.ReadLine());
 
double maior = n1;
 
if (maior < n2)
{
    maior = n2;
}
else
{
    if (maior < n3)
    {
        maior = n3;
    }
}
 
Console.WriteLine($"O maior número entre os três é o {maior}");
 
 
Console.Write("Me diga que hora (sem os minutos) é agora?: ");
double hora = double.Parse(Console.ReadLine());
 
if (hora < 13)
{
    Console.WriteLine("Bom dia!");
}
else if (hora >= 13 && hora < 18) {
    Console.WriteLine("Boa tarde!");
}
else {
    Console.WriteLine("Boa noite!");
}
 
 
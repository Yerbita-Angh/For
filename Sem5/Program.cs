Console.WriteLine("Hola, Buen dia");
string re = "s";
int suma = 0;
double cant = 0;

while (re=="s")
{
    Console.WriteLine("Desea participar (s/n)");
    re = Console.ReadLine().ToLower().Trim();
    if (re == "s")
    {

        Console.WriteLine("Ingrese edad");
        int edad = Convert.ToInt32(Console.ReadLine());
        suma = suma + edad;
        cant = cant + 2;
    }
}
double prom = suma / cant;
Console.WriteLine($"El promedio de {cant} edad es {prom}");

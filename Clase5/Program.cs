string respuesta = "S";

while (respuesta.ToUpper() != "N")
{
    if (respuesta.ToUpper() == "S")
    {
        Console.Clear();
        Console.WriteLine("Ingrese su nombre");
        string nombre = Console.ReadLine();
        Console.WriteLine($"!Hola {nombre}!");
        Console.WriteLine("¿Desea continuar? (S/N)");
        respuesta = Console.ReadLine();
    }
    else
    {
        Console.WriteLine("Opción no valida");
        Console.WriteLine("¿Desea continuar? (S/N)");
        respuesta = Console.ReadLine();
    }
}
Console.WriteLine("¡Adiós!");






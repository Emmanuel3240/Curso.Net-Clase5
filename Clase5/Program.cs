//Al ejercicio planteado, le agregué la posibilidad
//de poder rechazar la opcion no valida
// y volver a preguntar por S o N.

string respuesta = "S";

while (respuesta.ToUpper() != "N")
{
    Console.Clear();
    if (respuesta.ToUpper() == "S")
    {
        Console.WriteLine("Ingrese su nombre");
        string nombre = Console.ReadLine();
        Console.WriteLine($"!Hola {nombre}!");
    }
    else
    {
        Console.WriteLine("Opción no válida");
    }
    Console.WriteLine("¿Desea continuar? (S/N)");
    respuesta = Console.ReadLine();
}
Console.WriteLine("Programa finalizado correctamente");






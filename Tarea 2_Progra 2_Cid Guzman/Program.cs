string continuar = string.Empty; // Inicializacion de variable de la condicion del ciclo

do
{
    // Declaracion e inicializacion de variables
    string cedula, nombre, nombreTipoEmpleado = string.Empty;
    byte tipo = 0;
    int cantidadHoras = 0;
    double precio = 0.0, salarioOrdinario = 0.0, salarioBruto = 0.0, salarioNeto = 0.0, aumento = 0.0, deduccion = 0.0;
    const double CCSS = 0.0917;

    // Entrada de datos del empleado
    Console.WriteLine("Ingrese el numero de cedula del empleado:");
    cedula = Console.ReadLine();
    Console.WriteLine("Ingrese el nombre del empleado:");
    nombre = Console.ReadLine();

    Console.WriteLine("Tipo de empleado:");
    Console.WriteLine("1 - Operario\n2 - Tecnico\n3 - Profesional");
    Console.WriteLine("Digite el numero que corresponda:");
    tipo = byte.Parse(Console.ReadLine());

    // Calculo del aumento segun el tipo de empleado
    switch (tipo)
    {
        case 1:
            aumento = 0.15;
            nombreTipoEmpleado = "Operario"; // Esta variable es para despues imprimir el tipo
                                             // de empleado como el nombre del tipo y no el numero
            break;
        case 2:
            aumento = 0.10;
            nombreTipoEmpleado = "Tecnico";
            break;
        case 3:
            aumento = 0.05;
            nombreTipoEmpleado = "Profesional";
            break;
        default:
            Console.WriteLine("Tipo de empleado no valido.");
            break;
    }

    Console.WriteLine("Ingrese la cantidad de horas laboradas por el empleado:");
    cantidadHoras = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el precio por hora laborada por el empleado:");
    precio = double.Parse(Console.ReadLine());


    // Validacion de datos
    if ((tipo >= 1 && tipo <= 3) && cantidadHoras > 0 && precio > 0.0 && !string.IsNullOrEmpty(cedula) && !string.IsNullOrEmpty(nombre))
    {
        // Calculo de salarios
        salarioOrdinario = cantidadHoras * precio;
        aumento *= salarioOrdinario;
        salarioBruto = salarioOrdinario + aumento;
        deduccion = salarioBruto * CCSS;
        salarioNeto = salarioBruto - deduccion;

        // Salidas a la consola
        Console.WriteLine($"Cedula: {cedula}");
        Console.WriteLine($"Nombre Empleado: {nombre}");
        Console.WriteLine($"Tipo Empleado: {nombreTipoEmpleado}");
        Console.WriteLine($"Salario por Hora: {precio}");
        Console.WriteLine($"Cantidad de Horas: {cantidadHoras}");
        Console.WriteLine($"Salario Ordinario: {salarioOrdinario}");
        Console.WriteLine($"Aumento: {aumento}");
        Console.WriteLine($"Salario Bruto: {salarioBruto}");
        Console.WriteLine($"Deduccion CCSS: {deduccion}");
        Console.WriteLine($"Salario Neto: {salarioNeto}");

    }
    else
    {
        Console.WriteLine("Los datos ingresados son incorrectos.");
    }

    // Opcion para continuar realizando calculos salariales
    Console.WriteLine("Realizar otra operacion? (S/N)");
    continuar = Console.ReadLine();
    while (continuar != "S" && continuar != "s" && continuar != "N" && continuar != "n")
    {
        Console.WriteLine("Opcion invalida. Intente de nuevo.");
        Console.WriteLine("Realizar otra operacion? (S/N)");
        continuar = Console.ReadLine();
    }

} while (continuar == "S" || continuar == "s"); // Condicion para que se repita el ciclo
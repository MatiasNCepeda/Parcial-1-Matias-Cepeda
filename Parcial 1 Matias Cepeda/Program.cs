int largo;
int altura;
int ancho;
double area;
double volumen;
double basee;
double areaAltura;
double areaAncho;
double diagonal;
int contador = 0;
do
{
    Console.WriteLine("Ingrese largo");
    while (!int.TryParse(Console.ReadLine(), out largo))
    {
        Console.WriteLine("error ingrese un numero");
    }

    Console.WriteLine("Ingrese altura");
    while (!int.TryParse(Console.ReadLine(), out altura))
    {
        Console.WriteLine("error ingrese un numero");
    }

    Console.WriteLine("Ingrese ancho");
    while (!int.TryParse(Console.ReadLine(), out ancho))
    {
        Console.WriteLine("error ingrese un numero");
    }

    if (largo < 0 || altura < 0 || ancho < 0)
    {
        Console.WriteLine("Datos Incorrectos");
    }
    else if (largo == 0 && altura == 0 && ancho == 0)
    {
        Console.WriteLine("fin del ciclo");
    }
    else
    {
        areaAltura = FuncionAreaAltura (ancho, altura);

        basee = FuncionBase(largo, ancho);

        areaAncho = FuncionAreaAncho(largo, altura);

        area = FuncionArea(basee, areaAltura, areaAncho);

        diagonal = FuncionDiagonal(largo, ancho, altura);

        volumen = FuncionVolumen(ancho, altura, largo);
        Console.WriteLine($"El area es {area}, el volumen es {volumen} y la diagonal es {diagonal}");
        contador = contador + 1;
    }

} while (largo != 0 && altura != 0 && ancho != 0);

double FuncionDiagonal(int largo, int ancho, int altura)
{
    double resultado;
    resultado = Math.Sqrt((Math.Pow(altura,2)) + (Math.Pow(largo,2)) + (Math.Pow(ancho,2)));
    return resultado;
}

double FuncionAreaAncho(int largo, int altura)
{
    double resultado;
    resultado = largo * altura;
    return resultado;
}

double FuncionAreaAltura(int ancho, int altura)
{
    double resultado;
    resultado = ancho * altura;
    return resultado;
}

double FuncionVolumen(double ancho, double largo, double altura)
{
    double resultado;
    resultado = largo * altura * ancho;
    return resultado;
}

double FuncionBase(double largo, double ancho)
{
    double resultado;
    resultado = largo * ancho;
    return resultado;
}

double FuncionArea(double basee, double areaAltura, double areaAncho)
{
    double resultado;
    resultado = 2 * (basee + areaAltura + areaAncho);
    return resultado;
}
Console.WriteLine($"Se ingresaron {contador} Prismas");

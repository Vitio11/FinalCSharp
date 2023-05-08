using static System.Console;
using static System.Math;
class volCubo{

    public void AreaVolumenCubo()
{
    double lado = 0, area, volumen;

    Write("Introduce el valor del lado del cubo: ");
    if (!double.TryParse(ReadLine(), out lado))
    {
        WriteLine("Lado invalido");
        return;
    }

    area = 6 * Pow(lado, 2);
    volumen = Pow(lado, 3);

    WriteLine("El área del cubo es {0}", area);
    WriteLine("El volumen del cubo es {0}", volumen);

    ReadKey();
}
}
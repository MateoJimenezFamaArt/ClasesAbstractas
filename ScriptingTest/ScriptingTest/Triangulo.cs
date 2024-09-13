using System.ComponentModel.DataAnnotations.Schema;

namespace ScriptingTest;

class Triangulo:Figura
{

    public Triangulo(string nombre)
    {
        base.Nombre = nombre;
    }

    public override float Area()
    {
        Console.WriteLine("Hora de calcular el area del Triangulo pai");
        float AreaTriangulo = 0;
        float basesita = 0;
        float alturita = 0;       

        Console.WriteLine("Ingrese porfi el valor de la basesita pai:");
        if (float.TryParse(Console.ReadLine(), out basesita))
        Console.WriteLine("Ingrese porfi el valor de la alturita pai:");
        if (float.TryParse(Console.ReadLine(), out alturita))

        AreaTriangulo = (basesita * alturita)/2;

        return AreaTriangulo;
    }

        public override float Perimetro(int NumeroDeLados, int ValorDeLados)
    {

        float PerimteroTriangulo = 0;
        Console.WriteLine("Ingrese porfi el Radio del circulo pai:");
        if (int.TryParse(Console.ReadLine(), out NumeroDeLados))
        Console.WriteLine("Ingrese porfi el Radio del circulo pai:");
        if (int.TryParse(Console.ReadLine(), out ValorDeLados))

        PerimteroTriangulo = NumeroDeLados * ValorDeLados;
        return PerimteroTriangulo;
    }
}
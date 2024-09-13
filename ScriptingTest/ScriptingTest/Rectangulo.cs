namespace ScriptingTest;

class Rectangulo:Figura
{

    public Rectangulo(string nombre)
    {
        base.Nombre = nombre;
    }
    
    public override float Area()
    {
        Console.WriteLine("Hora de calcular el area del Rectangulo pai");
        float AreaRectangulo = 0;
        float basesita = 0;
        float alturita = 0;

        Console.WriteLine("Ingrese porfi el valor de la basesita pai:");
        if (float.TryParse(Console.ReadLine(), out basesita))
        Console.WriteLine("Ingrese porfi el valor de la alturita pai:");
        if (float.TryParse(Console.ReadLine(), out alturita))

        AreaRectangulo = basesita * alturita;

        return AreaRectangulo;
    }

        public override float Perimetro(int NumeroDeLados, int ValorDeLados)
    {

        float PerimetroRectangulo = 0;
        Console.WriteLine("Ingrese porfi el Radio del circulo pai:");
        if (int.TryParse(Console.ReadLine(), out NumeroDeLados))
        Console.WriteLine("Ingrese porfi el Radio del circulo pai:");
        if (int.TryParse(Console.ReadLine(), out ValorDeLados))

        PerimetroRectangulo = NumeroDeLados * ValorDeLados;
        return PerimetroRectangulo;
    }
}
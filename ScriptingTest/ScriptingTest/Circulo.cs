namespace ScriptingTest;

class Circulo:Figura
{

    public Circulo(string nombre)
    {
        base.Nombre = nombre;
    }


    public override float Area()
    {
        Console.WriteLine("Hora de calcular el area del Circulo pai");
        float AreaCirculo;
        float radio;
        radio = 0;
        AreaCirculo = 0;
        Console.WriteLine("Ingrese porfi el Radio del circulo pai:");
        if (float.TryParse(Console.ReadLine(), out radio))

        AreaCirculo = 3.14f *radio;

        return AreaCirculo;
    }

    public override float Perimetro(int NumeroDeLados, int ValorDeLados)
    {
        float PerimteroCirculo;
        PerimteroCirculo = 0;
        Console.WriteLine("Ingrese porfi el Radio del circulo pai:");
        if (int.TryParse(Console.ReadLine(), out NumeroDeLados))

        Console.WriteLine("Ingrese porfi el Radio del circulo pai:");
        if (int.TryParse(Console.ReadLine(), out ValorDeLados))

        
        PerimteroCirculo = NumeroDeLados * ValorDeLados;

        return PerimteroCirculo;
    }
}
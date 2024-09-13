namespace ScriptingTest;
abstract class Figura
{
    private string nombre; 

    public string Nombre {get => nombre; set => nombre = value;}

    public abstract float Area();

    public abstract float Perimetro(int NumeroDeLados, int ValorDeLados);

} 
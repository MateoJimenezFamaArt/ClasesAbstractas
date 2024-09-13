namespace ScriptingTest;

class Program
{
    static void Main(string[] args)
    {
        /*
        Circulo ElBalon = new Circulo();
        Triangulo ElDorito = new Triangulo();
        Rectangulo ElCosianflo = new Rectangulo();

        ElBalon.Area(); 
        */


        Figura []figuras;
        figuras = new Figura[3];
        figuras[0] = new Triangulo("Triangulo");
        figuras[1] = new Circulo("Circulo");
        figuras[2] = new Rectangulo("Rectangulo");

        foreach (var item in figuras)
        {
            if (item!=null)
            {
                Console.WriteLine($"El Area es {item.Area()}");
            }                       //{item.Nombre}

        }


    }
}

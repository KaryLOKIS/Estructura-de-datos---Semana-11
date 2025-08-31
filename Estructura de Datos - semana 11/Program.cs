public class Traductor
{
    public static void Main(string[] args)
    {
        // Diccionario base Español -> Inglés
        System.Collections.Generic.Dictionary<string, string> diccionario = 
            new System.Collections.Generic.Dictionary<string, string>();

        // Palabras iniciales
        diccionario.Add("tiempo", "time");
        diccionario.Add("persona", "person");
        diccionario.Add("año", "year");
        diccionario.Add("camino", "way");
        diccionario.Add("día", "day");
        diccionario.Add("cosa", "thing");
        diccionario.Add("hombre", "man");
        diccionario.Add("mundo", "world");
        diccionario.Add("vida", "life");
        diccionario.Add("mano", "hand");
        diccionario.Add("parte", "part");
        diccionario.Add("niño", "child");
        diccionario.Add("ojo", "eye");
        diccionario.Add("mujer", "woman");
        diccionario.Add("lugar", "place");
        diccionario.Add("trabajo", "work");
        diccionario.Add("semana", "week");
        diccionario.Add("caso", "case");
        diccionario.Add("punto", "point");
        diccionario.Add("gobierno", "government");
        diccionario.Add("empresa", "company");

        int opcion = -1;

        while (opcion != 0)
        {
            System.Console.WriteLine("\n==================== MENÚ ====================");
            System.Console.WriteLine("1. Traducir una frase");
            System.Console.WriteLine("2. Agregar palabras al diccionario");
            System.Console.WriteLine("0. Salir");
            System.Console.Write("Seleccione una opción: ");

            if (!int.TryParse(System.Console.ReadLine(), out opcion))
            {
                System.Console.WriteLine("Opción inválida, intente de nuevo.");
                continue;
            }

            if (opcion == 1)
            {
                TraducirFrase(diccionario);
            }
            else if (opcion == 2)
            {
                AgregarPalabra(diccionario);
            }
            else if (opcion == 0)
            {
                System.Console.WriteLine("¡Gracias por usar el traductor!");
            }
            else
            {
                System.Console.WriteLine("Opción inválida.");
            }
        }
    }

    static void TraducirFrase(System.Collections.Generic.Dictionary<string, string> diccionario)
    {
        System.Console.Write("Ingrese la frase a traducir: ");
        string frase = System.Console.ReadLine();

        string[] palabras = frase.Split(' ');

        for (int i = 0; i < palabras.Length; i++)
        {
            string palabra = palabras[i].ToLower();

            if (diccionario.ContainsKey(palabra))
            {
                palabras[i] = diccionario[palabra];
            }
        }

        string traduccion = string.Join(" ", palabras);

        System.Console.WriteLine("\nTraducción parcial: ");
        System.Console.WriteLine(traduccion);
    }

    static void AgregarPalabra(System.Collections.Generic.Dictionary<string, string> diccionario)
    {
        System.Console.Write("Ingrese la palabra en español: ");
        string espanol = System.Console.ReadLine().Trim().ToLower();

        System.Console.Write("Ingrese su traducción en inglés: ");
        string ingles = System.Console.ReadLine().Trim().ToLower();

        try
        {
            diccionario.Add(espanol, ingles);
            System.Console.WriteLine("Palabra agregada exitosamente.");
        }
        catch (System.ArgumentException)
        {
            System.Console.WriteLine("Ha ocurrido un error: la palabra ya existe en el diccionario.");
        }
    }
}


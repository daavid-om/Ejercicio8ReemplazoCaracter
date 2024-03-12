namespace Ejercicio8ReemplazoCaracter
{
    /// <summary>
    /// Clase principal de la aplicación
    /// 120324 - dom
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método principal de la aplicación
        /// 120324 - dom
        /// </summary>
        static void Main()
        {
            Console.WriteLine("Ingrese una cadena:");
            string cadena = Console.ReadLine();

            Console.WriteLine("Ingrese el carácter a reemplazar:");
            char charOriginal = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.WriteLine("Ingrese el nuevo carácter:");
            char charReemplazo = Console.ReadKey().KeyChar;
            Console.WriteLine(); 

            string cadenaReemplazada = ReemplazarCaracter(cadena, charOriginal, charReemplazo);
            Console.WriteLine("Cadena con reemplazo:");
            Console.WriteLine(cadenaReemplazada);
        }

        static string ReemplazarCaracter(string cadena, char charOriginal, char charReemplazo)
        {
            char[] cadenaArray = cadena.ToCharArray();
            for (int i = 0; i < cadenaArray.Length; i++)
            {
                if (cadenaArray[i] == charOriginal)
                {
                    cadenaArray[i] = charReemplazo;
                }
            }
            return new string(cadenaArray);
        }
    }
}
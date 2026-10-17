using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // ----------------------------------------------------------------------
        // PARTE 1: Manipulación de cadenas de texto
        // ----------------------------------------------------------------------
        Console.WriteLine("=== PARTE 1: MANIPULACIÓN DE CADENAS ===");
        string textoOriginal = "Fundamentos de Programacion en la Universidad UPN";
        Console.WriteLine($"Texto original: '{textoOriginal}'");

        // Substring
        string subcadena = textoOriginal.Substring(0, 11);
        Console.WriteLine($"1. Subcadena (0, 11): '{subcadena}'");

        // IndexOf
        int posicion = textoOriginal.IndexOf("Universidad");
        Console.WriteLine($"2. Búsqueda de 'Universidad' (IndexOf): Índice {posicion}");

        // Replace
        string textoReemplazado = textoOriginal.Replace("UPN", "UPN Cajamarca");
        Console.WriteLine($"3. Reemplazo de texto: '{textoReemplazado}'");

        // Split
        string[] palabras = textoOriginal.Split(' ');
        Console.WriteLine($"4. Texto separado (split): [{string.Join(", ", palabras)}]\n");

        // ----------------------------------------------------------------------
        // PARTE 2: Arreglos paralelos
        // ----------------------------------------------------------------------
        Console.WriteLine("=== PARTE 2: ARREGLOS PARALELOS ===");
        string[] nombres = { "Cleiver", "María", "Carlos", "Ana" };
        int[] edades = { 20, 22, 19, 21 };

        string buscado = "Cleiver";
        bool encontrado = false;

        for (int i = 0; i < nombres.Length; i++)
        {
            if (nombres[i].Equals(buscado, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Persona encontrada: {nombres[i]} tiene {edades[i]} años.\n");
                encontrado = true;
                break;
            }
        }

        // ----------------------------------------------------------------------
        // PARTE 3: Estructura combinada y Búsqueda Textual
        // ----------------------------------------------------------------------
        Console.WriteLine("=== PARTE 3: ESTRUCTURA COMBINADA Y BÚSQUEDA TEXTUAL ===");
        var usuarios = new List<Usuario>
        {
            new Usuario { Nombre = "Cleiver Vasquez", Email = "cleiverr@example.com", Ciudad = "Cajamarca" },
            new Usuario { Nombre = "Adrian agular ", Email = "adrian@example.com", Ciudad = "Lima" },
            new Usuario { Nombre = "luis leon", Email = " luis@example.com", Ciudad = "Cajamarca" },
            new Usuario { Nombre = "alexis ocas", Email = "alexis@example.com", Ciudad = "Arequipa" }
        };

        string ciudadBuscar = "Cajamarca";
        Console.WriteLine($"Coincidencias encontradas para la ciudad '{ciudadBuscar}':");
        foreach (var u in usuarios)
        {
            if (u.Ciudad.Equals(ciudadBuscar, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($" - Nombre: {u.Nombre} | Email: {u.Email}");
            }
        }
        Console.WriteLine();

        // ----------------------------------------------------------------------
        // PARTE 4: Ordenamiento de Cadenas
        // ----------------------------------------------------------------------
        Console.WriteLine("=== PARTE 4: ORDENAMIENTO DE CADENAS ===");
        string[] listaNombres = new string[usuarios.Count];
        for (int i = 0; i < usuarios.Count; i++) listaNombres[i] = usuarios[i].Nombre;

        // Ordenamiento por método Burbuja
        for (int i = 0; i < listaNombres.Length - 1; i++)
        {
            for (int j = 0; j < listaNombres.Length - i - 1; j++)
            {
                if (string.Compare(listaNombres[j], listaNombres[j + 1], StringComparison.Ordinal) > 0)
                {
                    string temp = listaNombres[j];
                    listaNombres[j] = listaNombres[j + 1];
                    listaNombres[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Nombres ordenados alfabéticamente:");
        foreach (var nombre in listaNombres)
        {
            Console.WriteLine($" - {nombre}");
        }
    }
}

class Usuario
{
    public string Nombre { get; set; }
    public string Email { get; set; }
    public string Ciudad { get; set; }
}
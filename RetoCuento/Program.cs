using System;
using System.IO;

// Archivo de cuento
string cuentoPath = "Cuento.txt";
string salida = "";
string resultadosPath = "resultado.txt";

// Si el archivo no existe, mensaje de error y salir
if (!File.Exists(cuentoPath))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("No se encontró 'Cuento.txt' en el directorio actual.");
    Console.ResetColor();
    return;
}

// Leer el cuento completo
string cuento = File.ReadAllText(cuentoPath);

// Crear/limpiar el archivo de resultados
File.WriteAllText(resultadosPath, "=== RESULTADOS DE LOS RETOS ===\n\n");

// Función auxiliar para imprimir y guardar
void MostrarResultado(string reto, string mensaje)
{
    Console.WriteLine($"{reto}: {mensaje}");
    File.AppendAllText(resultadosPath, $"{reto}: {mensaje}\n\n");
}

// ===== RETO 1: string.Concat() =====
salida = string.Concat("Bitín", " ", "Explorador");
MostrarResultado("RETO 1", salida);

// ===== RETO 2: string.Join() =====
string[] oraciones = cuento.Split('.', StringSplitOptions.None);
salida = string.Join(" | ", oraciones);
MostrarResultado("RETO 2", salida);

// ===== RETO 3: string.Format() =====
int caracteres = cuento.Length;
int palabras = cuento.Split(new[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;
salida = string.Format("El cuento tiene {0} caracteres y {1} palabras", caracteres, palabras);
MostrarResultado("RETO 3", salida);

// ===== RETO 4: string.Interpolation =====
string nombre = "Bitín";
string meta = "descifrar patrones";
salida = $"El protagonista es {nombre} y busca {meta}";
MostrarResultado("RETO 4", salida);

// ===== RETO 5: Convert.ToString() =====
salida = "La longitud del cuento es: " + Convert.ToString(cuento.Length);
MostrarResultado("RETO 5", salida);

// ===== RETO 6: IndexOf() =====
int posMundo = cuento.IndexOf("mundo", StringComparison.OrdinalIgnoreCase);
salida = "Primera posición de 'mundo': " + posMundo;
MostrarResultado("RETO 6", salida);

// ===== RETO 7: LastIndexOf() =====
int posCeros = cuento.LastIndexOf("ceros", StringComparison.OrdinalIgnoreCase);
salida = "Última posición de 'ceros': " + posCeros;
MostrarResultado("RETO 7", salida);

// ===== RETO 8: Contains() =====
salida = cuento.Contains("Nube") ? "Sí contiene 'Nube'" : "No contiene 'Nube'";
MostrarResultado("RETO 8", salida);

// ===== RETO 9: StartsWith() =====
salida = cuento.TrimStart().StartsWith("En el vasto universo") ? "Sí inicia así" : "No inicia así";
MostrarResultado("RETO 9", salida);

// ===== RETO 10: EndsWith() =====
salida = cuento.TrimEnd().EndsWith("ceros y unos.") ? "Sí termina así" : "No termina así";
MostrarResultado("RETO 10", salida);

// ===== RETO 11: Substring() =====
int idx = cuento.IndexOf("ciudades luminosas");
salida = (idx >= 0) ? cuento.Substring(idx, "ciudades luminosas".Length) : "No encontrado";
MostrarResultado("RETO 11", salida);

// ===== RETO 12: Remove() =====
salida = cuento.Length > 15 ? cuento.Remove(0, 15) : cuento;
MostrarResultado("RETO 12", salida);

// ===== RETO 13: Replace() =====
salida = cuento.Replace("Bitín", "ProgramaX");
MostrarResultado("RETO 13", salida);

// ===== RETO 14: Insert() =====
int idxFirewall = cuento.IndexOf("firewall");
salida = idxFirewall >= 0 ? cuento.Insert(idxFirewall + "firewall".Length, " (IMPORTANTE)") : cuento;
MostrarResultado("RETO 14", salida);

// ===== RETO 15: PadLeft() =====
salida = "Bitín".PadLeft(10, '+');
MostrarResultado("RETO 15", salida);

// ===== RETO 16: PadRight() =====
salida = "Nube".PadRight(12, '-');
MostrarResultado("RETO 16", salida);

// ===== RETO 17: Trim() =====
salida = " firewall ".Trim();
MostrarResultado("RETO 17", salida);

// ===== RETO 18: TrimStart() =====
salida = " Mundo binario".TrimStart();
MostrarResultado("RETO 18", salida);

// ===== RETO 19: TrimEnd() =====
salida = "Bitín explorador ".TrimEnd();
MostrarResultado("RETO 19", salida);

// ===== RETO 20: Split() =====
string[] palabrasArray = cuento.Split(new[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
salida = string.Join(" ", palabrasArray[..Math.Min(10, palabrasArray.Length)]);
MostrarResultado("RETO 20", salida);

// ===== RETO 21: Equals() =====
salida = "Nube".Equals("nube") ? "Iguales" : "Diferentes";
MostrarResultado("RETO 21", salida);

// ===== RETO 22: Compare() =====
int cmp1 = string.Compare("Bitín", "Firewall", StringComparison.CurrentCulture);
salida = cmp1 < 0 ? "Bitín va primero" : cmp1 > 0 ? "Firewall va primero" : "Son iguales";
MostrarResultado("RETO 22", salida);

// ===== RETO 23: CompareTo() =====
int cmp2 = "Nube".CompareTo("Cielo");
salida = cmp2 < 0 ? "'Nube' va antes que 'Cielo'" : cmp2 > 0 ? "'Nube' va después de 'Cielo'" : "Son iguales";
MostrarResultado("RETO 23", salida);

// ===== RETO 24: IsNullOrEmpty() =====
salida = string.IsNullOrEmpty("") ? "Sí está vacía" : "No está vacía";
MostrarResultado("RETO 24", salida);

// ===== RETO 25: IsNullOrWhiteSpace() =====
salida = string.IsNullOrWhiteSpace("   ") ? "Sí son solo espacios" : "No";
MostrarResultado("RETO 25", salida);

// ===== RETO 26: ToLower() =====
salida = cuento.ToLower();
MostrarResultado("RETO 26", salida);

// ===== RETO 27: ToUpper() =====
salida = cuento.ToUpper();
MostrarResultado("RETO 27", salida);

// ===== RETO 28: ToLowerInvariant() =====
salida = "NUBE".ToLowerInvariant();
MostrarResultado("RETO 28", salida);

// ===== RETO 29: ToUpperInvariant() =====
salida = "bitín".ToUpperInvariant();
MostrarResultado("RETO 29", salida);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"\nTodos los retos se resolvieron. Revisa '{resultadosPath}' para ver los resultados guardados.");
Console.ResetColor();

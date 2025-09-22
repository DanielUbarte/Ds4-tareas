
// Archivo de cuento
string cuentoPath = "Cuento.txt";
string salida = "";
string resultadosPath = "resultado.txt";

// Si el archivo no existe, mensaje de error y salir
if (!File.Exists(cuentoPath))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("No se encontró 'Cuento.txt' en el directorio actual.");
}

// Leer el cuento completo
string cuento = File.ReadAllText(cuentoPath);

// Crear o limpiar el archivo de resultados
File.WriteAllText(resultadosPath, "=== RESULTADOS DE LOS RETOS ===\n\n");

// ===== RETO 1: string.Concat() =====
salida = string.Concat("Bitín", " ", "Explorador");
Console.WriteLine("RETO 1: " + salida);//mostrar resultado en consola
File.AppendAllText(resultadosPath, "RETO 1: " + salida + "\n\n"); //registrar resultado en el archivo

// ===== RETO 2: string.Join() =====
string[] oraciones = cuento.Split('.', StringSplitOptions.None); // Dividir el cuento en oraciones
salida = string.Join(" | ", oraciones); // Unir las oraciones con " | "
Console.WriteLine("RETO 2: " + salida); //mostrar resultado en consola
File.AppendAllText(resultadosPath, "RETO 2: " + salida + "\n\n"); //registrar resultado en el archivo

// ===== RETO 3: string.Format() =====
int caracteres = cuento.Length; // Contar caracteres
int palabras = cuento.Split(new[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length; // Contar palabras
salida = string.Format("El cuento tiene {0} caracteres y {1} palabras", caracteres, palabras); // Formatear la salida
Console.WriteLine("RETO 3: " + salida); //mostrar resultado en consola
File.AppendAllText(resultadosPath, "RETO 3: " + salida + "\n\n"); //registrar resultado en el archivo

// ===== RETO 4: string.Interpolation =====
string nombre = "Bitín"; // Nombre del protagonista
string meta = "descifrar patrones"; // Meta del protagonista
salida = $"El protagonista es {nombre} y busca {meta}";// Interpolación de cadenas
Console.WriteLine("RETO 4: " + salida); 
File.AppendAllText(resultadosPath, "RETO 4: " + salida + "\n\n");  //registrar resultado en el archivo

// ===== RETO 5: Convert.ToString() =====
salida = "La longitud del cuento es: " + Convert.ToString(cuento.Length);// Convertir número a cadena
Console.WriteLine("RETO 5: " + salida);
File.AppendAllText(resultadosPath, "RETO 5: " + salida + "\n\n"); 

// ===== RETO 6: IndexOf() =====
int posMundo = cuento.IndexOf("mundo", StringComparison.OrdinalIgnoreCase);// Buscar posición de "mundo"
salida = "Primera posición de 'mundo': " + posMundo;
Console.WriteLine("RETO 6: " + salida);
File.AppendAllText(resultadosPath, "RETO 6: " + salida + "\n\n");

// ===== RETO 7: LastIndexOf() =====
int posCeros = cuento.LastIndexOf("ceros", StringComparison.OrdinalIgnoreCase);// Buscar última posición de "ceros"
salida = "Última posición de 'ceros': " + posCeros;
Console.WriteLine("RETO 7: " + salida);
File.AppendAllText(resultadosPath, "RETO 7: " + salida + "\n\n");

// ===== RETO 8: Contains() =====
salida = cuento.Contains("Nube") ? "Sí contiene 'Nube'" : "No contiene 'Nube'";// Verificar si contiene "Nube"
Console.WriteLine("RETO 8: " + salida);
File.AppendAllText(resultadosPath, "RETO 8: " + salida + "\n\n");

// ===== RETO 9: StartsWith() =====
salida = cuento.TrimStart().StartsWith("En el vasto universo") ? "Sí inicia así" : "No inicia así";// Verificar si inicia con "En el vasto universo"
Console.WriteLine("RETO 9: " + salida);
File.AppendAllText(resultadosPath, "RETO 9: " + salida + "\n\n");

// ===== RETO 10: EndsWith() =====
salida = cuento.TrimEnd().EndsWith("ceros y unos.") ? "Sí termina así" : "No termina así";// Verificar si termina con "ceros y unos."
Console.WriteLine("RETO 10: " + salida);
File.AppendAllText(resultadosPath, "RETO 10: " + salida + "\n\n");

// ===== RETO 11: Substring() =====
int idx = cuento.IndexOf("ciudades luminosas");
salida = (idx >= 0) ? cuento.Substring(idx, "ciudades luminosas".Length) : "No encontrado";// Extraer "ciudades luminosas"
Console.WriteLine("RETO 11: " + salida);
File.AppendAllText(resultadosPath, "RETO 11: " + salida + "\n\n");

// ===== RETO 12: Remove() =====
salida = cuento.Length > 15 ? cuento.Remove(0, 15) : cuento;// Eliminar los primeros 15 caracteres
Console.WriteLine("RETO 12: " + salida);
File.AppendAllText(resultadosPath, "RETO 12: " + salida + "\n\n");

// ===== RETO 13: Replace() =====
salida = cuento.Replace("Bitín", "ProgramaX");// Reemplazar "Bitín" por "ProgramaX"
Console.WriteLine("RETO 13: " + salida);
File.AppendAllText(resultadosPath, "RETO 13: " + salida + "\n\n");

// ===== RETO 14: Insert() =====
int idxFirewall = cuento.IndexOf("firewall");// Buscar "firewall"
salida = idxFirewall >= 0 ? cuento.Insert(idxFirewall + "firewall".Length, " (IMPORTANTE)") : cuento;
Console.WriteLine("RETO 14: " + salida);
File.AppendAllText(resultadosPath, "RETO 14: " + salida + "\n\n");

// ===== RETO 15: PadLeft() =====
salida = "Bitín".PadLeft(10, '+');// Rellenar a la izquierda con '+'
Console.WriteLine("RETO 15: " + salida);
File.AppendAllText(resultadosPath, "RETO 15: " + salida + "\n\n");

// ===== RETO 16: PadRight() =====
salida = "Nube".PadRight(12, '-');// Rellenar a la derecha con '-'
Console.WriteLine("RETO 16: " + salida);
File.AppendAllText(resultadosPath, "RETO 16: " + salida + "\n\n");

// ===== RETO 17: Trim() =====
salida = " firewall ".Trim();// Eliminar espacios en ambos extremos
Console.WriteLine("RETO 17: " + salida);
File.AppendAllText(resultadosPath, "RETO 17: " + salida + "\n\n");

// ===== RETO 18: TrimStart() =====
salida = " Mundo binario".TrimStart();// Eliminar espacios al inicio
Console.WriteLine("RETO 18: " + salida);
File.AppendAllText(resultadosPath, "RETO 18: " + salida + "\n\n");

// ===== RETO 19: TrimEnd() =====
salida = "Bitín explorador ".TrimEnd();// Eliminar espacios al final
Console.WriteLine("RETO 19: " + salida);
File.AppendAllText(resultadosPath, "RETO 19: " + salida + "\n\n");

// ===== RETO 20: Split() =====
string[] palabrasArray = cuento.Split(new[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);// Dividir en palabras
salida = string.Join(" ", palabrasArray[..Math.Min(10, palabrasArray.Length)]);
Console.WriteLine("RETO 20: " + salida);
File.AppendAllText(resultadosPath, "RETO 20: " + salida + "\n\n");

// ===== RETO 21: Equals() =====
salida = "Nube".Equals("nube") ? "Iguales" : "Diferentes";// Comparar "Nube" y "nube"
Console.WriteLine("RETO 21: " + salida);
File.AppendAllText(resultadosPath, "RETO 21: " + salida + "\n\n");

// ===== RETO 22: Compare() =====
int cmp1 = string.Compare("Bitín", "Firewall", StringComparison.CurrentCulture);// Comparar "Bitín" y "Firewall"
salida = cmp1 < 0 ? "Bitín va primero" : cmp1 > 0 ? "Firewall va primero" : "Son iguales";
Console.WriteLine("RETO 22: " + salida);
File.AppendAllText(resultadosPath, "RETO 22: " + salida + "\n\n");

// ===== RETO 23: CompareTo() =====
int cmp2 = "Nube".CompareTo("Cielo");// Comparar "Nube" y "Cielo"
salida = cmp2 < 0 ? "'Nube' va antes que 'Cielo'" : cmp2 > 0 ? "'Nube' va después de 'Cielo'" : "Son iguales";
Console.WriteLine("RETO 23: " + salida);
File.AppendAllText(resultadosPath, "RETO 23: " + salida + "\n\n");

// ===== RETO 24: IsNullOrEmpty() =====
salida = string.IsNullOrEmpty("") ? "Sí está vacía" : "No está vacía";// Verificar si cadena está vacía
Console.WriteLine("RETO 24: " + salida);
File.AppendAllText(resultadosPath, "RETO 24: " + salida + "\n\n");

// ===== RETO 25: IsNullOrWhiteSpace() =====
salida = string.IsNullOrWhiteSpace("   ") ? "Sí son solo espacios" : "No";// Verificar si cadena tiene solo espacios
Console.WriteLine("RETO 25: " + salida);
File.AppendAllText(resultadosPath, "RETO 25: " + salida + "\n\n");

// ===== RETO 26: ToLower() =====
salida = cuento.ToLower();// Convertir todo a minúsculas
Console.WriteLine("RETO 26: " + salida);
File.AppendAllText(resultadosPath, "RETO 26: " + salida + "\n\n");

// ===== RETO 27: ToUpper() =====
salida = cuento.ToUpper();// Convertir todo a mayúsculas
Console.WriteLine("RETO 27: " + salida);
File.AppendAllText(resultadosPath, "RETO 27: " + salida + "\n\n");

// ===== RETO 28: ToLowerInvariant() =====
salida = "NUBE".ToLowerInvariant();// Convertir "NUBE" a minúsculas invariablemente
Console.WriteLine("RETO 28: " + salida);
File.AppendAllText(resultadosPath, "RETO 28: " + salida + "\n\n");

// ===== RETO 29: ToUpperInvariant() =====
salida = "bitín".ToUpperInvariant();// Convertir "bitín" a mayúsculas invariablemente
Console.WriteLine("RETO 29: " + salida);
File.AppendAllText(resultadosPath, "RETO 29: " + salida + "\n\n");

Console.WriteLine($"\nTodos los retos se resolvieron. Revisa '{resultadosPath}' para ver los resultados guardados.");
Console.ResetColor();


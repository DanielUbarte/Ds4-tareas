// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//video 18

LinqQueries queries = new LinqQueries();//instancia de la clase LinqQueries
//toda la coleccion
//ImprimirValores(queries.TodaLaColeccion()); //imprime toda la coleccion de libros

//libros despues del 2000
//ImprimirValores(queries.LibrosDespuesDel2000()); //imprime los libros despues del 2000

//libros con mas de 250 paginas y con palabras in action
//Console.WriteLine("Libros con mas de 250 paginas");
//ImprimirValores(queries.librosConMasDe250pagConPalabrasInAction());

//todos los libros tienen status
//Console.WriteLine();
//Console.WriteLine($"Todos los libros tienen status? {queries.TodosLosLibrosTienenStatus()}");
//Console.WriteLine();

//algun libro fue publicado en 2005
//Console.WriteLine($"Algun libro fue publicado en 2005? {queries.SiAlgunLibroFuePublicado2005()}");
//Console.WriteLine();

//libros de python
//Console.WriteLine("Muestra los libros de python");
//ImprimirValores(queries.LibrosDePython());
//Console.WriteLine();

//libros de java por nombre ascendente
//Console.WriteLine("Libros de java de forma ascendente");
//ImprimirValores(queries.LibrosDeJavaPorNombreAscendente());
//Console.WriteLine();

//libros de mas de 450 paginas
//Console.WriteLine("Libros con más de 450 páginas");
//ImprimirValores(queries.LibrosDeMasDe450pagOrdenadoPorNumPagDescendente());
//Console.WriteLine();

//tres primeros libros
//Console.WriteLine("Libros ordenados por fecha");
//ImprimirValores(queries.TresPrimerosLibrosOrdenadoPorFecha());
//Console.WriteLine();

//mostrar el tercer y cuarto libro
//Console.WriteLine("tercer y cuarto libro de 400 páginas");
//ImprimirValores(queries.TerceryCuartoLibroDeMasDe400Pag());
//Console.WriteLine();

//tres primeros libros con select
//Console.WriteLine("Los tres primeros libros de la colección");
//ImprimirValores(queries.TresPrimerosLibrosDeLaColeccion());

//Console.WriteLine($"Cantidad de libros que tiene entre 200 y 500 pg");
//Console.WriteLine(queries.CantidadDeLibrosEntre200y500pag());

//fecha de publicacion menor de todos los libros
//Console.WriteLine($"Fecha de publicacion menor de todos los libros: {queries.FechaDePublicacionMenor()}");

//numero de paginas del libro con mayor numero de paginas
Console.WriteLine($"Número de páginas del libro con mayor número de páginas: {queries.NumeroDePagLibroMayor()}");

void ImprimirValores(IEnumerable<book> listalibros) //metodo para imprimir los valores en consola
{
    //Muestra los titulos de las columnas
    Console.WriteLine("{0, -60} {1, 15} {2, 15}", "Titulo", "N. Paginas", "Fecha publicacion");
    foreach (var item in listalibros)
    {
        //Muestra los valores en consola
        Console.WriteLine("{0, -60} {1, 15} {2, 15}", item.Title, item.PageCount, item.PublishedDate.ToShortDateString());
    }
}
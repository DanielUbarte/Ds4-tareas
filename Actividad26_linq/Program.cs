// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//video 12

LinqQueries queries = new LinqQueries();//instancia de la clase LinqQueries
//toda la coleccion
//ImprimirValores(queries.TodaLaColeccion()); //imprime toda la coleccion de libros

//libros despues del 2000
//ImprimirValores(queries.LibrosDespuesDel2000()); //imprime los libros despues del 2000

//libros con mas de 250 paginas y con palabras in action
//ImprimirValores(queries.librosConMasDe250pagConPalabrasInAction());

//todos los libros tienen status
//Console.WriteLine($"Todos los libros tienen status? {queries.TodosLosLibrosTienenStatus()}");

//algun libro fue publicado en 2005
//Console.WriteLine($"Algun libro fue publicado en 2005? {queries.SiAlgunLibroFuePublicado2005()}");

//libros de python
ImprimirValores(queries.LibrosDePython());

void ImprimirValores(IEnumerable<book> listalibros) //metodo para imprimir los valores en consola
{
    //Muestra los titulos de las columnas
    Console.WriteLine("{0, -60} {1, 15} {2, 15}", "Titulo", "N. Paginas", "Fecha publicacion");
    foreach(var item in listalibros)
    {
        //Muestra los valores en consola
        Console.WriteLine("{0, -60} {1, 15} {2, 15}", item.Title, item.PageCount, item.PublishedDate.ToShortDateString());
    }
}


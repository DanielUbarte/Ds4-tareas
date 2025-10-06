using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

    public class LinqQueries
    {
        private List<book> librosCollection = new List<book>(); //lista de libros
    public LinqQueries()
        {
        string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\books.json");
        using (StreamReader reader = new StreamReader(path)) //lee el archivo json
        {
            string json = reader.ReadToEnd(); //lee todo el contenido del archivo
            //deserializa el json a una lista de libros
            this.librosCollection = System.Text.Json.JsonSerializer.Deserialize<List<book>>(json, new System.Text.Json.JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
        }
        public IEnumerable<book> TodaLaColeccion()//retorna toda la coleccion de libros 
        {
            return librosCollection;
        }
        public IEnumerable<book> LibrosDespuesDel2000()  //reto where
        {
        //return librosCollection.Where(p=> p.PublishedDate.Year > 2000);
        //query epresion
        return from l in librosCollection where l.PublishedDate.Year > 2000 select l;
        }
     
        public IEnumerable<book> librosConMasDe250pagConPalabrasInAction() 
        {
        //extension methods
        //return librosCollection.Where(p => p.PageCount > 250 && p.Title.Contains("in Action"));

        //query expression
        return from l in librosCollection where l.PageCount > 250 && l.Title.Contains("in Action") select l;
        }

        public bool TodosLosLibrosTienenStatus()
        {
        return librosCollection.All(p => p.Status != string.Empty);   
        }

        public bool SiAlgunLibroFuePublicado2005()
        {
        return librosCollection.Any(p => p.PublishedDate.Year == 2005);
        }

        public IEnumerable<book> LibrosDePython()
        {
        return librosCollection.Where(p => p.Categories.Contains("Python"));
        }

        public IEnumerable<book> LibrosDeJavaPorNombreAscendente()
        { 
            return librosCollection.Where(p=> p.Categories.Contains("Java")).OrderBy(p=> p.Title);
        }

        public IEnumerable<book> LibrosDeMasDe450pagOrdenadoPorNumPagDescendente()
        {
            return librosCollection.Where(p=> p.PageCount > 450).OrderByDescending(p=> p.PageCount);
        }

        public IEnumerable<book> TresPrimerosLibrosOrdenadoPorFecha()
        {
            return librosCollection.Where(p => p.Categories.Contains("Java"))
            .OrderBy(p=> p.PublishedDate)
            .TakeLast(3);
        }

        public IEnumerable<book> TerceryCuartoLibroDeMasDe400Pag()
        {
            return librosCollection.Where(p=> p.PageCount > 400)
            .Take(4)
            .Skip(2);
    }

}


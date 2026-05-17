// Clase
class Language {
    // Variables locales (private)
    private string nom;
    private int anio;

    // Metodo constructor
    public Language(string _nom, int _anio) {
        // Asignar parametros a variables locales
        this.nom = _nom;
        this.anio = _anio;
    }

    // Metodo publico 'desc'
    public void desc () {
        // Imprime la descripcion del lenguaje
        Console.WriteLine($"{this.nom} fue creado en {this.anio}");
    }
}


// --- En otro archivo -------------------------------------

// Crear nuevo objeto con la clase 'Language'
Language html = new Language("HTML", 1993);
html.desc(); // Llamar al metodo 'desc' del objeto 'html'

// Diccionario de objetos 'Language'
Dictionary<string, Language> langs = new Dictionary<string, Language>();
langs.Add("c++", new Language("C++", 1979));
langs.Add("css", new Language("CSS", 1996));
langs.Add("js", new Language("JavaScript", 1995));

// Llamar al metodo 'desc' de cada llave
langs["c++"].desc();
langs["css"].desc();
langs["js"].desc();
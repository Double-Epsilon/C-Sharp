// --- Datos genericos ---------------------------
// Son tipos de datos que puedes asignar a voluntad, sin la necesidad de establecer uno especifico
// Sirven para hacer estructuras que pueden tomar diferentes tipos de valores

// Declaramos listas con tipos de dato diferentes
var nums = new MyList<int>(3); // Generic = int
var names = new MyList<string>(4); // Generic = string
var people = new MyList<Person>(2); // Generic = Class 'Person'

// Agregamos numeros con el metodo 'Add'
nums.Add(1);
nums.Add(2);
nums.Add(3);
nums.Add(4);

// Agregamos strings con el metodo 'Add'
names.Add("a");
names.Add("b");
names.Add("c");
names.Add("d");
names.Add("e");

// Agregamos 'Person's con el metodo 'Add'
people.Add(new Person() {
    name = "Juanito", age = 15
});
people.Add(new Person() {
    name = "Pedrito", age = 18
});
people.Add(new Person() {
    name = "Anastasio", age = 1
});

// Llamamos al metodo 'GetContent' de cada lista
Console.WriteLine(nums.GetContent());
Console.WriteLine(names.GetContent());
Console.WriteLine(people.GetContent());


// Clase 'MyList' de tipo de dato generico (T)
public class MyList <T> {
    private List<T> list; // Lista de tipo de dato generico
    private int limit; // Tamaño maximo de la lista

    // Metodo constructor
    public MyList (int _limit) {
        list = new List<T>(); // Creamos una nueva lista de tipo generico
        this.limit = _limit;
    }

    // Metodo 'Add' (Agrega un elemento generico a la lista)
    public void Add (T element) {
        // Si todavia hay espacio, agregamos a la lista
        if (list.Count < limit) {
            list.Add(element);
            Console.WriteLine($"{element} fue agregado a la lista");
        // Si no, no agregamos
        } else {
            Console.WriteLine($"Limite excedido. {element} no fue agregado a la lista");
        }
    }

    // Metodo 'GetContent' (Retorna los elementos de la lista)
    public string GetContent () {
        string content = ""; // Aqui guardamos el contenido
        // Iteramos por todos los elementos de la lista
        foreach (var element in list) {
            // Agregamos a 'content' y separamos por coma
            content += element + ", ";
        }

        return content; // Retornamos 'content'
    }
}

// Clase 'Person'
public class Person {
    public string name;
    public int age;

    // Sobreescribimos la funcion preintegrada 'ToString'
    public override string ToString () {
        // Retornamos el nombre y la edad de la persona
        return $"[Name: {name}, Age: {age}]";
    }
}


// When eres la letra 'T':
// Bro q generico de tu parte
// (q horrible chiste)
// --- Consola -------------------------------
// Escribir en consola
Console.WriteLine("Hola Mundo");
// Escribir en consola (texto + variables)
string name = "homo sapiens";
Console.WriteLine("Hola " + name + "!");
// Escribir en consola (variables dentro de texto)
Console.WriteLine($"Como estas {name}?");


// --- Variables -------------------------------
int entero = 2; // Enteros
float flotate = 1.2345F; // Decimales poco precisos (con 'F' al final del numero)
decimal dec = 1.2345M; // Decimales muy precisos (con 'M' al final del numero)
string palabra = "Hola Gente"; // Cadenas
bool booleano = true; // Booleanos

// Constantes 
const float pi = 3.1416F;


// --- Operadores -------------------------------
Console.WriteLine(1 < 2); // Menor que (en este caso: true)
Console.WriteLine(1 > 2); // Mayor que (en este caso: false)
Console.WriteLine(1 <= 2); // Menor o igual que (en este caso: true)
Console.WriteLine(1 >= 2); // Mayor o igual que (en este caso: false)
Console.WriteLine(1 == 2); // Igual que (en este caso: false)
Console.WriteLine(1 != 2); // Diferente que (en este caso: true)

Console.WriteLine(true && true); // Ambas condiciones cumplen
Console.WriteLine(true || false); // Al menos una condicion cumple


// --- Estructuras de datos -------------------------------
// Arreglos (memoria fija) (0-indexados)
int[] arr = {1, 2, 3, 4, 5}; // Inicializar con 5 elementos
Console.WriteLine(arr[0]); // Acceder a la posicion '0'

// Arreglo mixto ('dynamic')
dynamic[] mix = {8, "Ocho", 8.88F, true};


// Listas (memoria dinamica) (0-indexados)
List<int> list = new List<int> {6, 7, 8, 9, 10}; // Crear nueva lista inicializada con 5 elementos
Console.WriteLine(list[0]); // Acceder a la posicion '0'
// 'string.Join(separator, List)' : Separa los elementos de una lista por medio del 'separator'
Console.WriteLine(string.Join(",", list));


// Diccionarios (pares de llave - valor)
Dictionary<int, string> dicc = new Dictionary<int, string>(); // Crear nuevo diccionario vacio
// '.Add(key, value)' : Agregar un nuevo par al diccionario ('key' - 'value')
dicc.Add(10, "Pedrito");
dicc.Add(8, "Juanito");
Console.WriteLine(dicc[10]); // Acceder al valor con llave '10'

// Podemos mezclar estructuras de datos
// Diccionario de 'key = string' , 'value = array'
Dictionary<string, string[]> emails = new Dictionary<string, string[]>();

// Crear un nuevo arreglo
string[] emailsPedro = {"pedro@gmail.com", "pedro@outlook.com"};
// Agregar un nuevo par al diccionario
emails.Add("Pedro", emailsPedro);

string[] emailsJuan = {"juan@gmail.com", "juan@hotmail.com"};
emails.Add("Juan", emailsJuan);

// Separar e imprimir los elementos dentro del arreglo en la llave 'Juan'
Console.WriteLine(string.Join(", ", emails["Juan"]));
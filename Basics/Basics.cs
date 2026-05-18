// Escribir en consola
Console.WriteLine("Hola Mundo");
// Escribir en consola (texto + variables)
string name = "homo sapiens"
Console.WriteLine("Hola " + name + "!");
// Escribir en consola (variables dentro de texto)
Console.WriteLine($"Como estas {name}?");

// Tipos de variables
int entero = 2; // Enteros
decimal dec = 1.2345m; // Decimales (con 'm' al final del numero)
float flotate = 1.2345F; // Decimales (con 'F' al final del numero)
string palabra = "Hola Gente"; // Cadenas
bool booleano = true; // Booleanos

// Constantes 
const float pi = 3.1416F;

// Operadores
Console.WriteLine(1 < 2); // Menor que
Console.WriteLine(1 > 2); // Mayor que
Console.WriteLine(1 <= 2); // Menor o igual que
Console.WriteLine(1 >= 2); // Mayor o igual que
Console.WriteLine(1 == 2); // Igual que
Console.WriteLine(1 != 2); // Diferente que

Console.WriteLine(true && true); // Ambas condiciones cumplen
Console.WriteLine(true || false); // Al menos una condicion cumple

// Arreglos (memoria fija)
int[] arr = {1, 2, 3, 4, 5};
Console.WriteLine(arr[0]);

// Listas (memoria dinamica)
List<int> list = new List<int> {6, 7, 8, 9, 10};
Console.WriteLine(list[0]);
Console.WriteLine(string.Join(",", list));

// Arreglo mixto ('dynamic')
dynamic[] mix = {8, "Ocho", 8.88, true};

// Diccionarios (llave - valor)
Dictionary<int, string> dicc = new Dictionary<int, string>();
dicc.Add(10, "Pedrito");
dicc.Add(8, "Juanito");
Console.WriteLine(dicc[10]);

Dictionary<string, string[]> emails = new Dictionary<string, string[]>();
string[] emailsPedro = {"pedro@gmail.com", "pedro@outlook.com"};
emails.Add("Pedro", emailsPedro);
string[] emailsJuan = {"juan@gmail.com", "juan@hotmail.com"};
emails.Add("Juan", emailsJuan);
Console.WriteLine(string.Join(", ", emails["Juan"]));
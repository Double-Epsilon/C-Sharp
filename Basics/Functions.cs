// --- Funciones -----------------------------

// 'tipo' 'nombre' ('parametros') {}
int sumar (int a, int b) { // Los parametros son variables locales
    return a + b; // Retornar resultado de esta funcion
}

int res = sumar(3, 4); // Llamar a la funcion y almacenarla en una variable
Console.WriteLine(res); // Imprimir resultado

// Multiplicar
int mult (int a, int b) {
    return a * b;
}

// Imprimir directamente valor regresado por la funcion
Console.WriteLine(mult(6, 7));

// Funcion 'void' (no retorna valor)
void saludar (string nom) {
    // Imprimir texto + variable
    // ($"texto {variable}")
    Console.WriteLine($"Hola {nom}");
}

string my_name = "Persona";
saludar(my_name); // Llamar funcion con variable de parametro


// --- Funciones Lambda ---------------------------------------
// Para funciones que no retornan :
// Action <tipos de dato parametros> nombre (parametros)

// Para funciones que retornan :
// Func <tipos de dato parametros, tipo de dato retorno> nombre (parametros)

// Funcion lambda que imprime algo (no retorna nada)
Action <string> sayhi = (name) => {
    Console.WriteLine($"Hi {name}!");
};

// Funcion lambda que retorna la suma de 2 enteros
Func <int, int, int> sum = (a, b) => a + b;

// Funcion lambda que retorna el cuadrado de un entero
Func <int, int> sqrt = (a) => a * a;

// Llamamos a las funciones lambda
sayhi("stegosaurus");
Console.WriteLine(sum(2, 3));
Console.WriteLine(sqrt(6));


// --- Uso chido de las lambda -------------------------
// Puedes utilizarlas para pasar funciones como parametros

// Llamamos a la funcion 'algo' con una funcion lambda como parametro
// En este caso, la funcion lambda retorna 'a+b'
algo((a, b) => a + b, 5);

// Funcion que ocupa otra funcion como parametro
void algo (Func <int, int, int> fn, int num) {
    // Llamamos a la funcion 'fn' (su comportamiento esta establecido por la funcion parametro)
    int res = fn(num, num);
    // Imprimimos resultado
    Console.WriteLine(res);
}
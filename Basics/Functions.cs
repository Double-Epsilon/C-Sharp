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


// No se we, una funcion que ordena cosillas =P
// Ordenamiento "quicksort"
List<int> quicksort (List<int> lista) { // Recibimos una lista como parametro
    // list.Count : Retorna la cantidad de elementos en la lista 
    if (lista.Count <= 1) { // Si solo hay 1 elemento, retornamos asi nomas
        return lista;
    }

    int pivote = lista[0]; // Pivote (comparador de si es menor o mayor)
    List<int> izq = new List<int>(); // Lista izquierda (menores a 'pivote')
    List<int> der = new List<int>(); // Lista derecha (mayores o iguales a 'pivote')

    // Iterar todos los elementos de la lista (excluyendo al pivote)
    for (int i=1; i<lista.Count; i++) {
        if (lista[i] < pivote) { // Si '[i]' es menor a 'pivote', agregamos a 'izq'
            izq.Add(lista[i]);
        } else { // Si '[i]' es mayor o igual a 'pivote', agregamos a 'der'
            der.Add(lista[i]);
        }
    }

    List<int> first = quicksort(izq); // Ordenamos los elementos menores
    List<int> mid = new List<int> {pivote}; // Mantenemos el pivote a la mitad
    List<int> second = quicksort(der); // Ordenamos los elementos mayores

    first.AddRange(mid); // Agregamos el pivote
    first.AddRange(second); // Agregamos 'der' ya ordenado
    return first; // Retornamos 'first' (menores ordenados + pivote + mayores ordenados)
}

List<int> numeros = new List<int> {54, 29, 17, 88, 10, 1, 245};
List<int> numsOrdenado = quicksort(numeros); // Llamar a 'quicksort' con 'numeros' de parametro
Console.WriteLine(string.Join(", ", numsOrdenado)); // Imprimir lista ordenada
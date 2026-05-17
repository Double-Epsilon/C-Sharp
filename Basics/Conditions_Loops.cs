
// --- Condicionales ------------------------
bool autorizado = true;

// if / else
if (autorizado) { // Cumple la condicion
    Console.WriteLine("Puede ingresar");
} else { // No cumple la condicion
    Console.WriteLine("No puede ingresar");
}

// ------------------------------------
int entero = 101;

// if / else if / else
if (entero == 99) { // Cumple la 1ra condicion
    Console.WriteLine("Es 99");
}
else if (entero == 100) { // Cumple la 2da condicion, pero no la 1ra
    Console.WriteLine("Es 100");
}
else { // No cumple ninguna condicion
    Console.WriteLine("Ni 99 ni 100 :(");
}

// ---------------------------------------
string color = "amarillo";

// switch
switch (color) {
    case "verde": // Si 'color' es "verde"
        Console.WriteLine("Exito!");
        break; // Termina condicion
    case "amarillo": // Si 'color' es "amarillo"
        Console.WriteLine("Error minimo!");
        break;
    case "rojo": // Si 'color' es "rojo"
        Console.WriteLine("Error fatal!");
        break;
    default: // Si 'color' es cualquier otro valor no especificado
        Console.WriteLine("Error!");
        break;
}


// --- Ciclos -----------------------------------

// for
for (int i=0; i<5; i++) { // Iniciamos en '0', hasta que 'i < 5', aumentamos 'i + 1'
    Console.WriteLine(i); // Numeros del '0' al '4'
}

// ------------------------------------------------
string[] animales = {"perro", "gato", "pejelagarto"};

// foreach
foreach (string animal in animales) { // Iterar sobre todos los elementos de un arreglo
    Console.WriteLine(animal);
}

// ------------------------------------------------
int entero2 = 1;
int final = 10;

// while
while (entero2 <= final) { // Mientras 'entero' sea menor o igual a 'final'
    Console.WriteLine(entero2);
    entero2++; // Incrementar en 1 (+1)
}

// -----------------------------------------------
int idx = 100;

// do / while
do { // Hacemos minimo una vez
    Console.WriteLine(idx);
    idx += 10;
} while (idx < 150); // Revisamos condicion despues de hacer todo

// -----------------------------------------------
int num = 0;

// continue / break
while (true) {
    num++;

    // Si 'num' es par
    if (num % 2 == 0) {
        continue; // Nos saltamos todo lo demas
    }
    Console.WriteLine(num); // Imprimir 'num' (solo si no pasamos por 'continue')

    // Si 'num' es igual a '5'
    if (num >= 5) {
        break; // Rompemos el ciclo por completo
    }
}
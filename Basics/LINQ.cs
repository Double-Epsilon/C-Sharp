// --- LINQ -------------------------------------------
// Para realizar consultas, filtrados y transformaciones de datos
// Es parecido a SQL

// Lista de strings
var names = new List<string>() {
    "Juan", "Pedro", "Antonio", "Petronio", "Panfilo"
};

// Ordenar en orden ascendiente
// from 'n': Nombre identificador de los datos ('n')
// in 'data': De donde sacar los datos ('data')
// orderby 'n': Ordenar 'n' datos
// select 'n': Seleccionar 'n' datos
var namesOrdered = from n in names orderby n select n;
// Ojo: esta instruccion no se realiza sino hasta que se llama a la variable 'namesOrdered'
// Para realizar inmediatamente, agrega '(codigo).ToList();'

// Imprimir los datos ya ordenados
foreach (var name in namesOrdered) {
    Console.WriteLine(name);
}

// Ordenar en orden descendiente
// descending : Ordenar descendientemente
var namesOrdered2 = from n in names orderby n descending select n;

// Imprimir los datos ya ordenados
foreach (var name in namesOrdered2) {
    Console.WriteLine(name);
}

// where : Quedarse unicamente con los valores que cumplan la condicion
var namesOrdered3 = from n in names
                    where n.Length > 5
                    orderby n
                    select n; // Tambien se puede colocar la instruccion en multiples lineas

// Esto es igual a lo de arriba, pero con otra notacion
// var namesOrdered3 = names.Where(n => n.Length)
//                          .OrderBy(n => n)
//                          .Select(n => n);

// Imprimir los datos ya ordenados, omitiendo los datos que no cumplen la condicion del 'where'
foreach (var name in namesOrdered3) {
    Console.WriteLine(name);
}
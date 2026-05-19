// --- Serializacion a JSON ------------------------------
// Convertir objetos (clases) a JSON y viceversa

// Libreria para JSON
using System.Text.Json;

// Nuevo objeto 'People'
var juan = new People () {
    name = "Juan", age = 16
};

// Indicamos que vamos a serializar (convertir a JSON) a 'juan'
string json = JsonSerializer.Serialize(juan);
// Imprimimos para revisar
Console.WriteLine(json);

// Un ejemplo de archivo JSON
string myJson = @"{
    ""name"":""Pedro"",
    ""age"":19
}";
// Indicamos que vamos a deserializar (convertir JSON a objeto) a 'myJson'
var pedro = JsonSerializer.Deserialize<People>(myJson);
// Imprimimos para revisar
pedro.GetData();

// Clase 'People'
public class People {
    // Ojo : si no esta especificado el {get; set;} el JSON no va a leer datos
    public string name {get; set;}
    public int age {get; set;}

    // Metodo para imprimir los valores
    public void GetData () {
        Console.WriteLine($"[name: {name}, age: {age}]");
    }
}
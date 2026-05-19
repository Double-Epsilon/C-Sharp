// --- Interfaces ------------------------------------
// Manual/Reglas que debe seguir una clase para ser implementada correctamente

// Creamos un nuevo 'Sale'
Sale sale = new Sale();
// Creamos un nuevo 'Order'
Order order = new Order();

// Como ambos forman parte de 'ISave', podemos enviarlos como parametro de tipo 'ISave'
algoidk(sale);
algoidk(order);

// Funcion que hace algo (recibe un 'ISave' como parametro)
void algoidk (ISave save) {
    // Llama al metodo 'Save' del parametro. Debe tenerlo si o si por pertenecer a la interfaz 'ISave'
    save.Save();
}

// Interfaz 'ISale'
public interface ISale {
    // Establecemos que todos deben tener una variable decimal 'total'
    // 'get' : Establece que la variable puede ser consultada
    // 'set' : Establece que la variable puede ser editada (no obligatorio)
    public decimal total {get; set;}
}

// Interfaz 'ISave'
public interface ISave {
    // Establecemos que todos deben tener un metodo void 'Save'
    public void Save();
}

// Clase 'Sale' (sigue las reglas de 'ISale' y 'ISave')
public class Sale : ISale, ISave {
    // Declaramos 'total' (regla de 'ISale')
    public decimal total {get; set;}

    // Declaramos 'Save()' (regla de 'ISave')
    public void Save () {
        Console.WriteLine("Compra guardada! *no hace nada");
    }
}

// Clase 'Order' (sigue las reglas de 'ISave')
public class Order : ISave {
    // Declaramos 'Save()' (regla de 'ISave')
    public void Save () {
        Console.WriteLine("Orden guardada! *se hace p-ndejo");
    }
}

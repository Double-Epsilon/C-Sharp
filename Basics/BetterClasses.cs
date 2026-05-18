// --- Clases ----------------------------------
// public : Accesible desde cualquier lugar
// private : Accesible solamente dentro de la clase
// protected : Accesible solamente dentro de la clase y sus hijos (herencia)

// ... virtual : Metodo que puede ser sobreescrito por una clase hija
// ... override : Metodo que va a sobreescribir un metodo de la clase padre

// -------------------------------------------------------------------

// Creamos un nuevo 'Sale'
Sale sale1 = new Sale(15.5m); // La 'm' indica que es decimal

// Puedo llamar el metodo 'GetInfo' porque es publico
Console.WriteLine(sale1.GetInfo());

// No puedo llamar a los metodos 'GetIVA' o 'GetID' porque son protegidos y/o privados 

// Creamos un nuevo 'SaleWithDiscount'
SaleWithDiscount sale2 = new SaleWithDiscount(20, 25);
// Metodo exclusivo de la clase hija
Console.WriteLine(sale2.GetInfoWithDiscount());


Console.WriteLine(sale1.GetClassName());
// Al ser un metodo sobreescrito, arrojara un resultado diferente al 'GetClassName' de la clase padre
Console.WriteLine(sale2.GetClassName());

// Llamar al metodo 'GetProduct' sin parametros arrojara el resultado del metodo original
Console.WriteLine(sale1.GetProduct());
// Llamar al metodo 'GetProduct' con parametros arrojara el resultado del metodo sobrecargado
Console.WriteLine(sale1.GetProduct("TERRENEITOR"));


// Clase padre
class Sale {
    // Variable publica (accesible desde todos lados)
    public decimal total;
    // Variable privada (accesible solo dentro de la clase)
    private string id;
    // Variable protegida (accesible solo dentro de la clase y su herencia)
    protected decimal iva;

    // Metodo constructor
    public Sale (decimal _total) {
        // 'this.' especifica que es la variable de esta clase especificamente
        this.total = _total;
        id = "AAA001";
        iva = 16;
    }

    // Metodo publico (llamable desde todos lados)
    public string GetInfo () {
        return "El total es de " + total;
    }

    // Metodo privado (llamable solo dentro de la clase)
    private string GetID () {
        return "El ID es " + id;
    }

    // Metodo protegido (llamable solo dentro de la clase y su herencia)
    protected string GetIVA () {
        return "El IVA es de " + iva;
    }

    // Metodo virtual (puede ser sobreescrito)
    public virtual string GetClassName () {
        return "Esta clase se llama 'Sale'";
    }

    // Metodo publico
    public string GetProduct () {
        return "Este producto no tiene nombre";
    }

    // Metodo sobrecargado (metodo ya existente pero acoplado a diferentes parametros)
    public string GetProduct (string product) {
        return "Este producto se llama " + product;
    }
}

// Clase heredada de otra clase (Clase hija)
class SaleWithDiscount : Sale {
    // Variable privada
    private decimal discount;

    // Metodo constructor
    public SaleWithDiscount (decimal _total, decimal _discount) : base (_total) {
        this.discount = _discount;
    }

    // Metodo publico
    public string GetInfoWithDiscount () {
        // Puedo llamar al metodo 'GetInfo' porque es publico
        Console.WriteLine(GetInfo());
        // Puedo llamar al metodo 'GetIVA' porque esta clase hereda de 'Sale' (metodo protegido)
        Console.WriteLine(GetIVA());
        // No puedo llamar al metodo 'GetID' porque es privado

        // Puedo utilizar la variable 'total' porque es publica
        return "El total con descuento es de " + (total - (discount*total/100));
    }

    // Metodo anulador (sobreescribe el metodo original de la clase padre)
    public override string GetClassName () {
        return "Esta clase se llama 'SaleWithDiscount'";
    }
}

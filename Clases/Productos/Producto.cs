namespace Clases
{
    public class Producto
    {
        public int Id;
        public string Nombre;
        public double Precio;
        public int Stock;

    
        public Producto(int id, string nombre, double precio, int stock) 
        {
            Id = id;
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
        }
    }
}
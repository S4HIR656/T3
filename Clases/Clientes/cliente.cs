namespace Clases.Clientes
{
    public class cliente
    {
        public int Id;
        public string Nombre;
        public string Apellido;
        public string Telefono;

        public cliente(int id, string nombre, string apellido, string teléfono)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = teléfono;
        }
    }
}
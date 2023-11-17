namespace ESDAT_Examen_T3
{
    public class TicketModel
    {
        // Creamos la clase con 2 atributos
        public string Descripcion { get; set; }
        public string Prioridad { get; set; }

        // En el contructor le pasamos los datos
        public TicketModel(string descripcion, string prioridad)
        {
            this.Descripcion = descripcion;
            this.Prioridad = prioridad;
        }
    }
}

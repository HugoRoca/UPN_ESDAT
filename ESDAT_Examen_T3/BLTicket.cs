using System.Collections.Generic;

namespace ESDAT_Examen_T3
{
    public class BLTicket
    {
        // Creamos una variable privada qcon la que interactuaremos
        private List<TicketModel> ticketLista = new List<TicketModel>();

        public void AgregarAdelante(TicketModel ticketModel)
        {
            // Agregar el elemento al principio de la lista
            ticketLista.Insert(0, ticketModel);
        }

        public void AgregarFinal(TicketModel ticketModel)
        {
            // Agrega un elemento al final de la lista
            ticketLista.Add(ticketModel);
        }

        public int ContarCola()
        {
            // Cuenta el total de elementos de la lista
            // Nos ayudara a validar nuestra lista
            return ticketLista.Count;
        }

        public TicketModel EliminarAdelante()
        {
            // Obtener el primer elemento de la lista
            TicketModel item = ticketLista[0];

            // Eliminamos el primer elemento de la lista
            ticketLista.RemoveAt(0);

            // retornamos el primer elemento para fines de interfaz
            return item;
        }

        public List<TicketModel> ObtenerTickets()
        {
            // retorno todos los valores de la lista
            return ticketLista;
        }
    }
}

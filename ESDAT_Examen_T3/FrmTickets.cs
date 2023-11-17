using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ESDAT_Examen_T3
{
    public partial class FrmTickets : Form
    {
        // Inicializamos la clase el cual contiene todos nuestros métodos
        BLTicket bLTicket = new BLTicket();

        public FrmTickets()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validamos si el campo descripcion tiene valor
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                // En caso que no, mostramos mensaje y se impide el paso.
                MessageBox.Show("El campo descripción debe contener valores", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescripcion.Focus();
                return;
            }

            // Creamos modelo e instanciamos con los valores de los controles
            // En este caso, usamos un texbox y un radio button para diferenciar
            // los estados de la prioridad.
            TicketModel ticketModel = new TicketModel(txtDescripcion.Text, rbNormal.Checked ? Constantes.Prioridad.NORMAL : Constantes.Prioridad.URGENTE);

            // Si es normal procedemos con la inserción al final
            if (rbNormal.Checked) bLTicket.AgregarFinal(ticketModel);
            else
            {
                // si no lo ponemos adelante
                bLTicket.AgregarAdelante(ticketModel);
            }

            // Limpiamos los campos y ponemos el foco
            txtDescripcion.Clear();
            txtDescripcion.Focus();

            // Mostramos la lista completa en el control listview
            MostrarEnLista();
        }

        // Método que muestra la lista de los tickets
        private void MostrarEnLista()
        {
            // Limpiamos todo los elementos de la lista
            lvLista.Items.Clear();

            // Invocamos al método que lista todos los tickets
            List<TicketModel> tickets = bLTicket.ObtenerTickets();

            // Recorremos cada valor de la lista y agreamos al control
            foreach (var item in tickets)
            {
                // Creamos un ListViewItem, ya que contamos con columnas 
                // El primer valor que se le pasa indica la columna 0
                ListViewItem listViewItem = new ListViewItem(item.Prioridad);
                listViewItem.SubItems.Add(item.Descripcion);

                // Agreamos al control la clase previamente modelada
                lvLista.Items.Add(listViewItem);
            }
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            // Validamos si existe tickets en la lista.
            if (bLTicket.ContarCola() == 0)
            {
                // En caso de estar vacia, mostramos mensaje y restringimos el paso.
                MessageBox.Show("La lista está vacía.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Eliminamos el primer elemento de la lista y lo recuperamos en una variable
            TicketModel ticketModel = bLTicket.EliminarAdelante();

            // Mostramos mensaje y el valor del dato eliminado
            MessageBox.Show($"El ticket con descripción:\n{ticketModel.Descripcion} se ha eliminado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Invocamos al método que carga en el lista
            MostrarEnLista();

            txtDescripcion.Clear();
        }

        private void FrmTickets_Load(object sender, EventArgs e)
        {
            // Creamos data de prueba
            bLTicket.AgregarFinal(new TicketModel("Laptop con pantalla rota.","Normal"));
            bLTicket.AgregarAdelante(new TicketModel("Programa de office 365 no responde.","Urgente"));
            bLTicket.AgregarFinal(new TicketModel("La tecla L no funciona en equipo.","Normal"));
            bLTicket.AgregarFinal(new TicketModel("Reemplazo de monitor por uno de 4k.","Normal"));
            bLTicket.AgregarAdelante(new TicketModel("Requiere permisos para instalar.","Urgente"));

            // Mostramos en lista
            MostrarEnLista();

            txtDescripcion.Focus();
        }

        private void rbUrgente_CheckedChanged(object sender, EventArgs e)
        {
            txtDescripcion.Focus();
        }

        private void rbNormal_CheckedChanged(object sender, EventArgs e)
        {
            txtDescripcion.Focus();
        }
    }
}

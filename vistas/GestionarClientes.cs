using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlX.XDevAPI;
using numeroMayoryMenor.dao;
using numeroMayoryMenor.modelos;

namespace numeroMayoryMenor
{
    public partial class GestionarClientes : Form
    {
        public GestionarClientes()
        {
            InitializeComponent();
        }

        private void GestionarClientes_Load(object sender, EventArgs e)
        {

            renderizarLista();

        }

        private void renderizarLista()
        {
            clienteDao baseDeDatos = new clienteDao();
            List<Cliente> listaDB = baseDeDatos.listadoClientes();
            listClientes.Items.Clear();
            for (int i = 0; i < listaDB.Count; i++)
            {
                Cliente cliente = listaDB[i];
                listClientes.Items.Add(cliente);

            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            cliente.Nombre = txtNombre.Text;
            cliente.Apellido = txtApellido.Text;
            cliente.Telefono = txtTelefono.Text;
            cliente.TarjetaDeCredito = txtTarjeta.Text;

            if (lblID.Text != "")
            {
                cliente.Id = lblID.Text;
            }

            clienteDao baseDeDatos = new clienteDao();
            baseDeDatos.guardar(cliente);
            renderizarLista();
            limpiarListado();


        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)listClientes.SelectedItem;

            clienteDao baseDeDatos = new clienteDao();
            baseDeDatos.Eliminar(cliente);

            renderizarLista();

        }



        private void btnEditar_Click(object sender, EventArgs e)
        {

            Cliente cliente = (Cliente)listClientes.SelectedItem;

            txtApellido.Text = cliente.Apellido;
            txtNombre.Text = cliente.Nombre;
            txtTelefono.Text = cliente.Telefono;
            txtTarjeta.Text = cliente.TarjetaDeCredito;
            lblID.Text = cliente.Id;
        }



        private void limpiarListado()
        {
            lblID.Text = "";
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtTarjeta.Text = "";
        }

      
    }
}

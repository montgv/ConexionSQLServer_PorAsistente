using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionSQLServer_PorAsistente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banklineDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'banklineDataSet.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.banklineDataSet.Cliente);

        }

        private void bt_agregar_Click(object sender, EventArgs e)
        {
            this.clienteTableAdapter.AgregarDoc(docTextBox.Text, tipoDocTextBox.Text, nombreTextBox.Text, direccionTextBox.Text, postalTextBox.Text, telefonoTextBox.Text);
            this.clienteTableAdapter.Fill(this.banklineDataSet.Cliente);
        }

        private void bt_modificar_Click(object sender, EventArgs e)
        {
            this.clienteTableAdapter.ModificarDoc(docTextBox.Text, tipoDocTextBox.Text, nombreTextBox.Text, direccionTextBox.Text, postalTextBox.Text, telefonoTextBox.Text, docTextBox.Text);
            this.clienteTableAdapter.Fill(this.banklineDataSet.Cliente);
        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            this.clienteTableAdapter.EliminarDoc(docTextBox.Text);
            this.clienteTableAdapter.Fill(this.banklineDataSet.Cliente);
        }

        private void bt_buscar_Click(object sender, EventArgs e)
        {
            this.clienteTableAdapter.BuscarDoc(banklineDataSet.Cliente, docTextBox.Text);
        }

        private void bt_mostrar_Click(object sender, EventArgs e)
        {
            this.clienteTableAdapter.Fill(this.banklineDataSet.Cliente);
        }
    }
}

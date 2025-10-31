using SistemaNota.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaNota.Vista
{
    public partial class FrmDocente : Form
    {
        DocenteController lista = new DocenteController();

        public FrmDocente()
        {
            InitializeComponent();
        }
        private void Listar()
        {
            dgvRegistros.DataSource = null;
            dgvRegistros.DataSource = lista.GetDocente();
            dgvRegistros.Refresh();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            lista.Agregar(tbNombre.Text, tbCodigo.Text,tbCarrera.Text);
            Listar();
            tbNombre.Clear();
            tbCodigo.Clear();
            tbNombre.Focus();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            lista.Eliminar(tbNombre.Text, tbCodigo.Text);
            Listar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvRegistros.DataSource = null;
            dgvRegistros.DataSource = lista.GetDocente(tbDato.Text);
            dgvRegistros.Refresh();
        }

        private void dgvRegistros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvRegistros.Rows[e.RowIndex];
                tbNombre.Text = fila.Cells[0].Value.ToString();
                tbCodigo.Text = fila.Cells[1].Value.ToString();
            }
        }
    }
}

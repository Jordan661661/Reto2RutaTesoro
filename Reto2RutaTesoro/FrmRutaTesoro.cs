using System;
using System.Windows.Forms;

namespace Reto2RutaTesoro
{
    partial class FrmRutaTesoro
    {
        private readonly RutaService _service = new RutaService();

        public FrmRutaTesoro()
        {
            InitializeComponent();
            RefrescarVista();
        }

        private void RefrescarVista()
        {
            var lista = _service.ListarParaUI().ToList();
            dgvRuta.DataSource = lista;
            lblTotal.Text = $"Ubicaciones en la ruta: {_service.Contar()}";
        }

        private void LimpiarCampos()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtPista.Clear();
            nudPeligro.Value = 1;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("ID inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _service.Insertar(id, txtNombre.Text.Trim(), txtPista.Text.Trim(), (int)nudPeligro.Value);
                RefrescarVista();
                LimpiarCampos();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("ID inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var dto = _service.BuscarParaUI(id);
            if (dto == null)
            {
                MessageBox.Show("No se encontró la ubicación.", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtNombre.Text = dto.Nombre;
            txtPista.Text = dto.Pista;
            nudPeligro.Value = dto.NivelPeligro;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("ID inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool ok = _service.Modificar(id, txtNombre.Text.Trim(), txtPista.Text.Trim(), (int)nudPeligro.Value);
            if (!ok)
                MessageBox.Show("No se pudo modificar: ID no encontrado.", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            RefrescarVista();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("ID inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool ok = _service.Eliminar(id);
            if (!ok)
                MessageBox.Show("No se pudo eliminar: ID no encontrado.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            RefrescarVista();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dgvRuta_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvRuta.Rows[e.RowIndex].DataBoundItem;
            if (row == null) return;
            var dto = row as UbicacionDto;
            if (dto == null) return;
            txtId.Text = dto.Id.ToString();
            txtNombre.Text = dto.Nombre;
            txtPista.Text = dto.Pista;
            nudPeligro.Value = dto.NivelPeligro;
        }
    }
}

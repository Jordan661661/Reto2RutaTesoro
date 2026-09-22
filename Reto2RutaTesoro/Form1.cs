namespace Reto2RutaTesoro
{
    partial class FrmRutaTesoro : System.Windows.Forms.Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblId = new Label();
            txtId = new TextBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblPista = new Label();
            txtPista = new TextBox();
            lblPeligro = new Label();
            nudPeligro = new NumericUpDown();
            btnInsertar = new Button();
            btnBuscar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            dgvRuta = new DataGridView();
            lblTotal = new Label();
            panelFormulario = new Panel();
            ((System.ComponentModel.ISupportInitialize)nudPeligro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRuta).BeginInit();
            panelFormulario.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(23, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(361, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "La Ruta del Tesoro Perdido";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(17, 20);
            lblId.Name = "lblId";
            lblId.Size = new Size(97, 20);
            lblId.TabIndex = 0;
            lblId.Text = "ID Ubicación:";
            // 
            // txtId
            // 
            txtId.Location = new Point(126, 16);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.Size = new Size(114, 27);
            txtId.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(263, 20);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(343, 16);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(228, 27);
            txtNombre.TabIndex = 3;
            // 
            // lblPista
            // 
            lblPista.AutoSize = true;
            lblPista.Location = new Point(17, 73);
            lblPista.Name = "lblPista";
            lblPista.Size = new Size(43, 20);
            lblPista.TabIndex = 4;
            lblPista.Text = "Pista:";
            // 
            // txtPista
            // 
            txtPista.Location = new Point(126, 69);
            txtPista.Margin = new Padding(3, 4, 3, 4);
            txtPista.Name = "txtPista";
            txtPista.Size = new Size(445, 27);
            txtPista.TabIndex = 5;
            // 
            // lblPeligro
            // 
            lblPeligro.AutoSize = true;
            lblPeligro.Location = new Point(17, 127);
            lblPeligro.Name = "lblPeligro";
            lblPeligro.Size = new Size(119, 20);
            lblPeligro.TabIndex = 6;
            lblPeligro.Text = "Nivel de peligro:";
            // 
            // nudPeligro
            // 
            nudPeligro.Location = new Point(142, 125);
            nudPeligro.Margin = new Padding(3, 4, 3, 4);
            nudPeligro.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudPeligro.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPeligro.Name = "nudPeligro";
            nudPeligro.Size = new Size(69, 27);
            nudPeligro.TabIndex = 7;
            nudPeligro.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(23, 260);
            btnInsertar.Margin = new Padding(3, 4, 3, 4);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(126, 43);
            btnInsertar.TabIndex = 2;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(160, 260);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(126, 43);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(297, 260);
            btnModificar.Margin = new Padding(3, 4, 3, 4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(126, 43);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(434, 260);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(126, 43);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(571, 260);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(126, 43);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar campos";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvRuta
            // 
            dgvRuta.AllowUserToAddRows = false;
            dgvRuta.AllowUserToDeleteRows = false;
            dgvRuta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRuta.ColumnHeadersHeight = 29;
            dgvRuta.Location = new Point(23, 320);
            dgvRuta.Margin = new Padding(3, 4, 3, 4);
            dgvRuta.MultiSelect = false;
            dgvRuta.Name = "dgvRuta";
            dgvRuta.ReadOnly = true;
            dgvRuta.RowHeadersWidth = 25;
            dgvRuta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRuta.Size = new Size(846, 347);
            dgvRuta.TabIndex = 7;
            dgvRuta.CellClick += dgvRuta_CellClick;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(23, 680);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(170, 20);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "Ubicaciones en la ruta: 0";
            // 
            // panelFormulario
            // 
            panelFormulario.BorderStyle = BorderStyle.FixedSingle;
            panelFormulario.Controls.Add(lblId);
            panelFormulario.Controls.Add(txtId);
            panelFormulario.Controls.Add(lblNombre);
            panelFormulario.Controls.Add(txtNombre);
            panelFormulario.Controls.Add(lblPista);
            panelFormulario.Controls.Add(txtPista);
            panelFormulario.Controls.Add(lblPeligro);
            panelFormulario.Controls.Add(nudPeligro);
            panelFormulario.Location = new Point(23, 73);
            panelFormulario.Margin = new Padding(3, 4, 3, 4);
            panelFormulario.Name = "panelFormulario";
            panelFormulario.Size = new Size(845, 173);
            panelFormulario.TabIndex = 1;
            // 
            // FrmRutaTesoro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 727);
            Controls.Add(lblTotal);
            Controls.Add(dgvRuta);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnBuscar);
            Controls.Add(btnInsertar);
            Controls.Add(panelFormulario);
            Controls.Add(lblTitulo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmRutaTesoro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reto 2 - La Ruta del Tesoro Perdido";
            ((System.ComponentModel.ISupportInitialize)nudPeligro).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRuta).EndInit();
            panelFormulario.ResumeLayout(false);
            panelFormulario.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelFormulario;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblPista;
        private System.Windows.Forms.TextBox txtPista;
        private System.Windows.Forms.Label lblPeligro;
        private System.Windows.Forms.NumericUpDown nudPeligro;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvRuta;
        private System.Windows.Forms.Label lblTotal;
    }
}
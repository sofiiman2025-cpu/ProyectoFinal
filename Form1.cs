using System;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace ProyectoFianl
{
    public partial class frmParcial : Form
    {
        // Conexión a la base Movimientos.mdb (está en bin\Debug)
        string conexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +
                          Path.Combine(Application.StartupPath, "Movimientos.mdb");

        public frmParcial()
        {
            InitializeComponent();

            // Conectamos los botones con sus métodos
            btnAgregar.Click += btnAgregar_Click;
            btnBuscarMov.Click += btnBuscarMov_Click;
            btnVerTodos.Click += btnVerTodos_Click;
        }

        // 1) Al iniciar, mostrar todos los datos
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvMov.ReadOnly = true;
            dgvMov.AllowUserToAddRows = false;

            if (dgvMov.Columns.Count == 0)
            {
                dgvMov.Columns.Add("Monto", "Monto");
                dgvMov.Columns.Add("Nombre", "Nombre");
                dgvMov.Columns.Add("Tipo", "Tipo");
            }

            Mostrar("SELECT Monto, Nombre, Tipo FROM Movimientos");
        }

        // Trae los datos de la base y los pone en la grilla
        private void Mostrar(string sql)
        {
            dgvMov.Rows.Clear();

            try
            {
                using (OleDbConnection con = new OleDbConnection(conexion))
                using (OleDbCommand cmd = new OleDbCommand(sql, con))
                {
                    con.Open();
                    using (OleDbDataReader lector = cmd.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            bool esIngreso = Convert.ToBoolean(lector["Tipo"]);
                            dgvMov.Rows.Add(lector["Monto"],
                                            lector["Nombre"],
                                            esIngreso ? "Ingreso" : "Egreso");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer los datos: " + ex.Message);
            }
        }

        // 2) y 4) Agregar un movimiento con validaciones
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();

            if (nombre == "")
            {
                MessageBox.Show("Debe ingresar el nombre.");
                return;
            }

            decimal monto;
            if (!decimal.TryParse(txtMonto.Text, out monto) || monto <= 0)
            {
                MessageBox.Show("Debe ingresar un monto válido mayor que cero.");
                return;
            }

            if (!optIngreso.Checked && !optEgreso.Checked)
            {
                MessageBox.Show("Seleccione Ingreso o Egreso.");
                return;
            }

            // True = Ingreso, False = Egreso
            bool tipo = optIngreso.Checked;

            try
            {
                using (OleDbConnection con = new OleDbConnection(conexion))
                using (OleDbCommand cmd = new OleDbCommand(
                    "INSERT INTO Movimientos (Monto, Nombre, Tipo) VALUES (?, ?, ?)", con))
                {
                    cmd.Parameters.AddWithValue("@Monto", monto);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Tipo", tipo);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Movimiento guardado.");

                // Limpiamos los campos y actualizamos la grilla
                txtNombre.Clear();
                txtMonto.Clear();
                optIngreso.Checked = false;
                optEgreso.Checked = false;
                Mostrar("SELECT Monto, Nombre, Tipo FROM Movimientos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar: " + ex.Message);
            }
        }

        // 3) Filtrar por Ingreso o Egreso
        private void btnBuscarMov_Click(object sender, EventArgs e)
        {
            if (optIngresoFiltro.Checked)
                Mostrar("SELECT Monto, Nombre, Tipo FROM Movimientos WHERE Tipo = True");
            else if (optEgresoFiltro.Checked)
                Mostrar("SELECT Monto, Nombre, Tipo FROM Movimientos WHERE Tipo = False");
            else
                MessageBox.Show("Seleccione Ingreso o Egreso para filtrar.");
        }

        // 3) Ver todos los movimientos
        private void btnVerTodos_Click(object sender, EventArgs e)
        {
            optIngresoFiltro.Checked = false;
            optEgresoFiltro.Checked = false;
            Mostrar("SELECT Monto, Nombre, Tipo FROM Movimientos");
        }
    }
}

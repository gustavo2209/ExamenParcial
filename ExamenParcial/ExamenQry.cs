using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenParcial
{
    public partial class ExamenQry : Form
    {

        private Form1 form1;

        public ExamenQry()
        {
            InitializeComponent();
        }

        public ExamenQry(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;

            Consulta();
        }

        private void Consulta()
        {
            using (var db = new ModelExamen())
            {
                DataTable table = CreaGrilla(new string[] { "ID", "Titulo", "Descripcion", "Duracion (Min.)", "Publicacion", "Minima Nota", "Activo" });

                var query = from n in db.examenes select n;
                string activo = "";

                foreach (var n in query)
                {
                    if (n.activo.Equals("S"))
                        activo = "SI";
                    else
                        activo = "NO";

                    table.Rows.Add(n.idexamen, n.titulo, n.descripcion, n.duracion, DateTime.Parse(n.publicacion.ToString()).ToString("dd/MM/yyyy"), n.minimanota, activo);
                }

                dgvExamen.DataSource = table;

                dgvExamen.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvExamen.Columns["Titulo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvExamen.Columns["Descripcion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvExamen.Columns["Duracion (Min.)"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvExamen.Columns["Publicacion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvExamen.Columns["Minima Nota"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvExamen.Columns["Activo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void ExamenQry_Load(object sender, EventArgs e)
        {

        }

        private DataTable CreaGrilla(string[] titulos)
        {
            DataTable tabla = new DataTable();

            foreach (string t in titulos)
            {
                tabla.Columns.Add(t, System.Type.GetType("System.String"));
            }
            return tabla;
        }
    }
}

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
    public partial class PreguntaQry : Form
    {

        private Form1 form1;
        private DataTable table;

        public PreguntaQry()
        {
            InitializeComponent();
        }

        public PreguntaQry(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;

            table = new DataTable();
        }

        private void PreguntaQry_Load(object sender, EventArgs e)
        {
            using (var db = new ModelExamen())
            {
                var query = from exa in db.examenes
                            select new
                            {
                                idexamen = exa.idexamen,
                                titulo = exa.titulo
                            };

                cboExamen.DataSource = query.ToList();
                cboExamen.ValueMember = "idexamen";
                cboExamen.DisplayMember = "titulo";
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        private void Consultar()
        {
            using (var db = new ModelExamen())
            {
                var idexamen = Convert.ToInt32(cboExamen.SelectedValue);
                DataTable table = CreaGrilla(new string[] { "ID", "Pregunta", "Prioridad" });

                var query = from e in db.examenes
                            join p in db.preguntas on e.idexamen equals p.idexamen
                            where e.idexamen == idexamen 
                            select new
                            {
                                idpregunta = p.idpregunta,
                                pregunta = p.pregunta,
                                prioridad = p.prioridad
                            };

                foreach (var n in query)
                {
                    table.Rows.Add(n.idpregunta, n.pregunta, n.prioridad);
                }

                dgvResultado.DataSource = table;

                dgvResultado.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvResultado.Columns["Pregunta"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvResultado.Columns["Prioridad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
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

        public void RetirarFila()
        {
            DataGridViewSelectedRowCollection selectedRowCollection = dgvResultado.SelectedRows;

            if (selectedRowCollection.Count > 0)
            {
                var confirmResult = MessageBox.Show("¿Está seguro de retirar este examen?", "Confirmar Retiro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    int idpregunta = Convert.ToInt32(dgvResultado.SelectedRows[0].Cells[0].Value.ToString());

                    using (var db = new ModelExamen())
                    {
                        var pregunta = db.preguntas.Find(idpregunta);
                        db.preguntas.Remove(pregunta);
                        db.SaveChanges();

                        MessageBox.Show("Pregunta eliminada correctamente");
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione fila a retirar");
            }
        }
    }
}

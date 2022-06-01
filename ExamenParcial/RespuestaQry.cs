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
    public partial class RespuestaQry : Form
    {

        private Form1 form1;
        private DataTable table;

        public RespuestaQry()
        {
            InitializeComponent();
        }

        public RespuestaQry(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;

            table = new DataTable();
        }

        private void RespuestaQry_Load(object sender, EventArgs e)
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

                var idexamen = Convert.ToInt32(cboExamen.SelectedValue);
                var query2 = from ex in db.examenes
                            join p in db.preguntas on ex.idexamen equals p.idexamen
                            where ex.idexamen == idexamen
                            select new
                            {
                                idpregunta = p.idpregunta,
                                pregunta = p.pregunta,
                                prioridad = p.prioridad
                            };
                cboPregunta.DataSource = query2.ToList();
                cboPregunta.ValueMember = "idpregunta";
                cboPregunta.DisplayMember = "pregunta";
            }
        }

        private void cboExamen_SelectionChangeCommitted(object sender, EventArgs e)
        {
            using (var db = new ModelExamen())
            {
                var idexamen = Convert.ToInt32(cboExamen.SelectedValue);
                var query2 = from ex in db.examenes
                             join p in db.preguntas on ex.idexamen equals p.idexamen
                             where ex.idexamen == idexamen
                             select new
                             {
                                 idpregunta = p.idpregunta,
                                 pregunta = p.pregunta,
                                 prioridad = p.prioridad
                             };
                cboPregunta.DataSource = query2.ToList();
                cboPregunta.ValueMember = "idpregunta";
                cboPregunta.DisplayMember = "pregunta";
            }
        }

        private void Consultar()
        {
            using (var db = new ModelExamen())
            {
                var idexamen = Convert.ToInt32(cboExamen.SelectedValue);
                var idpregunta = Convert.ToInt32(cboPregunta.SelectedValue);
                DataTable table = CreaGrilla(new string[] { "ID", "Respuesta", "Puntaje" });

                var query = from e in db.examenes
                            join p in db.preguntas on e.idexamen equals p.idexamen
                            join r in db.respuestas on p.idpregunta equals r.idpregunta
                            where e.idexamen == idexamen && p.idpregunta == idpregunta
                            select new
                            {
                                idpregunta = r.idpregunta,
                                respuesta = r.respuesta,
                                puntaje = r.puntaje
                            };

                foreach (var n in query)
                {
                    table.Rows.Add(n.idpregunta, n.respuesta, n.puntaje);
                }

                dgvResultado.DataSource = table;

                dgvResultado.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvResultado.Columns["Respuesta"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvResultado.Columns["Puntaje"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Consultar();
        }
    }
}

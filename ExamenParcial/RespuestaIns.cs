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
    public partial class RespuestaIns : Form
    {

        private Form1 form1;

        public RespuestaIns()
        {
            InitializeComponent();
        }

        public RespuestaIns(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void RespuestaIns_Load(object sender, EventArgs e)
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

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            using (var db = new ModelExamen())
            {
                var idexamen = Convert.ToInt32(cboExamen.SelectedValue);
                var idpregunta = Convert.ToInt32(cboPregunta.SelectedValue);
                var respuesta = new respuestas
                {
                    idpregunta = idpregunta,
                    respuesta = txtRpta.Text,
                    puntaje = Convert.ToDecimal(txtPuntaje.Text)
                };
                db.respuestas.Add(respuesta);
                db.SaveChanges();

                MessageBox.Show("Respuesta grabada correctamente");
            }

            this.Dispose();
        }
    }
}

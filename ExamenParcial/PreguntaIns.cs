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
    public partial class PreguntaIns : Form
    {

        private Form1 form1;

        public PreguntaIns()
        {
            InitializeComponent();
        }

        public PreguntaIns(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void PreguntaIns_Load(object sender, EventArgs e)
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

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            using (var db = new ModelExamen())
            {
                var idexamen = Convert.ToInt32(cboExamen.SelectedValue);
                var pregunta = new preguntas
                {
                    idexamen = idexamen,
                    pregunta = txtPregunta.Text,
                    prioridad = Convert.ToInt32(txtPrioridad.Text)
                };
                db.preguntas.Add(pregunta);
                db.SaveChanges();

                MessageBox.Show("Pregunta grabada correctamente");
            }

            this.Dispose();
        }
    }
}

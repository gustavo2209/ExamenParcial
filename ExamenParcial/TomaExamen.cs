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
    public partial class TomaExamen : Form
    {

        private Form1 form1;

        public TomaExamen()
        {
            InitializeComponent();
        }

        public TomaExamen(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void TomaExamen_Load(object sender, EventArgs e)
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

            Consulta(1);
        }

        private void Consulta(int idespecialidad)
        {
            using (var db = new ModelExamen())
            {
                var id = Convert.ToInt32(cboExamen.SelectedValue);

                List<respuestas> query = (from r in db.respuestas
                                          where r.preguntas.examenes.idexamen == idespecialidad
                                          select r).ToList();


                grbPregunta01.Text = query[0].preguntas.pregunta;
                rbPreg01a.Text = query[0].respuesta;
                rbPreg01a.Tag = query[0].puntaje.ToString();
                rbPreg01b.Text = query[1].respuesta;
                rbPreg01b.Tag = query[1].puntaje.ToString();
                rbPreg01c.Text = query[2].respuesta;
                rbPreg01c.Tag = query[2].puntaje.ToString();

                grbPregunta02.Text = query[3].preguntas.pregunta;
                rbPreg02a.Text = query[3].respuesta;
                rbPreg02a.Tag = query[3].puntaje.ToString();
                rbPreg02b.Text = query[4].respuesta;
                rbPreg02b.Tag = query[4].puntaje.ToString();
                rbPreg02c.Text = query[5].respuesta;
                rbPreg02c.Tag = query[5].puntaje.ToString();

                grbPregunta03.Text = query[6].preguntas.pregunta;
                rbPreg03a.Text = query[6].respuesta;
                rbPreg03a.Tag = query[6].puntaje.ToString();
                rbPreg03b.Text = query[7].respuesta;
                rbPreg03b.Tag = query[7].puntaje.ToString();
                rbPreg03c.Text = query[8].respuesta;
                rbPreg03c.Tag = query[8].puntaje.ToString();

                grbPregunta04.Text = query[9].preguntas.pregunta;
                rbPreg04a.Text = query[9].respuesta;
                rbPreg04a.Tag = query[9].puntaje.ToString();
                rbPreg04b.Text = query[10].respuesta;
                rbPreg04b.Tag = query[10].puntaje.ToString();
                rbPreg04c.Text = query[11].respuesta;
                rbPreg04c.Tag = query[11].puntaje.ToString();

                grbPregunta05.Text = query[12].preguntas.pregunta;
                rbPreg05a.Text = query[12].respuesta;
                rbPreg05a.Tag = query[12].puntaje.ToString();
                rbPreg05b.Text = query[13].respuesta;
                rbPreg05b.Tag = query[13].puntaje.ToString();
                rbPreg05c.Text = query[14].respuesta;
                rbPreg05c.Tag = query[14].puntaje.ToString();

            }
        }

        private void cboExamen_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int idexamen = Convert.ToInt32(cboExamen.SelectedValue.ToString());
            Consulta(idexamen);

            rbPreg01a.Checked = false;
            rbPreg01b.Checked = false;
            rbPreg01c.Checked = false;
            rbPreg02a.Checked = false;
            rbPreg02b.Checked = false;
            rbPreg02c.Checked = false;
            rbPreg03a.Checked = false;
            rbPreg03b.Checked = false;
            rbPreg03c.Checked = false;
            rbPreg04a.Checked = false;
            rbPreg04b.Checked = false;
            rbPreg04c.Checked = false;
            rbPreg05a.Checked = false;
            rbPreg05b.Checked = false;
            rbPreg05c.Checked = false;

            txtNota.Text = "";
        }

        private void btnCalcularNota_Click(object sender, EventArgs e)
        {
            double notaFinal = 0, vp1a = 0, vp1b = 0, vp1c = 0, vp2a = 0, vp2b = 0, vp2c = 0, vp3a = 0, vp3b = 0, vp3c = 0, vp4a = 0, vp4b = 0, vp4c = 0, vp5a = 0, vp5b = 0, vp5c = 0;

            if (rbPreg01a.Checked) vp1a = Convert.ToDouble(rbPreg01a.Tag.ToString());
            if (rbPreg01b.Checked) vp1b = Convert.ToDouble(rbPreg01b.Tag.ToString());
            if (rbPreg01c.Checked) vp1c = Convert.ToDouble(rbPreg01c.Tag.ToString());

            if (rbPreg02a.Checked) vp2a = Convert.ToDouble(rbPreg02a.Tag.ToString());
            if (rbPreg02b.Checked) vp2b = Convert.ToDouble(rbPreg02b.Tag.ToString());
            if (rbPreg02c.Checked) vp2c = Convert.ToDouble(rbPreg02c.Tag.ToString());

            if (rbPreg03a.Checked) vp3a = Convert.ToDouble(rbPreg03a.Tag.ToString());
            if (rbPreg03b.Checked) vp3b = Convert.ToDouble(rbPreg03b.Tag.ToString());
            if (rbPreg03c.Checked) vp3c = Convert.ToDouble(rbPreg03c.Tag.ToString());

            if (rbPreg04a.Checked) vp4a = Convert.ToDouble(rbPreg04a.Tag.ToString());
            if (rbPreg04b.Checked) vp4b = Convert.ToDouble(rbPreg04b.Tag.ToString());
            if (rbPreg04c.Checked) vp4c = Convert.ToDouble(rbPreg04c.Tag.ToString());

            if (rbPreg05a.Checked) vp5a = Convert.ToDouble(rbPreg05a.Tag.ToString());
            if (rbPreg05b.Checked) vp5b = Convert.ToDouble(rbPreg05b.Tag.ToString());
            if (rbPreg05c.Checked) vp5c = Convert.ToDouble(rbPreg05c.Tag.ToString());

            notaFinal = vp1a + vp1b + vp1c + vp2a + vp2b + vp2c + vp3a + vp3b + vp3c + vp4a + vp4b + vp4c + vp5a + vp5b + vp5c;

            txtNota.Text = notaFinal.ToString();
        }
    }
}

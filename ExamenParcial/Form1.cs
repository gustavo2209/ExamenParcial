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
    public partial class Form1 : Form
    {
        private ExamenQry examenQry;
        private ExamenIns examenIns;
        private PreguntaQry preguntaQry;
        private PreguntaIns preguntaIns;
        private RespuestaQry respuestaQry;

        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void preguntasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(ExamenQry))
                {
                    form.Activate();
                    return;
                }
            }

            examenQry = new ExamenQry(this);
            examenQry.MdiParent = this;
            examenQry.Show();
            examenQry.BringToFront();
        }

        private void preguntasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(ExamenIns))
                {
                    form.Activate();
                    return;
                }
            }

            examenIns = new ExamenIns(this);
            examenIns.MdiParent = this;
            examenIns.Show();
            examenIns.BringToFront();
        }

        private void eliminarExamenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool msg = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(ExamenQry))
                {
                    examenQry = (ExamenQry)form;
                    examenQry.Activate();
                    examenQry.RetirarFila();

                    msg = false;
                    break;
                }
                else
                {
                    msg = true;
                }
            }

            if (msg)
            {
                MessageBox.Show("Para retirar active el formulario de CONSULTA DE EXAMEN");
            }
        }

        private void nuevaPreguntaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(PreguntaQry))
                {
                    form.Activate();
                    return;
                }
            }

            preguntaQry = new PreguntaQry(this);
            preguntaQry.MdiParent = this;
            preguntaQry.Show();
            preguntaQry.BringToFront();
        }

        private void nuevasPreguntasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(PreguntaIns))
                {
                    form.Activate();
                    return;
                }
            }

            preguntaIns = new PreguntaIns(this);
            preguntaIns.MdiParent = this;
            preguntaIns.Show();
            preguntaIns.BringToFront();
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bool msg = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(PreguntaQry))
                {
                    preguntaQry = (PreguntaQry)form;
                    preguntaQry.Activate();
                    preguntaQry.RetirarFila();

                    msg = false;
                    break;
                }
                else
                {
                    msg = true;
                }
            }

            if (msg)
            {
                MessageBox.Show("Para retirar active el formulario de CONSULTA DE PREGUNTAS");
            }
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(RespuestaQry))
                {
                    form.Activate();
                    return;
                }
            }

            respuestaQry = new RespuestaQry(this);
            respuestaQry.MdiParent = this;
            respuestaQry.Show();
            respuestaQry.BringToFront();
        }
    }
}

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
    public partial class ExamenIns : Form
    {

        private Form1 form1;

        public ExamenIns()
        {
            InitializeComponent();
        }

        public ExamenIns(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void ExamenIns_Load(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            DateTime dt1 = dtpFechaPub.Value;

            string s1 = dt1.Day + "-" + dt1.Month + "-" + dt1.Year;
            string activo = "";

            if (cboActivo.Text == "SI")
                activo = "S";
            else
                activo = "N";

            using (var db = new ModelExamen())
            {

                var examen = new examenes
                {
                    titulo = txtTitulo.Text,
                    descripcion = txtDescripcion.Text,
                    duracion = Convert.ToInt32(txtDuracion.Text),
                    publicacion = Convert.ToDateTime(s1),
                    minimanota = Convert.ToInt32(txtMinNota.Text),
                    activo = activo
                };
                db.examenes.Add(examen);
                db.SaveChanges();

                MessageBox.Show("Examen grabado correctamente");
            }

            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(ExamenQry))
                {
                    ((ExamenQry)form).Consulta();
                    form.Activate();
                    form.BringToFront();
                }
            }

            this.Dispose();
        }
    }
}

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
    }
}

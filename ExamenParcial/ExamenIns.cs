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
    }
}

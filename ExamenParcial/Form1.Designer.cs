
namespace ExamenParcial
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preguntasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preguntasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarExamenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preguntasToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaPreguntaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.nuevasPreguntasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.respuestasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.nuevaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.calificadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tomaDeExamenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.examenesToolStripMenuItem,
            this.calificadoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // examenesToolStripMenuItem
            // 
            this.examenesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preguntasToolStripMenuItem,
            this.preguntasToolStripMenuItem1,
            this.eliminarExamenToolStripMenuItem,
            this.preguntasToolStripMenuItem2,
            this.respuestasToolStripMenuItem});
            this.examenesToolStripMenuItem.Name = "examenesToolStripMenuItem";
            this.examenesToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.examenesToolStripMenuItem.Text = "Examenes";
            // 
            // preguntasToolStripMenuItem
            // 
            this.preguntasToolStripMenuItem.Name = "preguntasToolStripMenuItem";
            this.preguntasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.preguntasToolStripMenuItem.Text = "Consulta";
            this.preguntasToolStripMenuItem.Click += new System.EventHandler(this.preguntasToolStripMenuItem_Click);
            // 
            // preguntasToolStripMenuItem1
            // 
            this.preguntasToolStripMenuItem1.Name = "preguntasToolStripMenuItem1";
            this.preguntasToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.preguntasToolStripMenuItem1.Text = "Nuevo Examen";
            this.preguntasToolStripMenuItem1.Click += new System.EventHandler(this.preguntasToolStripMenuItem1_Click);
            // 
            // eliminarExamenToolStripMenuItem
            // 
            this.eliminarExamenToolStripMenuItem.Name = "eliminarExamenToolStripMenuItem";
            this.eliminarExamenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarExamenToolStripMenuItem.Text = "Eliminar Examen";
            this.eliminarExamenToolStripMenuItem.Click += new System.EventHandler(this.eliminarExamenToolStripMenuItem_Click);
            // 
            // preguntasToolStripMenuItem2
            // 
            this.preguntasToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaPreguntaToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.nuevasPreguntasToolStripMenuItem,
            this.eliminarToolStripMenuItem1});
            this.preguntasToolStripMenuItem2.Name = "preguntasToolStripMenuItem2";
            this.preguntasToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.preguntasToolStripMenuItem2.Text = "Preguntas";
            // 
            // nuevaPreguntaToolStripMenuItem
            // 
            this.nuevaPreguntaToolStripMenuItem.Name = "nuevaPreguntaToolStripMenuItem";
            this.nuevaPreguntaToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.nuevaPreguntaToolStripMenuItem.Text = "Consulta";
            this.nuevaPreguntaToolStripMenuItem.Click += new System.EventHandler(this.nuevaPreguntaToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(118, 6);
            // 
            // nuevasPreguntasToolStripMenuItem
            // 
            this.nuevasPreguntasToolStripMenuItem.Name = "nuevasPreguntasToolStripMenuItem";
            this.nuevasPreguntasToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.nuevasPreguntasToolStripMenuItem.Text = "Nueva";
            this.nuevasPreguntasToolStripMenuItem.Click += new System.EventHandler(this.nuevasPreguntasToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem1
            // 
            this.eliminarToolStripMenuItem1.Name = "eliminarToolStripMenuItem1";
            this.eliminarToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.eliminarToolStripMenuItem1.Text = "Eliminar";
            this.eliminarToolStripMenuItem1.Click += new System.EventHandler(this.eliminarToolStripMenuItem1_Click);
            // 
            // respuestasToolStripMenuItem
            // 
            this.respuestasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaToolStripMenuItem,
            this.toolStripMenuItem1,
            this.nuevaToolStripMenuItem,
            this.eliminarToolStripMenuItem2});
            this.respuestasToolStripMenuItem.Name = "respuestasToolStripMenuItem";
            this.respuestasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.respuestasToolStripMenuItem.Text = "Respuestas";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultaToolStripMenuItem.Text = "Consulta";
            this.consultaToolStripMenuItem.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // nuevaToolStripMenuItem
            // 
            this.nuevaToolStripMenuItem.Name = "nuevaToolStripMenuItem";
            this.nuevaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevaToolStripMenuItem.Text = "Nueva";
            this.nuevaToolStripMenuItem.Click += new System.EventHandler(this.nuevaToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem2
            // 
            this.eliminarToolStripMenuItem2.Name = "eliminarToolStripMenuItem2";
            this.eliminarToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.eliminarToolStripMenuItem2.Text = "Eliminar";
            this.eliminarToolStripMenuItem2.Click += new System.EventHandler(this.eliminarToolStripMenuItem2_Click);
            // 
            // calificadoToolStripMenuItem
            // 
            this.calificadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tomaDeExamenToolStripMenuItem});
            this.calificadoToolStripMenuItem.Name = "calificadoToolStripMenuItem";
            this.calificadoToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.calificadoToolStripMenuItem.Text = "Calificado";
            // 
            // tomaDeExamenToolStripMenuItem
            // 
            this.tomaDeExamenToolStripMenuItem.Name = "tomaDeExamenToolStripMenuItem";
            this.tomaDeExamenToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.tomaDeExamenToolStripMenuItem.Text = "Toma de Examen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ExamenParcial.Properties.Resources.head_bg28;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Sistema de Examenes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem examenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preguntasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calificadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tomaDeExamenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preguntasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem preguntasToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem nuevaPreguntaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevasPreguntasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem respuestasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nuevaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem eliminarExamenToolStripMenuItem;
    }
}


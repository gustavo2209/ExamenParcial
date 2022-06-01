
namespace ExamenParcial
{
    partial class RespuestaIns
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RespuestaIns));
            this.btnGrabar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboExamen = new System.Windows.Forms.ComboBox();
            this.txtPuntaje = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboPregunta = new System.Windows.Forms.ComboBox();
            this.txtRpta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGrabar
            // 
            this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrabar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Location = new System.Drawing.Point(162, 242);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(330, 30);
            this.btnGrabar.TabIndex = 7;
            this.btnGrabar.Text = "Grabar Datos";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtRpta);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboPregunta);
            this.groupBox1.Controls.Add(this.cboExamen);
            this.groupBox1.Controls.Add(this.txtPuntaje);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(654, 207);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Respuesta";
            // 
            // cboExamen
            // 
            this.cboExamen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExamen.FormattingEnabled = true;
            this.cboExamen.Location = new System.Drawing.Point(166, 32);
            this.cboExamen.Name = "cboExamen";
            this.cboExamen.Size = new System.Drawing.Size(460, 24);
            this.cboExamen.TabIndex = 6;
            this.cboExamen.SelectionChangeCommitted += new System.EventHandler(this.cboExamen_SelectionChangeCommitted);
            // 
            // txtPuntaje
            // 
            this.txtPuntaje.Location = new System.Drawing.Point(166, 162);
            this.txtPuntaje.Name = "txtPuntaje";
            this.txtPuntaje.Size = new System.Drawing.Size(67, 22);
            this.txtPuntaje.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Puntaje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pregunta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Examen:";
            // 
            // cboPregunta
            // 
            this.cboPregunta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPregunta.FormattingEnabled = true;
            this.cboPregunta.Location = new System.Drawing.Point(166, 75);
            this.cboPregunta.Name = "cboPregunta";
            this.cboPregunta.Size = new System.Drawing.Size(460, 24);
            this.cboPregunta.TabIndex = 8;
            // 
            // txtRpta
            // 
            this.txtRpta.Location = new System.Drawing.Point(166, 118);
            this.txtRpta.Name = "txtRpta";
            this.txtRpta.Size = new System.Drawing.Size(460, 22);
            this.txtRpta.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Respuesta:";
            // 
            // RespuestaIns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ExamenParcial.Properties.Resources.head_bg28;
            this.ClientSize = new System.Drawing.Size(678, 285);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RespuestaIns";
            this.Text = "Ingreso de Respuestas";
            this.Load += new System.EventHandler(this.RespuestaIns_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRpta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboPregunta;
        private System.Windows.Forms.ComboBox cboExamen;
        private System.Windows.Forms.TextBox txtPuntaje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}
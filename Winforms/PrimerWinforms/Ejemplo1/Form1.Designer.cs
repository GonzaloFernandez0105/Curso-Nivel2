namespace Ejemplo1
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lvElementos = new System.Windows.Forms.ListView();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.chbEjemplo = new System.Windows.Forms.CheckBox();
            this.rdbHombre = new System.Windows.Forms.RadioButton();
            this.rdbMujer = new System.Windows.Forms.RadioButton();
            this.rdbNull = new System.Windows.Forms.RadioButton();
            this.grbGenero = new System.Windows.Forms.GroupBox();
            this.cbEstudios = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numExp = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVerPerfil = new System.Windows.Forms.Button();
            this.grbGenero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numExp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(52, 687);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(113, 53);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(232, 109);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 26);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lvElementos
            // 
            this.lvElementos.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.lvElementos.HideSelection = false;
            this.lvElementos.Location = new System.Drawing.Point(52, 510);
            this.lvElementos.Name = "lvElementos";
            this.lvElementos.Size = new System.Drawing.Size(402, 171);
            this.lvElementos.TabIndex = 2;
            this.lvElementos.UseCompatibleStateImageBehavior = false;
            this.lvElementos.View = System.Windows.Forms.View.SmallIcon;
            this.lvElementos.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(130, 115);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 20);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre: ";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha namicimiento:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(232, 159);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(144, 26);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // chbEjemplo
            // 
            this.chbEjemplo.AutoSize = true;
            this.chbEjemplo.Location = new System.Drawing.Point(168, 218);
            this.chbEjemplo.Name = "chbEjemplo";
            this.chbEjemplo.Size = new System.Drawing.Size(136, 24);
            this.chbEjemplo.TabIndex = 6;
            this.chbEjemplo.Text = "Monotributista";
            this.chbEjemplo.UseVisualStyleBackColor = true;
            this.chbEjemplo.CheckedChanged += new System.EventHandler(this.chbEjemplo_CheckedChanged);
            // 
            // rdbHombre
            // 
            this.rdbHombre.AutoSize = true;
            this.rdbHombre.Location = new System.Drawing.Point(11, 43);
            this.rdbHombre.Name = "rdbHombre";
            this.rdbHombre.Size = new System.Drawing.Size(91, 24);
            this.rdbHombre.TabIndex = 7;
            this.rdbHombre.TabStop = true;
            this.rdbHombre.Text = "Hombre";
            this.rdbHombre.UseVisualStyleBackColor = true;
            // 
            // rdbMujer
            // 
            this.rdbMujer.AutoSize = true;
            this.rdbMujer.Location = new System.Drawing.Point(161, 42);
            this.rdbMujer.Name = "rdbMujer";
            this.rdbMujer.Size = new System.Drawing.Size(73, 24);
            this.rdbMujer.TabIndex = 8;
            this.rdbMujer.TabStop = true;
            this.rdbMujer.Text = "Mujer";
            this.rdbMujer.UseVisualStyleBackColor = true;
            // 
            // rdbNull
            // 
            this.rdbNull.AutoSize = true;
            this.rdbNull.Checked = true;
            this.rdbNull.Location = new System.Drawing.Point(320, 43);
            this.rdbNull.Name = "rdbNull";
            this.rdbNull.Size = new System.Drawing.Size(60, 24);
            this.rdbNull.TabIndex = 9;
            this.rdbNull.TabStop = true;
            this.rdbNull.Text = "Null";
            this.rdbNull.UseVisualStyleBackColor = true;
            // 
            // grbGenero
            // 
            this.grbGenero.Controls.Add(this.rdbHombre);
            this.grbGenero.Controls.Add(this.rdbNull);
            this.grbGenero.Controls.Add(this.rdbMujer);
            this.grbGenero.Location = new System.Drawing.Point(51, 269);
            this.grbGenero.Name = "grbGenero";
            this.grbGenero.Size = new System.Drawing.Size(402, 98);
            this.grbGenero.TabIndex = 10;
            this.grbGenero.TabStop = false;
            this.grbGenero.Text = "Genero:";
            this.grbGenero.Enter += new System.EventHandler(this.grbGenero_Enter);
            // 
            // cbEstudios
            // 
            this.cbEstudios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstudios.FormattingEnabled = true;
            this.cbEstudios.Items.AddRange(new object[] {
            "Primario Incompleto",
            "Primario Completo",
            "Secundario Completo",
            "Terciario Completo",
            "Matriculado"});
            this.cbEstudios.Location = new System.Drawing.Point(212, 398);
            this.cbEstudios.Name = "cbEstudios";
            this.cbEstudios.Size = new System.Drawing.Size(163, 28);
            this.cbEstudios.TabIndex = 11;
            this.cbEstudios.Text = "Desplegar";
            this.cbEstudios.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Estudios:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // numExp
            // 
            this.numExp.Location = new System.Drawing.Point(212, 451);
            this.numExp.Name = "numExp";
            this.numExp.Size = new System.Drawing.Size(136, 26);
            this.numExp.TabIndex = 13;
            this.numExp.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 451);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Años Experiencia:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(50, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 37);
            this.label4.TabIndex = 15;
            this.label4.Text = "Perfil Empleado:";
            // 
            // btnVerPerfil
            // 
            this.btnVerPerfil.Location = new System.Drawing.Point(371, 716);
            this.btnVerPerfil.Name = "btnVerPerfil";
            this.btnVerPerfil.Size = new System.Drawing.Size(101, 51);
            this.btnVerPerfil.TabIndex = 16;
            this.btnVerPerfil.Text = "Ver Perfil";
            this.btnVerPerfil.UseVisualStyleBackColor = true;
            this.btnVerPerfil.Click += new System.EventHandler(this.btnVerPerfil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(508, 785);
            this.Controls.Add(this.btnVerPerfil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numExp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbEstudios);
            this.Controls.Add(this.grbGenero);
            this.Controls.Add(this.chbEjemplo);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lvElementos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbGenero.ResumeLayout(false);
            this.grbGenero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numExp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ListView lvElementos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox chbEjemplo;
        private System.Windows.Forms.RadioButton rdbHombre;
        private System.Windows.Forms.RadioButton rdbMujer;
        private System.Windows.Forms.RadioButton rdbNull;
        private System.Windows.Forms.GroupBox grbGenero;
        private System.Windows.Forms.ComboBox cbEstudios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numExp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVerPerfil;
    }
}


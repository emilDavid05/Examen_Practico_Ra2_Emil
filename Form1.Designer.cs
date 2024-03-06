namespace Examen_practico_ra2_Alan
{
    partial class Form1
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
            this.txt_Matricula = new System.Windows.Forms.TextBox();
            this.lbl_Matricula = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.lbl_Direccion = new System.Windows.Forms.Label();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.lbl_Telefono = new System.Windows.Forms.Label();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lbl_Maestro = new System.Windows.Forms.Label();
            this.txt_Maestro_Titular = new System.Windows.Forms.TextBox();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.dgv_datos = new System.Windows.Forms.DataGridView();
            this.Col_matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coldireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coltelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colmaestro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colcurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colseccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbo_curso = new System.Windows.Forms.ComboBox();
            this.cbo_area = new System.Windows.Forms.ComboBox();
            this.cbo_seccion = new System.Windows.Forms.ComboBox();
            this.cbo_genero = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Matricula
            // 
            this.txt_Matricula.Location = new System.Drawing.Point(202, 95);
            this.txt_Matricula.Name = "txt_Matricula";
            this.txt_Matricula.Size = new System.Drawing.Size(227, 26);
            this.txt_Matricula.TabIndex = 1;
            // 
            // lbl_Matricula
            // 
            this.lbl_Matricula.AutoSize = true;
            this.lbl_Matricula.Location = new System.Drawing.Point(85, 95);
            this.lbl_Matricula.Name = "lbl_Matricula";
            this.lbl_Matricula.Size = new System.Drawing.Size(77, 20);
            this.lbl_Matricula.TabIndex = 2;
            this.lbl_Matricula.Text = "Matricula ";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(85, 143);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(65, 20);
            this.lbl_Nombre.TabIndex = 4;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(202, 143);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(227, 26);
            this.txt_Nombre.TabIndex = 3;
            // 
            // lbl_Direccion
            // 
            this.lbl_Direccion.AutoSize = true;
            this.lbl_Direccion.Location = new System.Drawing.Point(85, 188);
            this.lbl_Direccion.Name = "lbl_Direccion";
            this.lbl_Direccion.Size = new System.Drawing.Size(75, 20);
            this.lbl_Direccion.TabIndex = 6;
            this.lbl_Direccion.Text = "Direccion";
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.Location = new System.Drawing.Point(202, 188);
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(227, 26);
            this.txt_Direccion.TabIndex = 5;
            // 
            // lbl_Telefono
            // 
            this.lbl_Telefono.AutoSize = true;
            this.lbl_Telefono.Location = new System.Drawing.Point(85, 234);
            this.lbl_Telefono.Name = "lbl_Telefono";
            this.lbl_Telefono.Size = new System.Drawing.Size(71, 20);
            this.lbl_Telefono.TabIndex = 8;
            this.lbl_Telefono.Text = "Telefono";
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Location = new System.Drawing.Point(202, 234);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(227, 26);
            this.txt_Telefono.TabIndex = 7;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(85, 279);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(48, 20);
            this.lbl_Email.TabIndex = 10;
            this.lbl_Email.Text = "Email";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(202, 279);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(227, 26);
            this.txt_Email.TabIndex = 9;
            // 
            // lbl_Maestro
            // 
            this.lbl_Maestro.AutoSize = true;
            this.lbl_Maestro.Location = new System.Drawing.Point(85, 325);
            this.lbl_Maestro.Name = "lbl_Maestro";
            this.lbl_Maestro.Size = new System.Drawing.Size(114, 20);
            this.lbl_Maestro.TabIndex = 12;
            this.lbl_Maestro.Text = "Maestro Titular";
            // 
            // txt_Maestro_Titular
            // 
            this.txt_Maestro_Titular.Location = new System.Drawing.Point(202, 325);
            this.txt_Maestro_Titular.Name = "txt_Maestro_Titular";
            this.txt_Maestro_Titular.Size = new System.Drawing.Size(227, 26);
            this.txt_Maestro_Titular.TabIndex = 11;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(1178, 95);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(282, 45);
            this.btn_nuevo.TabIndex = 13;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.Lime;
            this.btn_guardar.Location = new System.Drawing.Point(1537, 225);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(282, 45);
            this.btn_guardar.TabIndex = 14;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.Red;
            this.btn_Eliminar.Location = new System.Drawing.Point(1187, 225);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(282, 45);
            this.btn_Eliminar.TabIndex = 15;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(1537, 95);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(282, 45);
            this.btn_agregar.TabIndex = 16;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Location = new System.Drawing.Point(1363, 300);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(282, 45);
            this.btn_Cerrar.TabIndex = 17;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // dgv_datos
            // 
            this.dgv_datos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_matricula,
            this.Col_Nombre,
            this.Coldireccion,
            this.Coltelefono,
            this.Colemail,
            this.Colmaestro,
            this.ColGenero,
            this.Colcurso,
            this.Colarea,
            this.Colseccion});
            this.dgv_datos.Location = new System.Drawing.Point(2, 385);
            this.dgv_datos.Name = "dgv_datos";
            this.dgv_datos.RowHeadersWidth = 62;
            this.dgv_datos.RowTemplate.Height = 28;
            this.dgv_datos.Size = new System.Drawing.Size(1898, 271);
            this.dgv_datos.TabIndex = 24;
            // 
            // Col_matricula
            // 
            this.Col_matricula.HeaderText = "Matricula";
            this.Col_matricula.MinimumWidth = 8;
            this.Col_matricula.Name = "Col_matricula";
            this.Col_matricula.Width = 150;
            // 
            // Col_Nombre
            // 
            this.Col_Nombre.HeaderText = "Nombre";
            this.Col_Nombre.MinimumWidth = 8;
            this.Col_Nombre.Name = "Col_Nombre";
            this.Col_Nombre.Width = 150;
            // 
            // Coldireccion
            // 
            this.Coldireccion.HeaderText = "Direccion";
            this.Coldireccion.MinimumWidth = 8;
            this.Coldireccion.Name = "Coldireccion";
            this.Coldireccion.Width = 150;
            // 
            // Coltelefono
            // 
            this.Coltelefono.HeaderText = "Telefono";
            this.Coltelefono.MinimumWidth = 8;
            this.Coltelefono.Name = "Coltelefono";
            this.Coltelefono.Width = 150;
            // 
            // Colemail
            // 
            this.Colemail.HeaderText = "Email";
            this.Colemail.MinimumWidth = 8;
            this.Colemail.Name = "Colemail";
            this.Colemail.Width = 150;
            // 
            // Colmaestro
            // 
            this.Colmaestro.HeaderText = "Maestro";
            this.Colmaestro.MinimumWidth = 8;
            this.Colmaestro.Name = "Colmaestro";
            this.Colmaestro.Width = 150;
            // 
            // ColGenero
            // 
            this.ColGenero.HeaderText = "Genero";
            this.ColGenero.MinimumWidth = 8;
            this.ColGenero.Name = "ColGenero";
            this.ColGenero.Width = 150;
            // 
            // Colcurso
            // 
            this.Colcurso.HeaderText = "Curso";
            this.Colcurso.MinimumWidth = 8;
            this.Colcurso.Name = "Colcurso";
            this.Colcurso.Width = 150;
            // 
            // Colarea
            // 
            this.Colarea.HeaderText = "Area tecnica";
            this.Colarea.MinimumWidth = 8;
            this.Colarea.Name = "Colarea";
            this.Colarea.Width = 150;
            // 
            // Colseccion
            // 
            this.Colseccion.HeaderText = "Seccion";
            this.Colseccion.MinimumWidth = 8;
            this.Colseccion.Name = "Colseccion";
            this.Colseccion.Width = 150;
            // 
            // cbo_curso
            // 
            this.cbo_curso.FormattingEnabled = true;
            this.cbo_curso.Items.AddRange(new object[] {
            "4to",
            "5to",
            "6to"});
            this.cbo_curso.Location = new System.Drawing.Point(738, 95);
            this.cbo_curso.Name = "cbo_curso";
            this.cbo_curso.Size = new System.Drawing.Size(170, 28);
            this.cbo_curso.TabIndex = 26;
            this.cbo_curso.Text = "Curso:";
            this.cbo_curso.SelectedIndexChanged += new System.EventHandler(this.cbo_curso_SelectedIndexChanged);
            // 
            // cbo_area
            // 
            this.cbo_area.FormattingEnabled = true;
            this.cbo_area.Items.AddRange(new object[] {
            "Informatica",
            "Enfermeria",
            "Electricidad",
            "Gastronomia",
            "Contabilidad"});
            this.cbo_area.Location = new System.Drawing.Point(491, 188);
            this.cbo_area.Name = "cbo_area";
            this.cbo_area.Size = new System.Drawing.Size(189, 28);
            this.cbo_area.TabIndex = 27;
            this.cbo_area.Text = "Área Tecnica:";
            this.cbo_area.SelectedIndexChanged += new System.EventHandler(this.cbo_area_SelectedIndexChanged);
            // 
            // cbo_seccion
            // 
            this.cbo_seccion.FormattingEnabled = true;
            this.cbo_seccion.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.cbo_seccion.Location = new System.Drawing.Point(738, 188);
            this.cbo_seccion.Name = "cbo_seccion";
            this.cbo_seccion.Size = new System.Drawing.Size(170, 28);
            this.cbo_seccion.TabIndex = 28;
            this.cbo_seccion.Text = "Seccion:";
            this.cbo_seccion.SelectedIndexChanged += new System.EventHandler(this.cbo_seccion_SelectedIndexChanged);
            // 
            // cbo_genero
            // 
            this.cbo_genero.FormattingEnabled = true;
            this.cbo_genero.Items.AddRange(new object[] {
            "Másculino",
            "Fémenino"});
            this.cbo_genero.Location = new System.Drawing.Point(491, 95);
            this.cbo_genero.Name = "cbo_genero";
            this.cbo_genero.Size = new System.Drawing.Size(189, 28);
            this.cbo_genero.TabIndex = 29;
            this.cbo_genero.Text = "Genero:";
            this.cbo_genero.SelectedIndexChanged += new System.EventHandler(this.cbo_genero_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 691);
            this.Controls.Add(this.cbo_genero);
            this.Controls.Add(this.cbo_seccion);
            this.Controls.Add(this.cbo_area);
            this.Controls.Add(this.cbo_curso);
            this.Controls.Add(this.dgv_datos);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.lbl_Maestro);
            this.Controls.Add(this.txt_Maestro_Titular);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.lbl_Telefono);
            this.Controls.Add(this.txt_Telefono);
            this.Controls.Add(this.lbl_Direccion);
            this.Controls.Add(this.txt_Direccion);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.lbl_Matricula);
            this.Controls.Add(this.txt_Matricula);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Matricula;
        private System.Windows.Forms.Label lbl_Matricula;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label lbl_Direccion;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.Label lbl_Telefono;
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lbl_Maestro;
        private System.Windows.Forms.TextBox txt_Maestro_Titular;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.DataGridView dgv_datos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coldireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coltelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colemail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colmaestro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colcurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colseccion;
        private System.Windows.Forms.ComboBox cbo_curso;
        private System.Windows.Forms.ComboBox cbo_area;
        private System.Windows.Forms.ComboBox cbo_seccion;
        private System.Windows.Forms.ComboBox cbo_genero;
    }
}


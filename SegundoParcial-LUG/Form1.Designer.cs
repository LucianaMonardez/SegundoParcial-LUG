namespace SegundoParcial_LUG
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            crearEstudianteBtn = new Button();
            agregarListaEstudiante = new Button();
            crearEstudiantesBtn = new Button();
            nombreTxt = new TextBox();
            promedioTxt = new TextBox();
            cursoComboBox = new ComboBox();
            fechaNacimientoDatePicker = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            modificarEstudianteBtn = new Button();
            idAlumnoModTxt = new TextBox();
            nombreModTxt = new TextBox();
            promedioModTxt = new TextBox();
            cursoComboBoxMod = new ComboBox();
            Estudiantes = new Label();
            estudiantesDataGrid = new DataGridView();
            label11 = new Label();
            label12 = new Label();
            idEstudianteEliminarTxt = new TextBox();
            eliminarBtn = new Button();
            label13 = new Label();
            cursosDataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)estudiantesDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cursosDataGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 26);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 0;
            label1.Text = "Cargar estudiante";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 61);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 95);
            label3.Name = "label3";
            label3.Size = new Size(117, 15);
            label3.TabIndex = 2;
            label3.Text = "Fecha de nacimiento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 132);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 3;
            label4.Text = "Promedio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 167);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 4;
            label5.Text = "Curso";
            // 
            // crearEstudianteBtn
            // 
            crearEstudianteBtn.Location = new Point(115, 198);
            crearEstudianteBtn.Name = "crearEstudianteBtn";
            crearEstudianteBtn.Size = new Size(101, 39);
            crearEstudianteBtn.TabIndex = 5;
            crearEstudianteBtn.Text = "Cargar un solo estudiante";
            crearEstudianteBtn.UseVisualStyleBackColor = true;
            crearEstudianteBtn.Click += crearEstudianteBtn_Click;
            // 
            // agregarListaEstudiante
            // 
            agregarListaEstudiante.Location = new Point(18, 243);
            agregarListaEstudiante.Name = "agregarListaEstudiante";
            agregarListaEstudiante.Size = new Size(100, 39);
            agregarListaEstudiante.TabIndex = 6;
            agregarListaEstudiante.Text = "Agregar a la lista";
            agregarListaEstudiante.UseVisualStyleBackColor = true;
            agregarListaEstudiante.Click += agregarListaEstudiante_Click;
            // 
            // crearEstudiantesBtn
            // 
            crearEstudiantesBtn.Location = new Point(209, 243);
            crearEstudiantesBtn.Name = "crearEstudiantesBtn";
            crearEstudiantesBtn.Size = new Size(101, 39);
            crearEstudiantesBtn.TabIndex = 7;
            crearEstudiantesBtn.Text = "Confirmar cambios";
            crearEstudiantesBtn.UseVisualStyleBackColor = true;
            crearEstudiantesBtn.Click += crearEstudiantesBtn_Click;
            // 
            // nombreTxt
            // 
            nombreTxt.Location = new Point(152, 53);
            nombreTxt.Name = "nombreTxt";
            nombreTxt.Size = new Size(158, 23);
            nombreTxt.TabIndex = 8;
            // 
            // promedioTxt
            // 
            promedioTxt.Location = new Point(152, 124);
            promedioTxt.Name = "promedioTxt";
            promedioTxt.Size = new Size(158, 23);
            promedioTxt.TabIndex = 9;
            // 
            // cursoComboBox
            // 
            cursoComboBox.FormattingEnabled = true;
            cursoComboBox.Location = new Point(152, 159);
            cursoComboBox.Name = "cursoComboBox";
            cursoComboBox.Size = new Size(158, 23);
            cursoComboBox.TabIndex = 10;
            // 
            // fechaNacimientoDatePicker
            // 
            fechaNacimientoDatePicker.Location = new Point(152, 89);
            fechaNacimientoDatePicker.Name = "fechaNacimientoDatePicker";
            fechaNacimientoDatePicker.Size = new Size(158, 23);
            fechaNacimientoDatePicker.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 336);
            label6.Name = "label6";
            label6.Size = new Size(116, 15);
            label6.TabIndex = 12;
            label6.Text = "Modificar estudiante";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 398);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 13;
            label7.Text = "Nombre";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 430);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 14;
            label8.Text = "Promedio";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(18, 366);
            label9.Name = "label9";
            label9.Size = new Size(75, 15);
            label9.TabIndex = 15;
            label9.Text = "Id estudiante";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(18, 461);
            label10.Name = "label10";
            label10.Size = new Size(38, 15);
            label10.TabIndex = 16;
            label10.Text = "Curso";
            // 
            // modificarEstudianteBtn
            // 
            modificarEstudianteBtn.Location = new Point(115, 503);
            modificarEstudianteBtn.Name = "modificarEstudianteBtn";
            modificarEstudianteBtn.Size = new Size(101, 39);
            modificarEstudianteBtn.TabIndex = 17;
            modificarEstudianteBtn.Text = "Modificar estudiante";
            modificarEstudianteBtn.UseVisualStyleBackColor = true;
            modificarEstudianteBtn.Click += modificarEstudianteBtn_Click;
            // 
            // idAlumnoModTxt
            // 
            idAlumnoModTxt.Location = new Point(140, 358);
            idAlumnoModTxt.Name = "idAlumnoModTxt";
            idAlumnoModTxt.Size = new Size(170, 23);
            idAlumnoModTxt.TabIndex = 18;
            // 
            // nombreModTxt
            // 
            nombreModTxt.Location = new Point(140, 387);
            nombreModTxt.Name = "nombreModTxt";
            nombreModTxt.Size = new Size(170, 23);
            nombreModTxt.TabIndex = 19;
            // 
            // promedioModTxt
            // 
            promedioModTxt.Location = new Point(140, 422);
            promedioModTxt.Name = "promedioModTxt";
            promedioModTxt.Size = new Size(170, 23);
            promedioModTxt.TabIndex = 20;
            // 
            // cursoComboBoxMod
            // 
            cursoComboBoxMod.FormattingEnabled = true;
            cursoComboBoxMod.Location = new Point(140, 451);
            cursoComboBoxMod.Name = "cursoComboBoxMod";
            cursoComboBoxMod.Size = new Size(170, 23);
            cursoComboBoxMod.TabIndex = 21;
            // 
            // Estudiantes
            // 
            Estudiantes.AutoSize = true;
            Estudiantes.Location = new Point(388, 26);
            Estudiantes.Name = "Estudiantes";
            Estudiantes.Size = new Size(67, 15);
            Estudiantes.TabIndex = 22;
            Estudiantes.Text = "Estudiantes";
            // 
            // estudiantesDataGrid
            // 
            estudiantesDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            estudiantesDataGrid.Location = new Point(388, 53);
            estudiantesDataGrid.Name = "estudiantesDataGrid";
            estudiantesDataGrid.Size = new Size(634, 264);
            estudiantesDataGrid.TabIndex = 23;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(388, 336);
            label11.Name = "label11";
            label11.Size = new Size(108, 15);
            label11.TabIndex = 24;
            label11.Text = "Eliminar estudiante";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(388, 371);
            label12.Name = "label12";
            label12.Size = new Size(75, 15);
            label12.TabIndex = 25;
            label12.Text = "Id estudiante";
            // 
            // idEstudianteEliminarTxt
            // 
            idEstudianteEliminarTxt.Location = new Point(519, 363);
            idEstudianteEliminarTxt.Name = "idEstudianteEliminarTxt";
            idEstudianteEliminarTxt.Size = new Size(180, 23);
            idEstudianteEliminarTxt.TabIndex = 26;
            // 
            // eliminarBtn
            // 
            eliminarBtn.Location = new Point(598, 397);
            eliminarBtn.Name = "eliminarBtn";
            eliminarBtn.Size = new Size(101, 39);
            eliminarBtn.TabIndex = 27;
            eliminarBtn.Text = "Eliminar estudiante";
            eliminarBtn.UseVisualStyleBackColor = true;
            eliminarBtn.Click += eliminarBtn_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(388, 442);
            label13.Name = "label13";
            label13.Size = new Size(43, 15);
            label13.TabIndex = 28;
            label13.Text = "Cursos";
            // 
            // cursosDataGrid
            // 
            cursosDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cursosDataGrid.Location = new Point(388, 469);
            cursosDataGrid.Name = "cursosDataGrid";
            cursosDataGrid.Size = new Size(634, 151);
            cursosDataGrid.TabIndex = 29;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 660);
            Controls.Add(cursosDataGrid);
            Controls.Add(label13);
            Controls.Add(eliminarBtn);
            Controls.Add(idEstudianteEliminarTxt);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(estudiantesDataGrid);
            Controls.Add(Estudiantes);
            Controls.Add(cursoComboBoxMod);
            Controls.Add(promedioModTxt);
            Controls.Add(nombreModTxt);
            Controls.Add(idAlumnoModTxt);
            Controls.Add(modificarEstudianteBtn);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(fechaNacimientoDatePicker);
            Controls.Add(cursoComboBox);
            Controls.Add(promedioTxt);
            Controls.Add(nombreTxt);
            Controls.Add(crearEstudiantesBtn);
            Controls.Add(agregarListaEstudiante);
            Controls.Add(crearEstudianteBtn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)estudiantesDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)cursosDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button crearEstudianteBtn;
        private Button agregarListaEstudiante;
        private Button crearEstudiantesBtn;
        private TextBox nombreTxt;
        private TextBox promedioTxt;
        private ComboBox cursoComboBox;
        private DateTimePicker fechaNacimientoDatePicker;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button modificarEstudianteBtn;
        private TextBox idAlumnoModTxt;
        private TextBox nombreModTxt;
        private TextBox promedioModTxt;
        private ComboBox cursoComboBoxMod;
        private Label Estudiantes;
        private DataGridView estudiantesDataGrid;
        private Label label11;
        private Label label12;
        private TextBox idEstudianteEliminarTxt;
        private Button eliminarBtn;
        private Label label13;
        private DataGridView cursosDataGrid;
    }
}

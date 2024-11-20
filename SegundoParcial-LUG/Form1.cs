using Business;
using Entity;
using System.Windows.Forms;

namespace SegundoParcial_LUG
{
    public partial class Form1 : Form
    {
        List<Estudiante> _estudiantes = new List<Estudiante>();
        private CursoBusiness _cursoBusiness = new CursoBusiness();
        private EstudianteBusiness _estudianteBusiness = new EstudianteBusiness();

        public Form1()
        {
            InitializeComponent();
            CargarComponentes();

        }

        private void crearEstudianteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Estudiante estudiante = ArmarEstudiante(true);
                _estudianteBusiness.CrearEstudiante(estudiante);
                MessageBox.Show("Estudiante dado de alta en el sistema exitosamente", "Operacion exitosa");
                LimpiarCamposCreacion();
                ActualizarEstudiantesDataGrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error al intentar crear el estudiante: " + ex.Message, "Error");
            }
        }

        private void modificarEstudianteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Estudiante estudiante = ArmarEstudiante(false);
                _estudianteBusiness.ModificarEstudiante(Convert.ToInt32(idAlumnoModTxt.Text), estudiante);

                LimpiarCamposModificacion();
                ActualizarEstudiantesDataGrid();
                idAlumnoModTxt.Clear();

                MessageBox.Show("Alumno modificado exitosamente", "Operacion exitosa");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("El valor ingresado no es un número válido. Por favor verifica los campos del id alumno a modificar.", "Error de formato");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error al intentar modificar el estudiante: " + ex.Message, "Error");
            }
        }

       
        private void crearEstudiantesBtn_Click(object sender, EventArgs e)
        {
            try
            {
                _estudianteBusiness.CrearEstudiantes(_estudiantes);
                ActualizarEstudiantesDataGrid();
                MessageBox.Show("Estudiantes dados de alta en el sistema exitosamente", "Operacion exitosa");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (_estudiantes.Any())
                {
                    MessageBox.Show("El borrador se reiniciara");
                    this._estudiantes = new List<Estudiante>();
                }
            }
        }

        private void agregarListaEstudiante_Click(object sender, EventArgs e)
        {
            try
            {
                Estudiante estudiante = ArmarEstudiante(true);
                this._estudiantes.Add(estudiante);
                LimpiarCamposCreacion();
                MessageBox.Show("Estudiante agregado al borrador exitosamente", "Operacion exitosa");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error al intentar agregar al estudiante al borrador, por favor complete el formulario o si el error persiste comuniquese con el administrador", "Error");
            }
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                _estudianteBusiness.EliminarEstudiante(Convert.ToInt32(idEstudianteEliminarTxt.Text));
                idEstudianteEliminarTxt.Clear();
                ActualizarEstudiantesDataGrid();
                MessageBox.Show("Alumno eliminado exitosamente", "Operacion exitosa");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("El valor ingresado no es un número válido. Por favor verifica los campos del id alumno a eliminar.", "Error de formato");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error al intentar eliminar el estudiante: " + ex.Message, "Error");
            }
        }

        private Estudiante ArmarEstudiante(bool esAlta)
        {
            try
            {
                return esAlta
                    ? new Estudiante(nombreTxt.Text,
                        fechaNacimientoDatePicker.Value.Date,
                        Convert.ToDouble(promedioTxt.Text),
                        Convert.ToInt32(cursoComboBox.SelectedValue))
                    : new Estudiante(nombreModTxt.Text,
                        Convert.ToDouble(promedioModTxt.Text),
                        Convert.ToInt32(cursoComboBoxMod.SelectedValue));
            }
            catch (FormatException ex)
            {
                throw new Exception("El valor ingresado en el campo promedio no es un numero valido");
            }
            catch (Exception ex)
            {

                throw new Exception("Ocurrio un error: " + ex.Message);
            }
        }

        private void LimpiarCamposCreacion() 
        {
            nombreTxt.Clear();
            fechaNacimientoDatePicker.Value = DateTime.Now;
            promedioTxt.Clear();
            cursoComboBox.SelectedIndex = 0;
        }

        private void LimpiarCamposModificacion()
        {
            nombreModTxt.Clear();
            promedioModTxt.Clear();
            cursoComboBoxMod.SelectedIndex = 0;
        }

        private void CargarComponentes() 
        {
            try
            {
                //Workaround para que al seleccionar una row del datagrid, que no cambie el indice de los dropdpowns
                cursosDataGrid.Enabled = false;
                List<Curso> cursos = _cursoBusiness.ObtenerCursos();
                ActualizarCursosDataGrid(cursos);
                CargarCursoComboBox(cursos);
                ActualizarEstudiantesDataGrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error al cargar la aplicacion, por favor comuniquese con el administrador", "Error");
            }
        }

        private void CargarCursoComboBox(List<Curso> cursos)
        {
           
            cursoComboBox.ValueMember = "Id";
            cursoComboBox.DisplayMember = "Nombre";
            cursoComboBox.DataSource = cursos;

            cursoComboBoxMod.ValueMember = "Id";
            cursoComboBoxMod.DisplayMember = "Nombre";
            cursoComboBoxMod.DataSource = cursos;
        }

        private void ActualizarEstudiantesDataGrid() 
        {
            estudiantesDataGrid.DataSource = null;
            estudiantesDataGrid.DataSource = _estudianteBusiness.ObtenerEstudiantes();

            estudiantesDataGrid.Columns["Curso"].Visible = false;
        }

        private void ActualizarCursosDataGrid(List<Curso> cursos)
        {
            cursosDataGrid.DataSource = null;
            cursosDataGrid.DataSource = cursos;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AppEscuela
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbGenero.Items.Add("Femenino");
            cmbGenero.Items.Add("Masculino");

            string[] estados = {"Aguascalientes","Baja California","Baja California","Campeche",
                "Chiapas","Chihuahua","Ciudad de México","Coahuila","Colima","Durango",
                "Guanajuato","Guerrero","Hidalgo","Jalisco","México","Michoacán","Morelos",
                "Nayarit","Nuevo León","Oaxaca","Puebla","Querétaro","Quintana Roo",
                "San Luis Potosí","Sinaloa","Sonora","Tabasco","Tamaulipas","Tlaxcala",
                "Veracruz","Yucatán","Zacatecas" };
            List<string> estad = new List<string>();
            //estad.Add(estados);
            //void getEstados()
            //{
            //    foreach(string estadosMex in estados)
            //    {
            //        estad.Add((estados);
            //    }
            //} 
            cmbEstadoProcedencia.Items.Add(ValidarAMaterno());
        }

        //-----------------------------------------------------------------------------------------
        List<Alumno> ListaAlumnos = new List<Alumno>();
        private void btnGuardarAlumno_Click(object sender, EventArgs e)
        {
            //Los metodos de las siguietes validaciones se encuentran en la parte inferior
            RecopilacionValidacionPersona();

            if (ValidarNumControl() == false)//Alumno
            {
                return;
            }
            //if (ValidarFecNacimiento() == false)////Alumno
            //{
            //    return;
            //}
            if (ValidarGenero() == false)//Alumno
            {
                return;
            }
            if (ValidarEdad() == false)//Alumno
            {
                return;
            }
            //if (ValidarFecIngreso() == false)////Alumno
            //{
            //    return;
            //}
            if (ValidarEstadoProcedencia() == false)//Alumno
            {
                return;
            }
            if (ValidarEscuelaProcedencia() == false)//Alumno
            {
                return;
            }
            MessageBox.Show("Los datos se guardaron correctamente", "Datos Alumnos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void RecopilacionValidacionPersona()
        {
            if (ValidarNombre() == false)//Persona
            {
                return;
            }
            if (ValidarAPaterno() == false)//Persona
            {
                return;
            }
            if (ValidarAMaterno() == false)//Persona
            {
                return;
            }
            if (ValidarCurp() == false)//Persona
            {
                return;
            }
            if (ValidarTelefono() == false)//Persona
            {
                return;
            }
        }
        //Creacion de validaciones de Persona
        private bool ValidarNombre()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))//Si esta vacio o nulo, enviar un error
            {
                errorValidacion.SetError(txtNombre, "Debes ingresar un nombre");
                return false;
            }
            else
            {
                errorValidacion.SetError(txtNombre, "");
                return true;
            }
        }
        private bool ValidarAPaterno()
        {
            if (string.IsNullOrEmpty(txtApellidoPaterno.Text))
            {
                errorValidacion.SetError(txtApellidoPaterno, "Debes ingresar tu apellido paterno");
                return false;
            }
            else
            {
                errorValidacion.SetError(txtApellidoPaterno, "");
                return true;
            }
        }
        private bool ValidarAMaterno()
        {
            if (string.IsNullOrEmpty(txtApellidoMaterno.Text))
            {
                errorValidacion.SetError(txtApellidoMaterno, "Debes ingresar tu apellido materno");
                return false;
            }
            else
            {
                errorValidacion.SetError(txtApellidoMaterno, "");
                return true;
            }
        }
        private bool ValidarCurp()
        {
            if (string.IsNullOrEmpty(txtCurp.Text))
            {
                errorValidacion.SetError(txtCurp, "Debes ingresar tu Curp");
                return false;
            }
            else
            {
                errorValidacion.SetError(txtCurp, "");
                return true;
            }
        }
        private bool ValidarTelefono()
        {
            int telefono;
            if (!int.TryParse(txtTelefono.Text, out telefono) || txtTelefono.Text == "")
            {
                errorValidacion.SetError(txtTelefono, "Debes ingresar tu número de télefono");
                return false;
            }
            else
            {
                errorValidacion.SetError(txtTelefono, "");
                return true;
            }
        }
        //Creacion de validaciones de Alumno
        private bool ValidarNumControl()
        {
            int telefono;
            if (!int.TryParse(txtNumControl.Text, out telefono) || txtNumControl.Text == "")
            {
                errorValidacion.SetError(txtNumControl, "Debes ingresar tu número de control");
                return false;
            }
            else
            {
                errorValidacion.SetError(txtNumControl, "");
                return true;
            }
        }
        //private bool ValidarFecNacimiento()
        //{
        //    DateTime actual = DateTime.Today;
        //    if (actual == DateTime.Today)
        //    {
        //        errorValidacion.SetError(dtNacimiento, "Elige tu fecha de Nacimiento");
        //        return false;
        //    }
        //    else
        //    {
        //        errorValidacion.SetError(dtNacimiento, "");
        //        return true;
        //    }
        //}
        private bool ValidarGenero()
        {
            if (cmbGenero.SelectedItem == null)
            {
                errorValidacion.SetError(cmbGenero, "Debes elegir un género");
                return false;
            }
            else
            {
                errorValidacion.SetError(cmbGenero, "");
                return true;
            }
        }
        private bool ValidarEdad()
        {
            int edad;
            if (!int.TryParse(txtEdad.Text, out edad) || txtEdad.Text == "")
            {
                errorValidacion.SetError(txtEdad, "Debes ingresar tu edad");
                return false;
            }
            else
            {
                errorValidacion.SetError(txtEdad, "");
                return true;
            }
        }
        //private bool ValidarFecIngreso()
        //{
        //    DateTime actual = DateTime.Today;
        //    if (actual == DateTime.Today)
        //    {
        //        errorValidacion.SetError(dtFecIngreso, "Elige tu fecha de ingreso");
        //        return false;
        //    }
        //    else
        //    {
        //        errorValidacion.SetError(dtFecIngreso, "");
        //        return true;
        //    }
        //}
        private bool ValidarEstadoProcedencia()
        {
            if (cmbEstadoProcedencia.SelectedItem == null)
            {
                errorValidacion.SetError(cmbEstadoProcedencia, "Debes elegir tu Estado de Procedencia");
                return false;
            }
            else
            {
                errorValidacion.SetError(cmbEstadoProcedencia, "");
                return true;
            }
        }

        private bool ValidarEscuelaProcedencia()
        {
            if (string.IsNullOrEmpty(txtEscuelaProcedencia.Text))
            {
                errorValidacion.SetError(txtEscuelaProcedencia, "Debes ingresar tu Escuela de Procedencia");
                return false;
            }
            else
            {
                errorValidacion.SetError(txtEscuelaProcedencia, "");
                return true;
            }
        }
        //Creacion de validaciones de Empleado
        private bool ValidarRfc()
        {
            if (string.IsNullOrEmpty(txtRfc.Text))
            {
                errorValidacion.SetError(txtRfc, "Debes ingresar tu Rfc");
                return false;
            }
            else
            {
                errorValidacion.SetError(txtRfc, "");
                return true;
            }
        }
        //Validaciones de Docente
        private bool ValidarNominaDocente()
        {
            int nomina;
            if (!int.TryParse(txtNominaDocente.Text, out nomina) || txtNominaDocente.Text == "")
            {
                errorValidacion.SetError(txtNominaDocente, "Debes ingresar tu número de nómina");
                return false;
            }
            else
            {
                errorValidacion.SetError(txtNominaDocente, "");
                return true;
            }
        }

        private bool ValidarGradEstudiosDocente()
        {
            if (string.IsNullOrEmpty(txtGradEstudDocente.Text))
            {
                errorValidacion.SetError(txtGradEstudDocente, "Ingresa tu grado de estudios");
                return false;
            }
            else
            {
                errorValidacion.SetError(txtGradEstudDocente, "");
                return true;
            }
        }
        private bool ValidarAreaAcademica()
        {
            if (string.IsNullOrEmpty(txtAreaAcademica.Text))
            {
                errorValidacion.SetError(txtAreaAcademica, "Debes ingresar tu área académica");
                return false;
            }
            else
            {
                errorValidacion.SetError(txtAreaAcademica, "");
                return true;
            }
        }
        //Validaciones Directivo
        private bool ValidarNominaDirec()
        {
            int nomina;
            if (!int.TryParse(txtNominaDirec.Text, out nomina) || txtNominaDirec.Text == "")
            {
                errorValidacion.SetError(txtNominaDirec, "Debes ingresar tu número de nómina");
                return false;
            }
            else
            {
                errorValidacion.SetError(txtNominaDirec, "");
                return true;
            }
        }

        private bool ValidarGradEstudiosDirec()
        {
            if (string.IsNullOrEmpty(txtGradEstudDirec.Text))
            {
                errorValidacion.SetError(txtGradEstudDirec, "Ingresa tu grado de estudios");
                return false;
            }
            else
            {
                errorValidacion.SetError(txtGradEstudDirec, "");
                return true;
            }
        }
        private bool ValidarDireccionDirec()
        {
            if (string.IsNullOrEmpty(txtDireccionDirec.Text))
            {
                errorValidacion.SetError(txtDireccionDirec, "Ingresa tu dirección");
                return false;
            }
            else
            {
                errorValidacion.SetError(txtDireccionDirec, "");
                return true;
            }
        }
        private bool ValidarPuestoJefatura()
        {
            if (string.IsNullOrEmpty(txtPuesto.Text))
            {
                errorValidacion.SetError(txtPuesto, "Ingresa tu Puesto o Jefatura");
                return false;
            }
            else
            {
                errorValidacion.SetError(txtPuesto, "");
                return true;
            }
        }
        private bool ValidarEmpleadosACargo()
        {
            int empleados;
            if (!int.TryParse(txtEmpleadosACargo.Text, out empleados) || txtEmpleadosACargo.Text == "")
            {
                errorValidacion.SetError(txtEmpleadosACargo, "Ingresa el numero de empleados a cargo");
                return false;
            }
            else
            {
                errorValidacion.SetError(txtEmpleadosACargo, "");
                return true;
            }
        }
        //Validaciones administrativo
        private bool ValidarNumEmpleado()
        {
            int numEmpleado;
            if (!int.TryParse(txtNumEmpleado.Text, out numEmpleado) || txtNumEmpleado.Text == "")
            {
                errorValidacion.SetError(txtNumEmpleado, "Ingresa tu número de empleado");
                return false;
            }
            else
            {
                errorValidacion.SetError(txtNumEmpleado, "");
                return true;
            }
        }
        private bool ValidarDepartamentoAdscripcion()
        {
            if (string.IsNullOrEmpty(txtDepartAdscripcion.Text))
            {
                errorValidacion.SetError(txtDepartAdscripcion, "Ingresa tu Departamento de Adscripción");
                return false;
            }
            else
            {
                errorValidacion.SetError(txtDepartAdscripcion, "");
                return true;
            }
        }
        private bool ValidarDireccionAdmin()
        {
            if (string.IsNullOrEmpty(txtDireccionAdmin.Text))
            {
                errorValidacion.SetError(txtDireccionAdmin, "Ingresa tu dirección");
                return false;
            }
            else
            {
                errorValidacion.SetError(txtDireccionAdmin, "");
                return true;
            }
        }
        private bool ValidarSeguroSocial()
        {
            if (string.IsNullOrEmpty(txtSeguroSocial.Text))
            {
                errorValidacion.SetError(txtSeguroSocial, "Ingresa tu seguro social");
                return false;
            }
            else
            {
                errorValidacion.SetError(txtSeguroSocial, "");
                return true;
            }
        }
        private bool ValidarCorreo()
        {
            if (string.IsNullOrEmpty(txtCorreo.Text))
            {
                errorValidacion.SetError(txtCorreo, "Ingresa tu correo");
                return false;
            }
            else
            {
                errorValidacion.SetError(txtCorreo, "");
                return true;
            }
        }
        //----------------------------------------------------------------------------------------------
        List<Docente> ListaDocentes = new List<Docente>();
        private void btnGuardarDocente_Click(object sender, EventArgs e)
        {
            //Los metodos de las siguietes validaciones se encuentran en la parte inferior
            RecopilacionValidacionPersona();//5
            if (ValidarRfc() == false)//Empleado
            {
                return;
            }
            if (ValidarNominaDocente() == false)//Docente
            {
                return;
            }
            if (ValidarGradEstudiosDocente() == false)//Docente
            {
                return;
            }
            if (ValidarAreaAcademica() == false)//Docente
            {
                return;
            }
            MessageBox.Show("Los datos se guardaron correctamente", "Datos docente", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //-----------------------------------------------------------------------------------------------
        
        private void btnGuardarDirec_Click(object sender, EventArgs e)
        {
            //Los metodos de las siguietes validaciones se encuentran en la parte inferior
            RecopilacionValidacionPersona();//5
            if (ValidarRfc() == false)//Empleado
            {
                return;
            }
            if (ValidarNominaDirec() == false)//Direc
            {
                return;
            }
            if (ValidarGradEstudiosDirec() == false)//Direc
            {
                return;
            }
            if (ValidarDireccionDirec() == false)//Direc
            {
                return;
            }
            if (ValidarPuestoJefatura() == false)//Direc
            {
                return;
            }
            if (ValidarEmpleadosACargo() == false)//Direc
            {
                return;
            }
            MessageBox.Show("Los datos se guardaron correctamente", "Datos Directivo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //------------------------------------------------------------------------------------------------
        private void btnGuardarAdmin_Click(object sender, EventArgs e)
        {
            //Los metodos de las siguietes validaciones se encuentran en la parte inferior

            RecopilacionValidacionPersona();//5
            if (ValidarRfc() == false)//Empleado
            {
                return;
            }
            if (ValidarNumEmpleado() == false)//Admin
            {
                return;
            }
            if (ValidarDepartamentoAdscripcion() == false)//Admin
            {
                return;
            }
            if (ValidarDireccionAdmin() == false)//Admin
            {
                return;
            }
            if (ValidarSeguroSocial() == false)//Admin
            {
                return;
            }
            if (ValidarCorreo() == false)//Admin
            {
                return;
            }

            MessageBox.Show("Los datos se guardaron correctamente", "Datos Administrativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMostrarAlumno_Click(object sender, EventArgs e)
        {
           


            Alumno alumno = new Alumno();
            alumno.nombre = txtNombre.Text;
            alumno.APaterno = txtApellidoPaterno.Text;
            alumno.AMaterno = txtApellidoMaterno.Text;
            alumno.Curp = txtCurp.Text;
            alumno.Telefono = long.Parse(txtTelefono.Text);
            alumno.numControl = Convert.ToInt32(txtNumControl.Text);
            alumno.fecNacimiento = dtFecNacimiento.Value;
            alumno.genero = cmbGenero.Text;
            alumno.edad = int.Parse(txtEdad.Text);
            alumno.fecIngreso = dtFecIngreso.Value;
            alumno.EstadoProcedencia = cmbEstadoProcedencia.Text;
            alumno.EscuelaProcedencia = txtEscuelaProcedencia.Text;
            ListaAlumnos.Add(alumno);

            dgvAlumno.DataSource = null;
            int n = dgvAlumno.Rows.Add();
            dgvAlumno.Rows[n].Cells[0].Value = alumno.nombre;
            dgvAlumno.Rows[n].Cells[1].Value = alumno.APaterno;
            dgvAlumno.Rows[n].Cells[2].Value = alumno.AMaterno;
            dgvAlumno.Rows[n].Cells[3].Value = alumno.Curp;
            dgvAlumno.Rows[n].Cells[4].Value = alumno.Telefono;
            dgvAlumno.Rows[n].Cells[5].Value = alumno.fecNacimiento;
            dgvAlumno.Rows[n].Cells[6].Value = alumno.genero;
            dgvAlumno.Rows[n].Cells[7].Value = alumno.edad;
            dgvAlumno.Rows[n].Cells[8].Value = alumno.edad;
            dgvAlumno.Rows[n].Cells[9].Value = alumno.fecIngreso;
            dgvAlumno.Rows[n].Cells[10].Value = alumno.EstadoProcedencia;
            dgvAlumno.Rows[n].Cells[11].Value = alumno.EscuelaProcedencia;
        }

        private void btnMostrarDocente_Click(object sender, EventArgs e)
        {
            
            Docente docenteEscuela = new Docente();
            docenteEscuela.nombre = txtNombre.Text;
            docenteEscuela.APaterno = txtApellidoPaterno.Text;
            docenteEscuela.AMaterno = txtApellidoMaterno.Text;
            docenteEscuela.Curp = txtCurp.Text;
            docenteEscuela.Telefono = long.Parse(txtTelefono.Text);
            docenteEscuela.numNomina = Convert.ToInt32(txtNominaDocente.Text);
            docenteEscuela.gradEstudios = txtGradEstudDocente.Text;
            docenteEscuela.areaAcademica = txtAreaAcademica.Text;
            
            //dgvDocente.Columns.Add("ColumNombre", "Nombre");
            //dgvDocente.Columns.Add("ColumPaterno", "Apellido Paterno");
            //dgvDocente.Columns.Add("ColumMaterno", "Apellido Materno");
            //dgvDocente.Columns.Add("ColumCurp", "Curp");
            //dgvDocente.Columns.Add("ColumTelefono", "Télefono");
            ListaDocentes.Add(docenteEscuela);
           
            dgvDocente.DataSource = null;
            int n = dgvDocente.Rows.Add();
            dgvDocente.Rows[n].Cells[0].Value = docenteEscuela.nombre;
            dgvDocente.Rows[n].Cells[1].Value = docenteEscuela.APaterno;
            dgvDocente.Rows[n].Cells[2].Value = docenteEscuela.AMaterno;
            dgvDocente.Rows[n].Cells[3].Value = docenteEscuela.Curp;
            dgvDocente.Rows[n].Cells[4].Value = docenteEscuela.Telefono;
            dgvDocente.Rows[n].Cells[5].Value = docenteEscuela.numNomina;
            dgvDocente.Rows[n].Cells[6].Value = docenteEscuela.gradEstudios;
            dgvDocente.Rows[n].Cells[7].Value = docenteEscuela.areaAcademica;
            //dgvDocente.DataSource = null;
            //dgvDocente.DataSource = dgvDocente.Columns.Count.CompareTo(ListaDocentes);

        }

        private void btnNuevoDocente_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellidoPaterno.Clear();
            txtApellidoMaterno.Clear();
            txtCurp.Clear();
            txtTelefono.Clear();
            txtRfc.Clear();
            txtNominaDocente.Clear();
            txtGradEstudDocente.Clear();
            txtAreaAcademica.Clear();
        }
    }
}

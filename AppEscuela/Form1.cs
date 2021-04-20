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
            //Agregamos items al combo Genero
            cmbGenero.Items.Add("Femenino");
            cmbGenero.Items.Add("Masculino");
            //Como son 32 estados, entonces con un array ingresamos todos los estados de Mex
            string[] estados = {"Aguascalientes","Baja California","Baja California","Campeche",
                "Chiapas","Chihuahua","Ciudad de México","Coahuila","Colima","Durango",
                "Guanajuato","Guerrero","Hidalgo","Jalisco","México","Michoacán","Morelos",
                "Nayarit","Nuevo León","Oaxaca","Puebla","Querétaro","Quintana Roo",
                "San Luis Potosí","Sinaloa","Sonora","Tabasco","Tamaulipas","Tlaxcala",
                "Veracruz","Yucatán","Zacatecas" };

            for (int i = 0; i < estados.Length; i++)//Lo leemos con un for
            {
                cmbEstadoProcedencia.Items.Add(estados[i]);//Es decir, que cada item sera de 
                //a cuerdo al numero que recorra
            }
        }

        //-----------------------------------------------------------------------------------------
        List<Alumno> ListaAlumnos = new List<Alumno>();//Creacion de lista o coleccion para 
                                                       //guardar los datos de alumno
                                                       //Instanciamos un objeto de la clase Alumno
        Alumno alumno = new Alumno();
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
            //Igualamos las propiedades de dicho objeto con las texBox, o ComboBox...
            alumno.nombre = txtNombre.Text;
            alumno.APaterno = txtApellidoPaterno.Text;
            alumno.AMaterno = txtApellidoMaterno.Text;
            alumno.Curp = txtCurp.Text;
            alumno.Telefono = txtTelefono.Text;
            alumno.numControl = Convert.ToInt32(txtNumControl.Text);
            alumno.fecNacimiento = dtFecNacimiento.Text;
            alumno.genero = cmbGenero.Text;
            alumno.edad = int.Parse(txtEdad.Text);
            alumno.fecIngreso = dtFecIngreso.Text;
            alumno.EstadoProcedencia = cmbEstadoProcedencia.Text;
            alumno.EscuelaProcedencia = txtEscuelaProcedencia.Text;
            ListaAlumnos.Add(alumno);//Lo añadimos a la lista o coleccion creada anteriormente
            btnMostrarAlumno.Enabled = true;
            //Hecha las validaciones, se confirma el guardado de datos
            MessageBox.Show("Los datos se guardaron correctamente", "Datos Alumnos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Como esatremos ocupando las mismas validaciones 4 veces, entonces creamos un metodo
        //para solo llamar a la funcion cuando sea necesaria
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

            if (string.IsNullOrEmpty(txtNombre.Text))
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
            int nominaDocente;
            if (!int.TryParse(txtNominaDocente.Text, out nominaDocente) || txtNominaDocente.Text == "")
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
            int nominaDirec;
            if (!int.TryParse(txtNominaDirec.Text, out nominaDirec) || txtNominaDirec.Text == "")
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
        Docente docenteEscuela = new Docente();
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
            docenteEscuela.nombre = txtNombre.Text;
            docenteEscuela.APaterno = txtApellidoPaterno.Text;
            docenteEscuela.AMaterno = txtApellidoMaterno.Text;
            docenteEscuela.Curp = txtCurp.Text;
            docenteEscuela.Telefono = txtTelefono.Text;
            docenteEscuela.rfc = txtRfc.Text;
            docenteEscuela.numNomina = Convert.ToInt32(txtNominaDocente.Text);
            docenteEscuela.gradEstudios = txtGradEstudDocente.Text;
            docenteEscuela.areaAcademica = txtAreaAcademica.Text;
            ListaDocentes.Add(docenteEscuela);
            MessageBox.Show("Los datos se guardaron correctamente", "Datos docente", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //-----------------------------------------------------------------------------------------------
        List<Directivo> ListaDirectivo = new List<Directivo>();
        Directivo directivo = new Directivo();
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
            directivo.nombre = txtNombre.Text;
            directivo.APaterno = txtApellidoPaterno.Text;
            directivo.AMaterno = txtApellidoMaterno.Text;
            directivo.Curp = txtCurp.Text;
            directivo.Telefono = txtTelefono.Text;
            directivo.rfc = txtRfc.Text;
            directivo.numNomina = Convert.ToInt32(txtNominaDirec.Text);
            directivo.gradEstudios = txtGradEstudDirec.Text;
            directivo.direccion = txtDireccionDirec.Text;
            directivo.puestoJefatura = txtPuesto.Text;
            directivo.EmpleadosCargo = Convert.ToInt32(txtEmpleadosACargo.Text);
            ListaDirectivo.Add(directivo);
            MessageBox.Show("Los datos se guardaron correctamente", "Datos Directivo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //------------------------------------------------------------------------------------------------
        List<Administrativo> ListaAdministrativo = new List<Administrativo>();
        Administrativo administrativo = new Administrativo();
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
            administrativo.nombre = txtNombre.Text;
            administrativo.APaterno = txtApellidoPaterno.Text;
            administrativo.AMaterno = txtApellidoMaterno.Text;
            administrativo.Curp = txtCurp.Text;
            administrativo.Telefono = txtTelefono.Text;
            administrativo.rfc = txtRfc.Text;
            administrativo.numEmpleado = Convert.ToInt32(txtNumEmpleado.Text);
            administrativo.departamentoAdscripcion = txtDepartAdscripcion.Text;
            administrativo.direccion = txtDireccionAdmin.Text;
            administrativo.seguroSocial = txtSeguroSocial.Text;
            administrativo.correo = txtCorreo.Text;
            MessageBox.Show("Los datos se guardaron correctamente", "Datos Administrativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMostrarAlumno_Click(object sender, EventArgs e)
        {
            if (ValidarNombre() == false)//Si da clic en Mostrar y no hay nada guardado
                                         //mostrará error de validacion en la casilla txtNombre, de esta forma el
                                         //programa no caé
            {
                return;
            }
            dgvAlumno.DataSource = null;
            int n = dgvAlumno.Rows.Add();
            dgvAlumno.Rows[n].Cells[0].Value = alumno.nombre;
            dgvAlumno.Rows[n].Cells[1].Value = alumno.APaterno;
            dgvAlumno.Rows[n].Cells[2].Value = alumno.AMaterno;
            dgvAlumno.Rows[n].Cells[3].Value = alumno.Curp;
            dgvAlumno.Rows[n].Cells[4].Value = alumno.Telefono;
            dgvAlumno.Rows[n].Cells[5].Value = alumno.numControl;
            dgvAlumno.Rows[n].Cells[6].Value = alumno.fecNacimiento;
            dgvAlumno.Rows[n].Cells[7].Value = alumno.genero;
            dgvAlumno.Rows[n].Cells[8].Value = alumno.edad;
            dgvAlumno.Rows[n].Cells[9].Value = alumno.fecIngreso;
            dgvAlumno.Rows[n].Cells[10].Value = alumno.EstadoProcedencia;
            dgvAlumno.Rows[n].Cells[11].Value = alumno.EscuelaProcedencia;
            btnNuevoAlumno.Enabled = true;
            //if (btnMostrarAlumno.Enabled == true) { btnEliminarAlumno.Enabled = true; }
            btnEliminarAlumno.Enabled = true;
        }
        private void btnNuevoAlumno_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellidoPaterno.Clear();
            txtApellidoMaterno.Clear();
            txtCurp.Clear();
            txtTelefono.Clear();
            txtNumControl.Clear();
            dtFecNacimiento.Text = null;
            cmbGenero.Text = null;
            txtEdad.Clear();
            dtFecIngreso.Text = null;
            cmbEstadoProcedencia.Text = null;
            txtEscuelaProcedencia.Clear();
            btnMostrarAlumno.Enabled = false;
            btnNuevoAlumno.Enabled = false;
        }
        private void btnMostrarDocente_Click(object sender, EventArgs e)
        {
            if (ValidarNombre() == false)//Si da clic en Mostrar y no hay nada guardado
                                         //mostrará error de validacion en la casilla txtNombre, de esta forma el
                                         //programa no caé
            {
                return;
            }


            dgvDocente.DataSource = null;
            int n = dgvDocente.Rows.Add();
            dgvDocente.Rows[n].Cells[0].Value = docenteEscuela.nombre;
            dgvDocente.Rows[n].Cells[1].Value = docenteEscuela.APaterno;
            dgvDocente.Rows[n].Cells[2].Value = docenteEscuela.AMaterno;
            dgvDocente.Rows[n].Cells[3].Value = docenteEscuela.Curp;
            dgvDocente.Rows[n].Cells[4].Value = docenteEscuela.Telefono;
            dgvDocente.Rows[n].Cells[5].Value = docenteEscuela.rfc;
            dgvDocente.Rows[n].Cells[6].Value = docenteEscuela.numNomina;
            dgvDocente.Rows[n].Cells[7].Value = docenteEscuela.gradEstudios;
            dgvDocente.Rows[n].Cells[8].Value = docenteEscuela.areaAcademica;
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

        private void btnMostrarDirec_Click(object sender, EventArgs e)
        {
            if (ValidarNombre() == false)
            {
                return;
            }
            dgvDirec.DataSource = null;
            int n = dgvDirec.Rows.Add();
            dgvDirec.Rows[n].Cells[0].Value = directivo.nombre;
            dgvDirec.Rows[n].Cells[1].Value = directivo.APaterno;
            dgvDirec.Rows[n].Cells[2].Value = directivo.AMaterno;
            dgvDirec.Rows[n].Cells[3].Value = directivo.Curp;
            dgvDirec.Rows[n].Cells[4].Value = directivo.Telefono;
            dgvDirec.Rows[n].Cells[5].Value = directivo.rfc;
            dgvDirec.Rows[n].Cells[6].Value = directivo.numNomina;
            dgvDirec.Rows[n].Cells[7].Value = directivo.gradEstudios;
            dgvDirec.Rows[n].Cells[8].Value = directivo.direccion;
            dgvDirec.Rows[n].Cells[9].Value = directivo.puestoJefatura;
            dgvDirec.Rows[n].Cells[10].Value = directivo.EmpleadosCargo;
           
        }

        private void btnNuevoDirec_Click(object sender, EventArgs e)
        {

            txtNombre.Clear();
            txtApellidoPaterno.Clear();
            txtApellidoMaterno.Clear();
            txtCurp.Clear();
            txtTelefono.Clear();
            txtRfc.Clear();
            txtNominaDirec.Clear();
            txtGradEstudDirec.Clear();
            txtDireccionDirec.Clear();
            txtPuesto.Clear();
            txtEmpleadosACargo.Clear();
        }

        private void btnMostrarAdmin_Click(object sender, EventArgs e)
        {
            if (ValidarNombre() == false)//Si da clic en Mostrar y no hay nada guardado
                                         //mostrará error de validacion en la casilla txtNombre, de esta forma el
                                         //programa no caé
            {
                return;
            }
            dgvDirec.DataSource = null;
            int n = dgvAdmin.Rows.Add();
            dgvAdmin.Rows[n].Cells[0].Value = administrativo.nombre;
            dgvAdmin.Rows[n].Cells[1].Value = administrativo.APaterno;
            dgvAdmin.Rows[n].Cells[2].Value = administrativo.AMaterno;
            dgvAdmin.Rows[n].Cells[3].Value = administrativo.Curp;
            dgvAdmin.Rows[n].Cells[4].Value = administrativo.Telefono;
            dgvAdmin.Rows[n].Cells[5].Value = administrativo.rfc;
            dgvAdmin.Rows[n].Cells[6].Value = administrativo.numEmpleado;
            dgvAdmin.Rows[n].Cells[7].Value = administrativo.departamentoAdscripcion;
            dgvAdmin.Rows[n].Cells[8].Value = administrativo.direccion;
            dgvAdmin.Rows[n].Cells[9].Value = administrativo.seguroSocial;
            dgvAdmin.Rows[n].Cells[10].Value = administrativo.correo;
            
        }

        private void btnNuevoAdmin_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellidoPaterno.Clear();
            txtApellidoMaterno.Clear();
            txtCurp.Clear();
            txtTelefono.Clear();
            txtRfc.Clear();
            txtNumEmpleado.Clear();
            txtDepartAdscripcion.Clear();
            txtDireccionAdmin.Clear();
            txtSeguroSocial.Clear();
            txtCorreo.Clear();
        }

        private void btnEliminarAlumno_Click(object sender, EventArgs e)
        {
            try 
            {
                if (dgvAlumno.Enabled == false) { }
                else
                {
                    DialogResult resultado = MessageBox.Show("¿Desea eliminar la fila seleccionada", "Confirme eliminacion",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    if (resultado == DialogResult.Yes)
                    {
                        int n = dgvAlumno.CurrentRow.Index;
                        dgvAlumno.Rows.RemoveAt(n);
                    }
                }
            }
            catch
            {
                btnEliminarAlumno.Enabled = false;
                errorValidacion.SetError(btnEliminarAlumno, "No hay ningun elemento a eliminar");
            }
        }
    }
}

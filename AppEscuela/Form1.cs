using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscuela
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnGuardarAlumno_Click(object sender, EventArgs e)
        {
            if (ValidarNombre() == false)
            {
                return;
            }
            if (ValidarAPaterno() == false)
            {
                return;
            }
            if (ValidarAMaterno() == false)
            {
                return;
            }
            if (ValidarCurp() == false)
            {
                return;
            }
            if (ValidarTelefono() == false)
            {
                return;
            }
            if (ValidarNumControl() == false)
            {
                return;
            }
            //if (ValidarFecNacimiento() == false)
            //{
            //    return;
            //}
            if (ValidarGenero() == false)
            {
                return;
            }
            if (ValidarEdad() == false)
            {
                return;
            }
            //if (ValidarFecIngreso() == false)
            //{
            //    return;
            //}
            if (ValidarEstadoProcedencia() == false)
            {
                return;
            }
            if (ValidarEscuelaProcedencia() == false)
            {
                return;
            }

        }
        //Creacion de validaciones de todos los campos
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
            int curp;
            if(!int.TryParse(txtCurp.Text, out curp) || txtCurp.Text == "")
            {
                errorValidacion.SetError(txtCurp, "Solo se permite números enteros o está vacio");
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
                errorValidacion.SetError(txtTelefono, "Debes ingresar tu numero de telefono");
                return false;
            }
            else
            {
                errorValidacion.SetError(txtTelefono, "");
                return true;
            }
        }
        private bool ValidarNumControl()
        {
            int telefono;
            if (!int.TryParse(txtNumControl.Text, out telefono) || txtNumControl.Text == "")
            {
                errorValidacion.SetError(txtNumControl, "Debes ingresar tu numero de control");
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
                errorValidacion.SetError(cmbGenero, "Debes elegir una género");
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
                errorValidacion.SetError(cmbEstadoProcedencia, "Debes elegir una género");
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
                errorValidacion.SetError(txtEscuelaProcedencia, "Debes ingresar un nombre");
                return false;
            }
            else
            {
                errorValidacion.SetError(txtEscuelaProcedencia, "");
                return true;
            }
        }

    }
}

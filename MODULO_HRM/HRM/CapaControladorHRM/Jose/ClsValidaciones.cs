using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;

namespace CapaControladorHRM.Jose
{
    public class ClsValidaciones
    {
        public void funcSoloLetras(KeyPressEventArgs validar)
        {

            try
            {
                if (Char.IsLetter(validar.KeyChar))
                {
                    validar.Handled = false;
                }
                else if (Char.IsControl(validar.KeyChar))
                {
                    validar.Handled = false;
                }
                else if (Char.IsSeparator(validar.KeyChar))
                {
                    validar.Handled = false;
                }
                else
                {
                    validar.Handled = true;
                    MessageBox.Show("Ingrese solo letras", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("validacion de letras fallo", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void ValidadCantidad(KeyPressEventArgs validar , TextBox txtValidar , int Cantidad)
        {
            bool mensaje = false;
            if (txtValidar.Text.Length == Cantidad)
            {
                validar.Handled = true;
                mensaje = true;
                if (validar.KeyChar == 8)
                {
                    validar.Handled = false;
                    mensaje = false;
                }
            }
            if (mensaje == true)
            {
                MessageBox.Show("El maximo de caracteres para el campo es de "+Cantidad+".", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void funcSoloNumerosDecimales(KeyPressEventArgs validar)
        {
            try
            {
                if (Char.IsLetter(validar.KeyChar))
                {
                    validar.Handled = true;
                    MessageBox.Show("Ingrese solo Numeros Enteros o con punto decimal", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (Char.IsControl(validar.KeyChar))
                {
                    validar.Handled = false;
                }
                else if (Char.IsSeparator(validar.KeyChar))
                {
                    validar.Handled = false;
                }else if(char.IsDigit(validar.KeyChar))
                {
                    validar.Handled = false;
                }else if(validar.KeyChar.ToString().Equals("."))
                {
                    validar.Handled = false;
                }
                else
                {
                    validar.Handled = true;
                    MessageBox.Show("Ingrese solo Numeros Enteros o con punto decimal", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("validacion de numeros Enteros o con punto decimal fallo", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void funcSoloNumeros(KeyPressEventArgs validar)
        {
            try
            {
                if (Char.IsLetter(validar.KeyChar))
                {
                    validar.Handled = true;
                    MessageBox.Show("Ingrese solo Numeros Enteros", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (Char.IsControl(validar.KeyChar))
                {
                    validar.Handled = false;
                }
                else if (Char.IsSeparator(validar.KeyChar))
                {
                    validar.Handled = false;
                }
                else if (char.IsDigit(validar.KeyChar))
                {
                    validar.Handled = false;
                }
                else
                {
                    validar.Handled = true;
                    MessageBox.Show("Ingrese solo Numeros Enteros", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("validacion de numeros Enteros Fallo", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

 
    }
}

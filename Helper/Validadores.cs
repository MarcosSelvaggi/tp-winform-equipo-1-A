﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Helper
{
    public class Validadores
    {
        public static bool txtSoloNumeros(TextBox txt, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            if ((e.KeyChar == ',') && !txt.Text.Contains(','))
            {
                e.Handled = false;
                return true;
            }
            e.Handled = true;
            return false;
        }
        public static bool txtVacio(TextBox txt)
        {
            if (txt.Text == string.Empty)
            {
                txt.Focus();
                return true;
            }
            else
                return false;
        }

    }
}

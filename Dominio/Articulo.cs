﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
       
        public int IdMarca { get; set; }
        public int IdCategoria { get; set; }


        public Articulo(string codigo, string nombre, string descripcion, decimal precio, int idMarca, int idCategoria)
        {
            Codigo = codigo;
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
            IdMarca = idMarca;
            IdCategoria = idCategoria;
        }
    }
}

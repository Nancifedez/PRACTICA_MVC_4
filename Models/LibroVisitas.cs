﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.IO;

namespace PRACTICA_MVC_4.Models
{
    public class LibroVisitas
    {
        public void Grabar(string nombre, string comentarios)
        {
            StreamWriter archivo = new StreamWriter(HostingEnvironment.MapPath("~") + "/App_Data/datos.txt", true);
            archivo.WriteLine("nombre:" + nombre + "<br>comentarios:" + comentarios + "<hr>");
            archivo.Close();

        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//usando fremework entity para la base de datos
using System.Data.Entity;

namespace Proyecto_Alumnos_MVC.Models
{
    public class Alumnos
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Grado { get; set; }
        }

    public class AlumnosDBContext : DbContext
    {
        public DbSet<Alumnos> Alumno { get; set; }
    }
}
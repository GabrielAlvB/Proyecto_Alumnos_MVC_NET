using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_Alumnos_MVC.Models
{
    public class Materias
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        //el boolean del estado no estoy seguro como lo tome para dar las altas
        public Boolean Estado { get; set; }

    }

    public class MateriasDBContext : DbContext
    {
        public DbSet<Materias> Materia { get; set; }
    }


}
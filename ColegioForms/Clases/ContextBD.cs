using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ColegioForms.Clases
{
    public partial class ContextBD : DbContext
    {
        public ContextBD()
            : base("name=ContextBD")
        {
        }

        public virtual DbSet<Alumno> Alumnos { get; set; }
        public virtual DbSet<Curso> Cursos { get; set; }
        public virtual DbSet<Profesor> Profesores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alumno>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Curso>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Curso>()
                .HasMany(e => e.Alumnos)
                .WithRequired(e => e.Curso)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Profesor>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Profesor>()
                .HasMany(e => e.Cursos)
                .WithRequired(e => e.Profesore)
                .WillCascadeOnDelete(false);
        }
    }
}

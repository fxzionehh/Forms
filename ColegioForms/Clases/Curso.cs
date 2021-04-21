namespace ColegioForms.Clases
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cursos")]
    public partial class Curso
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Curso()
        {
            Alumnos = new HashSet<Alumno>();
        }

        [Key]
        public int idCurso { get; set; }

        [StringLength(50)]
        public string Nombre { get; set; }

        public int idProfesor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Alumno> Alumnos { get; set; }

        public virtual Profesor Profesore { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ColegioMVC.Models
{
    public class Expediente
    {
        [Key]
        public int ExpedienteId { get; set; }

        [ForeignKey("Alumno")]
        public int AlumnoId { get; set; }

        [ForeignKey("Materia")]
        public int MateriaId { get; set; }

        public decimal NotaFinal { get; set; }

        public string Observaciones { get; set; }

        public Alumno? Alumno { get; set; }

        public Materia? Materia { get; set; }
    }
}
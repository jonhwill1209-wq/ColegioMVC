using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ColegioMVC.Models
{
    public class Expediente
    {
        [Key]
        public int ExpedienteId { get; set; }

        public int AlumnoId { get; set; }

        public int MateriaId { get; set; }

        public decimal NotaFinal { get; set; }

        public string Observaciones { get; set; }

        [ForeignKey("AlumnoId")]
        public Alumno? Alumno { get; set; }

        [ForeignKey("MateriaId")]
        public Materia? Materia { get; set; }
    }
}
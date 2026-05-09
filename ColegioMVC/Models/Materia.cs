using System.ComponentModel.DataAnnotations;

namespace ColegioMVC.Models
{
    public class Materia
    {
        [Key]
        public int MateriaId { get; set; }

        public string NombreMateria { get; set; }

        public string Docente { get; set; }
    }
}
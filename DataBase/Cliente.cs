using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataBase
{
    public class Cliente
    {
        [Key]
        [MaxLength(10)]
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        [MaxLength(1)]
        public string Sexo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public string Pais { get; set; }
        [MaxLength(5)]
        public string CodigoPostal { get; set; }
        public string Email { get; set; }
    }
}

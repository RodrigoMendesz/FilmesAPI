using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Models
{
    public class Filme
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo titulo é obtigatório")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo diretor é obtigatório")]
        public string Diretor { get; set; }
        [StringLength(30, ErrorMessage = "O genero não pode passar de 30 carcteres")]
        public string Genero { get; set; }
        [Range(1, 600, ErrorMessage = "O campo duração deve ter no minimo 1 e no máximo 600 minutos")]
        public int Duracao { get; set; }
    }
}

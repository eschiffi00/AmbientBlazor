using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLibrary.ViewModels
{
    public class Ratio
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int ItemId { get; set; }
        [Required]
        public string ExperienciaBarra { get; set; } = string.Empty;
        [Required]
        public string TipoRatio { get; set; } = string.Empty;
        [Required]
        public double BaseRatio { get; set; }
        [Required]
        public double ValorRatio { get; set; }
        [Required]
        public double TopeRatio { get; set; }
        public bool? Isla { get; set; }
        [Required]
        public bool Adultos { get; set; }
        [Required]
        public bool Menores3 { get; set; }
        [Required]
        public bool Menores3y8 { get; set; }
        [Required]
        public bool Adolescentes { get; set; }
        [Required]
        public bool FijoRatio { get; set; }
        public int EstadoId { get; set; }
        public int? ItemRatioId { get; set; }
        public int? ProductoRatioId { get; set; }
        public int? CategoriaRatioId { get; set; }
    }

}

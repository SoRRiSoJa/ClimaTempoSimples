using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClimaTempoSimples.Models
{
    [Table("PrevisaoClima")]
    public class PrevisaoClima
    {
        public int Id { get; set; }

        public int CidadeId { get; set; }

        [Column(TypeName = "date")]
        public DateTime DataPrevisao { get; set; }

        [Required]
        [StringLength(15)]
        public string Clima { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TemperaturaMinima { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TemperaturaMaxima { get; set; }

        public virtual Cidade Cidade { get; set; }
    }
}
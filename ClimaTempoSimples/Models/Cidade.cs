using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClimaTempoSimples.Models
{
    [Table("Cidade")]
    public class Cidade
    {
        public Cidade()
        {
            PrevisaoClima = new HashSet<PrevisaoClima>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Nome { get; set; }

        public int EstadoId { get; set; }

        public virtual Estado Estado { get; set; }

        public virtual ICollection<PrevisaoClima> PrevisaoClima { get; set; }
    }
}
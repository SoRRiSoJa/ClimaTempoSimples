using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClimaTempoSimples.Models
{
    [Table("Estado")]
    public class Estado
    {
        public Estado()
        {
            Cidade = new HashSet<Cidade>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Nome { get; set; }

        [Required]
        [StringLength(2)]
        public string UF { get; set; }
        public virtual ICollection<Cidade> Cidade { get; set; }
    }
}
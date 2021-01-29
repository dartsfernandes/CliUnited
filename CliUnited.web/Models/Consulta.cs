using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CliUnited.web.Models
{
    [Table("Consulta")]
    public class Consulta
    {
        [Key]
        public int id_consulta { get; set; }

        public string id_utilizador_utente { get; set; }
        public string id_utilizador_profissional_saude { get; set; }
        public string id_clinica { get; set; }
        public string id_especialidade_consulta { get; set; }
        public string id_tratamento { get; set; }
        public string id_protocolo { get; set; }
        public string id_gabinete { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal preco { get; set; }
        public string urgente { get; set; }
        public string domicilio { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{yyyy-MM-dd:0}", ApplyFormatInEditMode = true)]
        public string data { get; set; }
    

    }
}

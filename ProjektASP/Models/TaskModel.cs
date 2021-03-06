using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektASP.Models
{
    [Table ("Tasks")]
    public class TaskModel
    {
        [Key]
        public int TaskId { get; set; }
        [DisplayName("Nazwa")]
        [Required(ErrorMessage = "To pole nie może być puste.")]
        [MaxLength(50)]
        public string Name { get; set; }
        [DisplayName("Opis")]
        [MaxLength(2000)]
        public string Description { get; set; }

        public bool Done { get; set; }
    }
}

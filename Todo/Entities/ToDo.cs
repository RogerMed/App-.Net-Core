using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    [Table("Todo")]
     public class ToDo : ToDo<int>
    {
        [Required]
        [Column("Tarefa")]
        public string Tarefa { get; set; }
    }
}

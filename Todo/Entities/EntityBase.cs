using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    public class ToDo<T> where T : struct
    {
        [Key]
        [Column("Id")]
        public T id { get; set; }
    }
}

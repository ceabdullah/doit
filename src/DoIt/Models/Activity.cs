using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DoIt.Models
{
    public class Activity
    {
        [Key]
        public int Activity_Id { get; set; }
        public string Activity_Name { get; set; }
    }
}

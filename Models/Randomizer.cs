using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EF.Core.Tutorial.Models
{
    internal class Randomizer
    {
        [Key]
        public Guid UniqueId { get; set; }
        public int KeyGen { get; set; }
        public DateTime DateCreated { get; set; }
    }
}

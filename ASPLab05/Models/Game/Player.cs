using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPLab05.Models.Game
{
    public class Player
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(40)]
        public string Name { get; set; }
        [MaxLength(40)]
        public string Surname { get; set; }
    }
}
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mvc_MusteriTakipUygulaması.Models
{
    public class Admin
    {

        [Key]
        public int AdminID { get; set; }

        [Column(TypeName = "Varchar(20)")]
        [StringLength(20,MinimumLength = 6)]
        public string UserName { get; set; }

        [Column(TypeName = "Varchar(20)")]
        [StringLength(20, MinimumLength = 6)]
        public string Password { get; set; }

        [StringLength(1)]
        public string AdminRole { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Company { get; set; }

    }
}

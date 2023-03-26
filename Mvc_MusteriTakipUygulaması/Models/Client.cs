using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mvc_MusteriTakipUygulaması.Models
{
    public class Client
    {
        [Key]
        public int MusteriID { get; set; }

        public string Unvan { get; set; }

        public string VergiNo { get; set; }

        public string VergiDairesi { get; set; }

        public string TelNo { get; set; }

        public string Adres { get; set; }

        public string WebSitesi { get; set; }

        public string Email { get; set; }

        public string ImzaYetkilisiAdiSoyadi1 { get; set; }

        public string? ImzaYetkilisiAdiSoyadi2 { get; set; }

        public string? ImzaYetkilisiAdiSoyadi3 { get; set; }

        public string ImzaYetkilisiMail1 { get; set; }

        public string? ImzaYetkilisiMail2 { get; set; }

        public string? ImzaYetkilisiMail3 { get; set; }

        public string IletisimYetkilisiAdiSoyadi1 { get; set; }

        public string? IletisimYetkilisiAdiSoyadi2 { get; set; }

        public string? IletisimYetkilisiAdiSoyadi3 { get; set; }

    }
}

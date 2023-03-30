using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mvc_MusteriTakipUygulaması.Models
{
    public class WorkList
    {
        [Key]
        public int WorkID { get; set; }
        public string? YapilacakIs { get; set; }
        public string? KurumAdi { get; set; }
        public string? IsiTakipEdenPersonel { get; set; }
        public string? IsinTeslimEdilecegiYetkili { get; set; }
        public string? HizmetBedeli { get; set; }
        public string? HarcBedeli { get; set; }
        public string? ToplamFaturaBedeli { get; set; }
        public DateTime Tarih { get; set; }

        public int MusteriID { get; set; }
        
        [ForeignKey("MusteriID")]
        public Client Client { get; set; }

    }
}

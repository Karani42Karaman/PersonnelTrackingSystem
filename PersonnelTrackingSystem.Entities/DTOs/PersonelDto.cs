using PersonnelTrackingSystem.Entities.Common;
using System;

namespace PersonnelTrackingSystem.Entities.DTOs
{
    public class PersonelDto : BaseDto
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Sehir { get; set; }
        public string Adres { get; set; }
    }
}

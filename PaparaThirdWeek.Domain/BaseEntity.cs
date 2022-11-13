using System;

namespace PaparaThirdWeek.Domain
{
    public abstract class BaseEntity
    {
        public int CarId { get; set; }

        public bool IsDeleted { get; set; }
        //kaydın yaratılma tarıhı
        public DateTime CreatedDate { get; set; }
        // bu kaydı kım yarattı
        public string CreatedBy { get; set; }
        //Son degiştirilme tarihi
        public DateTime? LastUpdateAt { get; set; }
        // kim tarafından uppdate edilid
        public string LastUpdateBy { get; set; }
    }
}

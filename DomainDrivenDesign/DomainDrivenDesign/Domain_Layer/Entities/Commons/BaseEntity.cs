using System;

namespace Domain_Layer.Entities.Commons
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsDelete { get; set; } = false;
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public int CreateBy { get; set; } = 1;
        public DateTime? UpdateDate { get; set; }
        public int? UpdateBy { get; set; }
    }
}

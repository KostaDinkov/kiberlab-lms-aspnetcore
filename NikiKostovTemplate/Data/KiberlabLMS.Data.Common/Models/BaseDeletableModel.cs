namespace KiberlabLMS.Data.Common.Models
{
    using System;

    public abstract class BaseDeletableModel<TKey> : BaseModel, IDeletableEntity
    {
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}

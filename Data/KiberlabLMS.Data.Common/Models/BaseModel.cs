using System;
using System.ComponentModel.DataAnnotations;

namespace KiberlabLMS.Data.Common.Models
{
    public abstract class BaseModel : IAuditInfo
    {
        protected BaseModel()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        [Key]
        public string Id { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }
    }
}

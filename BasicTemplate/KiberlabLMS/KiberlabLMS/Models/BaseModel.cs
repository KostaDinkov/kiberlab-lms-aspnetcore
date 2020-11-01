using System;
using System.ComponentModel.DataAnnotations;

namespace KiberlabLMS.Models
{
    public abstract class BaseModel 
    {
        protected BaseModel()
        {
            this.Id = Guid.NewGuid().ToString();
            this.CreatedOn = DateTime.UtcNow;
        }

        [Key]
        public string Id { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }
    }
}

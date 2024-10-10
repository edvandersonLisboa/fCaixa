using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Shared.Constants.ValidationErrors;
using Flunt.Notifications;
using Flunt.Validations;

namespace Shared.Entities
{
    public abstract class Entity 
        //: Notifiable<Notification>
    {
        protected Entity() { }

        protected Entity( bool isActive, DateTime creationDate, DateTime? lastUpdateDate)
        {
            IsActive = isActive;
            CreationDate = creationDate;
            LastUpdateDate = lastUpdateDate;
        }

        public int Id { get; set; }

        public bool IsActive { get; protected set; } = true;

        [Required]
        public DateTime CreationDate { get; protected set; } = TimeZoneInfo.ConvertTime(DateTime.UtcNow, TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time"));

        public DateTime? LastUpdateDate { get; protected set; } 

        public void SetLastUpdateDate()
        {
            LastUpdateDate = TimeZoneInfo.ConvertTime(DateTime.UtcNow, TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time"));
            //ValidateLastUpdateDate();
        }

        public void Inactivate()
        {
            IsActive = false;
        }

        public void Activate()
        {
            IsActive = true;
        }


        //private void ValidateLastUpdateDate()
        //{
        //    if (LastUpdateDate.HasValue)
        //        AddNotifications(new Contract<Notification>()
        //            .Requires()
        //            .IsGreaterThan(LastUpdateDate.Value, CreationDate, nameof(LastUpdateDate), EntityValidationErrors.LAST_UPDATE_DATETIME_BEFORE_CREATION_TIME_ERROR)
        //        );
        //}
    }
}

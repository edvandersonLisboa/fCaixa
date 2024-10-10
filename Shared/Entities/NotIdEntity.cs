using Flunt.Notifications;
using Flunt.Validations;
using Shared.Constants.ValidationErrors;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Entities
{
    public abstract class NotIdEntity : Notifiable<Notification>
    {
        protected NotIdEntity() { }

        protected NotIdEntity( bool isActive, DateTime creationDate, DateTime? lastUpdateDate)
        {

            IsActive = isActive;
            CreationDate = creationDate;
            LastUpdateDate = lastUpdateDate;
        }


        public bool IsActive { get; protected set; } = true;

        [Required]
        public DateTime CreationDate { get; protected set; } = DateTime.UtcNow;

        public DateTime? LastUpdateDate { get; protected set; }

        public void SetLastUpdateDate(DateTime lastUpdateDate)
        {
            LastUpdateDate = lastUpdateDate;
            ValidateLastUpdateDate();
        }

        public void Inactivate()
        {
            IsActive = false;
        }

        public void Activate()
        {
            IsActive = true;
        }

        private void ValidateLastUpdateDate()
        {
            if (LastUpdateDate.HasValue)
                AddNotifications(new Contract<Notification>()
                    .Requires()
                    .IsGreaterThan(LastUpdateDate.Value, CreationDate, nameof(LastUpdateDate), EntityValidationErrors.LAST_UPDATE_DATETIME_BEFORE_CREATION_TIME_ERROR)
                );
        }
    }
}

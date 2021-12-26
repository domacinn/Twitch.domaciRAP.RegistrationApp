using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Twitch.domaciRAP.RegistrationApp.Models
{
    public class Events
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(255, ErrorMessage = "The Name value cannot exceed 255 characters. ")]
        public string Name { get; set; }

        [StringLength(4000, ErrorMessage = "The Name value cannot exceed 4000 characters. ")]
        public string Descirption { get; set; }

        [Required]
        public DateTime StardDateTime { get; set; }

        [Required]
        [StringLength(255, ErrorMessage = "The CreatedBy value cannot exceed 255 characters. ")]
        public string CreatedBy { get; set; }

        [Required]
        [StringLength(255, ErrorMessage = "The CreatedByEmail value cannot exceed 255 characters. ")]
        public string CreatedByEmail { get; set; }

        [Required]
        [StringLength(255, ErrorMessage = "The Presneter value cannot exceed 255 characters. ")]
        public string Presneter { get; set; }

        [Required]
        [StringLength(255, ErrorMessage = "The PresenterEmail value cannot exceed 255 characters. ")]
        public string PresenterEmail { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        public int AmountOfAttendees { get; set; }

        public bool IsActive { get; set; }
    }
}

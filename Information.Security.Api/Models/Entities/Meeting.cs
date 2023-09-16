using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Information.Security.Api.Models.Entities
{
    public class Meeting
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public string Site { get; set; }
        [Required]

        public string DateMeeting { get; set; }   
        public bool IsDeleted { get; set; }
    }
}

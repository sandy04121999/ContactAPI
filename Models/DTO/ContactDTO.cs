using System.ComponentModel.DataAnnotations;

namespace ContactsManagementAPI.Models.DTO
{
    public class ContactDTO
    {
        [Required(ErrorMessage = "FirstName is required") ]
        public string FirstName { get; set; }
        [Required(ErrorMessage ="LastName is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage ="Email is required")]
        public string Email { get; set; }
    }
}

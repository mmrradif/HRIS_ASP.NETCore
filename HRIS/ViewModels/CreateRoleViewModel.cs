using System.ComponentModel.DataAnnotations;

namespace HRIS.ViewModels
{
    public class CreateRoleViewModel
    {
        [Required]
        public string RoleName { get; set; }
    }
}

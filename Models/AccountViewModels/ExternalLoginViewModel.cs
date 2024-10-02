#region Using

using System.ComponentModel.DataAnnotations;

#endregion

namespace app_tramites.Models.AccountViewModels
{
    public class ExternalLoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace BasicMeetingApp.Models
{
    public class Userinfo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ad Alanı Zorunlu Bir Alandır")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Telefon Alanı Zorunlu Bir Alandır")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Email Alanı Zorunlu Bir Alandır")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Katılım Durumu Alanı Zorunlu Bir Alandır")]
        public bool WillAttend { get; set;}
    }
}

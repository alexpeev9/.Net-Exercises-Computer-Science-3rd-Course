namespace LoginDesktopForm.Models
{
    using LoginDesktopForm.Models.Abstractions;
    using System.ComponentModel.DataAnnotations;
    public class User : BaseModel
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}

namespace Parser.Model
{
    public class UserModel : BaseModel
    {
        public string Username { get; set; } = default!;

        public string Password { get; set; } = default!;

        public UserRole Role { get; set; } = UserRole.Auditor;
    }
}

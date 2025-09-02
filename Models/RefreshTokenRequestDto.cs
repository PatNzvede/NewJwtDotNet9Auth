namespace NewJwtDotNet9Auth.Models
{
    public class RefreshTokenRequestDto
    {
        public required string RefreshToken { get; set; }
        public Guid UserId { get; set; }
    }
}

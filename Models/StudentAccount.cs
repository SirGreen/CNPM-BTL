using Microsoft.AspNetCore.Identity;

public class StudentAccount : IdentityUser
{
    public required string FullName { get; set; } // Add the FullName property
    public const uint DefaultPageLeft = 100;
    public  uint PageLeft { get; set; } = DefaultPageLeft; // Page left for printing
}

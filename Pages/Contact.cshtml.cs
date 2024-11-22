using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website_demo.Pages;

public class ContactModel : PageModel
{
    private readonly ILogger<ContactModel> _logger;

    public ContactModel(ILogger<ContactModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
    [Required]
    [Display(Name = "Họ và tên")]
    public required string FullName {get; set;}

    [Required(ErrorMessage = "Cần điền email")]
    [Display(Name = "Email")]
    public required string Email {get; set;}

    [Required(ErrorMessage = "Cần ghi rõ vấn đề")]
    [Display(Name = "Chủ đề")]
    public required string Topic {get; set;}

    [Required(ErrorMessage = "Cần điền nội dung chi tiết")]
    [Display(Name = "Nội dung")]
    public required string Context {get; set;}
}

using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website_demo.Pages;

public class PageConfigModel : PageModel
{
    private readonly ILogger<PageConfigModel> _logger;

    public PageConfigModel(ILogger<PageConfigModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        _logger.LogInformation("Hello config");
    }
    [Required(ErrorMessage = "Hãy chọn loại giấy")]
    [Display(Name = "Cỡ giấy")]
    public required string PageSize {get; set;}

    [Required(ErrorMessage = "Hãy chọn số mặt in")]
    [Display(Name = "Một / Hai mặt")]
    public required string PageSide {get; set;}

    [Required(ErrorMessage = "Hãy chọn số bản muốn in")]
    [Display(Name = "Số bản copy")]
    public required string CopyNum {get; set;}

    [Required(ErrorMessage = "Hãy chọn những trang muốn in")]
    [Display(Name = "Trang")]
    public required string PageSelect {get; set;}
}
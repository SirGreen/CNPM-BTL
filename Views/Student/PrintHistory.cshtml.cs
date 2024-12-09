using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website_demo.Pages;

public class PrintHistoryModel : PageModel
{
    private readonly ILogger<PrintHistoryModel> _logger;

    public string FromDate { get; set; }
    public DateTime ToDate { get; set; }


    public PrintHistoryModel(ILogger<PrintHistoryModel> logger)
    {
        _logger = logger;
        _logger.LogInformation("init");
    }

    public void OnGet()
    {
        _logger.LogInformation("doing get");
        // Calculate the date 1 month ago
        DateTime oneMonthAgo = DateTime.Now.AddMonths(-1);

        FromDate = oneMonthAgo.ToString("yyyy-MM-dd");
        ToDate = DateTime.Now; // Make sure this is set!

    }
}
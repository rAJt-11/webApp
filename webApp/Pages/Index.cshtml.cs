using Microsoft.AspNetCore.Mvc.RazorPages;

namespace webApp.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly IConfiguration _configuration;

    public IndexModel(ILogger<IndexModel> logger, IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;
    }

    public void OnGet()
    {
        ViewData["IsEnabled"] = _configuration["IsEnabled"];
    }
}

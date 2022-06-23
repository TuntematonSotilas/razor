using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace mvc.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

	[BindProperty]
	public Asset Asset { get; set; }

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
		Asset = new Asset();
    }

    public void OnGet()
    {

    }

	public void OnPost()
    {

    }
}

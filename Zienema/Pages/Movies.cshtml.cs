using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Zienema.Pages
{
    public class MoviesModel : PageModel
    {
        private readonly ILogger<MoviesModel> _logger;

        public MoviesModel(ILogger<MoviesModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}

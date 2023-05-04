using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace POST_UTME_UI.Pages
{
    public class FormModel : PageModel
    {

        public class FormInput
        {
            public IFormFile Passport { get; set; }
            public string Pin { get; set; }
            public string JambRegNumber { get; set; }
            
        }

        [BindProperty]
        public FormInput Input { get; set; }

        public void OnGet(string pin)
        {
            Input = new FormInput { Pin = pin };
        }

        public IActionResult OnPost()
        {

        }
    }
}

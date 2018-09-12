using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace CoreRazorPages.ComponentBasedUi.TagHelpers
{
    public class AddButtonTagHelper : TagHelper
    {
        public string AddRoute {get;set;}
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";    
            output.Attributes.SetAttribute("href", AddRoute);
            output.Attributes.SetAttribute("class", "btn btn-success");
        }
    }
}
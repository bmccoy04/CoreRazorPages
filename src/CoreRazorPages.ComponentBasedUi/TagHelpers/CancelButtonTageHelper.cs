using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace CoreRazorPages.ComponentBasedUi.TagHelpers
{
    public class CancelButtonTagHelper : TagHelper
    {
        public string CancelRoute {get;set;}
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";    
            output.Attributes.SetAttribute("href", CancelRoute);
            output.Attributes.SetAttribute("class", "btn btn-default");
            output.Content.SetContent("Cancel");
        }
    }
}
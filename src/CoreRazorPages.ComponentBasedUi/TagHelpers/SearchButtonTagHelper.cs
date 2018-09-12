using CoreRazorPages.ComponentBasedUi.Shared.Enum;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace CoreRazorPages.ComponentBasedUi.TagHelpers
{
    public class SearchButtonTagHelper : TagHelper
    {
        public ButtonSize Size {get;set;}
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "input";                
            output.Attributes.SetAttribute("type", "submit");
            var btnClass = "btn btn-success";
            
            if(Size == ButtonSize.Small)
                btnClass = btnClass +  " btn-sm";            

            output.Attributes.SetAttribute("class", btnClass);            
            output.Attributes.SetAttribute("value", "Search");            
        }
    }
}
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebApplication5_TagHelpers.CostumTagHelper
{
    public class EmailTagHelpers : TagHelper
    {
        public string Mail { get; set; }

        public string Display { get; set; }


        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            
            output.TagName = "a";
            output.Attributes.Add("href", $"Mailto : {Mail}");
            output.Content.Append(Display);
        }

    }
}

using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplication4.Extensions_ozelhtmlTagHelper_
{
    public static class Extensions
    {
        public static IHtmlContent CostumTextBox(this IHtmlHelper htmlHelper, string name, string value = "", string placeHolder="")
        {
            return htmlHelper.TextBox(name, value, new
            {
                style = "background-color= red; color: white; font-size:18px;",
                @class="from-input",
                a = "a",
                b = "b",
                placeHolder = placeHolder
            });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace AspNetCoreTagHelpers.Helper
{
    public class AppreciateTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
    {
        private
        const string appreciationText = "Olá";
        public string PersonName
        {
            get;
            set;
        }
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            
            output.TagName = "Appreciation";
            string message = $"{appreciationText}, {PersonName}";
            var attribute = new TagHelperAttribute(name: "Label", value: message);
            output.Attributes.Add(attribute);
            output.Content.SetContent(message);
        }
    }

}

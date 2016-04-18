﻿using System.Linq;
using System.Text;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Razor.TagHelpers;
using WebApp.Models;

namespace WebApp.TagHelpers
{
    [HtmlTargetElement("city-list", Attributes = "city-id, name")]
    public class CitySelectListTagHelper : TagHelper
    {
        public int CityId { get; set; }
        public string Name { get; set; }

        private ApplicationDbContext DbContext;

        public CitySelectListTagHelper([FromServices] ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {

            output.TagName = "select";
            

            var items = new StringBuilder();
            var cityList = DbContext.Cities.OrderBy(x => x.Name).ToList();

            items.Append("<option value=\"\"Все города</option>");
            foreach (var city in cityList)
            {
                items.Append($"<option value=\"{city.Id}\">{city.Name}</option>");
            }
        
            output.Content.SetHtmlContent(items.ToString());
         
            output.Attributes["name"] = Name;
            output.Attributes.Add("class", "ui fluid dropdown");
        }
    }
}

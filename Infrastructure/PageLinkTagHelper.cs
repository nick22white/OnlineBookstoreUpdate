using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using OnlineBookstore.Models.ViewModels;

namespace OnlineBookstore.Infrastructure
{
    //Building TagHelper -> Helps build the html Dynamically
    [HtmlTargetElement("div", Attributes = "page-model")]
    //Inherets Tag  Helper
    public class PageLinkTagHelper : TagHelper
    {


        private IUrlHelperFactory urlHelperFactory;
        public PageLinkTagHelper (IUrlHelperFactory hp)
        {
            urlHelperFactory = hp;
        }

        //Not sure
        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }
        public PagingInfo PageModel { get; set; }
        public string PageAction { get; set; }

        //creates entries in dictionary
        [HtmlAttributeName(DictionaryAttributePrefix = "page-url-")]
        public Dictionary<string, object> PageUrlValues { get; set; } = new Dictionary<string, object>();

        public bool PageClassesEnabled { get; set; } = false;
        public string PageClass { get; set; }
        public string PageClassNormal { get; set; }
        public string PageClassSelected { get; set; }

        //Overriding
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            IUrlHelper urlHelper = urlHelperFactory.GetUrlHelper(ViewContext);

            TagBuilder result = new TagBuilder("div");

            for (int i = 1; i <= PageModel.TotalPages; i++)
            {
                //Build Tag
                TagBuilder tag = new TagBuilder("a");

                PageUrlValues["page"] = i;

                tag.Attributes["href"] = urlHelper.Action(PageAction,
                    PageUrlValues);

                //CSS
                if(PageClassesEnabled)
                {
                    tag.AddCssClass(PageClass);
                    tag.AddCssClass(i == PageModel.CurrentPage ? PageClassSelected : PageClassNormal);
                }

                tag.InnerHtml.Append(i.ToString());

                //Append to result
                result.InnerHtml.AppendHtml(tag);
            }

            //Build pages in div to print it out
            output.Content.AppendHtml(result.InnerHtml);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Enzo.CoffeeRun2.Web.Models;
using Enumerable = System.Linq.Enumerable;

namespace Enzo.CoffeeRun2.Web.Helpers
{
    public static class DropDownListExtensions
    {
        public static MvcHtmlString EnumDropDownList<TEnum>(this HtmlHelper htmlHelper, string name, TEnum selectedValue)
        {
            IEnumerable<TEnum> values = Enumerable.Cast<TEnum>(Enum.GetValues(typeof (TEnum)));

            var items = values.Select(value => new SelectListItem
                                           {
                                               Text = value.ToString(),
                                               Value = value.ToString(),
                                               Selected = (value.Equals(selectedValue))
                                           });

            return htmlHelper.DropDownList(name,items);
        }
    }
}
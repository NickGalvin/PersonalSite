using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalSite.Shared.FindBy
{
    public class FindByIdAttribute : Attribute
    {
        public FindByIdAttribute(string id)
        {

        }

        public string Id { get; set; }
    }

    public class FindAllByClassAttribute : Attribute
    {
        public FindAllByClassAttribute(string cssClass)
        {

        }

        public string CssClass { get; set; }
    }

    public class FindAllByCssAttribute : Attribute
    {
        public FindAllByCssAttribute(string cssClass)
        {

        }

        public string CssSelector { get; set; }
    }

    public class FindAllByXPathAttribute : Attribute
    {
        public FindAllByXPathAttribute(string cssClass)
        {

        }

        public string CssSelector { get; set; }
    }

    public class FindByXPathAttribute : Attribute
    {
        public FindByXPathAttribute(string cssClass)
        {

        }

        public string CssSelector { get; set; }
    }
}

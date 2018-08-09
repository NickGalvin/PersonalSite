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

    public class FindAllByCssSelectorAttribute : Attribute, where T : IEnumerable<>
    {
        public FindAllByClassAttribute<T>(string cssClass)
        {

        }

        public string CssClass { get; set; }
    }

}

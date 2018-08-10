using System;
using System.Collections.Generic;
using System.Text;
using PersonalSite.Shared.Elements;
using PersonalSite.Shared.FindBy;

namespace PersonalSite.Shared.Pages
{
    public interface IPage
    {
        
    }

    public class Page : IPage
    {
        [FindById("Name")]
        IWebElement NameTextbox { get; set; }

    }
}

using PersonalSite.Shared.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalSite.Shared.Browsers
{
    public interface IBrowser
    {
        IPage CurrentPage { get; set; }

    }
}

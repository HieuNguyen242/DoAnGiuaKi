﻿using System.Web;
using System.Web.Mvc;

namespace _1460017_DAGK
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

﻿using System.Web;
using System.Web.Mvc;

namespace _5032_Assignment_Car
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

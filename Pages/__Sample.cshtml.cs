﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using isRock.Web.Core.Razor;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace __NameSpace__.Pages
{
    public class SampleModel : isPageModel
    {
        public void OnGet()
        {

        }

        [PageMethod]
        public static object CalBmi(dynamic para)
        {
            int height = para.height;
            int weight = para.weight;

            float H = para.height;
            H = H / 100;
            return weight / (H * H);
        }
    }
}
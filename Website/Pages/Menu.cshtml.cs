﻿/*  Menu.cshtml.cs
*   Author: Nick Monaco
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;

namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        /// <summary>
        /// The Menu variable that allows an instance of a menu to be accessed in the cshtml file.
        /// </summary>
        public Menu menu { get; private set; }

        /// <summary>
        /// The OnGet function, generated by Visual Studio.
        /// </summary>
        public void OnGet()
        {
            menu = new Menu();
        }

    }
}
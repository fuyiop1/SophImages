using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SophImages.Models;

namespace SophImages.ViewModels
{
    public class AdminLogin
    {
        public string ReturnUrl { get; set; }
        public Admin Admin { get; set; }
        public bool IsRememberAccount { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;


namespace WebApp.Controllers 
{
    public class AboutController 
    {
        public string Phone()
        {
            return @"1-800-234-5678";
        }

        public string Address()
        {
            return "USA";
        }
    }

}
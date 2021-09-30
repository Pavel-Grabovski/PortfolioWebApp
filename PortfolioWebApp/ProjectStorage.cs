using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioWebApp
{

    public static class ProjectStorage
    {
        public static List<Project> Projects { get; private set; } = new List<Project>()
        {
            new Project
            {
                Name = "ASP.NET_Core_1.0",
                Link = "https://github.com/Pavel-Grabovski/PortfolioWebApp",
                Description = "Написание WEB приложений с помощью ASP.NET."
            }
        };
    }
}

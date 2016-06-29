using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(TestService.Startup))]

namespace TestService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}

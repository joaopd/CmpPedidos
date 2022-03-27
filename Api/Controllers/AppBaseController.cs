using Microsoft.AspNetCore.Mvc;
using System;

namespace Api.Controllers
{
    public class AppBaseController : ControllerBase
    {      
        protected readonly IServiceProvider _serviceProvider;
        public AppBaseController(IServiceProvider serviceProvider)  
        {
            _serviceProvider = serviceProvider;
        }      
    }
}

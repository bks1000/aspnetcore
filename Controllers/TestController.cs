using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace WebApplication.Controllers
{
    public class TestController : Controller
    {
        //只读域(readonly)只能在初始化--声明初始化或构造器初始化--的过程中赋值，其他地方不能进行对只读域的赋值操作
        private readonly IConfigurationRoot _configurationRoot;

        public TestController(IConfigurationRoot configurationRoot)
        {
            _configurationRoot = configurationRoot;
        }
        public IActionResult Index()
        {
            return Content("hello world！");
        }
    }
}
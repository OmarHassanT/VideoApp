﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EmployeeManagement.Controllers
{
    public class ErrorController : Controller
    {
        private readonly ILogger<ErrorController> logger;

       
        //when url does not match any route in the application
        [Route("Error/{StatusCode}")]
        public IActionResult HttpStatusCodeHandler(int StatusCode)
        {
            var statusCodeResult = HttpContext.Features.Get<IStatusCodeReExecuteFeature>();
            switch(StatusCode)
            {
                case 404:
                    ViewBag.ErrorMessage = "404 Sorry page not found";                             
                break;
            }
            return View("NotFound");
        }
        //[Route("/Error")]
       // [AllowAnonymous]
       // public IActionResult Error()
       // {   //must be write to database not to endusers
       //     var exceptionDetails = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
        //    logger.LogError($"the path {exceptionDetails.Path} " +
         //       $"threw new exception {exceptionDetails.Error}");
         //   return View("Error");
      //  }
    }
}
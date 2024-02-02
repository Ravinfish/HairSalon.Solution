using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System;
using System.Threading.Tasks;
//using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace HairSalon.Controllers;

public class HomeController : Controller
{
  public ActionResult Index()
  {
    return View();
   
    }
  }
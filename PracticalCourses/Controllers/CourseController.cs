﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PracticalCourses.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("{nameCategory}")]
        public IActionResult List(string nameCategory)
        {
            return View();
        }

        [HttpGet("{courseId}")]
        public IActionResult Details(string courseId)
        {
            return View();
        }
    }
}
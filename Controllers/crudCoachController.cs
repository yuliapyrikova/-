﻿using Microsoft.AspNetCore.Mvc;

namespace pyrikova.Controllers
{
    [ApiController]
    [Route("/coach")]
    public class CoachController1 : ControllerBase
    {
        [HttpPut("Create")]
        public string Create(string str)
        {
            return str;
        }

        [HttpGet("Read")]
        public string Read(string str)
        {
            return str;
        }

        [HttpPatch("Update")]
        public string Update(string str)
        {
            return str;
        }

        [HttpDelete("Delete")]
        public string Delete(string str)
        {
            return str;
        }
    }
}


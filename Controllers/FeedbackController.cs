﻿using System.Linq;
using System.Threading.Tasks;
using pyrikova.Domain;
using pyrikova.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace pyrikova.Controllers
{
    [ApiController]
    [Route("/feedback")]
    public class FeedbackController : ControllerBase
    {
        [HttpPut]
        public Feedback Create(Feedback feedback)
        {
            Storage.FeedbackStorage.Create(feedback);
            return feedback; // Метод создания
        }

        [HttpGet]
        public Feedback Read(int reviewCode)
        {
            return Storage.AdminStorage.Read(reviewCode); // Метод чтения
        }

        [HttpPatch]
        public string Update(string str)
        {
            return str; // Метод обновления
        }

        [HttpDelete]
        public string Delete(string str)
        {
            return str; // Метод удаления
        }
    }
}
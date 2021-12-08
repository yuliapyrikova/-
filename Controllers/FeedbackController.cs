using pyrikova.Domain;
using pyrikova.Repository;
using Microsoft.AspNetCore.Mvc;

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
            return feedback;
        }

        [HttpGet]
        public Feedback Read(int feedbackId)
        {
            return Storage.FeedbackStorage.Read(feedbackId);
        }

        [HttpPatch]
        public string Update(string str)
        {
            return str;
        }

        [HttpDelete]
        public string Delete(string str)
        {
            return str;
        }
    }
}
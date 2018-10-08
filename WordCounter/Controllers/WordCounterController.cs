using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;


namespace WordCounter.Controllers
{
    public class WordCounterController : Controller
    {
        [HttpGet("/WordCounter/CreateSentence")]
        public ActionResult CreateSentence()
        {
            return View();
        }
        [HttpPost("/WordCounter/CreateWord")]
        public ActionResult CreateWord()
        {
            RepeatCounter newCounter = new RepeatCounter();
            
            newCounter.SetUserSentence(Request.Form["new-sentence"]);
            
            return View(newCounter);

        }
        [HttpPost("/WordCounter/Counter")]
        public ActionResult CreateCount()
        {
            RepeatCounter newCounter = new RepeatCounter();
            
            newCounter.SetUserSentence(Request.Form["entered-sentence"]);
            newCounter.SetUserWord(Request.Form["new-word"]);

            return View("Counter", newCounter);
        }
        
    }

}

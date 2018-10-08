using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;


namespace WordCounter.Controllers
{
    public class WordCounterController : Controller
    {
        [HttpGet("/WordCounter")]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost("/WordCounter/New")]
        public ActionResult UserInputWord()
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
        // [HttpPost("/words")]
        // public ActionResult CreateCount()
        // {
        //     RepeatCounter userInput = new RepeatCounter(Request.Form["new-word"], Request.Form["new-sentence"]);
        //     userInput.CountWord();
        //     userInput.Save();
        //     List<RepeatCounter> allItems = RepeatCounter.GetAll();
        //     return View("Index", allItems);
        // }
    }

}

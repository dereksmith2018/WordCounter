using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class WordCountersControllerTest
    {
        [TestMethod]
        public void Index_HasCorrectView_True()
        {
            WordCountersController controller = new WordCountersController();

            ViewResult indexView = (ViewResult)controller.Index();
            
            Assert.IsInstanceOfType(indexView, typeof(ViewResult));

        }
    }
}
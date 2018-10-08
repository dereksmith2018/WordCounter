using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class WordCounterTest
    {
        [TestMethod]
        public void Index_ReturnsCorrectView_True()
        {
            //Arrange
            WordCounterController controller = new WordCounterController();

            //Act
            ActionResult indexView = controller.Index();

            //Assert
            Assert.IsInstanceOfType(indexView, typeof(ViewResult));
        }
        [TestMethod]
        public void CreateWord_ReturnsCorrectView_True()
        {
            //Arrange
            WordCounterController controller = new WordCounterController();

            //Act
            ActionResult createWordView = controller.CreateWord();

            //Assert
            Assert.IsInstanceOfType(createWordView, typeof(ViewResult));   
        }
        [TestMethod]
        public void CreateWord_HasCorrectModelType_List()
        {
            //Arrange
            WordCounterController controller = new WordCounterController();
            ViewResult createWordView = controller.CreateWord() as ViewResult;

            //Act
            ViewResult result = createWordView.ViewData.Model;

            //Assert
            Assert.IsInstanceOfType(result, typeof(List<RepeatCounter));
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterControllerTest
  {
    [TestMethod]

    public void New_ReturnCorrectView_True()
    {
      //Arrange
      RepeatCounterController controller = new RepeatCounterController();

      //Act
      ActionResult newView = controller.New();

      Assert.IsInstanceOfType(newView, typeof(ViewResult));
    }
}
}

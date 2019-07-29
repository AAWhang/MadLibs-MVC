using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {

    [Route("/hello")]
    public string Hello() { return "Hello friend!"; }

    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye friend."; }

    [Route("/")]
    public ActionResult Letter() {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = "Lina";
      myLetterVariable.Sender = "Jasmine";
      return View(myLetterVariable);
    }

    [Route("/form")]
    public ActionResult Form() { return View(); }

      [Route("/postcard")]
      public ActionResult Postcard(string recipient, string sender, string noun, string verb, string adjective, string pronoun, string spiritualanimal, string zodiacsign, string spiritualstatus, string nameofyourgod, string yourfursona, string yourfavoritesovietrifle, string antspecies, string yournameplusthehedgehog)
      {
        LetterVariable myLetterVariable = new LetterVariable();
        myLetterVariable.Recipient = recipient;
        myLetterVariable.Sender = sender;
        myLetterVariable.Noun = noun;
        myLetterVariable.Verb = verb;
        myLetterVariable.Adjective = adjective;
        myLetterVariable.Pronoun = pronoun;
        myLetterVariable.SpiritualAnimal = spiritualanimal;
        myLetterVariable.ZodiacSign = zodiacsign;
        myLetterVariable.SpiritualStatus = spiritualstatus;
        myLetterVariable.NameOfYourGod = nameofyourgod;
        myLetterVariable.YourFursona = yourfursona;
        myLetterVariable.YourFavoriteSovietRifle = yourfavoritesovietrifle;
        myLetterVariable.AntSpecies = antspecies;
        myLetterVariable.YourNamePlusTheHedgehog = yournameplusthehedgehog;


        return View(myLetterVariable);
      }
    }
}

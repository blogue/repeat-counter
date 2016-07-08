using Nancy;
using System.Collections.Generic;
using System.Text;
using System;


namespace WordRepeatCounter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/result"] = _ => {
        RepeatCounter newCountResult = new RepeatCounter();
        newCountResult.CountRepeats(Request.Form["user-sentence"], Request.Form["user-word"]);
        return View["result.cshtml", newCountResult];
      };
    }
  }
}

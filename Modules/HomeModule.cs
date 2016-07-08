using Nancy;
using System.Collections.Generic;
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
        RepeatCounter c = new RepeatCounter();
        int userResult = c.CountRepeats(Request.Form["user-sentence"], Request.Form["user-word"]);
        return View["result.cshtml", userResult];
      };
    }
  }
}

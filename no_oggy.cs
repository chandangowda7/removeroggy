using System;
using System.Collections.Generic;

class NoOggyChecker
{
  static void RemoveOggy(List<string> names)
  {
    for(var i=names.Count-1;i>=0;i--)
    {
        if(names[i].StartsWith("oggy")) {
            Console.WriteLine($"Need to remove {names[i]}!");
            names.Remove(names[i]);
        }
    }
  }
  static bool OggyIsRemoved(List<string> names)
  {
    return names.Find(x => x.Contains("oggy")) == null;
  }
  static int Main()
  {
    var names = new List<string>
      { "nobita", "bheem", "oggy", "oggy cockroach", "ninja" };
    RemoveOggy(names);
    if(OggyIsRemoved(names)) {
      Console.WriteLine("Passed!");
      return 0;
    } else {
      Console.WriteLine("Failed!!");
      return 1;
    }
  }
}

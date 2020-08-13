using System;
using System.Collections.Generic;

class NoOggyChecker
{
  static void RemoveOggy(List<string> names)
  {
    List<string> duplicates=new List<string>(names);
     names.Clear();
    for(var i=duplicates.Count-1;i>=0;i--)
    {
        if(duplicates[i].StartsWith("oggy")) {
          
            Console.WriteLine($"Need to remove {duplicates[i]}!");
        }
        else
           names.Add(duplicates[i]);
          
        
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

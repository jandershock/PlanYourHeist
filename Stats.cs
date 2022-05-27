using System;
using System.Collections.Generic;

namespace PlanYourHeist
{
    public class Stats
    {
        public Dictionary<string, int> attemptRecord = new Dictionary<string, int>(){
            {"Success", 0},
            {"Fail", 0}
        };

        public void PrintReport() => Console.WriteLine($@"
            Stats for your heists:
            Successes: {attemptRecord["Success"]}
            Failures:  {attemptRecord["Fail"]}");
    }
}
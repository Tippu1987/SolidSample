using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ArdalisRating
{
    public class PolicyReader
    {
        public string GetPolicyContent()
        {
            return File.ReadAllText("policy.json");
        }
    }
}

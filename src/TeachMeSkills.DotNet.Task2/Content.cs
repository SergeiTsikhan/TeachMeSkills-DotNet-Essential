using System;
using System.Collections.Generic;
using System.Text;

namespace TeachMeSkills.DotNet.Task2
{
    class Content:Book
    {
        public string content { get; set; }

        public override void Show ()
        {
            Console.WriteLine($"Book content:{content}");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace TeachMeSkills.DotNet.Task2
{
    class Title:Book
    {
        public string  title { get; set; }

        public override void Show()
        {
            Console.WriteLine($"Book title:{title}");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace TeachMeSkills.DotNet.Task2
{
    class Author:Book
    {
        public string author { get; set; }

        public override void Show()
        {
            Console.WriteLine($"Book author:{author}");
        }

    }
}

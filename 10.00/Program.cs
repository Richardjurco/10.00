﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Open_Lab_10._04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();
            //lotr.category = "roman";
            //lotr.title = "lord of the rings";
            //lotr.releasedate = 1989;
            //lotr.author = "michalelo";
            //lotr.pages = 1000;
            Book LOTR3 = new Book(1000, "lord of the rings3");
            Book LOTR2 = new Book();
            Book Hobbit = new Book();
            Console.WriteLine(LOTR.ToString("roman", "Hobbit",500,1724,"samko"));

        }
    }
}

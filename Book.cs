﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCustomObjects
{
    internal class Book
    {
        private string title;
        private string author;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
    }
}

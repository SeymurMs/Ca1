using System;
using System.Collections.Generic;
using System.Text;

namespace Praktika_2
{
    class Status
    {
        public Status(string title , string content)
        {
            this.Title = title;
            this.Content = content;
            date = DateTime.Now;
        }
        public string Title { get; set; }
        public string Content { get; set; }

        public DateTime date { get; set; }
    }
}

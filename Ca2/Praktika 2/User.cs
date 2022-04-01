using System;
using System.Collections.Generic;
using System.Text;

namespace Praktika_2
{
    class User
    {
        List<Status> statuses = new List<Status>();
        public string UserName { get; set; }
        public void ShareStatus(Status status)
        {
            statuses.Add(status);

        }
        public string GetStatusByTitle(string title)
        {
            DateTime date1 = new DateTime();
            date1 = DateTime.Now;
            
            foreach (var item in statuses)
            {
                if (item.Title == title)
                {
                    return $"Title: {item.Title} Content: {item.Content} Date: {(date1 -item.date).Seconds }";
                }
                else if (item.Title != title)
                    throw new NotFountException("Bele bir title yoxdu");
            }
            return null;
        }
    }
}

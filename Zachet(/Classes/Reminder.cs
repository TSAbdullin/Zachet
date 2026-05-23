using System;
using Zachet_.Enums;

namespace Zachet_.Classes
{
    public class Reminder
    {
        public Guid Id {  get; set; }
        public string? Name { get; set; }
        public DateTime Date { get; set; }
        public Priority Priority { get; set; }
        public bool Status { get; set; }

        public Reminder(string name, DateTime date, Priority priority, bool status)
        {
            Name = name;
            Date = date;
            Priority = priority;
            Status = status;
        }
    }
}

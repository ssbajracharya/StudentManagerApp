using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagerApp
{
    public enum MonthOfAdmission
    {
        January = 1, 
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
    internal class Student
    {
        public int StudId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public MonthOfAdmission Month { get; set; }
        public char Grade {  get; set; }
    }
}

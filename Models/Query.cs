namespace Hebrew_date_test.Models
{
    public class Query(string dayInWeek, int dayInMonth, string month, string year, string result)
    {
        public string DayInWeek { get; set; } = dayInWeek;
        public int DayInMonth { get; set; } = dayInMonth;
        public string Month { get; set; } = month;
        public string Year { get; set; } = year;
        public string Result { get; set; } = result;
    }
}

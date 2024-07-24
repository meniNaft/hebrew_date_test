using Hebrew_date_test.Models;
using Hebrew_date_test.Services;
namespace Hebrew_date_test
{
    public partial class Dashboard : Form
    {
        private readonly XmlService service;
        private Dictionary<string, string> dayInWeek = [];
        private Dictionary<int, string> dayInMonth = [];
        private Dictionary<string, int> month = [];
        private Dictionary<string, string> year = [];
        private int[] monthsWith29Days = [];
        public Dashboard(XmlService service)
        {
            this.service = service;
            InitializeComponent();
            InitDictionaries();
            InitComboBoxes();
        }

        private void InitDictionaries()
        {
            dayInWeek = new()
            {
                {"ראשון","באחד"},
                {"שני","בשני"},
                {"שלישי","בשלישי"},
                {"רביעי","ברביעי"},
                {"חמישי","בחמישי"},
                {"שישי","בששי"}
            };

            dayInMonth = new()
            {
                { 1, "יום אחד" },
                { 2, "שני ימים" },
                {3, "שלשה ימים" },
                {4, "ארבעה ימים" },
                { 5, "חמישה ימים" },
                { 6, "שישה ימים" },
                { 7, "שבעה ימים" },
                { 8, "שמונה ימים" },
                { 9, "תשעה ימים" },
                { 10, "עשרה ימים" },
                { 11, "אחד עשר יום" },
                { 12, "שנים עשר יום" },
                { 13, "שלשה עשר יום" },
                { 14, "ארבעה עשר יום" },
                { 15, "חמישה עשר יום" },
                { 16, "ששה עשר יום" },
                { 17, "שבעה עשר יום" },
                { 18, "שמונה עשר יום" },
                { 19, "תשעה עשר יום" },
                { 20, "עשרים יום" },
                { 21, "עשרים ואחד יום" },
                { 22, "עשרים ושתיים יום" },
                { 23, "עשרים ושלושה יום" },
                { 24, "עשרים וארבעה יום" },
                { 25, "עשרים וחמישה יום" },
                { 26, "עשרים וששה יום" },
                { 27, "עשרים ושבעה יום" },
                { 28, "עשרים ושמונה יום" },
                { 29, "עשרים ותשע יום" },
                { 30, "יום שלושים לחדש {0} שהוא ראש חודש {1}" }
            };

            month = new()
            {
                {"תשרי",1},
                {"מרחשון",2},
                {"כסלו",3},
                {"טבת",4},
                {"שבט",5},
                {"אדר",6},
                {"אדר הראשון",7},
                {"אדר השני ",8},
                {"ניסן",9},
                {"אייר",10},
                {"סיון",11},
                {"תמוז",12},
                {"אב",13},
                {"אלול",14}
            };

            monthsWith29Days = [4, 6, 8, 10, 12, 14];

            year = new() {
            {"תשפ\"ד", "חמשת אלפים ושבע מאות ושמונים וארבע"},
            {"תשפ\"ה", "חמשת אלפים ושבע מאות ושמונים וחמש"},
            {"תשפ\"ו", "חמשת אלפים ושבע מאות ושמונים ושש"},
            {"תשפ\"ז", "חמשת אלפים ושבע מאות ושמונים ושבע"},
            {"תשפ\"ח", "חמשת אלפים ושבע מאות ושמונים ושמונה"},
            {"תשפ\"ט", "חמשת אלפים ושבע מאות ושמונים ותשע"},
            {"תש\"צ", "חמשת אלפים ושבע מאות ותשעים"},
            {"תשצ\"א", "חמשת אלפים ושבע מאות ותשעים ואחד"},
            {"תשצ\"ב", "חמשת אלפים ושבע מאות ותשעים ושתיים"},
            {"תשצ\"ג", "חמשת אלפים ושבע מאות ותשעים ושלוש"}
            };
        }

        private void InitComboBoxes()
        {
            comboBox_dayInWeek.DataSource = new BindingSource(dayInWeek, null);
            comboBox_dayInWeek.DisplayMember = "Key";
            comboBox_dayInWeek.ValueMember = "Value";

            comboBox_dayInMonth.DataSource = new BindingSource(dayInMonth, null);
            comboBox_dayInMonth.DisplayMember = "Key";
            comboBox_dayInMonth.ValueMember = "Value";

            comboBox_month.DataSource = new BindingSource(month, null);
            comboBox_month.DisplayMember = "Key";
            comboBox_month.ValueMember = "Value";

            comboBox_year.DataSource = new BindingSource(year, null);
            comboBox_year.DisplayMember = "Key";
            comboBox_year.ValueMember = "Value";
        }

        private void Button_submit_Click(object sender, EventArgs e)
        {
            int selectedDay = int.Parse(comboBox_dayInMonth.Text);
            var currentMonth = month.Where(elem => elem.Key == comboBox_month.Text).ToArray()[0].Value;
            if (selectedDay == 30 && monthsWith29Days.Any(m => m == currentMonth))
            {
                MessageBox.Show($"בחודש {comboBox_month.Text} לא ניתן לבחור ביום 30");
            }
            else
            {
                string result = $"{dayInWeek[comboBox_dayInWeek.Text]} בשבת {GetDayInMonthAndMonth()} שנת {year[comboBox_year.Text]} לבריאת העולם";
                Query newQuery = new(comboBox_dayInWeek.Text, int.Parse(comboBox_dayInMonth.Text), comboBox_month.Text, comboBox_year.Text, result);
                var res = service.AddQuery(newQuery);
                MessageBox.Show($"{(res.IsSuccess ? "התאריך נרשם בקובץ כראוי" : res.Message)}");
            }
        
        }

        private string GetDayInMonthAndMonth()
        {
            var currentMonth = month.Where(elem => elem.Key == comboBox_month.Text).ToArray()[0].Value;
            int nextMonth = currentMonth switch
            {
                6 => 9,
                < 14 => currentMonth + 1,
                _ => 1
            };
            return int.Parse(comboBox_dayInMonth.Text) == 30 ?
                string.Format(dayInMonth[int.Parse(comboBox_dayInMonth.Text)], month.Where(elem => elem.Value == currentMonth).ToArray()[0].Key, month.Where(elem => elem.Value == nextMonth).ToArray()[0].Key) :
                $"{dayInMonth[int.Parse(comboBox_dayInMonth.Text)]} לירח {comboBox_month.Text}";
        }
    }
}

using Hebrew_date_test.Models;
using Hebrew_date_test.Services;
namespace Hebrew_date_test
{
    public partial class Dashboard : Form
    {
        private readonly XmlService service;
        private Dictionary<string, string> dayInWeek = [];
        private Dictionary<int, string> dayInMonth = [];
        private Dictionary<string, string> month = [];
        private Dictionary<string, string> year = [];
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
                { 14, "ארבעה עשר ימים" },
                { 15, "חמישה עשר ימים" },
                { 16, "ששה עשר יום" },
                { 17, "שבעה עשר ימים" },
                { 18, "שמונה עשר ימים" },
                { 19, "תשעה עשר ימים" },
                { 20, "עשרים ימים" },
                { 21, "עשרים ואחד ימים" },
                { 22, "עשרים ושתיים ימים" },
                { 23, "עשרים ושלושה ימים" },
                { 24, "עשרים וארבעה ימים" },
                { 25, "עשרים וחמישה ימים" },
                { 26, "עשרים וששה ימים" },
                { 27, "עשרים ושבעה ימים" },
                { 28, "עשרים ושמונה ימים" },
                { 29, "עשרים ותשע ימים" },
                { 30, "שלשים ימים" }
            };

            month = new()
            {
                {"תשרי","תשרי" },
                {"מרחשון","מרחשון" },
                {"כסלו","כסלו" },
                {"טבת","טבת" },
                {"שבט","שבט" },
                {"אדר","אדר" },
                {"אדר הראשון","אדר הראשון" },
                {"אדר השני ","אדר השני " },
                {"ניסן","ניסן" },
                {"אייר","אייר" },
                {"סיון","סיון" },
                {"תמוז","תמוז" },
                {"אב","אב" },
                {"אלול","אלול" }
            };

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
            string result = $"{dayInWeek[comboBox_dayInWeek.Text]} בשבת {dayInMonth[int.Parse(comboBox_dayInMonth.Text)]} לירח {month[comboBox_month.Text]} שנת {year[comboBox_year.Text]} לבריאת העולם";
            Query newQuery = new(comboBox_dayInWeek.Text, int.Parse(comboBox_dayInMonth.Text), comboBox_month.Text, comboBox_year.Text, result);
            service.AddQuery(newQuery);
        }
    }
}

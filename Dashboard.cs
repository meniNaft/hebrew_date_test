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
                {"�����","����"},
                {"���","����"},
                {"�����","������"},
                {"�����","������"},
                {"�����","������"},
                {"����","����"}
            };

            dayInMonth = new()
            {
                { 1, "��� ���" },
                { 2, "��� ����" },
                {3, "���� ����" },
                {4, "����� ����" },
                { 5, "����� ����" },
                { 6, "���� ����" },
                { 7, "���� ����" },
                { 8, "����� ����" },
                { 9, "���� ����" },
                { 10, "���� ����" },
                { 11, "��� ��� ���" },
                { 12, "���� ��� ���" },
                { 13, "���� ��� ���" },
                { 14, "����� ��� ����" },
                { 15, "����� ��� ����" },
                { 16, "��� ��� ���" },
                { 17, "���� ��� ����" },
                { 18, "����� ��� ����" },
                { 19, "���� ��� ����" },
                { 20, "����� ����" },
                { 21, "����� ���� ����" },
                { 22, "����� ������ ����" },
                { 23, "����� ������ ����" },
                { 24, "����� ������ ����" },
                { 25, "����� ������ ����" },
                { 26, "����� ���� ����" },
                { 27, "����� ����� ����" },
                { 28, "����� ������ ����" },
                { 29, "����� ���� ����" },
                { 30, "����� ����" }
            };

            month = new()
            {
                {"����","����" },
                {"������","������" },
                {"����","����" },
                {"���","���" },
                {"���","���" },
                {"���","���" },
                {"��� ������","��� ������" },
                {"��� ���� ","��� ���� " },
                {"����","����" },
                {"����","����" },
                {"����","����" },
                {"����","����" },
                {"��","��" },
                {"����","����" }
            };

            year = new() {
            {"���\"�", "���� ����� ���� ���� ������� �����"},
            {"���\"�", "���� ����� ���� ���� ������� ����"},
            {"���\"�", "���� ����� ���� ���� ������� ���"},
            {"���\"�", "���� ����� ���� ���� ������� ����"},
            {"���\"�", "���� ����� ���� ���� ������� ������"},
            {"���\"�", "���� ����� ���� ���� ������� ����"},
            {"��\"�", "���� ����� ���� ���� ������"},
            {"���\"�", "���� ����� ���� ���� ������ ����"},
            {"���\"�", "���� ����� ���� ���� ������ ������"},
            {"���\"�", "���� ����� ���� ���� ������ �����"}
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
            string result = $"{dayInWeek[comboBox_dayInWeek.Text]} ���� {dayInMonth[int.Parse(comboBox_dayInMonth.Text)]} ���� {month[comboBox_month.Text]} ��� {year[comboBox_year.Text]} ������ �����";
            Query newQuery = new(comboBox_dayInWeek.Text, int.Parse(comboBox_dayInMonth.Text), comboBox_month.Text, comboBox_year.Text, result);
            service.AddQuery(newQuery);
        }
    }
}

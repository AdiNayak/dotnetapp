namespace Test.Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var res = DateTime_Converter.ConvertLocalToUtc("26-Sep-2023", "");
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;

namespace AddTwoNumbers
{
    public partial class AddForm : Form
    {
        public AddForm(IHistoryDatabase historyDatabase)
        {
            InitializeComponent();
            _historyDatabase = historyDatabase;
        }

        private int _currentIndex;
        private List<History> Histories { get; set; }
        private IHistoryDatabase _historyDatabase;

        private void AddForm_Load(object sender, EventArgs e)
        {
            Histories = _historyDatabase.GetAll();
            Display(_currentIndex);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int number1, number2;
            if (number1TextBox.Text == "" || number2TextBox.Text == "")
            {
                MessageBox.Show("Enter a number");
                return;
            }
            if (int.TryParse(number1TextBox.Text, out number1) == false ||
                int.TryParse(number2TextBox.Text, out number2) == false)

                MessageBox.Show("Number is not in correct format.");

            else
                SumTextBox.Text = (number1 + number2).ToString();

        }

        private void firstButton_Click(object sender, EventArgs e)
        {
            Display(0);
        }

        private void lastButton_Click(object sender, EventArgs e)
        {
            Display(Histories.Count - 1);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            Display(_currentIndex + 1);
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            Display(_currentIndex - 1);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            History history = GetHistoryFromForm();
            Histories.Add(history);
            _historyDatabase.SaveToDatabase(history);
        }

        public void Display(int index)
        {
            if (index < 0 || index > Histories.Count - 1)
            {
                MessageBox.Show("Out of range");
                return;
            }

            number1TextBox.Text = Histories[index].Number1.ToString();
            number2TextBox.Text = Histories[index].Number2.ToString();
            SumTextBox.Text = Histories[index].Sum.ToString();
            _currentIndex = index;
        }

        public History GetHistoryFromForm()
        {
            History history = new History();

            history.Number1 = Convert.ToInt32(number1TextBox.Text);
            history.Number2 = Convert.ToInt32(number2TextBox.Text);
            history.Sum = Convert.ToInt32(SumTextBox.Text);

            return history;
        }

    }
}

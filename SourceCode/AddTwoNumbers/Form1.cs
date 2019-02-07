using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddTwoNumbers
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private AddTwoNumbersEntities _db = new AddTwoNumbersEntities();
        private List<History> _histories = new List<History>();
        private int _currentIndex = -1;

        private void LoadFromDatabase()
        {
            _histories = _db.Histories.ToList();
        }

        private void SaveToDatabase(History history)
        {
            _db.Histories.Add(history);
            _db.SaveChanges();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            LoadFromDatabase();
            if (_histories.Count() > 0)
            {
                _currentIndex = 0;
                Display(_currentIndex);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int number1, number2;
            try
            {

                if (number1TextBox.Text == "" || number2TextBox.Text == "")
                {
                    MessageBox.Show("Enter a number");
                    return;
                }

                if (int.TryParse(number1TextBox.Text, out number1) == false ||
                    int.TryParse(number2TextBox.Text, out number2) == false)

                    MessageBox.Show("Number is not in correct format.");

                else
                {
                    SumTextBox.Text = (number1 + number2).ToString();

                    var history = GetHistoryFromForm();
                    _histories.Add(history);
                    SaveToDatabase(history);

                    _currentIndex = _histories.Count - 1;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void firstButton_Click(object sender, EventArgs e)
        {
            var history = _histories.FirstOrDefault();
            if (history == null)
                EmptyList();
            else
            {
                _currentIndex = 0;
                Display(_currentIndex);
            }
        }

        private void lastButton_Click(object sender, EventArgs e)
        {
            _currentIndex = _histories.Count - 1;

            if (_currentIndex < 0)
                EmptyList();
            else
            {
                var history = _histories[_currentIndex];
                Display(_currentIndex);
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (_currentIndex == -1)
                EmptyList();
            else
            {
                _currentIndex += 1;

                if (_currentIndex >= _histories.Count)
                    MessageBox.Show("This is the last item.");

                else
                    Display(_currentIndex);
            }

        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (_currentIndex == -1)
                EmptyList();
            else
            {
                _currentIndex -= 1;
                if (_currentIndex == -1)
                {
                    MessageBox.Show("this is the first item.");
                    _currentIndex = 0;
                }
                else

                    Display(_currentIndex);
            }
        }

        public void Display(int index)
        {
            number1TextBox.Text = _histories[index].Number1.ToString();
            number2TextBox.Text = _histories[index].Number2.ToString();
            SumTextBox.Text = _histories[index].Sum.ToString();
        }

        public History GetHistoryFromForm()
        {
            History history = new History();

            history.Number1 = Convert.ToInt32(number1TextBox.Text);
            history.Number2 = Convert.ToInt32(number2TextBox.Text);
            history.Sum = Convert.ToInt32(SumTextBox.Text);

            return history;
        }

        private void EmptyList()
        {
            MessageBox.Show("There is nothing in list yet.");
        }
    }
}

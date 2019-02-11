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
        public AddForm()
        {
            InitializeComponent();
        }

        private int _currentIndex;
        private HistoryDatabase _data = new HistoryDatabase();

        private void AddForm_Load(object sender, EventArgs e)
        {
            _data.LoadFromDatabase();
            Display(_currentIndex);
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
                    _data.Histories.Add(history);
                    _data.SaveToDatabase(history);
                    _currentIndex = _data.Histories.Count - 1;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void firstButton_Click(object sender, EventArgs e)
        {
            Display(0);
        }

        private void lastButton_Click(object sender, EventArgs e)
        {
            Display(_data.Histories.Count - 1);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            Display(_currentIndex + 1);
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            Display(_currentIndex - 1);
        }

        public void Display(int index)
        {
            if (index < 0 || index > _data.Histories.Count - 1)
            {
                MessageBox.Show("Out of range");
                return;
            }

            number1TextBox.Text = _data.Histories[index].Number1.ToString();
            number2TextBox.Text = _data.Histories[index].Number2.ToString();
            SumTextBox.Text = _data.Histories[index].Sum.ToString();
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

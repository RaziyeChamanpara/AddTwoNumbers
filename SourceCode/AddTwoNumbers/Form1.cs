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

        public History history = new History();
        public AddTwoNumbersEntities db = new AddTwoNumbersEntities();
        public int currentId { get; set; }

        private void AddForm_Load(object sender, EventArgs e)
        {
            if (db.Histories.Count() > 0)
            {
                number1TextBox.Text = db.Histories.First().Number1.ToString();
                number2TextBox.Text = db.Histories.First().Number2.ToString();
                SumTextBox.Text = db.Histories.First().Sum.ToString();
                currentId = 1;
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

                    history.Number1 = number1;
                    history.Number2 = number2;
                    history.Sum = Convert.ToInt32(SumTextBox.Text);

                    db.Histories.Add(history);

                    db.SaveChanges();

                    currentId = db.Histories.OrderByDescending
                                            (h => h.Id).First().Id;

                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void firstButton_Click(object sender, EventArgs e)
        {
            number1TextBox.Text = db.Histories.First().Number1.ToString();
            number2TextBox.Text = db.Histories.First().Number2.ToString();
            SumTextBox.Text = db.Histories.First().Sum.ToString();
            currentId = db.Histories.First().Id;
        }

        private void lastButton_Click(object sender, EventArgs e)
        {
            number1TextBox.Text = db.Histories.OrderByDescending(h => h.Id).
                First().Number1.ToString();

            number2TextBox.Text = db.Histories.OrderByDescending(h => h.Id).
                First().Number2.ToString();

            SumTextBox.Text = db.Histories.OrderByDescending(h => h.Id).
                First().Sum.ToString();

            currentId = db.Histories.OrderByDescending(h => h.Id)
               .First().Id;

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            number1TextBox.Clear();
            number2TextBox.Clear();
            SumTextBox.Clear();
            currentId = 0;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (currentId == 0)
                firstButton_Click(sender, e);

            else if (currentId == db.Histories.Count())
                MessageBox.Show("This is the last record.");

            else
            {
                History history = (from h in db.Histories
                                   where h.Id > currentId
                                   orderby h.Id
                                   ascending
                                   select h)
                                  .FirstOrDefault();

                number1TextBox.Text = history.Number1.ToString();
                number2TextBox.Text = history.Number2.ToString();
                SumTextBox.Text = history.Sum.ToString();

                currentId += 1;

            }

        }

        private void priviousButton_Click(object sender, EventArgs e)
        {


        }
    }
}

namespace ServiceProjectExample
{
    using ServiceProjectExample.Models;
    using ServiceProjectExample.Repositories;
    using ServiceProjectExample.Services;
    using System.Windows.Forms;
    public partial class BookForm : Form
    {
        private readonly IBookService _bookService;
        public BookForm()
        {
            _bookService = (IBookService)Program.ServiceProvider.GetService(typeof(IBookService));
            InitializeComponent();
        }


        private void CreateBtn_Click(object sender, System.EventArgs e)
        {

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                var book = new Book()
                {
                    Name = InputName.Text,
                    Description = InputDescription.Text,
                    Year = int.Parse(InputYear.Text)
                };
                _bookService.CreateBook(book);
                MessageBox.Show(InputName.Text, "Created!");
            }
        }

        private void InputName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(InputName.Text))
            {
                e.Cancel = true;
                //InputName.Focus();
                ErrorInputName.SetError(InputName, "Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                ErrorInputName.SetError(InputName, "");
            }
        }

        private void ErrorForDescription(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(InputDescription.Text))
            {
                e.Cancel = true;
                //InputName.Focus();
                ErrorInputName.SetError(InputDescription, "Description should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                ErrorInputName.SetError(InputDescription, "");
            }
        }
    }
}

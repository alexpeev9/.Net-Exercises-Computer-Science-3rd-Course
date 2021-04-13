using DemoProject.Models;
using DemoProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoProject
{
    public partial class HomeForm : Form
    {
        private readonly IBookRepository _bookRepository;
        public HomeForm()
        {
            _bookRepository = (IBookRepository)Program.ServiceProvider.GetService(typeof(IBookRepository));
            InitializeComponent();
            OnStart();
            GetStart();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            var book = new Book()
            {
                Name = InputName.Text,
                Description = InputDescription.Text
            };
            _bookRepository.Add(book);
            ClearForm();
            GetStart();
        }
        private void OnStart()
        {
            BookGridView.ColumnCount = 3;
            BookGridView.Columns[0].Name = "Id";
            BookGridView.Columns[1].Name = "Name";
            BookGridView.Columns[2].Name = "Description";
        }
        private void GetStart()
        {
            BookGridView.Rows.Clear();
            var bookModels = _bookRepository.GetAllBooks;
            foreach(var book in bookModels)
            {
                string[] currentRow = { book.Id.ToString(), book.Name, book.Description };
                BookGridView.Rows.Add(currentRow);
            }
        }
        private void ClearForm()
        {
            InputId.Text = "";
            InputName.Text = "";
            InputDescription.Text = "";
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            int currentId = int.Parse(InputId.Text);
            _bookRepository.Delete(currentId);
            ClearForm();
            GetStart();
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int currentId = int.Parse(InputId.Text);
            Book book = _bookRepository.GetBookById(currentId);
            book.Name = InputName.Text;
            book.Description = InputDescription.Text;

            _bookRepository.Edit(book);
            ClearForm();
            GetStart();
        }

        private void BookGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            InputId.Text = BookGridView.Rows[rowIndex].Cells[0].Value.ToString();
            InputName.Text = BookGridView.Rows[rowIndex].Cells[1].Value.ToString();
            InputDescription.Text = BookGridView.Rows[rowIndex].Cells[2].Value.ToString();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            var bookSearch = InputSearch.Text.ToString();
            if(bookSearch == "")
            {
                GetStart();
            }
            else
            {
                var bookModels = _bookRepository.GetAllBooks.Where(x => x.Name == bookSearch);
                BookGridView.Rows.Clear();
                foreach(var book in bookModels)
                {
                    string[] currentRow = { book.Id.ToString(), book.Name, book.Description };
                    BookGridView.Rows.Add(currentRow);
                }
                InputSearch.Text = "";
            }
        }
    }
}

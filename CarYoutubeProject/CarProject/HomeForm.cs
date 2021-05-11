using Models;
using Repositories.BrandRepository;
using Repositories.CarRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarProject
{
    public partial class HomeForm : Form
    {
        private readonly ICarRepository _carRepository;
        private readonly IBrandRepository _brandRepository;
        
        public HomeForm()
        {
            _carRepository = (ICarRepository)StartUp.ServiceProvider.GetService(typeof(ICarRepository));
            _brandRepository = (IBrandRepository)StartUp.ServiceProvider.GetService(typeof(IBrandRepository));
            InitializeComponent();
            OnStart();
            GetData();
        }
        private void OnStart()
        {
            CarGridView.ColumnCount = 5;
            CarGridView.Columns[0].Name = "Id";
            CarGridView.Columns[1].Name = "Model";
            CarGridView.Columns[2].Name = "Year";
            CarGridView.Columns[3].Name = "Brand";
            CarGridView.Columns[4].Name = "Extras";

            var brandNames = _brandRepository.GetAllBrands
                      .Select(b => b.Name).ToArray();
            this.InputBrandId.Items.AddRange(brandNames);
        }
        private void GetData()
        {
            CarGridView.Rows.Clear();
            var carsModel = _carRepository.GetAllCars;
            foreach(Car car in carsModel)
            {
                string[] currentRow =
                {
                    car.Id.ToString(),
                    car.Model,
                    car.Year.ToString(),
                    car.Brand.Name,
                    string.Join(",",car.CarExtras.Select(x=>x.Extra.Name))
                };
                CarGridView.Rows.Add(currentRow);
            }
        }
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            Brand selectBrand = _brandRepository.GetAllBrands.SingleOrDefault(b => b.Name == InputBrandId.Text);
            var car = new Car()
            {
                Model = InputModel.Text,
                Year = int.Parse(InputYear.Text),
                BrandId = selectBrand.Id,
            };
            int carId = _carRepository.Add(car);
            ClearForm();
            this.Hide();
            CarExtras f2 = new CarExtras(carId);
            f2.ShowDialog();
            GetData();

        }
        private void ClearForm()
        {
            InputId.Text = "";
            InputModel.Text = "";
            InputYear.Text = "";
            InputBrandId.Text = "";
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            var car = new Car()
            {
                Id = int.Parse(InputId.Text),
                Model = InputModel.Text,
                Year = int.Parse(InputYear.Text),
                BrandId = _brandRepository.GetAllBrands.SingleOrDefault(b => b.Name == InputBrandId.Text).Id
            };
            _carRepository.Update(car);
            ClearForm();
            GetData();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var currentId = int.Parse(InputId.Text);
            _carRepository.Delete(currentId);
            ClearForm();
            GetData();
        }

        private void CarGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            InputId.Text = CarGridView.Rows[rowIndex].Cells[0].Value.ToString();
            InputModel.Text = CarGridView.Rows[rowIndex].Cells[1].Value.ToString();
            InputYear.Text = CarGridView.Rows[rowIndex].Cells[2].Value.ToString();
            InputBrandId.Text = CarGridView.Rows[rowIndex].Cells[3].Value.ToString();
        }
        private void CarGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int currentId  = int.Parse(CarGridView.Rows[rowIndex].Cells[0].Value.ToString());
            this.Hide();
            CarExtras f2 = new CarExtras(currentId);
            f2.ShowDialog();
        }
    }
}

namespace CarDesktopApp
{
    using DataAccess.Repositories.Interfaces;
    using DataStructure;
    using System;
    using System.Data;
    using System.Linq;
    using System.Windows.Forms;
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
            CarGrid.ColumnCount = 4;
            CarGrid.Columns[0].Name = "Id";
            CarGrid.Columns[1].Name = "Model";
            CarGrid.Columns[2].Name = "Brand";
            CarGrid.Columns[3].Name = "Year";
            var brandNames = _brandRepository.Brands
                        .Select(b => b.Name).ToArray();
            this.InputBrandId.Items.AddRange(brandNames);
        }
        private void GetData()
        {
            CarGrid.Rows.Clear();
            var carsModel = _carRepository.Cars;
            foreach (var car in carsModel)
            {
                string[] currentRow = { car.Id.ToString(), car.Model, car.Brand.Name, car.Year.ToString()};
                CarGrid.Rows.Add(currentRow);
            }
        }
        private void CreateButton_Click(object sender, EventArgs e)
        {
            var selectedBrand = _brandRepository.Brands.SingleOrDefault(b => b.Name == InputBrandId.Text);
            var car = new Car()
            {
                Model = InputModel.Text,
                Year = int.Parse(InputYear.Text),
                BrandId = selectedBrand.Id,
            };
            _carRepository.Add(car);
            ClearForm();
            //MessageBox.Show($"Great Success");
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
            var currentId = int.Parse(InputId.Text);
            var carBase = _carRepository.Car(currentId);
            carBase.Model = InputModel.Text;
            carBase.Year = int.Parse(InputYear.Text);
            carBase.Brand = _brandRepository.Brands.SingleOrDefault(b => b.Name == InputBrandId.Text);
            _carRepository.Edit(carBase);
            ClearForm();
            GetData();
        }
        private void CarGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            InputId.Text = CarGrid.Rows[rowIndex].Cells[0].Value.ToString();
            InputModel.Text = CarGrid.Rows[rowIndex].Cells[1].Value.ToString();
            InputBrandId.Text = CarGrid.Rows[rowIndex].Cells[2].Value.ToString();
            InputYear.Text = CarGrid.Rows[rowIndex].Cells[3].Value.ToString();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            var currentId = int.Parse(InputId.Text);
            var dbCar = _carRepository.Cars.SingleOrDefault(c => c.Id == currentId);
            _carRepository.Delete(dbCar);
            ClearForm();
            GetData();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            var model = InputSearch.Text.ToString();
            if (model == "")
            {
                GetData();
            }
            else
            {
                var carsModel = _carRepository.Cars.Where(x => x.Model == model);
                CarGrid.Rows.Clear();
                foreach (var car in carsModel)
                {
                    string[] currentRow = { car.Id.ToString(), car.Model, car.Brand.Name, car.Year.ToString() };
                    CarGrid.Rows.Add(currentRow);
                }
                InputSearch.Text = "";
            }
        }

    }
}

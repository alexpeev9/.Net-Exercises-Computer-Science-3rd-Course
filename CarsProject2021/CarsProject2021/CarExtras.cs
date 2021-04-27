namespace CarsProject2021
{
    using Models;
    using Repositories.CarExtraRepository;
    using Repositories.CarRepository;
    using Repositories.ExtraRepository;
    using System;
    using System.Linq;
    using System.Windows.Forms;
    public partial class CarExtras : Form
    {
        private readonly ICarExtraRepository _carExtraRepository;
        private readonly ICarRepository _carRepository;
        private readonly IExtraRepository _extraRepository;
        private readonly int _currentId;
        public CarExtras(int currentId)
        {
            _currentId = currentId;
            _carExtraRepository = (ICarExtraRepository)StartUp.ServiceProvider.GetService(typeof(ICarExtraRepository));
            _extraRepository = (IExtraRepository)StartUp.ServiceProvider.GetService(typeof(IExtraRepository));
            _carRepository = (ICarRepository)StartUp.ServiceProvider.GetService(typeof(ICarRepository));
            InitializeComponent();
            OnStart();
            GetData();
        }
        private void OnStart()
        {
            var brandNames = _extraRepository.GetAllExtras.Select(b => b.Name).ToArray();
            this.InputCarName.Text = _carRepository.GetCarById(_currentId).Model;
            this.ComboExtraId.Items.AddRange(brandNames);
            ManyToManyGrid.ColumnCount = 2;
            ManyToManyGrid.Columns[0].Name = "Name";
            ManyToManyGrid.Columns[1].Name = "Description";
        }
        private void GetData()
        {
            ManyToManyGrid.Rows.Clear();
            var carExtras = _carExtraRepository.GetCarExtras(_currentId);
            foreach (var carExtra in carExtras)
            {
                string[] currentRow =
                {
                    carExtra.Extra.Name,
                    carExtra.Extra.Description,
                };
                ManyToManyGrid.Rows.Add(currentRow);
            }
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm f1 = new HomeForm();
            f1.ShowDialog();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Extra selectedExtra = _extraRepository.GetExtraByName(ComboExtraId.Text);
            CarExtra currentCarExtra = new CarExtra
            {
                CarId = _currentId,
                ExtraId = selectedExtra.Id
            };
            _carExtraRepository.Add(currentCarExtra);
            MessageBox.Show($"Great Success");
            ComboExtraId.Text = "";
        }

        private void ManyToManyGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            InputCarName.Text = ManyToManyGrid.Rows[rowIndex].Cells[0].Value.ToString();
            ComboExtraId.Text = ManyToManyGrid.Rows[rowIndex].Cells[1].Value.ToString();
        }
    }
}

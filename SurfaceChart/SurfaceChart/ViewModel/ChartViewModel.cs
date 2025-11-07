using System.Collections.ObjectModel; 
using System.ComponentModel; 
using System.Runtime.CompilerServices; 

namespace SurfaceChart
{
    public class ChartViewModel : INotifyPropertyChanged
    {
        private int rowSize;
        private int columnSize;
        private ObservableCollection<EnergyDataPoint> dataValues = new();

        public ObservableCollection<EnergyDataPoint> DataValues
        {
            get => dataValues;
            set { dataValues = value; OnPropertyChanged(); }
        }

        public int RowSize
        {
            get => rowSize;
            set { rowSize = value; OnPropertyChanged(); }
        }

        public int ColumnSize
        {
            get => columnSize;
            set { columnSize = value; OnPropertyChanged(); }
        }


        public ChartViewModel()
        {
            var stats = new List<AnnualEnergyStats>
            {
                new() { Year = 2015, Canada = 111824, France = 43493, India = 5943, UK = 34864, US = 78949 },
                new() { Year = 2016, Canada = 109289, France = 42506, India = 6148, UK = 34099, US = 78155 },
                new() { Year = 2017, Canada = 109394, France = 42219, India = 6304, UK = 33925, US = 77730 },
                new() { Year = 2018, Canada = 109465, France = 42589, India = 6593, UK = 33653, US = 79894 },
                new() { Year = 2019, Canada = 107456, France = 41554, India = 6682, UK = 32677, US = 78683 },
                new() { Year = 2020, Canada = 100465, France = 37088, India = 6268, UK = 29440, US = 72563 },
                new() { Year = 2021, Canada = 100431, France = 39307, India = 6749, UK = 29422, US = 76307 },
                new() { Year = 2022, Canada = 102122, France = 34796, India = 7057, UK = 29480, US = 77628 },
                new() { Year = 2023, Canada = 98930,  France = 36221, India = 7529, UK = 28095, US = 76327 },
                new() { Year = 2024, Canada = 97785,  France = 37866, India = 7813, UK = 28016, US = 76800 },
            };

            BuildSurfaceData(stats);
        }

        private void BuildSurfaceData(IList<AnnualEnergyStats> years)
        {
            DataValues.Clear();
            foreach (var y in years)
            {
                DataValues.Add(new EnergyDataPoint { Year = y.Year, Consumption = y.Canada / 1000d, Country = 1 });
                DataValues.Add(new EnergyDataPoint { Year = y.Year, Consumption = y.France / 1000d, Country = 2 });
                DataValues.Add(new EnergyDataPoint { Year = y.Year, Consumption = y.India / 1000d, Country = 3 });
                DataValues.Add(new EnergyDataPoint { Year = y.Year, Consumption = y.UK / 1000d, Country = 4 });
                DataValues.Add(new EnergyDataPoint { Year = y.Year, Consumption = y.US / 1000d, Country = 5 });
            }

            RowSize = years.Count;  // number of years provided
            ColumnSize = 5;         // countries plotted per year
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string? name = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}

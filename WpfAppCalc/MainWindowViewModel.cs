using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppCalc
{
    public partial class MainWindowViewModel: ObservableObject
    {
        [ObservableProperty] int? operand1 = null;
        [ObservableProperty] int? operand2 = null;
        [ObservableProperty] string? mathOperator = null;

        private string[] _operators = new string[] { "+", "-", "*", "/" };

        public MainWindowViewModel()
        {
            
        }

        [RelayCommand]
        private void Calculate()
        {

        }
    }
}

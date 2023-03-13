using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Cwlibary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW.ViewModels
{
    public partial class CwVM : ObservableRecipient, IRecipient<SaveMessege>
    {


        [ObservableProperty]
        public double result;



        [ObservableProperty]
        private int clickedNumber;





        [RelayCommand]
        public void NumbercClicked(string number)
        {

            clickedNumber = int.Parse(number);
            if (clickedNumber == 0) result = 0;
            else result = result + clickedNumber;
        }


        public void Receive(SaveMessege message)
        {
            throw new NotImplementedException();
        }
    }
}

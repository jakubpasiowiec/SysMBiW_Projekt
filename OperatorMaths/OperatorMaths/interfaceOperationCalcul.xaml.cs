using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OperatorMaths
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class interfaceOperationCalcul : ContentPage
    {
        stackLayoutOperator _stack;
        operatorChoice _operatorChoice;
        String signe;
        public interfaceOperationCalcul(String operateurMaths, string mode)
        {
            InitializeComponent();
            signe = operateurMaths;
            frameMode.Text = mode;
            _stack = new stackLayoutOperator(operateurMaths);
            _operatorChoice = new operatorChoice(operateurMaths);
            stackLayoutFunction.Children.Add(_stack.operateurStackLayout());
        }

        private async void btnResult(object sender, EventArgs e)
        {
            if (signe == "b>d" || signe == "b>h")
                foreach (char c in _stack.EntryNumber1.Text)
                    if (c != '0' && c != '1' && c != '-')
                    {
                        await DisplayAlert("Binary mode", "Digit accepted => '0', '1', '-'", "OK");
                        btnClear(sender, e);
                        break;
                    }
            if(signe == "h>d" || signe == "h>b")
                foreach (char c in _stack.EntryNumber1.Text)
                    
                    if (c != '0' && c != '1' && c != '2' && c != '3' && c != '4' && c != '5' && c != '6' && c != '7' && c != '8' && 
                        c != '9' && c != 'A' && c!='a' && c != 'B' && c != 'b' && c != 'c' && c != 'C' && c != 'd' && c != 'D' && c != 'e' &&
                        c != 'E' && c != 'f' && c != 'F')
                    {
                        await DisplayAlert("Hexadecimal mode", "Digit accepted => [0,9] && [A,F]", "OK");
                        btnClear(sender, e);
                        break;
                    }

            if (_stack.EntryNumber1.Text == "")
                _stack.EntryNumber1.Text = "0";
            if (_stack.EntryNumber2.Text == "")
                _stack.EntryNumber2.Text = "0";
            if (_stack.EntryNumber3.Text == "")
                _stack.EntryNumber3.Text = "0";

           

            lblResult.Text = _operatorChoice.calculOperation(_stack.EntryNumber1.Text, _stack.EntryNumber2.Text, _stack.EntryNumber3.Text);
        }

        private void btnClear(object sender, EventArgs e)
        {
            _stack.EntryNumber1.Text = "";
            _stack.EntryNumber2.Text = "";
            _stack.EntryNumber3.Text = "";
            lblResult.Text = "Wynik";
        }
    }
}
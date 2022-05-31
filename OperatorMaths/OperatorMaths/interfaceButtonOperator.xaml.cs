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
    public partial class interfaceButtonOperator : ContentPage
    {
        public interfaceButtonOperator()
        {
            InitializeComponent();
        }

        private async void btnOperatorCalcul(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            string mode = btn.ClassId;
            await Navigation.PushAsync(new interfaceOperationCalcul(btn.AutomationId, mode));
        }

        private async void imageBtnOperatorCalcul(object sender, EventArgs e)
        {
            var btn = (ImageButton)sender;
            await Navigation.PushAsync(new interfaceOperationCalcul(btn.AutomationId, btn.ClassId));
        }
    }
}
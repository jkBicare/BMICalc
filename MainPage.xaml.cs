using BMICalc.ViewModels;

namespace BMICalc
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new BMIViewModel();
        }
    }

}

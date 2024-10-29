using BMICalc.Models;
using System.ComponentModel;

namespace BMICalc.ViewModels
{
    public class BMIViewModel
    {
       public BMI BMI { get; set; }

        public BMIViewModel()
        {
            BMI = new BMI();
            BMI.Height = 170;
            BMI.Weight = 43;
        }
    }
}

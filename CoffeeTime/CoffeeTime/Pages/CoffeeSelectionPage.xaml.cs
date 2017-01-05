using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace CoffeeTime.Pages
{
    public partial class CoffeeSelectionPage : ContentPage
    {
        private readonly CoffeeCalculations _coffeeCalculations;

        public CoffeeSelectionPage()
        {
            _coffeeCalculations = new CoffeeCalculations();

            InitializeComponent();

            CoffeeCupSelectionText.Text = $"Cups: {CoffeeCupStepper.Value}";
            CoffeeGramSlider.Value = _coffeeCalculations.CupsToCoffeeGrams(CoffeeMethodPicker.Items[CoffeeMethodPicker.SelectedIndex],
                    Convert.ToInt32(CoffeeCupStepper.Value));
            CoffeeGramsText.Text = $"{CoffeeGramSlider.Value:F1}";
        }

        private void CoffeeCupStepper_OnValueChanged(object sender, ValueChangedEventArgs e)
        {
            CoffeeCupSelectionText.Text = $"Cups: {e.NewValue}";
            CoffeeGramSlider.Value = _coffeeCalculations.CupsToCoffeeGrams(CoffeeMethodPicker.Items[CoffeeMethodPicker.SelectedIndex],
                    Convert.ToInt32(CoffeeCupStepper.Value));
        }

        private void CoffeeGramSlider_OnValueChanged(object sender, ValueChangedEventArgs e)
        {
            //CoffeeGramsText.Text = Convert.ToInt32(e.NewValue).ToString();
            CoffeeGramsText.Text = $"{e.NewValue:F1}";
        }
    }
}

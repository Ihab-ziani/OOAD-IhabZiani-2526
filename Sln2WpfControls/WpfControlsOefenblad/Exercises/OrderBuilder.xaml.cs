using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using WpfControlsOefenblad.Helpers;

namespace WpfControlsOefenblad.Exercises
{
    [NavPage(Title = "Order Builder", Description = "CheckBox + RadioButton met samenvatting en reset.", Order = 5, IsVisible = true)]
    public partial class OrderBuilder : Page
    {
        public OrderBuilder()
        {
            InitializeComponent();
        }
        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            // Leveringsmethode
            string levering = "";
            if (rbDelivery.IsChecked == true) levering = "Thuislevering";
            else if (rbPickup.IsChecked == true) levering = "Afhalen";
            else
            {
                txtSummary.Text = "Kies eerst een leveringsmethode";
                return;
            }

            // Gekozen ingrediënten
            List<string> keuzes = new List<string>();
            if (chkCheese.IsChecked == true) keuzes.Add("Cheese");
            if (chkTomato.IsChecked == true) keuzes.Add("Tomato");
            if (chkPepperoni.IsChecked == true) keuzes.Add("Pepperoni");
            if (chkMushrooms.IsChecked == true) keuzes.Add("Mushrooms");
            if (chkOnions.IsChecked == true) keuzes.Add("Onions");
            if (chkOlives.IsChecked == true) keuzes.Add("Olives");

            // Samenvatting
            txtSummary.Text = $"Je hebt gekozen voor: {string.Join(", ", keuzes)}.\nLevering: {levering}.";
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            // Reset checkboxen
            chkCheese.IsChecked = true;
            chkTomato.IsChecked = false;
            chkPepperoni.IsChecked = true;
            chkMushrooms.IsChecked = false;
            chkOnions.IsChecked = false;
            chkOlives.IsChecked = false;

            // Reset radiobuttons
            rbDelivery.IsChecked = false;
            rbPickup.IsChecked = false;

            // Samenvatting
            txtSummary.Text = "...";
        }
    }
}

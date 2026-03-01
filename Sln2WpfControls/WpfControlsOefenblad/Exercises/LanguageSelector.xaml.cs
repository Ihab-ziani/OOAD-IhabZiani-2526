using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using WpfControlsOefenblad.Helpers;

namespace WpfControlsOefenblad.Exercises;

[NavPage(Title = "Language Selector", Description = "ComboBox SelectionChanged event en ComboBoxItem", Order = 6, IsVisible = true)]
public partial class LanguageSelector : Page
{
    public LanguageSelector()
    {
        InitializeComponent();

        // Array maken
        string[] languages = { "Nederlands", "English", "Français" };

        // ComboBoxItems toevoegen
        foreach (string taal in languages)
        {
            ComboBoxItem item = new ComboBoxItem();
            item.Content = taal;
            cmbLanguage.Items.Add(item);
        }
    }

    private void cmbLanguage_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        ComboBoxItem gekozenItem = (ComboBoxItem)cmbLanguage.SelectedItem;

        if (gekozenItem == null)
            return;

        string taal = gekozenItem.Content.ToString();

        // Begroeting tonen (switch-case!)
        switch (taal)
        {
            case "Nederlands":
                txtGreeting.Text = "Hallo";
                break;

            case "English":
                txtGreeting.Text = "Hello";
                break;

            case "Français":
                txtGreeting.Text = "Bonjour";
                break;

            default:
                txtGreeting.Text = "...";
                break;
        }

        // Alle items terug normaal maken
        foreach (ComboBoxItem item in cmbLanguage.Items)
        {
            item.FontWeight = FontWeights.Normal;
        }

        // Gekozen item vet maken
        gekozenItem.FontWeight = FontWeights.Bold;
    }
}

using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WpfControlsOefenblad.Helpers;
using System.Linq;

namespace WpfControlsOefenblad.Exercises
{
    [NavPage(Title = "Live Form Validation", Description = "TextChanged gebruiken voor live validatie en IsEnabled.", Order = 4, IsVisible = true)]
    public partial class LiveFormValidation : Page
    {
        public LiveFormValidation()
        {
            InitializeComponent();
        }
    }
    private void txtPaswoord_TextChanged(object sender, TextChangedEventArgs e)
        {
            string password = txtPaswoord.Text;

            // Leeg wachtwoord
            if (string.IsNullOrWhiteSpace(password))
            {
                txtStatus.Text = "";
                btnSave.IsEnabled = false;
                return;
            }

            // Controle regels
            bool lengteOk = password.Length >= 8;
            bool hoofdletterOk = password.Any(c => char.IsUpper(c));
            bool cijferOk = password.Any(c => char.IsDigit(c));

            bool geldig = lengteOk && hoofdletterOk && cijferOk;

            if (geldig)
            {
                txtStatus.Text = "Geldig paswoord";
                txtStatus.Foreground = System.Windows.Media.Brushes.DarkGreen;
                btnSave.IsEnabled = true;
            }
            else
            {
                txtStatus.Text = "ongeldig paswoord";
                txtStatus.Foreground = System.Windows.Media.Brushes.Red;
                btnSave.IsEnabled = false;
            }
        }
    }

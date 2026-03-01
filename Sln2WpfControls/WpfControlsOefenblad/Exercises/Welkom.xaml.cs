using System;
using System.Windows;
using System.Windows.Controls;
using WpfControlsOefenblad.Helpers;

namespace WpfControlsOefenblad.Exercises
{
    [NavPage(Title = "Welkom", Description = "TextBox met eenvoudige validatie.", Order = 2, IsVisible = true)]
    public partial class Welkom : Page
    {
        public Welkom()
        {
            InitializeComponent();
        }
    }

    private void btnVerzenden_Click(object sender, RoutedEventArgs e)
        {
            string naam = txtNaam.Text.Trim();

            if (naam == "")
            {
                txtFout.Visibility = Visibility.Visible;
                txtResultaat.Text = "...";
            }
            else
            {
                txtFout.Visibility = Visibility.Hidden;
                txtResultaat.Text = "Welkom, " + naam + "!";
            }
        }
    }

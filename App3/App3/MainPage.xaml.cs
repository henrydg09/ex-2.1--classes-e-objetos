using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            {

                void OnButtonClicked(object sender, Event args)
                {
                    Label1.IsVisible = false;
                    Label1.IsVisible = false;
                    if (Entry2.text != null &&
                        Entry2.Text.Lenght > 0 &&
                        Picker.SelectedIndex >= 0)
                    {
                        int periodo = int.Parse(Entry2.text);
                        int semestre = Picker.SelectedIndex + 1;
                        if periodo == semestre;
                    {
                            Label1.IsVisible = true;
                        } else
                        {
                            Label2.IsVisible = true;
                        }
                    } else
                    {
                        Label2.IsVisible = true;
                    }
                }
            }
        }
    }
}
  

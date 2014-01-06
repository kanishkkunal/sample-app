using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Media;

namespace SampleApp.SamplePages
{
    public partial class CustomFont : PhoneApplicationPage
    {
        public CustomFont()
        {
            InitializeComponent();
            //Font Source: http://www.dafont.com/elegant-ink.font
            //See http://blog.superdevresources.com/ for more free fonts
            appTitle.FontFamily = new FontFamily("/Assets/Fonts/elegant_ink.ttf#Elegant Ink");
            TodosListToday.ItemsSource = new String[] { "Car Wash", "Buy Groceries", "Complete Assignment" };
            TodosListLater.ItemsSource = new String[] { "Buy Shoes", "Study for Exams", "Practice for tennis match" };
        }
    }
}
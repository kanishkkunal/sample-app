using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace WindowsStore.SamplePages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CustomFont : Page
    {
        public CustomFont()
        {
            this.InitializeComponent();
            //Font Source: http://www.dafont.com/elegant-ink.font
            //See http://blog.superdevresources.com/ for more free fonts
            appTitle.FontFamily = new FontFamily("/Assets/Fonts/elegant_ink.ttf#Elegant Ink");
            TodosListToday.ItemsSource = new String[] { "Car Wash", "Buy Groceries", "Complete Assignment" };
            TodosListLater.ItemsSource = new String[] { "Buy Shoes", "Study for Exams", "Practice for tennis match" };
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
    }
}

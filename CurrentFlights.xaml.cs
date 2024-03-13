using System.Collections.Generic;
using System.Windows;

namespace Avia1
{
    public partial class CurrentFlightsWindow : Window
    {
        public static List<Flight> CurrentFlightsList = new List<Flight>();

        public CurrentFlightsWindow()
        {
            InitializeComponent();
            AddCurrentFlight("Київ", "Бізнес клас");
            AddCurrentFlight("Біла Церква", "Економ клас");
            AddCurrentFlight("Харків", "Бізнес клас");
            AddCurrentFlight("Одеса", "Бізнес клас");
        }

        public void AddCurrentFlight(string destination, string ticketClass)
        {
            CurrentFlightsList.Add(new Flight
            {
                Destination = destination,
                TripType = "One Way",
                Class = ticketClass
            });

            CurrentFlightsListBox.Items.Add($"{destination}, One Way, {ticketClass}");
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HealthCentreSystem
{
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private HealthCentre healthCentre;

        public MainWindow()
        {
            InitializeComponent();
            CreateObjects();
            lstPatients.ItemsSource = healthCentre.GetPatients();
        }

        public void CreateObjects()
        {
            healthCentre = new HealthCentre("Sunnyvale Health Centre", "El Camino Royale Boluevard");
            Patient pat1 = new Patient("Sebastien", "Vettel", "P001", "9/8/1990", "NHS");
            Patient pat2 = new Patient("Adrian", "Sutil", "P002", "10/11/1988", "PRIVATE");
            Patient pat3 = new Patient("Nico", "Rosberg", "P003", "12/3/1990", "PRIVATE");
            Patient pat4 = new Patient("Vitaly", "Petrov", "P004", "8/9/1984", "NHS");
            Patient pat5 = new Patient("Fernando", "Alonso", "P005", "12/7/1981", "PRIVATE");
            Patient pat6 = new Patient("Felipe", "Massa", "P006", "11/4/1981", "PRIVATE");
            healthCentre.AddPatient(pat1);
            healthCentre.AddPatient(pat2);
            healthCentre.AddPatient(pat3);
            healthCentre.AddPatient(pat4);
            healthCentre.AddPatient(pat5);
            healthCentre.AddPatient(pat6);

        }

        private void cmdGetPatient_Click(object sender, RoutedEventArgs e)
        {
            Patient foundPatient = healthCentre.GetPatientByID(txtPatientID.Text);
            txtName.Text = "";
            txtDoB.Text = "";
            txtStatus.Text = "";

            if (foundPatient != null)
            {
                txtName.Text = foundPatient.GetFullName();
                txtDoB.Text = foundPatient.DateOfBirth.ToShortDateString();
                txtStatus.Text = foundPatient.Status;
            }
        }
    }
}

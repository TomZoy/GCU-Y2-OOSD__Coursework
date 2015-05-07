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

namespace Appointments
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<IPerson> people = new List<IPerson>();

        public MainWindow()
        {
            InitializeComponent();
            CreateObjects();
            cmbPeople.ItemsSource = people;
            cmbPeople.SelectedIndex = 0;
        }

        public void CreateObjects()
        {
            GeneralPractitioner doc1 = new GeneralPractitioner("D001", "Michael", "Schumacher", "GP","London Road");
            GeneralPractitioner doc2 = new GeneralPractitioner("D002", "Rubens", "Barrichello", "GP","Glasgow Road");
            GeneralPractitioner doc3 = new GeneralPractitioner("D003", "Mark", "Webber", "GP", "Edinburgh Road");
            people.Add(doc1);
            people.Add(doc2);
            people.Add(doc3);

            Surgeon doc4 = new Surgeon("D004", "Timo", "Glock", "ENT","Southern General");
            Surgeon doc5 = new Surgeon("D005", "Jenson", "Button", "Paediatrics","Western General");
            Surgeon doc6 = new Surgeon("D006", "Robert", "Kubica", "Surgery","Northern General");
            people.Add(doc4);
            people.Add(doc5);
            people.Add(doc6);

            Patient pat1 = new Patient("P001","Sebastien", "Vettel", "9/8/1990", "NHS");
            Patient pat2 = new Patient("P002", "Adrian", "Sutil", "10/11/1988", "PRIVATE");
            Patient pat3 = new Patient("P003", "Nico", "Rosberg", "12/3/1990", "PRIVATE");
            people.Add(pat1);
            people.Add(pat2);
            people.Add(pat3);

        }

        private void cmbPeople_SelectionChanged(object sender, RoutedEventArgs e)
        {
            txtFullName.Clear();
            txtPractice.Clear();
            txtNext.Clear();
            txtHospital.Clear();
            
            int index = cmbPeople.SelectedIndex;
            IPerson pers = this.people[index];

            txtFullName.Text = pers.GetFullName();

            if (pers is GeneralPractitioner)
            {
                GeneralPractitioner gp = (GeneralPractitioner)pers;
                txtPractice.Text = gp.Practice;
                txtNext.Text = gp.NextAvailableHomeVisit().ToShortDateString();
            }
            if (pers is Surgeon)
            {
                Surgeon surg = (Surgeon)pers;
                txtHospital.Text = surg.Hospital;
                txtNext.Text = surg.NextAvailableAppointment().ToShortDateString();
            }
        }
    }
}

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
            Doctor doc1 = new Doctor("D001","Michael","Schumacher", "ENT");
            Doctor doc2 = new Doctor("D002", "Rubens", "Barrichello", "Paediatrics");
            Doctor doc3 = new Doctor("D003", "Mark", "Webber", "Surgery");
            people.Add(doc1);
            people.Add(doc2);
            people.Add(doc3);

            Patient pat1 = new Patient("P001", "Sebastien", "Vettel", "9/8/1990", "NHS");
            Patient pat2 = new Patient("P002", "Adrian", "Sutil", "10/11/1988", "PRIVATE");
            Patient pat3 = new Patient("P003", "Nico", "Rosberg", "12/3/1990", "PRIVATE");
            people.Add(pat1);
            people.Add(pat2);
            people.Add(pat3);

        }

        private void cmbPeople_SelectionChanged(object sender, RoutedEventArgs e)
        {
            int index = cmbPeople.SelectedIndex;
            IPerson pers = this.people[index];

            txtFullName.Text = pers.GetFullName();
        }

        
    }
}

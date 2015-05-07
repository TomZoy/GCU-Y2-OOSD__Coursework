using System;
using SimpleCollections;

namespace CollectionsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleEnumerableArrayList people = new SimpleEnumerableArrayList();
           
            Doctor doc1 = new Doctor("D001", "Michael", "Schumacher", "GP");
            Doctor doc2 = new Doctor("D002", "Rubens", "Barrichello", "GP");
            Doctor doc3 = new Doctor("D003", "Mark", "Webber", "GP");

            Patient pat1 = new Patient("Sebastien", "Vettel", "P001", "9/8/1990", "NHS");
            Patient pat2 = new Patient("Adrian", "Sutil", "P002", "10/11/1988", "PRIVATE");
            Patient pat3 = new Patient("Nico", "Rosberg", "P003", "12/3/1990", "PRIVATE");

            people.Add(doc1);
            people.Add(doc2);
            people.Add(doc3);
            people.Add(pat1);
            people.Add(pat2);
            people.Add(pat3);

            foreach (IPerson p in people)
            {
                Console.WriteLine(p.GetFullName());
            }

            Console.ReadLine();


        }
    }
}

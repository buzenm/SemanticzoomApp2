using SemanticzoomApp2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemanticzoomApp2.ViewModels
{
    public class MyDatasViewModel
    {
        public readonly Person[] PeopleDatas = new[]
        {
            new Person{ID=1,Name="Maa",PersonGender=Gender.Men,Discription = "Maaaaaaaaaaaaa"},
            new Person{ID=2,Name="Mbb",PersonGender=Gender.Men,Discription = "Mbbbbbbbbbbbbbbbb"},
            new Person{ID=3,Name="Mcc",PersonGender=Gender.Men,Discription = "Mccccccccccccc"},
            new Person{ID=4,Name="Mdd",PersonGender=Gender.Men,Discription = "Mdddddddddddddd"},
            new Person{ID=5,Name="Mee",PersonGender=Gender.Men,Discription = "Meeeeeeeeeeeeeeee"},
            new Person{ID=6,Name="WMaa",PersonGender=Gender.Women,Discription = "WMaaaaaaaaaaaaaaaa"},
            new Person{ID=7,Name="WMbb",PersonGender=Gender.Women,Discription = "WMbbbbbbbbbbbbbbb"},
            new Person{ID=8,Name="WMcc",PersonGender=Gender.Women,Discription = "WMcccccccccccccccc"},
            new Person{ID=9,Name="WMdd",PersonGender=Gender.Women,Discription = "WMddddddddddddddd"},
            new Person{ID=10,Name="WMee",PersonGender=Gender.Women,Discription = "WMeeeeeeeeeeeee"},
        };

        public IList<Person> People { get; set; }
        public IList<PeopleGroup> PeopleGroups { get; set; }

        public MyDatasViewModel()
        {
            People = new ObservableCollection<Person>(PeopleDatas);
            PeopleGroups = new ObservableCollection<PeopleGroup>
            {
                new PeopleGroup("Men",new ObservableCollection<Person>(PeopleDatas.Where(c=>c.PersonGender == Gender.Men))),
                new PeopleGroup("Women",new ObservableCollection<Person>(PeopleDatas.Where(c=>c.PersonGender == Gender.Women))),
            };
        }
    }

    
}

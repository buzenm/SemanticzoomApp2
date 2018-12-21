using SemanticzoomApp1.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace SemanticzoomApp1.ViewModels
{
    public class DiaryListSemanticzoomViewModel
    {
        public IList<Group> Groups { get; set; }

        public DiaryListSemanticzoomViewModel()
        {
            Groups = new ObservableCollection<Group>
            {
                new Group("2018-12-21",new ObservableCollection<Diary>
                {
                    new Diary
                    {
                        Date = "2018-12-20",
                        Weather = "qing",
                        Content = "diyitian"
                    },
                    new Diary
                    {
                        Date = "2018-12-20",
                        Weather = "qing",
                        Content = "diyitian"
                    }
                }),
                new Group("2018-11-20",new ObservableCollection<Diary>
                {
                    new Diary
                    {
                        Date = "2018-12-20",
                        Weather = "qing",
                        Content = "qianyitian"
                    },
                    new Diary
                    {
                        Date = "2018-12-20",
                        Weather = "qing",
                        Content = "qianyitian"
                    }
                })
                
            };
        }
    }
}

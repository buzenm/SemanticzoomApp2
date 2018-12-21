using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemanticzoomApp2.Models
{
    public class PeopleGroup
    {
        public string GroupTitle { get; set; }
        public IList<Person> PeopleInfos { get; set; }

        public PeopleGroup(string _groupTitle, IList<Person> _peopleInfos)
        {
            this.GroupTitle = _groupTitle;
            this.PeopleInfos = _peopleInfos;
        }
    }

}

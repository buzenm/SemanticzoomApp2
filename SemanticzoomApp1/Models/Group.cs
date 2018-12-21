using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemanticzoomApp1.Models
{
    public class Group
    {
        public string GroupTitle { get; set; }

        public IList<Diary> GroupItems { get; set; }

        public Group(string groupTitle,IList<Diary> groupItems)
        {
            GroupTitle = groupTitle;
            GroupItems = groupItems;
        }

    }
}

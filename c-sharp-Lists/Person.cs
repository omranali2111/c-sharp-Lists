using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_Lists
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }

        public Person(int id, string name, string title)
        {
            Id = id;
            Name = name;
            Title = title;
        }

        public override string ToString()
        {
            return $"ID: {Id}\nName: {Name}\nTitle: {Title}\n";
        }
    }
}

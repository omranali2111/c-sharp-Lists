using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_Lists
{
    internal class Person:IComparable<Person>
    {
        public int Id { get; set; }

        public int Age { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }



        public Person(int id,int age ,string name, string title)
        {
            Id = id;
            Age = age;
            Name = name;
            Title = title;
        }

        public override string ToString()
        {
            return $"ID: {Id}\nName: {Name}\nAge: {Age}\nTitle: {Title}\n";
        }

        public int CompareTo(Person? other)
        {
            if (other == null)
            { return 1; } 
           if(other.Age==this.Age) 
                return 0 ;
           if(other.Age>this.Age)
                return -1 ;

           return 1 ;
        }
    }
}

using c_sharp_Lists;
using System;
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
       List<int> list = new List<int>();
        list.Add(1);
        list.Add(2);
        list.Remove(1);
        list.Add(3);
        list.Add(4);
        list.Add(5);
        list.Insert(0, 1);

        foreach (int i in list)
        {
            Console.WriteLine(i);
        }


        List<Person> personlist= new List<Person>();
        personlist.Add(new Person(1123,19, "omran", "Mr"));
        personlist.Add(new Person(1125,20, "fatima", "Ms"));
        personlist.Add(new Person(1129,18 ,"ali", "Mr"));



        foreach (Person person in personlist)
        {
            Console.WriteLine(person.ToString());
        }

        

        personlist.Sort();

        Console.WriteLine("this is after sorting: ");

        foreach (Person person in personlist)
        {
            Console.WriteLine(person.ToString());
        }


        ArrayList arraylist= new ArrayList();
        arraylist.Add(1);
        arraylist.Add("hello");
        arraylist.Add(new Person(1118, 30, "omar", "Mr"));

        foreach(var item  in arraylist)
        {
            Console.WriteLine(item.ToString());
        }



    }
}
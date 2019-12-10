using System;
using System.Collections.Generic;

namespace A_LvLMod2Less_1
{
    class Gum
    {
        public static List<Person> persons = new List<Person>();

        public static void InToGum(string name, int count, string str)
        {
            Person person = new Person(name, count, str);
            persons.Add(person);
        }

        public static void Training()
        {
            if (persons.Count != 0)
            {
                for (int i = 0; i < persons.Count; i++)
                {
                    if (persons[i].count > 0)
                    {
                        persons[i].count--;
                    }
                    else
                    {
                        persons.RemoveAt(i);
                    }
                }
            }
        }
    }
}

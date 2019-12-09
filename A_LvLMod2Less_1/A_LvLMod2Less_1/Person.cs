using System;

namespace A_LvLMod2Less_1
{
    class Person
    {
        public string name;
        public string rooms;
        public int count;
        public Guid guid;

        public Person(string name, int count, string str)
        {
            this.name = name;
            this.count = count;
            rooms = str;
            guid = Guid.NewGuid();
        }

        public override string ToString()
        {
            return $"name = {name}, Count = {count}, rooms = {rooms}, Guid = {guid}";
        }
    }
}

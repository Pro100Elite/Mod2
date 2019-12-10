using System;

namespace A_LvLMod2Less_1
{
    class Person
    {
        public string name;
        public Gum.Rooms rooms;
        public uint count;
        private Guid guid;

        public Person(string name, uint count, Gum.Rooms room)
        {
            this.name = name;
            this.count = count;
            rooms = room;
            guid = Guid.NewGuid();
        }

        public override string ToString()
        {
            return $"name = {name}, Count = {count}, room = {rooms}, Guid = {guid}";
        }
    }
}

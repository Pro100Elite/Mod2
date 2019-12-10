using System;
using System.Collections.Generic;

namespace A_LvLMod2Less_1
{
    class Gum
    {
        static Rooms rooms;
        static Random rand = new Random();

        public static List<Person> persons = new List<Person>();

        public static void InToGum(string name, uint count)
        {
            
            Person person = new Person(name, count, SelectedRooms());
            persons.Add(person);
        }

        public static Rooms SelectedRooms()
        {
            int selectRooms = rand.Next(1, 4);
            switch (selectRooms)
            {
                case 1:
                    rooms = Rooms.footRoom;
                    break;
                case 2:
                    rooms = Rooms.chestRoom;
                    break;
                case 3:
                    rooms = Rooms.backRoom;
                    break;
            }
            return rooms;
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
                        persons[i].rooms = SelectedRooms();

                    }
                    else
                    {
                        persons.RemoveAt(i);
                    }
                }
            }
        }

        public enum Rooms
        {
            footRoom = 1,
            chestRoom,
            backRoom
        }
    }
}

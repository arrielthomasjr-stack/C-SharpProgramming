using System;

class PaintingDemo
{
    static void Main(string[] args)
    {
        Room[] rooms = new Room[8];
        rooms[0] = new Room(12, 12, 9);
        rooms[1] = new Room(14, 14, 9);
        rooms[2] = new Room(20, 15, 9);
        rooms[3] = new Room(20, 20, 9);
        rooms[4] = new Room(12, 10, 9);
        rooms[5] = new Room(12, 9, 9);
        rooms[6] = new Room(13, 8, 9);
        rooms[7] = new Room(27, 17, 9);
        Console.WriteLine("{0,-8} {1,-8} {2,-8} {3,-12} {4,-10}",
                        "Length", "Width", "Height", "Wall Area", "Gallons");
        Console.WriteLine(new string('-', 50));

        foreach (Room room in rooms)
        {
            Console.WriteLine("{0,-8} {1,-8} {2,-8} {3,-12} {4,-10}",
                room.Length, room.Width, room.Height,
                room.Area, room.NumGallons);
        }

    }
}

using System;

namespace JednaciMistnost
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("######  JEDNACÍ MÍSTNOST  ######");
            Console.WriteLine("Při příchodu účastníka stiskni šipku nahoru, po odchodu stiskni šipku dolů.");
            Console.WriteLine("Pro ukončení programu stiskni ESC.");
            Console.WriteLine();

            var meetingRoom = new MeetingRoom(0);
            Console.WriteLine(meetingRoom);

            ConsoleKeyInfo keyInfo;

            do
            {
                keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    meetingRoom.PeopleCount++;
                    Console.WriteLine(meetingRoom);
                }
                if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    meetingRoom.PeopleCount--;
                    Console.WriteLine(meetingRoom);
                }
            }
            while (keyInfo.Key != ConsoleKey.Escape);
        }
    }
}

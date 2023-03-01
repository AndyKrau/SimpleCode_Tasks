using System;
using System.Collections.Generic;

namespace lesson_SQL1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            using (var context = new MyDbContext())
            {
                var group = new Group()
                {
                    Name = "Rammstein",
                    Year = 1994
                };

                var group2 = new Group()
                {
                    Name = "Linkin Park",
                };

                context.Groups.Add(group);
                context.Groups.Add(group2);
                context.SaveChanges();

                var songs = new List<Song>
                {
                    new Song() {Name = "Sonne!", GroupId = group.Id },
                    new Song() {Name = "Mutter!", GroupId = group.Id },
                    new Song() {Name = "In the End!", GroupId = group2.Id},
                    new Song() {Name = "Numb!", GroupId = group2.Id}
                    
                };
                context.Songs.AddRange(songs);
                context.SaveChanges();

                foreach (var song in songs)
                {
                Console.WriteLine($"id: {song.Id}, name: {song.Name}, group: {song.Group.Name}");
                }


                Console.ReadKey();
            }
        }
    }
}

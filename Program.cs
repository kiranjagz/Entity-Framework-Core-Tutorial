using EF.Core.Tutorial.Database;
using EF.Core.Tutorial.Models;
using System;
using System.Threading.Tasks;

namespace EF.Core.Tutorial
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var random = new Random();

            while (true)
            {
                using (var context = new KeyGenContext())
                {
                    var randomizer = new Randomizer()
                    {
                        DateCreated = DateTime.Now,
                        KeyGen = random.Next(),
                        UniqueId = Guid.NewGuid()
                    };

                    await Task.Delay(TimeSpan.FromSeconds(3));

                    context.Randomizers.Add(randomizer);
                    context.SaveChanges();

                    Console.WriteLine($"Inserted value: {randomizer.UniqueId}");
                }
            }                
        }
    }
}

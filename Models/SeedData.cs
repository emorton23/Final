using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Final.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new FinalContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<FinalContext>>()))
            {
                if (context == null || context.Games == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                if (context.Users.Any())
                {
                    return;
                }

                context.Users.Add(
                    new User{
                        Username = "jdoe",
                        Games = new List<Game> 
                        {
                            new Game{
                                Title = "Dying Light 2",
                                Developer = "Techland",
                                Genre = "Action",
                                Price = 29.99
                            }
                        }
                    }
                );

                context.SaveChanges();

                context.Games.AddRange(
                    new Game {
                        Title = "Lethal Company",
                        Developer = "Zeekerss",
                        Genre = "Action",
                        Price = 11.99,
                    },
                    new Game {
                        Title = "Arizon Sunshine 2",
                        Developer = "Vertigo Games",
                        Genre = "VR",
                        Price = 34.99,
                    },
                    new Game {
                        Title = "Call of Duty Modern Warfare III",
                        Developer = "Activision",
                        Genre = "First Person Shooter",
                        Price = 69.99,
                    },
                    new Game {
                        Title = "Call of Duty Warzone",
                        Developer = "Activision",
                        Genre = "First Person Shooter",
                        Price = 1.99,
                    },
                    new Game {
                        Title = "CyberPunk 2077",
                        Developer = "CD Projekt Red",
                        Genre = "First Person Shooter",
                        Price = 59.99,
                    },
                    new Game {
                        Title = "ForeWarned",
                        Developer = "Dreambyte Games",
                        Genre = "Horror",
                        Price = 4.99,
                    },
                    new Game {
                        Title = "Phasmophobia",
                        Developer = "Kinetic Games",
                        Genre = "Horror",
                        Price = 19.99,
                    },
                    new Game {
                        Title = "Hometopia",
                        Developer = "Hometopia Inc.",
                        Genre = "Casual",
                        Price = 9.99,
                    },
                    new Game {
                        Title = "Cooking Simulator",
                        Developer = "Big Cheese Studio",
                        Genre = "Simulation",
                        Price = 19.99,
                    },
                    new Game {
                        Title = "Assassin's Creed Mirage",
                        Developer = "Ubisoft",
                        Genre = "Stealth",
                        Price = 59.99,
                    },
                    new Game {
                        Title = "PowerWash Simulator",
                        Developer = "FuturLab",
                        Genre = "Simulation",
                        Price = 9.99,
                    },
                    new Game {
                        Title = "Payday 3",
                        Developer = "Overkill Software",
                        Genre = "Stealth",
                        Price = 29.99,
                    },
                    new Game {
                        Title = "Minecraft",
                        Developer = "Mojang Studios",
                        Genre = "Casual",
                        Price = 19.99,
                    },
                    new Game {
                        Title = "Starfield",
                        Developer = "Bethesda",
                        Genre = "RPG",
                        Price = 59.99,
                        UserId = 1
                    },
                    new Game {
                        Title = "Demonologist",
                        Developer = "Dana",
                        Genre = "Horror",
                        Price = 9.99,
                        UserId = 1
                    },
                    new Game {
                        Title = "Satisfactory",
                        Developer = "Wube Software LTD.",
                        Genre = "Builder",
                        Price = 24.99,
                        UserId = 1
                    },
                    new Game {
                        Title = "factorio",
                        Developer = "Dana",
                        Genre = "builder",
                        Price = 29.99,
                        UserId = 1
                    },
                    new Game {
                        Title = "Cafe Owner Simulator",
                        Developer = "Second Reality",
                        Genre = "Simulation",
                        Price = 5.99,
                        UserId = 1
                    },
                    new Game {
                        Title = "Doom",
                        Developer = "Bethesda",
                        Genre = "First Person Shooter",
                        Price = 29.99,
                        UserId = 1
                    },
                    new Game {
                        Title = "Halo Infinite",
                        Developer = "343 Industries",
                        Genre = "First Person Shooter",
                        Price = 59.99,
                        UserId = 1
                    },
                    new Game {
                        Title = "Farming Simulator 2122",
                        Developer = "Giants Software",
                        Genre = "Simulation",
                        Price = 19.99,
                        UserId = 1
                    },
                    new Game {
                        Title = "Elder Scrolls V: Skyrim",
                        Developer = "Bethesda",
                        Genre = "RPG",
                        Price = 24.99,
                        UserId = 1
                    },
                    new Game {
                        Title = "Final Fantasy XV",
                        Developer = "Square Enix",
                        Genre = "RPG",
                        Price = 34.99,
                        UserId = 1
                    },
                    new Game {
                        Title = "BeatSaber",
                        Developer = "Beat Games",
                        Genre = "VR",
                        Price = 19.99,
                        UserId = 1
                    },
                    new Game {
                        Title = "Propagation VR",
                        Developer = "WanadevStudio",
                        Genre = "VR",
                        Price = 4.99,
                        UserId = 1
                    }

                );


                context.SaveChanges();
            }
        }
    }
}
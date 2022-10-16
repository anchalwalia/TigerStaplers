using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TigerStaplers.Data;
using System;
using System.Linq;

namespace TigerStaplers.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TigerStaplersContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<TigerStaplersContext>>()))
            {
                
                if (context.Stapler.Any())
                {
                    return;   // DB has been seeded
                }

                context.Stapler.AddRange(
                    new Stapler
                    {
                        
                        Name = "Kang",
                        Color = "Black",
                        Size = "Medium",
                        Material ="Plastic",
                        Price = 22.00M,
                        PinsIncluded = 50,
                        Rating = 1.5M

                    },

                     new Stapler
                     {

                         Name = "Maxo",
                         Color = "Blue",
                         Size = "Small",
                         Material = "Plastic",
                         Price = 15.78M,
                         PinsIncluded = 80,
                         Rating = 2.5M

                     },

                      new Stapler
                      {

                          Name = "Aion",
                          Color = "Pink",
                          Size = "Medium",
                          Material = "Plastic",
                          Price = 14.99M,
                          PinsIncluded = 30,
                          Rating = 1.0M

                      },

                       new Stapler
                       {

                           Name = "Unique",
                           Color = "White",
                           Size = "Small",
                           Material = "Plastic Iron",
                           Price = 12.77M,
                           PinsIncluded = 20,
                           Rating = 2.0M


                       },

                        new Stapler
                        {

                            Name = "Desk",
                            Color = "Silver",
                            Size = "Medium",
                            Material = "Plastic",
                            Price =40.92M,
                            PinsIncluded = 60,
                            Rating = 3.5M

                        },

                         new Stapler
                         {

                             Name = "koo",
                             Color = "Gold",
                             Size = "Medium",
                             Material = "Metal",
                             Price = 45.99M,
                             PinsIncluded = 54,
                             Rating = 1.0M


                         },

                          new Stapler
                          {

                              Name = "Fri",
                              Color = "Brown",
                              Size = "Small",
                              Material = "Plastic",
                              Price = 26.88M,
                              PinsIncluded = 70,
                              Rating = 4.5M


                          },

                           new Stapler
                           {

                               Name = "Fego",
                               Color = "Purple",
                               Size = "Medium",
                               Material = "Metal",
                               Price = 27.9M,
                               PinsIncluded = 80,
                               Rating = 1.5M

                           },

                            new Stapler
                            {

                                Name = "Clone",
                                Color = "Red",
                                Size = "Small",
                                Material = "Plastic",
                                Price = 30.45M,
                                PinsIncluded = 40,
                                Rating = 4.5M


                            },

                             new Stapler
                             {

                                 Name = "Plusey",
                                 Color = "Dark Blue",
                                 Size = "Medium",
                                 Material = "Metal",
                                 Price = 22.09M,
                                 PinsIncluded = 35,
                                 Rating = 3.5M


                             },

                              new Stapler
                              {

                                  Name = "Basic",
                                  Color = "Green",
                                  Size = "Medium",
                                  Material = "Plastic",
                                  Price = 60.0M,
                                  PinsIncluded = 100,
                                  Rating = 3.5M


                              }

                );
                context.SaveChanges();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using Domain.Concrete;
using Domain.Entityes;
using static System.DateTime;

namespace DressShopWebUI.Models
{
    /// <summary>
    /// Добавление "фейковых" записей в БД, для работы с ними
    /// </summary>
    public class DebugDb
    {

        public static void TestDb()
        {
            ShopContext db = new ShopContext();
            DbSet<Photo> product = db.Photo;
            if (!product.Any()) // проверка на наличие БД и записей.
                AddToDb();// Если БД пустая - заполнит "тестовыми значениями"
        }
        public static void AddToDb()
        {
            var db = new ShopContext();

            #region Отзывы

            db.Reviews.Add(new Reviews
            {
                ClientName = "Test",
                ClientFeedback = "Test Test Test Test Test Test Test Test Test Test Test Test ",
                Email = "galina@gmail.com",
                Rating = 1,
                DateFeedback = Now
            });
            Thread.Sleep(10);//ставлю задержку для хоть небольшой разницы во времени создания отзывов, для сортировки

            db.Reviews.Add(new Reviews
            {
                ClientName = "Test",
                ClientFeedback = "Test Test Test Test Test Test Test Test Test Test Test Test ",
                Email = "galina@gmail.com",
                Rating = 1,
                DateFeedback = Now
            });
            Thread.Sleep(10);

            db.Reviews.Add(new Reviews
            {
                ClientName = "Test",
                ClientFeedback = "Test Test Test Test Test Test Test Test Test Test Test Test ",
                Email = "galina@gmail.com",
                Rating = 1,
                DateFeedback = Now
            });
            Thread.Sleep(10);

            db.Reviews.Add(new Reviews
            {
                ClientName = "Test",
                ClientFeedback = "Test Test Test Test Test Test Test Test Test Test Test Test ",
                Email = "galina@gmail.com",
                Rating = 1,
                DateFeedback = Now
            });
            Thread.Sleep(10);

            db.Reviews.Add(new Reviews
            {
                ClientName = "Test",
                ClientFeedback = "Test Test Test Test Test Test Test Test Test Test Test Test ",
                Email = "galina@gmail.com",
                Rating = 2,
                DateFeedback = Now
            });
            Thread.Sleep(10);
            db.Reviews.Add(new Reviews
            {
                ClientName = "Test",
                ClientFeedback = "Test Test Test Test Test Test Test Test Test Test Test Test ",
                Email = "galina@gmail.com",
                Rating = 1,
                DateFeedback = Now
            });
            Thread.Sleep(10);
            db.Reviews.Add(new Reviews
            {
                ClientName = "Test",
                ClientFeedback = "Test Test Test Test Test Test Test Test Test Test Test Test ",
                Email = "galina@gmail.com",
                Rating = 1,
                DateFeedback = Now
            });
            Thread.Sleep(10);
            db.Reviews.Add(new Reviews
            {
                ClientName = "Test",
                ClientFeedback = "Test Test Test Test Test Test Test Test Test Test Test Test ",
                Email = "galina@gmail.com",
                Rating = 2,
                DateFeedback = Now
            });
            Thread.Sleep(10);



            #endregion

            #region Товар

            db.Product.Add(new Product
            {
                Name = "Test 1",
                Description = "Test Test Test Test Test Test Test Test  ",
                Photo = new List<Photo>
                    {
                        new Photo {PhotoUrl = "s1.jpg",Priority = true}
                    },
                Discount = 50,
                Category = "Selling",
                Price = 1000,
                SpecOffer = "Test Test Test Test Test Test Test Test  ",
                DateCreate = Now
            });
            Thread.Sleep(10);
            db.Product.Add(new Product
            {
                Name = "Test 2",
                Description = "Test Test Test Test Test Test Test Test  ",
                Photo = new List<Photo>
                    {
                        new Photo {PhotoUrl = "s2.jpg",Priority = true}
                    },
                Discount = 50,
                Category = "Selling",
                Price = 1000,
                SpecOffer = "Test Test Test Test Test Test Test Test  ",
                DateCreate = Now
            });
            Thread.Sleep(10);
            db.Product.Add(new Product
            {
                Name = "Test 3",
                Description = "Test Test Test Test Test Test Test Test  ",
                Photo = new List<Photo>
                    {
                        new Photo {PhotoUrl = "s3.jpg",Priority = true}
                    },
                Discount = 50,
                Category = "Selling",
                Price = 1000,
                SpecOffer = "Test Test Test Test Test Test Test Test  ",
                DateCreate = Now
            });
            Thread.Sleep(10);
            db.Product.Add(new Product
            {
                Name = "Test 4",
                Description = "Test Test Test Test Test Test Test Test  ",
                Photo = new List<Photo>
                    {
                        new Photo {PhotoUrl = "s4.jpg",Priority = true}
                    },
                Discount = 50,
                Category = "Selling",
                Price = 1000,
                SpecOffer = "Test Test Test Test Test Test Test Test  ",
                DateCreate = Now
            });
            Thread.Sleep(10);
            db.Product.Add(new Product
            {
                Name = "Test 5",
                Description = "Test Test Test Test Test Test Test Test  ",
                Photo = new List<Photo>
                    {
                        new Photo {PhotoUrl = "s5.jpg",Priority = true}
                    },
                Discount = 50,
                Category = "Selling",
                Price = 1000,
                SpecOffer = "Test Test Test Test Test Test Test Test  ",
                DateCreate = Now
            });
            Thread.Sleep(10);
            db.Product.Add(new Product
            {
                Name = "Test 6",
                Description = "Test Test Test Test Test Test Test Test  ",
                Photo = new List<Photo>
                    {
                        new Photo {PhotoUrl = "s6.jpg",Priority = true}
                    },
                Discount = 50,
                Category = "Selling",
                Price = 1000,
                SpecOffer = "Test Test Test Test Test Test Test Test  ",
                DateCreate = Now
            });
            Thread.Sleep(10);
            db.Product.Add(new Product
            {
                Name = "Test 7",
                Description = "Test Test Test Test Test Test Test Test  ",
                Photo = new List<Photo>
                    {
                        new Photo {PhotoUrl = "s7.jpg",Priority = true}
                    },
                Discount = 50,
                Category = "Selling",
                Price = 1000,
                SpecOffer = "Test Test Test Test Test Test Test Test  ",
                DateCreate = Now
            });
            Thread.Sleep(10);
            db.Product.Add(new Product
            {
                Name = "Test 8",
                Description = "Test Test Test Test Test Test Test Test  ",
                Photo = new List<Photo>
                    {
                        new Photo {PhotoUrl = "s8.jpg",Priority = true}
                    },
                Discount = 50,
                Category = "Selling",
                Price = 1000,
                SpecOffer = "Test Test Test Test Test Test Test Test  ",
                DateCreate = Now
            });
            Thread.Sleep(10);
            db.Product.Add(new Product
            {
                Name = "Test 9",
                Description = "Test Test Test Test Test Test Test Test  ",
                Photo = new List<Photo>
                    {
                        new Photo {PhotoUrl = "s9.jpg",Priority = true}
                    },
                Discount = 50,
                Category = "Selling",
                Price = 1000,
                SpecOffer = "Test Test Test Test Test Test Test Test  ",
                DateCreate = Now
            });
            Thread.Sleep(10);

           

            db.Product.Add(new Product
            {
                Name = "Test 1",
                Description = "Test Test Test Test Test Test Test Test",
                Photo = new List<Photo>
                    {
                        new Photo {PhotoUrl = "g1.jpg",Priority = true}
                    },
                Category = "Gallery",
                Price = 1200,
                DateCreate = Now
            }
           );
            Thread.Sleep(10);
            db.Product.Add(new Product
            {
                Name = "Test 2",
                Description = "Test Test Test Test Test Test Test Test",
                Photo = new List<Photo>
                    {
                        new Photo {PhotoUrl = "g2.jpg",Priority = true}
                    },
                Category = "Gallery",
                Price = 1200,
                DateCreate = Now
            }
          );
            Thread.Sleep(10);
            db.Product.Add(new Product
            {
                Name = "Test 3",
                Description = "Test Test Test Test Test Test Test Test",
                Photo = new List<Photo>
                    {
                        new Photo {PhotoUrl = "g3.jpg",Priority = true}
                    },
                Category = "Gallery",
                Price = 1200,
                DateCreate = Now
            }
          );
            Thread.Sleep(10);
            db.Product.Add(new Product
            {
                Name = "Test 4",
                Description = "Test Test Test Test Test Test Test Test",
                Photo = new List<Photo>
                    {
                        new Photo {PhotoUrl = "g4.jpg",Priority = true}
                    },
                Category = "Gallery",
                Price = 1200,
                DateCreate = Now
            }
          );
            Thread.Sleep(10);
            db.Product.Add(new Product
            {
                Name = "Test 5",
                Description = "Test Test Test Test Test Test Test Test",
                Photo = new List<Photo>
                    {
                        new Photo {PhotoUrl = "g5.jpg",Priority = true}
                    },
                Category = "Gallery",
                Price = 1200,
                DateCreate = Now
            }
          );
            Thread.Sleep(10);
            db.Product.Add(new Product
            {
                Name = "Test 6",
                Description = "Test Test Test Test Test Test Test Test",
                Photo = new List<Photo>
                    {
                        new Photo {PhotoUrl = "g6.jpg",Priority = true}
                    },
                Category = "Gallery",
                Price = 1200,
                DateCreate = Now
            }
          );
            Thread.Sleep(10);
            db.Product.Add(new Product
            {
                Name = "Test 7",
                Description = "Test Test Test Test Test Test Test Test",
                Photo = new List<Photo>
                    {
                        new Photo {PhotoUrl = "g7.jpg",Priority = true}
                    },
                Category = "Gallery",
                Price = 1200,
                DateCreate = Now
            }
          );
            Thread.Sleep(10);
            db.Product.Add(new Product
            {
                Name = "Test 8",
                Description = "Test Test Test Test Test Test Test Test",
                Photo = new List<Photo>
                    {
                        new Photo {PhotoUrl = "g8.jpg",Priority = true}
                    },
                Category = "Gallery",
                Price = 1200,
                DateCreate = Now
            }
          );
            Thread.Sleep(10);
            db.Product.Add(new Product
            {
                Name = "Test 9",
                Description = "Test Test Test Test Test Test Test Test",
                Photo = new List<Photo>
                    {
                        new Photo {PhotoUrl = "g9.jpg",Priority = true}
                    },
                Category = "Gallery",
                Price = 1200,
                DateCreate = Now
            }
          );
            Thread.Sleep(10);


            db.Product.Add(new Product
            {
                Name = "Test 1",
                Description = "Test Test Test Test Test Test Test Test",
                Photo = new List<Photo>
                    {
                        new Photo {PhotoUrl = "p1.jpg",Priority = true}
                    },
                Discount = 5,
                Category = "Partners",
                Price = 3300,
                SpecOffer = "Test Test Test Test Test Test Test Test",
                DateCreate = Now
            }
           );
            Thread.Sleep(10);

            db.Product.Add(new Product
            {
                Name = "Test 2",
                Description = "Test Test Test Test Test Test Test Test",
                Photo = new List<Photo>
                    {
                        new Photo {PhotoUrl = "p2.jpg",Priority = true}
                    },
                Discount = 5,
                Category = "Partners",
                Price = 3300,
                SpecOffer = "Test Test Test Test Test Test Test Test",
                DateCreate = Now
            }
           );
            Thread.Sleep(10);

            db.Product.Add(new Product
            {
                Name = "Test 3",
                Description = "Test Test Test Test Test Test Test Test",
                Photo = new List<Photo>
                    {
                        new Photo {PhotoUrl = "p3.jpg",Priority = true}
                    },
                Discount = 5,
                Category = "Partners",
                Price = 3300,
                SpecOffer = "Test Test Test Test Test Test Test Test",
                DateCreate = Now
            }
            );
            Thread.Sleep(10);

            db.Product.Add(new Product
            {
                Name = "Test 4",
                Description = "Test Test Test Test Test Test Test Test",
                Photo = new List<Photo>
                    {
                        new Photo {PhotoUrl = "p4.jpg",Priority = true}
                    },
                Discount = 5,
                Category = "Partners",
                Price = 3300,
                SpecOffer = "Test Test Test Test Test Test Test Test",
                DateCreate = Now
            }
            );
            Thread.Sleep(10);



            #endregion

            db.SaveChanges();
        }

    }
}
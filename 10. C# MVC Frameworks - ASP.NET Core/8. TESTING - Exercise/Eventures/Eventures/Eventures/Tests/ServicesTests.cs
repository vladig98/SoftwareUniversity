using AutoMapper;
using Eventures.Data;
using Eventures.DbModels;
using Eventures.DbModels.Enums;
using Eventures.Models;
using Eventures.Services;
using Eventures.Services.Contracts;
using Eventures.Utilities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System.Globalization;

namespace Eventures.Tests
{
    public class ServicesTests
    {
        private ICollection<User> Users;
        private ICollection<Order> Orders;
        private ICollection<EventuresEvent> EventuresEvents;
        private IPasswordHasher<User> PasswordHasher { get; set; }

        public ServicesTests()
        {
            Users = new List<User>();
            PasswordHasher = new PasswordHasher<User>();
        }

        [SetUp]
        public void SetUp()
        {
            Users = new List<User>();

            for (int i = 1; i <= 5; i++)
            {
                var role = i <= 2 ? Role.Admin : Role.User;

                var user = new User()
                {
                    Email = $"user{i}@gmail.com",
                    FirstName = $"UserFirtsName{i}",
                    Id = $"{i}",
                    LastName = $"UserLastName{i}",
                    Role = role,
                    UCN = $"123456789{i}",
                    UserName = $"user{i}"
                };

                user.PasswordHash = PasswordHasher.HashPassword(user, "123");

                Users.Add(user);
            }

            EventuresEvents = new List<EventuresEvent>();

            for (int i = 1; i <= 5; i++)
            {
                EventuresEvents.Add(new EventuresEvent()
                {
                    End = DateTime.UtcNow.AddDays(2),
                    Id = i.ToString(),
                    Name = $"Name{i}",
                    Place = $"Place{i}",
                    PricePerTicket = 19.99M * i,
                    Start = DateTime.UtcNow,
                    TotalTickets = 10 * i
                });
            }

            Orders = new List<Order>();

            for (int i = 1; i <= 5; i++)
            {
                Orders.Add(new Order()
                {
                    CustomerId = i.ToString(),
                    EventuresEventId = i.ToString(),
                    Id = i.ToString(),
                    OrderedOn = DateTime.UtcNow,
                    TicketsCount = 10 * i,
                    Customer = Users.ElementAt(i - 1),
                    EventuresEvent = EventuresEvents.ElementAt(i - 1)
                });
            }
        }

        private DbContextOptions<EventuresDbContext> GetOptions()
        {
            return new DbContextOptionsBuilder<EventuresDbContext>().UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString()).Options;
        }

        [Test]
        public void TestIfThereIsMoreThanOneAdminInTheDatabase()
        {
            using (var context = new EventuresDbContext(GetOptions()))
            {
                context.Users.AddRange(Users);
                context.SaveChanges();

                IUsersService userService = new UsersService(context, null, null);

                Assert.IsTrue(userService.HasMoreThanOneAdmin());
            }
        }

        [Test]
        public void TestIfThereIsMoreThanOneAdminInTheDatabaseWithAnEmptyList()
        {
            using (var context = new EventuresDbContext(GetOptions()))
            {
                IUsersService userService = new UsersService(context, null, null);

                Assert.IsTrue(!userService.HasMoreThanOneAdmin());
            }
        }

        [Test]
        public void TestIfThereIsMoreThanOneAdminInTheDatabaseWithOnlyOneAdminPresent()
        {
            using (var context = new EventuresDbContext(GetOptions()))
            {
                var oneAdmin = new List<User>(Users);

                oneAdmin.ForEach(x => x.Role = Role.User);
                oneAdmin.First().Role = Role.Admin;

                context.Users.AddRange(oneAdmin);
                context.SaveChanges();

                IUsersService userService = new UsersService(context, null, null);

                Assert.IsTrue(!userService.HasMoreThanOneAdmin());
            }
        }

        [Test]
        public void TestIfYouCanGetAllUsersFromTheDatabase()
        {
            using (var context = new EventuresDbContext(GetOptions()))
            {
                context.Users.AddRange(Users);
                context.SaveChanges();

                IUsersService userService = new UsersService(context, null, null);

                Assert.That(!Users.Except(userService.GetUsers().ToList()).Any());
            }
        }

        [Test]
        public void TestCreateUserInstanceMethodWithExternalLoginViewModel()
        {
            var user = new User()
            {
                Email = $"user@gmail.com",
                FirstName = $"UserFirtsName",
                Id = $"1",
                LastName = $"UserLastName",
                Role = Role.User,
                UCN = $"123456789"
            };

            var model = new ExternalLoginViewModel()
            {
                Email = $"user@gmail.com",
                FirstName = $"UserFirtsName",
                Id = $"1",
                LastName = $"UserLastName",
                Role = Role.User,
                UCN = $"123456789"
            };

            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();

            IUsersService usersService = new UsersService(null, null, mapper);

            var createdUser = usersService.CreateUserInstance(model);

            Assert.That(user.Equals(createdUser));
        }

        [Test]
        public void TestCreateUserInstanceMethodWithRegisterViewModel()
        {
            var user = new User()
            {
                Email = $"user@gmail.com",
                FirstName = $"UserFirtsName",
                Id = $"1",
                LastName = $"UserLastName",
                Role = Role.User,
                UCN = $"123456789"
            };

            var model = new RegisterViewModel()
            {
                Email = $"user@gmail.com",
                FirstName = $"UserFirtsName",
                Id = $"1",
                LastName = $"UserLastName",
                Role = Role.User,
                UCN = $"123456789"
            };

            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();

            IUsersService usersService = new UsersService(null, null, mapper);

            var createdUser = usersService.CreateUserInstance(model);

            Assert.That(user.Equals(createdUser));
        }


        //OrderService Test

        [Test]
        public void TestIfYouCanGetOrderById()
        {
            using (var context = new EventuresDbContext(GetOptions()))
            {
                context.Orders.AddRange(Orders);
                context.SaveChanges();

                IOrdersService ordersService = new OrdersService(context, null);

                Assert.That(context.Orders.First().Equals(ordersService.GetOrderById("1")));
            }
        }

        [Test]
        public void TestIfYouCanGetOrderByIdWithNonExistentId()
        {
            using (var context = new EventuresDbContext(GetOptions()))
            {
                context.Orders.AddRange(Orders);
                context.SaveChanges();

                IOrdersService ordersService = new OrdersService(context, null);

                Assert.That(ordersService.GetOrderById("10") == null);
            }
        }

        [Test]
        public void TestIfYouCanGetAllOrders()
        {
            using (var context = new EventuresDbContext(GetOptions()))
            {
                context.Orders.AddRange(Orders);
                context.SaveChanges();

                IOrdersService ordersService = new OrdersService(context, null);

                Assert.That(!Orders.Except(ordersService.GetAllOrders().ToList()).Any());
            }
        }

        [Test]
        public void TestIfYouCanGetOrdersForAParticularUser()
        {
            using (var context = new EventuresDbContext(GetOptions()))
            {
                context.Orders.AddRange(Orders);
                context.SaveChanges();

                IOrdersService ordersService = new OrdersService(context, null);

                Assert.That(ordersService.GetAllOrdersForUser("1").First().Equals(Orders.First()));
            }
        }

        [Test]
        public void TestIfYouCanGetOrdersForAParticularUserWithNonExistentId()
        {
            using (var context = new EventuresDbContext(GetOptions()))
            {
                context.Orders.AddRange(Orders);
                context.SaveChanges();

                IOrdersService ordersService = new OrdersService(context, null);

                Assert.That(!ordersService.GetAllOrdersForUser("10").Any());
            }
        }

        [Test]
        public void TestIfAnOrderExistsUsingId()
        {
            using (var context = new EventuresDbContext(GetOptions()))
            {
                context.Orders.AddRange(Orders);
                context.SaveChanges();

                IOrdersService ordersService = new OrdersService(context, null);

                Assert.That(ordersService.OrderExists("1"));
            }
        }

        [Test]
        public void TestIfAnOrderExistsUsingNonExistentId()
        {
            using (var context = new EventuresDbContext(GetOptions()))
            {
                context.Orders.AddRange(Orders);
                context.SaveChanges();

                IOrdersService ordersService = new OrdersService(context, null);

                Assert.That(!ordersService.OrderExists("10"));
            }
        }

        [Test]
        public void TestIfYouCanAddOrders()
        {
            OrderViewModel model = new OrderViewModel()
            {
                Id = "1",
                OrderedOn = DateTime.ParseExact("11-11-2023 00:00:00", "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                Tickets = 10
            };

            var order = new Order()
            {
                Id = "1",
                CustomerId = "1",
                EventuresEventId = "1",
                OrderedOn = DateTime.ParseExact("11-11-2023 00:00:00", "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                TicketsCount = 10
            };

            using (var context = new EventuresDbContext(GetOptions()))
            {
                var mapperConfig = new MapperConfiguration(mc =>
                {
                    mc.AddProfile(new AutoMapperProfile());
                });

                context.EventuresEvents.AddRange(EventuresEvents);
                context.SaveChanges();

                IMapper mapper = mapperConfig.CreateMapper();

                IOrdersService ordersService = new OrdersService(context, mapper);

                Assert.That(ordersService.AddOrder(model, "1", "1").Equals(order));
            }
        }

        //EventService Tests

        [Test]
        public void TestIfYouCanGetEventById()
        {
            using (var context = new EventuresDbContext(GetOptions()))
            {
                context.EventuresEvents.AddRange(EventuresEvents);
                context.SaveChanges();

                IEventsService eventsService = new EventsService(context, null);

                Assert.That(eventsService.GetEventById("1").Equals(EventuresEvents.First()));
            }
        }

        [Test]
        public void TestIfYouCanGetEventByNonExistentId()
        {
            using (var context = new EventuresDbContext(GetOptions()))
            {
                context.EventuresEvents.AddRange(EventuresEvents);
                context.SaveChanges();

                IEventsService eventsService = new EventsService(context, null);

                Assert.That(eventsService.GetEventById("10") == null);
            }
        }

        [Test]
        public void TestIfYouCanGetEventByEmptyId()
        {
            using (var context = new EventuresDbContext(GetOptions()))
            {
                context.EventuresEvents.AddRange(EventuresEvents);
                context.SaveChanges();

                IEventsService eventsService = new EventsService(context, null);

                Assert.That(eventsService.GetEventById("") == null);
            }
        }

        [Test]
        public void TestIfYouCanGetEventByUsingNullAsId()
        {
            using (var context = new EventuresDbContext(GetOptions()))
            {
                context.EventuresEvents.AddRange(EventuresEvents);
                context.SaveChanges();

                IEventsService eventsService = new EventsService(context, null);

                Assert.That(eventsService.GetEventById(null) == null);
            }
        }

        [Test]
        public void TestIfYouCanGetAllEvents()
        {
            using (var context = new EventuresDbContext(GetOptions()))
            {
                context.EventuresEvents.AddRange(EventuresEvents);
                context.SaveChanges();

                IEventsService eventsService = new EventsService(context, null);

                Assert.That(!EventuresEvents.Except(eventsService.GetAllEvents().ToList()).Any());
            }
        }

        [Test]
        public void TestIfYouCanGetAllBuyableEvents()
        {
            var buyableEvents = new List<EventuresEvent>(EventuresEvents);

            buyableEvents.Last().TotalTickets = 0;

            using (var context = new EventuresDbContext(GetOptions()))
            {
                context.EventuresEvents.AddRange(buyableEvents);
                context.SaveChanges();

                IEventsService eventsService = new EventsService(context, null);

                Assert.That(buyableEvents.Except(eventsService.GetAllBuyableEvents().ToList()).Count() == 1);
            }
        }

        [Test]
        public void TestIfEventExistsUsingId()
        {
            using (var context = new EventuresDbContext(GetOptions()))
            {
                context.EventuresEvents.AddRange(EventuresEvents);
                context.SaveChanges();

                IEventsService eventsService = new EventsService(context, null);

                Assert.That(eventsService.EventExists("1"));
            }
        }

        [Test]
        public void TestIfEventExistsUsingNonExistentId()
        {
            using (var context = new EventuresDbContext(GetOptions()))
            {
                context.EventuresEvents.AddRange(EventuresEvents);
                context.SaveChanges();

                IEventsService eventsService = new EventsService(context, null);

                Assert.That(!eventsService.EventExists("10"));
            }
        }

        [Test]
        public void TestIfEventExistsUsingNullAsId()
        {
            using (var context = new EventuresDbContext(GetOptions()))
            {
                context.EventuresEvents.AddRange(EventuresEvents);
                context.SaveChanges();

                IEventsService eventsService = new EventsService(context, null);

                Assert.That(!eventsService.EventExists(null));
            }
        }

        [Test]
        public void TestIfEventExistsUsingEmptyStringAsId()
        {
            using (var context = new EventuresDbContext(GetOptions()))
            {
                context.EventuresEvents.AddRange(EventuresEvents);
                context.SaveChanges();

                IEventsService eventsService = new EventsService(context, null);

                Assert.That(!eventsService.EventExists(""));
            }
        }

        [Test]
        public void TestIfYouCanAddEvent()
        {
            EventViewModel model = new EventViewModel()
            {
                Id = "1",
                End = "12-Nov-2023 00:00",
                Name = "Name1",
                Place = "Place1",
                PricePerTicket = 19.99M,
                Start = "11-Nov-2023 00:00",
                TotalTickets = 10
            };

            EventuresEvent eventuresEvent = new EventuresEvent()
            {
                Id = "1",
                End = DateTime.ParseExact("12-Nov-2023 00:00", "dd-MMM-yyyy HH:mm", CultureInfo.InvariantCulture),
                Name = "Name1",
                Place = "Place1",
                PricePerTicket = 19.99M,
                Start = DateTime.ParseExact("11-Nov-2023 00:00", "dd-MMM-yyyy HH:mm", CultureInfo.InvariantCulture),
                TotalTickets = 10
            };

            using (var context = new EventuresDbContext(GetOptions()))
            {
                var mapperConfig = new MapperConfiguration(mc =>
                {
                    mc.AddProfile(new AutoMapperProfile());
                });

                IMapper mapper = mapperConfig.CreateMapper();

                IEventsService eventsService = new EventsService(context, mapper);

                Assert.That(eventsService.AddEvent(model).Equals(eventuresEvent));
            }
        }
    }
}

namespace myWebApi.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using myWebApi.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<myWebApi.Data.myWebApiContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(myWebApi.Data.myWebApiContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.Employees.AddOrUpdate(x => x.Id,
                new Employee()
                {
                    Id = 1,
                    FirstName = "Fletcher",
                    LastName = "Trueblood",
                    Age = 33,
                    SocialSecurityNumber = 111223333,
                    HireDate = DateTime.Now,
                    Terminated = false
                },
                 new Employee()
                 {
                     Id = 2,
                     FirstName = "Fred",
                     LastName = "Flinstone",
                     Age = 99,
                     SocialSecurityNumber = 111223333,
                     HireDate = DateTime.Now,
                     Terminated = false
                 },
                  new Employee()
                  {
                      Id = 3,
                      FirstName = "Billy",
                      LastName = "Kid",
                      Age = 52,
                      SocialSecurityNumber = 111223333,
                      HireDate = DateTime.Now,
                      Terminated = false
                  },
                   new Employee()
                   {
                       Id = 4,
                       FirstName = "Corey",
                       LastName = "Taylor",
                       Age = 65,
                       SocialSecurityNumber = 111223333,
                       HireDate = DateTime.Now,
                       Terminated = false
                   },
                    new Employee()
                    {
                        Id = 5,
                        FirstName = "Axel",
                        LastName = "Rose",
                        Age = 22,
                        SocialSecurityNumber = 111223333,
                        HireDate = DateTime.Now,
                        Terminated = false
                    },
                     new Employee()
                     {
                         Id = 6,
                         FirstName = "Austin",
                         LastName = "Powers",
                         Age = 33,
                         SocialSecurityNumber = 111223333,
                         HireDate = DateTime.Now,
                         Terminated = false
                     },
                      new Employee()
                      {
                          Id = 7,
                          FirstName = "Tiny",
                          LastName = "Tim",
                          Age = 42,
                          SocialSecurityNumber = 111223333,
                          HireDate = DateTime.Now,
                          Terminated = false
                      }
                );
        }
    }
}

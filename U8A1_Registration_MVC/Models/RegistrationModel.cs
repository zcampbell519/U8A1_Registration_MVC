namespace U8A1_Registration_MVC.Models
{
    using System;
    using System.Data.Entity;
    using System.Collections.Generic;
    using System.Linq;
    using Courses;
    using System.Web.Mvc;

    public class RegistrationModel : DbContext
    {
        // Your context has been configured to use a 'RegistrationModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'U8A1_Registration_MVC.Models.RegistrationModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'RegistrationModel' 
        // connection string in the application configuration file.
        public RegistrationModel()
            : base("name=RegistrationModelConnString")
        {
        }

        public DbSet<Course> Courses {get;set;}
        public DbSet<RegisteredCourse> RegisteredCourses { get; set; }


        public List<SelectListItem> CourseListItems { get; set; }
        public string SelectedCourseNumber { get; set; }
        public string UserIdText { get; set; }
        public string UserMessage { get; set; }
        public int TotalCredits { get; set; }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}
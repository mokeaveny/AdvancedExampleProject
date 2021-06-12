﻿using System.Collections.Generic;

namespace AdvancedExampleProject.Models
{
    public class Person
    {
        public long PersonId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public long DepartmentId { get; set; }
        public long LocationId { get; set; }

        public Department Department { get; set; }
        public Location Location { get; set; }
    }
}

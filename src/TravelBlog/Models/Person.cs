﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelBlog.Models
{
    [Table("People")]
    public class Person
    {

        [Key]
        public int PeopleId { get; set; }
        public string Name { get; set; }
        public int ExperienceId { get; set; }
        public virtual Experience Experience { get; set; }



        public override bool Equals(System.Object otherPerson)
        {
            if (!(otherPerson is Person))
            {
                return false;
            }
            else
            {
                Person newPerson = (Person)otherPerson;
                return this.PeopleId.Equals(newPerson.PeopleId);
            }
        }

        public override int GetHashCode()
        {
            return this.PeopleId.GetHashCode();
        }
    }
}

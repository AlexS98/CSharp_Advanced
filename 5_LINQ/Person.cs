﻿using System;

namespace IteaLinq
{
    public enum Gender
    {
        Man,
        Woman,
        etc
    }

    public class Person
    {
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
<<<<<<< HEAD
=======
        public string City { get; set; }
        public string Street { get; set; }
        public string Appartment { get; set; }
>>>>>>> b98c0122454e40247b55ad6a0cd6f2bf3579d819

        public Person(string name, int age)
        {
            Guid = Guid.NewGuid();
            Name = name;
            Age = age;
        }

        public Person(string name, Gender gender, int age, string email)
            : this(name, age)
        {
            Gender = gender;
            Email = email;
        }

        public override string ToString()
        {
            return $"{Guid.ToString().Substring(0, 5)}_{Name}: {Gender}, {Age}, {Email}";
        }
<<<<<<< HEAD

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
=======
>>>>>>> b98c0122454e40247b55ad6a0cd6f2bf3579d819
    }
}

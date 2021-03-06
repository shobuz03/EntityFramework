﻿using System;
using System.Linq;
using EF.BaiscRelationship.App.Data;
using EF.BaiscRelationship.App.Model;

namespace EF.BaiscRelationship.App
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateStudent3();
            Console.WriteLine("Student Creatred");

            StudentContext c = new StudentContext();
            var result = from r in c.Students select r;
            foreach (var r in result)
            {
                Console.WriteLine(r.Name);
            }

            Console.ReadKey(true);
        }
        static void CreateStudent()
        {
            Student s = new Student
            {
                Id = 1,
                Age = 12,
                Name = "Foo"
            };
            using (StudentContext c = new StudentContext())
            {
                c.Students.Add(s);
                c.SaveChanges();
            }
           
        }
        static void CreateStudent1()
        {
            StudentAccount sa = new StudentAccount
            {
                Amount = 300,
                Name = "Sports Account"
            };
            Student s = new Student
            {
                Age = 12,
                Name = "Foo",
                StudentAccount = sa

            };
           
            using (StudentContext c = new StudentContext())
            {
                c.Students.Add(s);
                //c.StudentAccounts.Add(sa);
                c.SaveChanges();
            }
            
           
        }
        static void CreateStudent2()
        {
            Student s = new Student
            {
                Age = 12,
                Name = "Foo"
            };

            StudentAddress sa1 = new StudentAddress { Address = "Delhi", Id = 1 };
            StudentAddress sa2 = new StudentAddress { Address = "Bangalore", Id = 2 };
            s.StudentAddresses.Add(sa1);
            s.StudentAddresses.Add(sa2);

            using (StudentContext c = new StudentContext())
            {
                c.Students.Add(s);
                c.SaveChanges();
            }
        }

        static void CreateStudent3()
        {
            Student s = new Student
            {
                Age = 12,
                Name = "Foo"
            };

            Subject s1 = new Subject {  Name = "Phy" };
            Subject s2 = new Subject {  Name = "Maths" };
            s.Subjects.Add(s1);
            s.Subjects.Add(s2);

            using (StudentContext c = new StudentContext())
            {
                c.Students.Add(s);
                c.SaveChanges();
            }
        }

    }
}

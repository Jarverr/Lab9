using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string FullName => Name + LastName;
        public DateTime Entlisting { get; set; }
        public override string ToString() //nadpisany tostring 
        {
            return FullName;
        }
    }
    public class StudentView
    {
        public StudentList List { get; set; }
        public StudentView()
        {
            List = new StudentList()
            {
                students = new ObservableCollection<Student>()
                {
                    new Student
                    {
                        Id = 1,
                        Name = "Mark",
                        LastName = "Kowalski",
                        Entlisting = new DateTime(2000, 1, 1)
                    },
                    new Student
                    {
                        Id = 1,
                        Name = "John",
                        LastName = "Kwiatkowski",
                        Entlisting = new DateTime(2002, 1, 2)
                    },
                    new Student
                    {
                        Id = 1,
                        Name = "Peter",
                        LastName = "Nowak",
                        Entlisting = new DateTime(2003, 3, 3)
                    }
                }
            };
        }
    }
    public class StudentList
    {

        public ObservableCollection<Student> students { get; set; } = new ObservableCollection<Student>(); //typ wbudowany podobony do Listy
    }
}

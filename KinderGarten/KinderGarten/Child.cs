using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinderGarten
{
    public class Child
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public string ResponsiblePerson;
        public string Age;
        public string Address;
    }

    public static class Children
    {
        static List<Child> children = new List<Child>()
        {
            new Child()
            {
                Id = 1,
                FirstName = "Javohir",
                LastName = "Bekmurodov",
                ResponsiblePerson = "Bekzod - otasi",
                Age = "3",
                Address = "Bodomzor ko'chasi, 44-uy",
            },

            new Child()
            {
                Id = 2,
                FirstName = "Zulfiya",
                LastName = "Aliyeva",
                ResponsiblePerson = "Munira - onasi",
                Age = "4",
                Address = "Obodlik ko'chasi, 13-uy",
            },

            new Child()
            {
                Id = 3,
                FirstName = "Asilbek",
                LastName = "Kamolov",
                ResponsiblePerson = "Tolib - bobosi",
                Age = "1",
                Address = "Obodlik ko'chasi, 112-uy",
            },
        };

        public static List<Child> GetAll()
        {
            return children;
        }

        public static Child GetById(int Id)
        {
            return children.FirstOrDefault(child => child.Id == Id);
        }

        public static Child Create(Child child)
        {
            int Id = children.Last().Id + 1;
            child.Id = Id;
            children.Add(child);
            return child;
        }

        public static void Delete(int Id)
        {
            children.Remove(GetById(Id));
        }

        public static Child Update(Child _child)
        {
            Child child = GetById(_child.Id);
            child = _child;
            return child;
        }
    }
}

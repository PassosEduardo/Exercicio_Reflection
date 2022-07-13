using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Reflection
{
    public class Program
    {
        public static void DisplayPublicProperties()
        {
            Student newStudent = Activator.CreateInstance<Student>();
            PropertyInfo[] propertyInfos = newStudent.GetType().GetProperties();
            Console.WriteLine($"Nesta classe, temos {propertyInfos.Length} propriedades públicas \n");
            foreach(var property in propertyInfos)
            {
                Console.WriteLine($"{property.Name}");
            }
        }


        public static void CreateInstance()
        {
            Student newStudent = Activator.CreateInstance<Student>();
            PropertyInfo[] propertyInfos = newStudent.GetType().GetProperties();
            foreach (var property in propertyInfos)
            {
                if (property.Name == "Name")
                {
                    property.SetValue(newStudent, "Eduardo");
                    
                }
                if (property.Name == "University")
                {
                    property.SetValue(newStudent, "Universidade Federal de São Carlos");
                    
                }
                if (property.Name == "RollNumber")
                {
                    property.SetValue(newStudent, 759006);
                   
                }
            }

            newStudent.DisplayInfo();

        }

        static void Main()
        {
            CreateInstance();

            DisplayPublicProperties();
        }


    }
}

using System;

namespace Aufgabe5
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        public class Person
        {
            string name;
            int age;
        }

        public class Teilnehmer : Person
        {
            int registrationNumber;
            string[] cours; 
        

            }
        
        public class Dozent : Person
        {
            int room;
            DateTime office_hours;
            string[] cours;
            public void listCourse(){
                 
            Console.WriteLine(Course.title);
            }
            public List <Member> listMember ();
                 
            }
        }

        public class Course
        {
            string title;
            DateTime course_hours;
            int room;
            string [] dozent;
            string [] members;
            
           
        
     public void Infotext()
        {
            Console.WriteLine("Der Kurs " + title + " findet am " + course_hours + " in Raum " + room + " statt.");
}
    
        }
    
}

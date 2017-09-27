using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfStudenthandlerV2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public void AddStudent(string name, int id)
        {
            Student.StudentListe.Add(new Student() { Navn = name, Id = id });
        }

        public void EditStudent(string name, int id)
        {
            throw new NotImplementedException();
        }

        public Student FindStudent(int id)
        {
            return Student.StudentListe.Find(x => x.Id == id);
        }

        //Ikke sikker på at det er rigtigt...
        public List<Student> GetAllStudents()
        {
            return Student.StudentListe;
        }

        public void RemoveStudent(int id)
        {
            Student.StudentListe.Remove(new Student() { Id = id });
        }





        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

    }
}

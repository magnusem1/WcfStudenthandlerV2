using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfStudenthandlerV2
{
    [DataContract]
    public class Student
    {
        [DataMember]
        public string Navn { get; set; }
        [DataMember]
        public int Id { get; set; }
        [DataMember]

        public static List<Student> StudentListe { get; set; }


        static Student()
        {
            StudentListe = new List<Student>();
        }
    }
}
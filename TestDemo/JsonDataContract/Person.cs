using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization;

namespace JsonDataContract
{

    [DataContract]
    public class Person
    {
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public int age { get; set; }
    }
    [DataContract]
    public class StudentClasses
    {
        [DataMember]
        public string className;
        [DataMember]
        public string classTeacher;
    }

    [DataContract]
    public class Student : Person
    {
        [DataMember]
        public int score { get; set; }
        [DataMember]
        public List<StudentClasses> stuClasses { get; set; }
           
    }
}

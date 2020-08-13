using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfo_system.StudentEntities
{
    #region
    public class Student
    //2.1. This is to make its methods and variables accessible to all classes even if they are not in the same folder
    {
        //2.2.2. I'm giving them private access modifiers so they cannot be easily accessible to outside class, so their values aren't changed
        private int studentID;
        private char gender;
        private string populationGroup;
        private string homeLanguage;
        private char saCitizenshipStat;
        private string foreignCountry;
    }
}

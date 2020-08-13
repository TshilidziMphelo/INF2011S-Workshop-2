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

        //2.4 Property Methods
        public int StudentID
        {
            get
            {
                return studentID;
            }
            set
            {
                studentID = value;
            }
        }
        public char Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }
        public string PopulationGroup
        {
            get
            {
                return populationGroup;
            }
            set
            {
                populationGroup = value;
            }
        }
        public string HomeLanguage
        {
            get
            {
                return homeLanguage;
            }
            set
            {
                homeLanguage = value;
            }
        }
        public char SACitizenship
        {
            get
            {
                return saCitizenshipStat;
            }
            set
            {
                saCitizenshipStat = value;
            }
        }
        public string ForeignCountry
        {
            get
            {
                return foreignCountry;
            }
            set
            {
                foreignCountry = value;
            }
        }q
    }
}

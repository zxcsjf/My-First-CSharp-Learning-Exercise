using System;

namespace HelloWorldCSharp
{
    public class Person
    {
        private DateTime _birthdate;
        public DateTime Birthdate
        {
            get { return _birthdate; }
            set { _birthdate = value; }
        }

       /* public DateTime Birthday { get; set; }
        public int Age
        {
            get 
            { 
                var timeSpan = DateTime.Today - Birthday;
                var years = timeSpan.Days / 365;
                return years;
            }
        }*/

       /* private DateTime _birthday;
        public void SetBirthday(DateTime birthday)
        {
            _birthday = birthday;
        }
        public DateTime GetBirthday()
        {
            return _birthday;
        }*/


        
    }
}


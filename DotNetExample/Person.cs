using System;

namespace DotNetExample
{
    class Person
    {
        private DateTime _birthdate;
        public void SetBirthDate(DateTime birthdate)
        {
            this._birthdate = birthdate;
        }
        public DateTime GetBirthDate()
        {
            return _birthdate;
        }

    }
}

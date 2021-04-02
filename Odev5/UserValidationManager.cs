using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1988 && gamer.FirstName == "Yucel" && gamer.LastName == "Taskiran" && gamer.IdentityNumber == 123456)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

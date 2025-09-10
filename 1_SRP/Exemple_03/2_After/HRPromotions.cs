
using System;

namespace Exemple_03.After
{
    public class HRPromotions
    {
        public bool IsPromotionIsDueThisYear(Employee employee)
        {
            int yearsWorked = DateTime.Now.Year - employee.GetDateOfJoining().Year;
            return yearsWorked > 0 && yearsWorked % 5 == 0;
        }
    }
}
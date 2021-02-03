using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FineSpiritsStore.Models
{
    public class MinimunAgeAttribute : ValidationAttribute
    {
        int minAge;

        public MinimunAgeAttribute(int minimumAge)
        {
            minAge = minimumAge;
        }

        public override bool IsValid(object value)
        {
            DateTime date;
            if (DateTime.TryParse(value.ToString(), out date))
            {
                return date.AddYears(minAge) < DateTime.Now;
             }

            return false;
        }

    }
}

using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] isKurallari)
        {
            foreach (var isKurali in isKurallari)
            {
                if (!isKurali.Success)
                {
                    return isKurali;
                }
            }
            return null;
        }
    }
}

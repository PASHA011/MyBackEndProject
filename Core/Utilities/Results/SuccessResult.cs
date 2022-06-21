using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult:Result
    {
        public SuccessResult(String massage):base(true,massage)
        {

        }
        public SuccessResult() : base(true)
        {

        }
    }
}

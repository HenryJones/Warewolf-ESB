﻿using System;
using Dev2.Common.ExtMethods;

namespace Dev2.Data.Decisions.Operations
{
    /// <summary>
    /// Is Not Binary Decision
    /// </summary>
    public class IsNotBinary : IDecisionOperation
    {

        public bool Invoke(string[] cols)
        {
            if (!string.IsNullOrEmpty(cols[0]))
            {
                return !(cols[0].IsBinary());
            }

            return false;
        }

        public Enum HandlesType()
        {
            return enDecisionType.IsNotBinary;
        }
    }
}

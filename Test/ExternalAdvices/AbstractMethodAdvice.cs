﻿#region Mr. Advice
// Mr. Advice
// A simple post build weaving package
// http://mradvice.arxone.com/
// Released under MIT license http://opensource.org/licenses/mit-license.php
#endregion

namespace ExternalAdvices
{
    using System;
    using ArxOne.MrAdvice.Advice;

    [AttributeUsage(AttributeTargets.Method)]
    public abstract class AbstractMethodAdvice : Attribute, IMethodAdvice
    {
        public abstract void Advise(MethodAdviceContext context);
    }
}

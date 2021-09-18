﻿using System;
using System.Linq.Expressions;

namespace Entities.Specifications
{
    public abstract class Specification<T>
    {
        public abstract Expression<Func<T, bool>> Expression { get; }
        public bool IsSatisfiedBy(T entity) 
        {
            var ExpressionDelegate = Expression.Compile();
            return ExpressionDelegate(entity);
        }        
    }
}

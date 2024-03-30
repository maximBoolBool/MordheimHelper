using System.Linq.Expressions;

namespace SharedEntities.Helpers;

public static class FilterHelpers
{
    public static IQueryable<T> Eq<T, TValue>(
        IQueryable<T> query,
        Expression<Func<T,TValue>> expression,
        TValue? filter)
    {
        if (filter == null)
            return query;
        
        var parameter = expression.Parameters[0];
        var memberAccess = Expression
            .MakeMemberAccess(parameter, (expression.Body as MemberExpression)?.Member);
        var filterExpression = Expression.Equal(memberAccess, Expression.Constant(filter));
        var lambda = Expression.Lambda<Func<T, bool>>(filterExpression, parameter);

        return query.Where(lambda);
    }

    public static IQueryable<T> Sm<T, TValue>(
        IQueryable<T> query,
        Expression<Func<T,TValue>> expression,
        TValue? filter)
    {
        if (filter == null)
            return query;
        
        var parameter = expression.Parameters[0];
        var memberAccess = Expression
            .MakeMemberAccess(parameter, (expression.Body as MemberExpression)?.Member);
        var filterExpression = Expression.LessThan(memberAccess, Expression.Constant(filter));
        var lambda = Expression.Lambda<Func<T, bool>>(filterExpression, parameter);

        return query.Where(lambda);
    }

    public static IQueryable<T> Gr<T, TValue>(
        IQueryable<T> query,
        Expression<Func<T,TValue>> expression,
        TValue? filter)
    {
        if (filter == null)
            return query;
        
        var parameter = expression.Parameters[0];
        var memberAccess = Expression
            .MakeMemberAccess(parameter, (expression.Body as MemberExpression)?.Member);
        var filterExpression = Expression.GreaterThan(memberAccess, Expression.Constant(filter));
        var lambda = Expression.Lambda<Func<T, bool>>(filterExpression, parameter);

        return query.Where(lambda);
    }

    public static IQueryable<T> GrOrEq<T, TValue>(
        IQueryable<T> query,
        Expression<Func<T, TValue>> expression,
        TValue filter)
    {
        if (filter == null)
            return query;
        
        var parameter = expression.Parameters[0];
        var memberAccess = Expression
            .MakeMemberAccess(parameter, (expression.Body as MemberExpression)?.Member);
        var filterExpression = Expression.GreaterThanOrEqual(memberAccess, Expression.Constant(filter));
        var lambda = Expression.Lambda<Func<T, bool>>(filterExpression, parameter);

        return query.Where(lambda);
    }
    
    public static IQueryable<T> SmOrEq<T, TValue>(
        IQueryable<T> query,
        Expression<Func<T,
        TValue>> expression,
        TValue filter)
    {
        if (filter == null)
            return query;
        
        var parameter = expression.Parameters[0];
        var memberAccess = Expression
            .MakeMemberAccess(parameter, (expression.Body as MemberExpression)?.Member);
        var filterExpression = Expression.LessThanOrEqual(memberAccess, Expression.Constant(filter));
        var lambda = Expression.Lambda<Func<T, bool>>(filterExpression, parameter);

        return query.Where(lambda);
    }
}
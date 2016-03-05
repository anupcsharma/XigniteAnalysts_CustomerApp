using AutoMapper;

namespace XigniteAnalysts.Infrastructure
{
	public static class AutoMapperExtensions
	{
		public static IMappingExpression<TSource, TDest> IgnoreAllUnmapped<TSource, TDest>(this IMappingExpression<TSource, TDest> expression)
		{
			expression.ForAllMembers(opt => opt.Ignore());
			return expression;
		}
	}
}

namespace Shop.RouteConstraints
{
    public enum SortingType
    {
        AscendingPrice,
        DescendingPrice,
        DescendingDiscount,
        Default
    }

    public class SortingTypeConstraint : IRouteConstraint
    {
        public bool Match(HttpContext? httpContext, IRouter? route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            var candidate = values[routeKey]?.ToString();
            return Enum.TryParse(candidate, out SortingType _);
        }
    }
}
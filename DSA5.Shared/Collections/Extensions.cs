namespace DSA5.Shared.Collections;

public static class Extensions
{
    public static bool None<T>(this IEnumerable<T> items)
    {
        return !items.Any();
    }

    public static bool None<T>(this IEnumerable<T> items, Func<T, bool> predicate)
    {
        return !items.Any(predicate);
    }
}
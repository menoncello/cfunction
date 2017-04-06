// ReSharper disable once CheckNamespace
namespace System
{
  public static class FunctionalExtensions
  {
    /// <summary>
    /// Execute the same value after executing the action
    /// </summary>
    /// <param name="this">Value to execute the action</param>
    /// <param name="action">Action that will be execute</param>
    /// <typeparam name="TValue">Any type</typeparam>
    /// <returns>The same value that @this</returns>
    public static TValue Tee<TValue>(this TValue @this, Action<TValue> action)
    {
      action(@this);
      return @this;
    }

    /// <summary>
    /// Maps a object to other object, by a function
    /// </summary>
    /// <param name="this">Object to map from</param>
    /// <param name="fn">Function that map the object</param>
    /// <typeparam name="TSource">Source type</typeparam>
    /// <typeparam name="TResult">Result from map function convert</typeparam>
    /// <returns>Converted object</returns>
    public static TResult Map<TSource, TResult>(
      this TSource @this,
      Func<TSource, TResult> fn) =>
      fn(@this);
  }
}
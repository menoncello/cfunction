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
    /// <typeparam name="TValue">Type inherited from the chain</typeparam>
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
    /// <typeparam name="TSource">Type inherited from the chain</typeparam>
    /// <typeparam name="TResult">Result from map function convert</typeparam>
    /// <returns>Converted object</returns>
    public static TResult Map<TSource, TResult>(
      this TSource @this,
      Func<TSource, TResult> fn) =>
      fn(@this);

    /// <summary>
    /// Execute the method when the condition is true
    /// </summary>
    /// <param name="this">Value part of the chain</param>
    /// <param name="condition">Function to verify if method will be executed</param>
    /// <param name="fn">Method to be executed</param>
    /// <typeparam name="TValue">Type inherited from the chain</typeparam>
    /// <returns>Returns the if condition result is false or processed value, if true</returns>
    public static TValue When<TValue>(this TValue @this, Func<TValue, bool> condition, Func<TValue, TValue> fn) =>
      condition(@this)
        ? fn(@this)
        : @this;

    /// <summary>
    /// Execute the method when the condition is true
    /// </summary>
    /// <param name="this">Value part of the chain</param>
    /// <param name="condition">Function to verify if method will be executed</param>
    /// <param name="fn">Method to be executed</param>
    /// <typeparam name="TValue">Type inherited from the chain</typeparam>
    /// <returns>Returns the if condition result is false or processed value, if true</returns>
    public static TValue When<TValue>(this TValue @this, bool condition, Func<TValue, TValue> fn) =>
      condition
        ? fn(@this)
        : @this;
  }
}
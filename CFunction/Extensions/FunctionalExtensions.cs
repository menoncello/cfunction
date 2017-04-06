// ReSharper disable once CheckNamespace
namespace System
{
  public static class FunctionalExtensions
  {
    public static TResult Tee<TResult>(this TResult @this, Action<TResult> action)
    {
      action(@this);
      return @this;
    }
  }
}
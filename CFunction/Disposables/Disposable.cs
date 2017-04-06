using System;

namespace CFunction.Disposables
{
    public static class Disposable
    {
        public static TResult Using<TDisposable, TResult>(Func<TDisposable> factory, Func<TDisposable, TResult> fn)
            where TDisposable : IDisposable, new()
        {
            using (var disposable = new TDisposable())
            {
                return fn(disposable);
            }
        }
    }
}
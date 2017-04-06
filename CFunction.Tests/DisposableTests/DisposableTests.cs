using System;
using CFunction.Disposables;
using CFunction.Tests.Disposables;
using Xunit;

namespace CFunction.Tests.DisposableTests
{
    public class DisposableTests
    {
        [Fact]
        public void Using__Should_execute_method_once()
        {
            var calls = 0;
            Disposable.Using(() => new TestDisposable(), dis => calls++);
            Assert.Equal(1, calls);
        }
        [Fact]
        public void Using__Should_pass_to_method_the_disposable_object()
        {
            Disposable.Using(() => new TestDisposable(), Assert.IsAssignableFrom<IDisposable>);
            Assert.True(true);
        }
        [Fact]
        public void Using__Should_return_the_result_from_the_method()
        {
            var result = Disposable.Using(() => new TestDisposable(), dis => 1);
            Assert.Equal(1, result);
        }
    }
}
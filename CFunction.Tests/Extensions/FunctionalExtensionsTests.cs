using System;
using Xunit;

namespace CFunction.Tests.Extensions
{
  public class FunctionalExtensionsTests
  {
    [Fact]
    public void Tee__Should_return_number()
    {
      Assert.Equal(123, 123.Tee(x => { }));
    }
    [Fact]
    public void Tee__Should_execute_the_method_once()
    {
      var calls = 0;
      123.Tee(x => calls++);
      Assert.Equal(1, calls);
    }
  }
}
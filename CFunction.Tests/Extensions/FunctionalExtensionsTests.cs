using System;
using Xunit;

namespace CFunction.Tests.Extensions
{
  public class FunctionalExtensionsTests
  {
    #region Tee
    [Fact]
    public void Tee__Should_return_number() =>
      Assert.Equal(123, 123.Tee(x => { }));

    [Fact]
    public void Tee__Should_execute_the_method_once()
    {
      var calls = 0;
      123.Tee(x => calls++);
      Assert.Equal(1, calls);
    }
    #endregion

    #region Map
    [Fact]
    public void Map__Should_return_a_different_type_from_method() =>
      Assert.Equal("124", 123.Map(x => (x + 1).ToString()));
    #endregion
  }
}
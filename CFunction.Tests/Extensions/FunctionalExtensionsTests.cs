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


    #region When
    [Fact]
    public void When__Should_execute_the_method_once_if_result_of_condition_is_true()
    {
      var calls = 0;
      123.When(x => x == 123, x => calls++);
      Assert.Equal(1, calls);
    }
    [Fact]
    public void When__Should_not_execute_the_method_if_result_of_condition_is_false()
    {
      var calls = 0;
      123.When(x => x == 0, x => calls++);
      Assert.Equal(0, calls);
    }
    [Fact]
    public void When__Should_execute_the_method_once_if_condition_is_true()
    {
      var calls = 0;
      123.When(true, x => calls++);
      Assert.Equal(1, calls);
    }
    [Fact]
    public void When__Should_not_execute_the_method_if_condition_is_false()
    {
      var calls = 0;
      123.When(false, x => calls++);
      Assert.Equal(0, calls);
    }
    [Fact]
    public void When__Should_returns_the_result_of_method_condition_is_true() =>
      Assert.Equal(173, 123.When(true, x => 123 + 50));
    [Fact]
    public void When__Should_returns_the_same_value_condition_is_false() =>
      Assert.Equal(123, 123.When(false, x => 123 + 50));
    #endregion
  }
}
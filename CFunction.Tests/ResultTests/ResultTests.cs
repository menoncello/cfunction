using System;
using Xunit;

namespace CFunction.Tests.ResultTests
{
  public class ResultTests
  {
    #region SucceedWith
    [Fact]
    public void SucceedWith__Should_returns_a_Result_type() =>
      Assert.IsAssignableFrom<Result<int, string>>(Result<int, string>.SucceedWith(1));

    [Fact]
    public void SucceedWith__Should_returns_the_SuccessValue_as_passed_value() =>
      Assert.Equal(1, Result<int, string>.SucceedWith(1).SuccessValue);

    [Fact]
    public void SucceedWith__Should_returns_the_IsSuccess_as_true() =>
      Assert.True(Result<int, string>.SucceedWith(1).IsSuccess);
    #endregion

    #region FailWith
    [Fact]
    public void FailWith__Should_returns_a_Result_type() =>
      Assert.IsAssignableFrom<Result<int, string>>(Result<int, string>.FailWith("1"));

    [Fact]
    public void FailWith__Should_returns_the_FailureValue_as_passed_value() =>
      Assert.Equal("1", Result<int, string>.FailWith("1").FailureValue);

    [Fact]
    public void FailWith__Should_returns_the_IsSuccess_as_true() =>
      Assert.False(Result<int, string>.FailWith("1").IsSuccess);
    #endregion
  }
}
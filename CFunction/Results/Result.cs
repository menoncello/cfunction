// ReSharper disable once CheckNamespace
namespace System
{
  /// <summary>
  /// Result class returns from conditional functions
  /// </summary>
  /// <typeparam name="TSuccess">Success type</typeparam>
  /// <typeparam name="TFailure">Failure type</typeparam>
  public class Result<TSuccess, TFailure>
  {
    private Result(bool isSuccess)
    {
      IsSuccess = isSuccess;
    }

    /// <summary>
    /// Success value, when Result has succeed
    /// </summary>
    public TSuccess SuccessValue { get; private set; }

    /// <summary>
    /// Failure value, when Result has Fail
    /// </summary>
    public TFailure FailureValue { get; private set; }

    /// <summary>
    /// Result is successful
    /// </summary>
    public bool IsSuccess { get; }

    /// <summary>
    /// Create a new Result succeed with a immutable value
    /// </summary>
    /// <param name="value">Immutable value</param>
    /// <returns>Returns a succeed Result with a immutable value</returns>
    public static Result<TSuccess, TFailure> SucceedWith(TSuccess value) =>
      new Result<TSuccess, TFailure>(true)
      {
        SuccessValue = value
      };

    /// <summary>
    /// Create a new Result fail with a immutable value
    ///l </summary>
    /// <param name="value">Immutable value</param>
    /// <returns>Returns a fail Result with a immutable value</returns>
    public static Result<TSuccess, TFailure> FailWith(TFailure value) =>
      new Result<TSuccess, TFailure>(false)
      {
        FailureValue = value
      };

    /// <summary>
    /// Execute the function if the result is succeed
    /// </summary>
    /// <param name="fn">Function to return another Result, will be executed if this Result is success</param>
    /// <returns>Return this result, if fail or a new one if succeed</returns>
    public Result<TSuccess, TFailure> Bind(Func<TSuccess, Result<TSuccess, TFailure>> fn) =>
      IsSuccess
        ? fn(SuccessValue)
        : this;
  }
}
# C-Function
Functional Programming for C# in .Net Core. Based in [Functional C#: Fluent Interfaces and Functional Method Chaining](https://davefancher.com/2015/06/14/functional-c-fluent-interfaces-and-functional-method-chaining/)
# Utilization

## Functional Methods

### - Tee(method) => `Returns the subject`
The Tee extension method takes it’s name from the corresponding UNIX command which is used in command pipelines to cause a side-effect with a given input and return the original value. Here, our side-effect is populating a byte array but we could just as easily use Tee for logging or anything else for that matter.
```c#
Console.WriteLine(123.Tee(x => Console.WriteLine(x)));
// 123
// 123
```

### - Map(mapFunction) => `Result of mapFunction`
Maps a object to other object, by a function.
```c#
Console.WriteLine(123.Tee(x => Console.WriteLine(x)));
// 123
// 123
```

### - When(condition, function) => `Result of function if condition is true`
Execute the method when the condition is true.
```c#
123.When(x => x == 123, x => 123 + 50) // returns 173;
// or
123.When(true, x => 123 + 50) // also returns 173;
```

## Result

### - SucceedWith(value) => `Returns a succeed Result with value as parameter`
```c#
Result<int, string>.SucceedWith(123);
// results:
//  Result<int, string> {
//      IsSuccess = true,
//      SuccessValue = 123 
//  }
```

### - FailWith(value) => `Returns a fail Result with value as parameter`
```c#
Result<int, string>.FailWith('fail');
// results:
//  Result<int, string> {
//      IsSuccess = false,
//      FailureValue = 'fail' 
//  }
```

### - Bind(function) => `Result`
Execute the function if the result is succeed
```c#
Result<int, string>.Success(123)
    .Bind(x => Promise.SucceedWith(321));
```

## Disposables

### - Using(constructor, function) => `Returns the result of function`
Execute using method, without using enclosure.
```c#
// Before
using (var reader = new StreamReader(stream)) {
    return reader.ReadToEnd();
}

// After
Disposable.Using(() => new StreamReader(stream), (reader) => reader.readToEnd);
```


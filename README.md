# C-Function
Functional Programming for C# in .Net Core. Based in [Functional C#: Fluent Interfaces and Functional Method Chaining](https://davefancher.com/2015/06/14/functional-c-fluent-interfaces-and-functional-method-chaining/)
# Utilization

## Functional Methods

### - Tee
The Tee extension method takes it’s name from the corresponding UNIX command which is used in command pipelines to cause a side-effect with a given input and return the original value. Here, our side-effect is populating a byte array but we could just as easily use Tee for logging or anything else for that matter.
```c#
Console.WriteLine(123.Tee(x => Console.WriteLine(x)));
// 123
// 123
```

### - Map
Maps a object to other object, by a function.
```c#
Console.WriteLine(123.Tee(x => Console.WriteLine(x)));
// 123
// 123
```

## Disposables

### - Using
Execute using method, without using enclosure.
```c#
// Before
using (var reader = new StreamReader(stream)) {
    return reader.ReadToEnd();
}

// After
Disposable.Using(() => new StreamReader(stream), (reader) => reader.readToEnd);
```


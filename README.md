# C-Function
Functional Programming for C# in .Net Core

# Utilization

## Disposables

### Using
```c#
// Before
using (var reader = new StreamReader(stream)) {
    return reader.ReadToEnd();
}

// After
Disposable.Using(() => new StreamReader(stream), (reader) => reader.readToEnd);
```

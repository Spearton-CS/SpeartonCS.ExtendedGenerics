# SpeartonCS.ExtendedGenerics [![NuGet](https://img.shields.io/nuget/v/SpeartonCS.ExtendedGenerics.svg)](https://nuget.org/packages/SpertonCS.ExtendedGenerics)

---

## Why should I choose this package?
- ### Targeting on crossplatform and modern .NET 10 and higher
- ### NativeAOT compatible
- ### No reflection and "hidden allocations"
- ### Flexible generic constraints

---

## Namespace map

| Namespace | Description | Example types |
| :--- | :---: | ---: |
| SpeartonCS.ExtendedGenerics | Something uncategorized | `IFactory<T1-T15, TResult>`, `INullValue<TSelf>` |
| SpeartonCS.ExtendedGenerics.Collections | Modern, minimal and flexible contracts over collections | `IEnumerable<T, TEnumerator>`, `IClearable` |
| SpeartonCS.ExtendedGenerics.DuckTyping | C# sugar syntax or features, that haven't an interface yet | `ICollectionBuilder<T, TCollection>`, `IPinnable<TPinnableReference>` |
| SpeartonCS.ExtendedGenerics.Numerics | Minimal contracts over Generic Math and logical/cast operators. NO System.Numerics DUPLICATION | `IExplicitOperators<TSelf, TOther>`, `IZeroValue<TSelf>` |
| SpeartonCS.ExtendedGenerics.Runtime.CompilerServices | Structs for generic-usage of: Pointers, Relative Pointer, Function Pointer, Managed Pointers | `ManagedActionPtr`, `Ref<T>` |

### But for **full** list of exported types, look [This md file](./SpeartonCS.ExtendedGenerics/ExportTypeList.md)
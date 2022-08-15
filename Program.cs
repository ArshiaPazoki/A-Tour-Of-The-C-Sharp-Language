// A tour of the C# language

// C# (pronounced "See Sharp") is a modern, object-oriented, and type-safe programming language.
// C# is an object-oriented, component-oriented programming language.
// At its core, C# is an object-oriented language. You define types and their behavior.

// Several C# features help create robust and durable applications:
//      1 - Garbage collection automatically reclaims memory occupied by unreachable unused objects.
//      2 - Nullable types guard against variables that don't refer to allocated objects.
//      3 - Exception handling provides a structured and extensible approach to error detection and recovery.
//      4 - Lambda expressions support functional programming techniques.
//      5 - Language Integrated Query (LINQ) syntax creates a common pattern for working with data from any source.
//      6 - Language support for asynchronous operations provides syntax for building distributed systems.
//      7 - C# has a unified type system. All C# types, including primitive types such as int and double, inherit from a single root object type.
//          All types share a set of common operations. Values of any type can be stored, transported, and operated upon in a consistent manner.
//          C# supports both user-defined reference types and value types.
//      8 - C# allows dynamic allocation of objects and in-line storage of lightweight structures.
//      9 - C# supports generic methods and types, which provide increased type safety and performance.
//      10- C# provides iterators, which enable implementers of collection classes to define custom behaviors for client code.
//      11- C# emphasizes versioning to ensure programs and libraries can evolve over time in a compatible manner.
//          Aspects of C#'s design that were directly influenced by versioning considerations include the separate virtual and override modifiers,
//          the rules for method overload resolution, and support for explicit interface member declarations.

// .NET Architecture

// C# programs run on .NET:  a virtual execution system called the common language runtime (CLR) and a set of class libraries.
// The CLR is the implementation by Microsoft of the common language infrastructure (CLI), an international standard.
// The CLI is the basis for creating execution and development environments in which languages and libraries work together seamlessly.

// Source code written in C# is compiled into an intermediate language (IL) that conforms to the CLI specification.
// The IL code and resources, such as bitmaps and strings, are stored in an assembly, typically with an extension of .dll.
// An assembly contains a manifest that provides information about the assembly's types, version, and culture.

// When the C# program is executed, the assembly is loaded into the CLR.
// The CLR performs Just-In-Time (JIT) compilation to convert the IL code to native machine instructions.
// The CLR provides other services related to automatic garbage collection, exception handling, and resource management.
// Code that's executed by the CLR is sometimes referred to as "managed code".
// "Unmanaged code" is compiled into native machine language that targets a specific platform.

// Language interoperability is a key feature of .NET.
// IL code produced by the C# compiler conforms to the Common Type Specification (CTS).
// IL code generated from C# can interact with code that was generated from the .NET versions of F#, Visual Basic, C++.
// There are more than 20 other CTS-compliant languages.
// A single assembly may contain multiple modules written in different .NET languages.
// The types can reference each other as if they were written in the same language.

// In addition to the run time services, .NET also includes extensive libraries.
// These libraries support many different workloads.
// They're organized into namespaces that provide a wide variety of useful functionality.
// The libraries include everything from file input and output to string manipulation to XML parsing, to web application frameworks to Windows Forms controls.
// The typical C# application uses the .NET class library extensively to handle common "plumbing" chores.
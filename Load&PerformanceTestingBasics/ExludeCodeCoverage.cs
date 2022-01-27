using System.Diagnostics.CodeAnalysis;
...
public class ExampleClass1
{
[ExcludeFromCodeCoverage]
void ExampleMethod() {...}
[ExcludeFromCodeCoverage] // exclude property
int ExampleProperty1
{ get {...} set{...}}
int ExampleProperty2
{
get
{
...
}
[ExcludeFromCodeCoverage] // exclude setter
set
{
...
}
}
}
[ExcludeFromCodeCoverage]
class ExampleClass2 { ... }

Imports System.Diagnostics.CodeAnalysis
Class ExampleClass1
<ExcludeFromCodeCoverage()>
Public Sub ExampleSub1()
...
End Sub
' Exclude property
< ExcludeFromCodeCoverage()>
Property ExampleProperty1 As Integer
...
End Property
' Exclude setter
Property ExampleProperty2 As Integer
Get
...
End Get
<ExcludeFromCodeCoverage()>
Set(ByVal value As Integer)
...
End Set
End Property
End Class
<ExcludeFromCodeCoverage()>
Class ExampleClass2
...
End Class

// A .cpp file compiled as managed (CLI) code.
using namespace System::Diagnostics::CodeAnalysis;
...
public ref class ExampleClass1
{
public:
[ExcludeFromCodeCoverage]
void ExampleFunction1() { ... }
[ExcludeFromCodeCoverage]
property int ExampleProperty2 {...}
property int ExampleProperty2 {
int get() { ... }
[ExcludeFromCodeCoverage]
void set(int value) { ... }
}
}
[ExcludeFromCodeCoverage]
public ref class ExampleClass2
{ ... }

#include <CodeCoverage\CodeCoverage.h>
...
// Exclusions must be compiled as unmanaged (native):
#pragma managed(push, off)
// Exclude a particular function:
ExcludeFromCodeCoverage(Exclusion1, L"MyNamespace::MyClass::MyFunction");
// Exclude all the functions in a particular class:
ExcludeFromCodeCoverage(Exclusion2, L"MyNamespace::MyClass2::*");
// Exclude all the functions generated from a particular template:
ExcludeFromCodeCoverage(Exclusion3, L"*::MyFunction<*>");
// Exclude all the code from a particular .cpp file:
ExcludeSourceFromCodeCoverage(Exclusion4, L"*\\unittest1.cpp");
// After setting exclusions, restore the previous managed/unmanaged state:
#pragma managed(pop)

//Functions Exclusion oN C++
[System::Diagnostics::CodeAnalysis::ExcludeFromCodeCoverage]

//From Command Line
//In the Windows Star t menu, choose Visual Studio 2019 > Developer Command Prompt for VS
vstest.console.exe MyTestAssembly.dll /EnableCodeCoverage
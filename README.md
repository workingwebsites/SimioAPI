# TestSimioFactory1: SimioProjectFactory instance not working

This repositiory has all the files for doing a simple command -- setting the SetExtensionsPath.

**However, it throws the following error:**

```
System.TypeInitializationException
  HResult=0x80131534
  Message=The type initializer for 'SimioAPI.SimioProjectFactory' threw an exception.
  Source=SimioDLL
  StackTrace:
   at SimioAPI.SimioProjectFactory.get_ca12d39e53e858308bab2d9cfba97d9b1()
   at SimioAPI.SimioProjectFactory.SetExtensionsPath(String path)
   at TestSimioFactory1.Program.Main(String[] args) in C:\Users\lisa\Work\PROJECTS\Simio\TestSimioFactory1\TestSimioFactory1\Program.cs:line 12

  This exception was originally thrown at this call stack:
    [External Code]

Inner Exception 1:
NullReferenceException: Object reference not set to an instance of an object.
```
---

What is the issue?  
Comments and suggestions welcome!

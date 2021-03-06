using System;
using System.Runtime.CompilerServices;

[assembly: ScriptAssembly("test")]

public class MyClass {
}

public class MyClass2 : MyClass {
}

public class MyClass3 : IDisposable {
}

public class MyClass4 : MyClass, IDisposable {

    public void SomeMethod() {

        IXyzInterface xyz = null;
        MyClass2 c2 = new MyClass2();

        xyz = c2 as IXyzInterface;
    }
}

public sealed class MyRecord : Record {
}

public enum MyEnum {
}

namespace Foo {

    public class MyClass {
    }
}

public interface IXyzInterface {
}

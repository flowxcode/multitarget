// See https://aka.ms/new-console-template for more information
//using CoreFunc;

using System.Reflection;

Console.WriteLine("Hello, World!");

//ClassCore.Func();

Assembly assembly = Assembly.LoadFrom(@"C:\git\multitarget_gh\CoreFunc\bin\Debug\net6.0\CoreFunc.dll");
Type typeToExecute = assembly.GetType("CoreFunc.ClassCore");


//var ov = Activator.CreateInstance(typeToExecute);

object[] parameters1 = new object[0];
var x = typeToExecute.GetMethod("Func");

x.Invoke(null, parameters1);


//Assembly asm = Assembly.LoadFrom(@"C:\git\MultiTarget\CoreFunc\bin\x86\Debug\net6.0\CoreFunc.dll");
//Type t = asm.GetType("CoreFunc.ClassCore");

//var methodInfo = t.GetMethod("Func");
//if (methodInfo == null)
//{
//    // never throw generic Exception - replace this with some other exception type
//    throw new Exception("No such method exists.");
//}

//var o = Activator.CreateInstance(t);
//object[] parameters = new object[0];
//var r = methodInfo.Invoke(o, parameters);


Console.WriteLine("fine x");




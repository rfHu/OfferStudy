using System;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace DllDemo
{

    public class ClassGreenerycn
    {
#if UNITY_EDITOR
        [UnityEditor.MenuItem("C#Study/ref", false, 1)]
        static void MenuCilcked()
        {
            //加载程序集
            var asm = Assembly.LoadFile(@"C:\Users\24496\Documents\Visual Studio 2017\Projects\ClassLibrary1\ClassLibrary1\bin\Debug\netcoreapp2.1\DllDemo.dll");

            //获得目标类型
            var type = asm.GetType("DllDemo.ClassGreenerycn");

            //创建目标实例
            var instance = asm.CreateInstance("DllDemo.ClassGreenerycn");

            //设置属性
            type.GetProperty("Name").SetValue(instance, "Raine", null);
            type.GetProperty("IsTest").SetValue(instance, true, null);

            //获得方法
            var method = type.GetMethod("Hello");

            //调用方法
            method.Invoke(instance, null);

            var method1 = type.GetMethod("Hi");

            Debug.Log(method1.Invoke(instance, null));
        }
#endif
    }
}

﻿//HintName: IGenericMethods.g.cs
// <auto-generated>
// This file was generated by Roozie.AutoInterface v0.6.0.0
// </auto-generated>

using Roozie.AutoInterface;
using System.Drawing;

namespace Roozie.AutoInterface.Tests;

#nullable enable

public partial interface IGenericMethods
{
    /// <summary>
    /// This is a test comment for <see cref="System.Drawing.Color"/>
    /// </summary>
    /// <param name="input"></param>
    /// <typeparam name="T">doc</typeparam>
    /// <returns></returns>
    T TestMethod<T>(T input);

    T3? TestMethod2<T1, T2, T3>(T1 input1, T2 input2);

    T TestMethod3<T>(T input) where T : class;
}

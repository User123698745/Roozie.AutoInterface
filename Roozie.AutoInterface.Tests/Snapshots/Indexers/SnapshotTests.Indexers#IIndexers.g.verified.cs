﻿//HintName: IIndexers.g.cs
// <auto-generated>
// This file was generated by Roozie.AutoInterface v0.3.0-beta
// </auto-generated>
using Roozie.AutoInterface;
using System.Drawing;
namespace Roozie.AutoInterface.Tests;
#nullable enable

public partial interface IIndexers
{
    int this[int index] {get;set;}

    int this[string v1] {get;set;}

    int this[string v1 = "", decimal v2 = 1234.1234m, KnownColor color = KnownColor.Aqua] {get;set;}
}

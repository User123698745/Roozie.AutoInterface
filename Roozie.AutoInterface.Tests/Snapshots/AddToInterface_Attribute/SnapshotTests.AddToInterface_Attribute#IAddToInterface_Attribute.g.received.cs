﻿//HintName: IAddToInterface_Attribute.g.cs
// <auto-generated>
// This file was generated by Roozie.AutoInterface v0.2.0-beta
// </auto-generated>
using Roozie.AutoInterface;
using System;
namespace Roozie.AutoInterface.Tests;
#nullable enable

public partial interface IAddToInterface_Attribute
{
    string? TestPropWithAttribute {get;set;}

    string? TestPropWithAttributePrivateSet {get;}

    string? TestPropWithAttributeInit {get;init;}

    int TestMethodWithAttribute(int input);
}

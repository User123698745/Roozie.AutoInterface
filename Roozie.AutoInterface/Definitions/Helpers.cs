namespace Roozie.AutoInterface.Definitions;

internal static class Helpers
{
    internal const string Namespace = $"{nameof(Roozie)}.{nameof(AutoInterface)}";

    internal static string GetGeneratedFileComment(string version) =>
        $$"""
// <auto-generated>
// This file was generated by {{Namespace}} v{{version}}
// </auto-generated>
""";

    internal static class FullNames
    {
        public const string AutoInterfaceAttribute = $"{Namespace}.{nameof(AutoInterfaceAttribute)}";
        public const string AddToInterfaceAttribute = $"{Namespace}.{nameof(AddToInterfaceAttribute)}";
    }
}
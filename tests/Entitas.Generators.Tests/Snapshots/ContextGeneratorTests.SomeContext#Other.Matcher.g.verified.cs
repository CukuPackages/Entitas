﻿//HintName: Other.Matcher.g.cs
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by
//     Entitas.Generators.ContextGenerator.Matcher
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Other
{
public static class Matcher
{
    public static Entitas.IAllOfMatcher<Entity> AllOf(System.Span<ComponentIndex> indices)
    {
        return Entitas.Matcher<Entity>.AllOf(ToIntArray(indices));
    }

    public static Entitas.IAnyOfMatcher<Entity> AnyOf(System.Span<ComponentIndex> indices)
    {
        return Entitas.Matcher<Entity>.AnyOf(ToIntArray(indices));
    }

    public static Entitas.IAnyOfMatcher<Entity> AnyOf(this Entitas.IAllOfMatcher<Entity> matcher, System.Span<ComponentIndex> indices)
    {
        return matcher.AnyOf(ToIntArray(indices));
    }

    public static Entitas.INoneOfMatcher<Entity> NoneOf(this Entitas.IAnyOfMatcher<Entity> matcher, System.Span<ComponentIndex> indices)
    {
        return matcher.NoneOf(ToIntArray(indices));
    }

    static int[] ToIntArray(System.Span<ComponentIndex> indices)
    {
        var ints = new int[indices.Length];
        for (var i = 0; i < indices.Length; i++)
            ints[i] = indices[i];

        return ints;
    }
}
}

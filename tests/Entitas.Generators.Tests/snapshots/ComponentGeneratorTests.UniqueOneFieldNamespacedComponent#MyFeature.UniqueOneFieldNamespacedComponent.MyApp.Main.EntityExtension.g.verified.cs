﻿//HintName: MyFeature.UniqueOneFieldNamespacedComponent.MyApp.Main.EntityExtension.g.cs
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by
//     Entitas.Generators.ComponentGenerator.EntityExtension
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using global::MyApp.Main;
using static global::MyFeature.MyAppMainUniqueOneFieldNamespacedComponentIndex;

namespace MyFeature
{
public static class MyAppMainUniqueOneFieldNamespacedEntityExtension
{
    public static bool HasUniqueOneFieldNamespaced(this Entity entity)
    {
        return entity.HasComponent(Index.Value);
    }

    public static Entity AddUniqueOneFieldNamespaced(this Entity entity, string value)
    {
        var index = Index.Value;
        var component = (UniqueOneFieldNamespacedComponent)entity.CreateComponent(index, typeof(UniqueOneFieldNamespacedComponent));
        component.Value = value;
        entity.AddComponent(index, component);
        return entity;
    }

    public static Entity ReplaceUniqueOneFieldNamespaced(this Entity entity, string value)
    {
        var index = Index.Value;
        var component = (UniqueOneFieldNamespacedComponent)entity.CreateComponent(index, typeof(UniqueOneFieldNamespacedComponent));
        component.Value = value;
        entity.ReplaceComponent(index, component);
        return entity;
    }

    public static Entity RemoveUniqueOneFieldNamespaced(this Entity entity)
    {
        entity.RemoveComponent(Index.Value);
        return entity;
    }

    public static UniqueOneFieldNamespacedComponent GetUniqueOneFieldNamespaced(this Entity entity)
    {
        return (UniqueOneFieldNamespacedComponent)entity.GetComponent(Index.Value);
    }
}
}

﻿//HintName: MyAppMainAnyFlagEventRemovedListenerEntityExtension.g.cs
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
using static global::MyAppMainAnyFlagEventRemovedListenerComponentIndex;

public static class MyAppMainAnyFlagEventRemovedListenerEntityExtension
{
    public static bool HasAnyFlagEventRemovedListener(this Entity entity)
    {
        return entity.HasComponent(Index.Value);
    }

    public static Entity AddAnyFlagEventRemovedListener(this Entity entity, global::System.Collections.Generic.List<IMyAppMainAnyFlagEventRemovedListener> value)
    {
        var index = Index.Value;
        var componentPool = entity.GetComponentPool(index);
        var component = componentPool.Count > 0
            ? (MyAppMainAnyFlagEventRemovedListenerComponent)componentPool.Pop()
            : new MyAppMainAnyFlagEventRemovedListenerComponent();
        component.Value = value;
        entity.AddComponent(index, component);
        return entity;
    }

    public static Entity ReplaceAnyFlagEventRemovedListener(this Entity entity, global::System.Collections.Generic.List<IMyAppMainAnyFlagEventRemovedListener> value)
    {
        var index = Index.Value;
        var componentPool = entity.GetComponentPool(index);
        var component = componentPool.Count > 0
            ? (MyAppMainAnyFlagEventRemovedListenerComponent)componentPool.Pop()
            : new MyAppMainAnyFlagEventRemovedListenerComponent();
        component.Value = value;
        entity.ReplaceComponent(index, component);
        return entity;
    }

    public static Entity RemoveAnyFlagEventRemovedListener(this Entity entity)
    {
        entity.RemoveComponent(Index.Value);
        return entity;
    }

    public static MyAppMainAnyFlagEventRemovedListenerComponent GetAnyFlagEventRemovedListener(this Entity entity)
    {
        return (MyAppMainAnyFlagEventRemovedListenerComponent)entity.GetComponent(Index.Value);
    }
}

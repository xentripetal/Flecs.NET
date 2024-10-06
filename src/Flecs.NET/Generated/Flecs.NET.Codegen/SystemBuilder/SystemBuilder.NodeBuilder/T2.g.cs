﻿// SystemBuilder.NodeBuilder/T2.g.cs
// File was auto-generated by /_/src/Flecs.NET.Codegen/Generators/SystemBuilder.cs
using System;
using Flecs.NET.Core.BindingContext;

namespace Flecs.NET.Core;

public unsafe partial struct SystemBuilder<T0, T1>
{
    /// <summary>
    ///     Creates <see cref="System"/> with the provided .Run callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public System<T0, T1> Run(Ecs.RunCallback callback)
    {
        TypeHelper<T0, T1>.AssertReferenceTypes(true);
        TypeHelper<T0, T1>.AssertSparseTypes(World, true);
        return SetRun(callback, Pointers<T0, T1>.RunCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="System"/> with the provided .Run callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public System<T0, T1> Run(delegate*<Iter, void> callback)
    {
        TypeHelper<T0, T1>.AssertReferenceTypes(true);
        TypeHelper<T0, T1>.AssertSparseTypes(World, true);
        return SetRun((IntPtr)callback, Pointers<T0, T1>.RunCallbackPointer).Build();
    }

    /// <summary>
    ///     Creates <see cref="System"/> with the provided .Iter callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public System<T0, T1> Iter(Ecs.IterFieldCallback<T0, T1> callback)
    {
        TypeHelper<T0, T1>.AssertReferenceTypes(true);
        TypeHelper<T0, T1>.AssertSparseTypes(World, false);
        return SetCallback(callback, Pointers<T0, T1>.IterFieldCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="System"/> with the provided .Iter callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public System<T0, T1> Iter(Ecs.IterSpanCallback<T0, T1> callback)
    {
        TypeHelper<T0, T1>.AssertReferenceTypes(false);
        TypeHelper<T0, T1>.AssertSparseTypes(World, false);
        return SetCallback(callback, Pointers<T0, T1>.IterSpanCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="System"/> with the provided .Iter callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public System<T0, T1> Iter(Ecs.IterPointerCallback<T0, T1> callback)
    {
        TypeHelper<T0, T1>.AssertReferenceTypes(false);
        TypeHelper<T0, T1>.AssertSparseTypes(World, false);
        return SetCallback(callback, Pointers<T0, T1>.IterPointerCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="System"/> with the provided .Iter callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public System<T0, T1> Iter(delegate*<Iter, Field<T0>, Field<T1>, void> callback)
    {
        TypeHelper<T0, T1>.AssertReferenceTypes(true);
        TypeHelper<T0, T1>.AssertSparseTypes(World, false);
        return SetCallback((IntPtr)callback, Pointers<T0, T1>.IterFieldCallbackPointer).Build();
    }

    /// <summary>
    ///     Creates <see cref="System"/> with the provided .Iter callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public System<T0, T1> Iter(delegate*<Iter, Span<T0>, Span<T1>, void> callback)
    {
        TypeHelper<T0, T1>.AssertReferenceTypes(false);
        TypeHelper<T0, T1>.AssertSparseTypes(World, false);
        return SetCallback((IntPtr)callback, Pointers<T0, T1>.IterSpanCallbackPointer).Build();
    }

    /// <summary>
    ///     Creates <see cref="System"/> with the provided .Iter callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public System<T0, T1> Iter(delegate*<Iter, T0*, T1*, void> callback)
    {
        TypeHelper<T0, T1>.AssertReferenceTypes(false);
        TypeHelper<T0, T1>.AssertSparseTypes(World, false);
        return SetCallback((IntPtr)callback, Pointers<T0, T1>.IterPointerCallbackPointer).Build();
    }

    /// <summary>
    ///     Creates <see cref="System"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public System<T0, T1> Each(Ecs.EachRefCallback<T0, T1> callback)
    {
        TypeHelper<T0, T1>.AssertReferenceTypes(true);
        TypeHelper<T0, T1>.AssertSparseTypes(World, true);
        return SetCallback(callback, Pointers<T0, T1>.EachRefCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="System"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public System<T0, T1> Each(Ecs.EachEntityRefCallback<T0, T1> callback)
    {
        TypeHelper<T0, T1>.AssertReferenceTypes(true);
        TypeHelper<T0, T1>.AssertSparseTypes(World, true);
        return SetCallback(callback, Pointers<T0, T1>.EachEntityRefCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="System"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public System<T0, T1> Each(Ecs.EachIterRefCallback<T0, T1> callback)
    {
        TypeHelper<T0, T1>.AssertReferenceTypes(true);
        TypeHelper<T0, T1>.AssertSparseTypes(World, true);
        return SetCallback(callback, Pointers<T0, T1>.EachIterRefCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="System"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public System<T0, T1> Each(delegate*<ref T0, ref T1, void> callback)
    {
        TypeHelper<T0, T1>.AssertReferenceTypes(true);
        TypeHelper<T0, T1>.AssertSparseTypes(World, true);
        return SetCallback((IntPtr)callback, Pointers<T0, T1>.EachRefCallbackPointer).Build();
    }

    /// <summary>
    ///     Creates <see cref="System"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public System<T0, T1> Each(delegate*<Entity, ref T0, ref T1, void> callback)
    {
        TypeHelper<T0, T1>.AssertReferenceTypes(true);
        TypeHelper<T0, T1>.AssertSparseTypes(World, true);
        return SetCallback((IntPtr)callback, Pointers<T0, T1>.EachEntityRefCallbackPointer).Build();
    }

    /// <summary>
    ///     Creates <see cref="System"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public System<T0, T1> Each(delegate*<Iter, int, ref T0, ref T1, void> callback)
    {
        TypeHelper<T0, T1>.AssertReferenceTypes(true);
        TypeHelper<T0, T1>.AssertSparseTypes(World, true);
        return SetCallback((IntPtr)callback, Pointers<T0, T1>.EachIterRefCallbackPointer).Build();
    }

    /// <summary>
    ///     Creates <see cref="System"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public System<T0, T1> Each(Ecs.EachPointerCallback<T0, T1> callback)
    {
        TypeHelper<T0, T1>.AssertReferenceTypes(false);
        TypeHelper<T0, T1>.AssertSparseTypes(World, true);
        return SetCallback(callback, Pointers<T0, T1>.EachPointerCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="System"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public System<T0, T1> Each(Ecs.EachEntityPointerCallback<T0, T1> callback)
    {
        TypeHelper<T0, T1>.AssertReferenceTypes(false);
        TypeHelper<T0, T1>.AssertSparseTypes(World, true);
        return SetCallback(callback, Pointers<T0, T1>.EachEntityPointerCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="System"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public System<T0, T1> Each(Ecs.EachIterPointerCallback<T0, T1> callback)
    {
        TypeHelper<T0, T1>.AssertReferenceTypes(false);
        TypeHelper<T0, T1>.AssertSparseTypes(World, true);
        return SetCallback(callback, Pointers<T0, T1>.EachIterPointerCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="System"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public System<T0, T1> Each(delegate*<T0*, T1*, void> callback)
    {
        TypeHelper<T0, T1>.AssertReferenceTypes(false);
        TypeHelper<T0, T1>.AssertSparseTypes(World, true);
        return SetCallback((IntPtr)callback, Pointers<T0, T1>.EachPointerCallbackPointer).Build();
    }

    /// <summary>
    ///     Creates <see cref="System"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public System<T0, T1> Each(delegate*<Entity, T0*, T1*, void> callback)
    {
        TypeHelper<T0, T1>.AssertReferenceTypes(false);
        TypeHelper<T0, T1>.AssertSparseTypes(World, true);
        return SetCallback((IntPtr)callback, Pointers<T0, T1>.EachEntityPointerCallbackPointer).Build();
    }

    /// <summary>
    ///     Creates <see cref="System"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public System<T0, T1> Each(delegate*<Iter, int, T0*, T1*, void> callback)
    {
        TypeHelper<T0, T1>.AssertReferenceTypes(false);
        TypeHelper<T0, T1>.AssertSparseTypes(World, true);
        return SetCallback((IntPtr)callback, Pointers<T0, T1>.EachIterPointerCallbackPointer).Build();
    }
}
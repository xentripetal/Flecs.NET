﻿// ObserverBuilder.NodeBuilder/T1.g.cs
// File was auto-generated by /_/src/Flecs.NET.Codegen/Generators/ObserverBuilder.cs
using System;
using Flecs.NET.Core.BindingContext;

namespace Flecs.NET.Core;

public unsafe partial struct ObserverBuilder<T0>
{
    /// <summary>
    ///     Creates <see cref="Observer"/> with the provided .Run callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Observer<T0> Run(Ecs.RunCallback callback)
    {
        TypeHelper<T0>.AssertReferenceTypes(true);
        TypeHelper<T0>.AssertSparseTypes(World, true);
        return SetRun(callback, Pointers<T0>.RunCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="Observer"/> with the provided .Run callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Observer<T0> Run(delegate*<Iter, void> callback)
    {
        TypeHelper<T0>.AssertReferenceTypes(true);
        TypeHelper<T0>.AssertSparseTypes(World, true);
        return SetRun((IntPtr)callback, Pointers<T0>.RunCallbackPointer).Build();
    }

    /// <summary>
    ///     Creates <see cref="Observer"/> with the provided .Iter callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Observer<T0> Iter(Ecs.IterFieldCallback<T0> callback)
    {
        TypeHelper<T0>.AssertReferenceTypes(true);
        TypeHelper<T0>.AssertSparseTypes(World, false);
        return SetCallback(callback, Pointers<T0>.IterFieldCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="Observer"/> with the provided .Iter callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Observer<T0> Iter(Ecs.IterSpanCallback<T0> callback)
    {
        TypeHelper<T0>.AssertReferenceTypes(false);
        TypeHelper<T0>.AssertSparseTypes(World, false);
        return SetCallback(callback, Pointers<T0>.IterSpanCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="Observer"/> with the provided .Iter callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Observer<T0> Iter(Ecs.IterPointerCallback<T0> callback)
    {
        TypeHelper<T0>.AssertReferenceTypes(false);
        TypeHelper<T0>.AssertSparseTypes(World, false);
        return SetCallback(callback, Pointers<T0>.IterPointerCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="Observer"/> with the provided .Iter callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Observer<T0> Iter(delegate*<Iter, Field<T0>, void> callback)
    {
        TypeHelper<T0>.AssertReferenceTypes(true);
        TypeHelper<T0>.AssertSparseTypes(World, false);
        return SetCallback((IntPtr)callback, Pointers<T0>.IterFieldCallbackPointer).Build();
    }

    /// <summary>
    ///     Creates <see cref="Observer"/> with the provided .Iter callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Observer<T0> Iter(delegate*<Iter, Span<T0>, void> callback)
    {
        TypeHelper<T0>.AssertReferenceTypes(false);
        TypeHelper<T0>.AssertSparseTypes(World, false);
        return SetCallback((IntPtr)callback, Pointers<T0>.IterSpanCallbackPointer).Build();
    }

    /// <summary>
    ///     Creates <see cref="Observer"/> with the provided .Iter callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Observer<T0> Iter(delegate*<Iter, T0*, void> callback)
    {
        TypeHelper<T0>.AssertReferenceTypes(false);
        TypeHelper<T0>.AssertSparseTypes(World, false);
        return SetCallback((IntPtr)callback, Pointers<T0>.IterPointerCallbackPointer).Build();
    }

    /// <summary>
    ///     Creates <see cref="Observer"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Observer<T0> Each(Ecs.EachRefCallback<T0> callback)
    {
        TypeHelper<T0>.AssertReferenceTypes(true);
        TypeHelper<T0>.AssertSparseTypes(World, true);
        return SetCallback(callback, Pointers<T0>.EachRefCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="Observer"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Observer<T0> Each(Ecs.EachEntityRefCallback<T0> callback)
    {
        TypeHelper<T0>.AssertReferenceTypes(true);
        TypeHelper<T0>.AssertSparseTypes(World, true);
        return SetCallback(callback, Pointers<T0>.EachEntityRefCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="Observer"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Observer<T0> Each(Ecs.EachIterRefCallback<T0> callback)
    {
        TypeHelper<T0>.AssertReferenceTypes(true);
        TypeHelper<T0>.AssertSparseTypes(World, true);
        return SetCallback(callback, Pointers<T0>.EachIterRefCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="Observer"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Observer<T0> Each(delegate*<ref T0, void> callback)
    {
        TypeHelper<T0>.AssertReferenceTypes(true);
        TypeHelper<T0>.AssertSparseTypes(World, true);
        return SetCallback((IntPtr)callback, Pointers<T0>.EachRefCallbackPointer).Build();
    }

    /// <summary>
    ///     Creates <see cref="Observer"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Observer<T0> Each(delegate*<Entity, ref T0, void> callback)
    {
        TypeHelper<T0>.AssertReferenceTypes(true);
        TypeHelper<T0>.AssertSparseTypes(World, true);
        return SetCallback((IntPtr)callback, Pointers<T0>.EachEntityRefCallbackPointer).Build();
    }

    /// <summary>
    ///     Creates <see cref="Observer"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Observer<T0> Each(delegate*<Iter, int, ref T0, void> callback)
    {
        TypeHelper<T0>.AssertReferenceTypes(true);
        TypeHelper<T0>.AssertSparseTypes(World, true);
        return SetCallback((IntPtr)callback, Pointers<T0>.EachIterRefCallbackPointer).Build();
    }

    /// <summary>
    ///     Creates <see cref="Observer"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Observer<T0> Each(Ecs.EachPointerCallback<T0> callback)
    {
        TypeHelper<T0>.AssertReferenceTypes(false);
        TypeHelper<T0>.AssertSparseTypes(World, true);
        return SetCallback(callback, Pointers<T0>.EachPointerCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="Observer"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Observer<T0> Each(Ecs.EachEntityPointerCallback<T0> callback)
    {
        TypeHelper<T0>.AssertReferenceTypes(false);
        TypeHelper<T0>.AssertSparseTypes(World, true);
        return SetCallback(callback, Pointers<T0>.EachEntityPointerCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="Observer"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Observer<T0> Each(Ecs.EachIterPointerCallback<T0> callback)
    {
        TypeHelper<T0>.AssertReferenceTypes(false);
        TypeHelper<T0>.AssertSparseTypes(World, true);
        return SetCallback(callback, Pointers<T0>.EachIterPointerCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="Observer"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Observer<T0> Each(delegate*<T0*, void> callback)
    {
        TypeHelper<T0>.AssertReferenceTypes(false);
        TypeHelper<T0>.AssertSparseTypes(World, true);
        return SetCallback((IntPtr)callback, Pointers<T0>.EachPointerCallbackPointer).Build();
    }

    /// <summary>
    ///     Creates <see cref="Observer"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Observer<T0> Each(delegate*<Entity, T0*, void> callback)
    {
        TypeHelper<T0>.AssertReferenceTypes(false);
        TypeHelper<T0>.AssertSparseTypes(World, true);
        return SetCallback((IntPtr)callback, Pointers<T0>.EachEntityPointerCallbackPointer).Build();
    }

    /// <summary>
    ///     Creates <see cref="Observer"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Observer<T0> Each(delegate*<Iter, int, T0*, void> callback)
    {
        TypeHelper<T0>.AssertReferenceTypes(false);
        TypeHelper<T0>.AssertSparseTypes(World, true);
        return SetCallback((IntPtr)callback, Pointers<T0>.EachIterPointerCallbackPointer).Build();
    }
}
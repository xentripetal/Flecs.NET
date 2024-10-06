﻿// SystemBuilder.NodeBuilder/T13.g.cs
// File was auto-generated by /_/src/Flecs.NET.Codegen/Generators/SystemBuilder.cs
using System;
using Flecs.NET.Core.BindingContext;

namespace Flecs.NET.Core;

public unsafe partial struct SystemBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
{
    /// <summary>
    ///     Creates <see cref="System"/> with the provided .Run callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public System<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Run(Ecs.RunCallback callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.AssertReferenceTypes(true);
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.AssertSparseTypes(World, true);
        return SetRun(callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.RunCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="System"/> with the provided .Run callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public System<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Run(delegate*<Iter, void> callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.AssertReferenceTypes(true);
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.AssertSparseTypes(World, true);
        return SetRun((IntPtr)callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.RunCallbackPointer).Build();
    }

    /// <summary>
    ///     Creates <see cref="System"/> with the provided .Iter callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public System<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Iter(Ecs.IterFieldCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.AssertReferenceTypes(true);
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.AssertSparseTypes(World, false);
        return SetCallback(callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.IterFieldCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="System"/> with the provided .Iter callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public System<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Iter(Ecs.IterSpanCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.AssertReferenceTypes(false);
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.AssertSparseTypes(World, false);
        return SetCallback(callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.IterSpanCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="System"/> with the provided .Iter callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public System<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Iter(Ecs.IterPointerCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.AssertReferenceTypes(false);
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.AssertSparseTypes(World, false);
        return SetCallback(callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.IterPointerCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="System"/> with the provided .Iter callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public System<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Iter(delegate*<Iter, Field<T0>, Field<T1>, Field<T2>, Field<T3>, Field<T4>, Field<T5>, Field<T6>, Field<T7>, Field<T8>, Field<T9>, Field<T10>, Field<T11>, Field<T12>, void> callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.AssertReferenceTypes(true);
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.AssertSparseTypes(World, false);
        return SetCallback((IntPtr)callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.IterFieldCallbackPointer).Build();
    }

    /// <summary>
    ///     Creates <see cref="System"/> with the provided .Iter callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public System<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Iter(delegate*<Iter, Span<T0>, Span<T1>, Span<T2>, Span<T3>, Span<T4>, Span<T5>, Span<T6>, Span<T7>, Span<T8>, Span<T9>, Span<T10>, Span<T11>, Span<T12>, void> callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.AssertReferenceTypes(false);
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.AssertSparseTypes(World, false);
        return SetCallback((IntPtr)callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.IterSpanCallbackPointer).Build();
    }

    /// <summary>
    ///     Creates <see cref="System"/> with the provided .Iter callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public System<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Iter(delegate*<Iter, T0*, T1*, T2*, T3*, T4*, T5*, T6*, T7*, T8*, T9*, T10*, T11*, T12*, void> callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.AssertReferenceTypes(false);
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.AssertSparseTypes(World, false);
        return SetCallback((IntPtr)callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.IterPointerCallbackPointer).Build();
    }

    /// <summary>
    ///     Creates <see cref="System"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public System<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Each(Ecs.EachRefCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.AssertReferenceTypes(true);
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.AssertSparseTypes(World, true);
        return SetCallback(callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.EachRefCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="System"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public System<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Each(Ecs.EachEntityRefCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.AssertReferenceTypes(true);
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.AssertSparseTypes(World, true);
        return SetCallback(callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.EachEntityRefCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="System"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public System<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Each(Ecs.EachIterRefCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.AssertReferenceTypes(true);
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.AssertSparseTypes(World, true);
        return SetCallback(callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.EachIterRefCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="System"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public System<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Each(delegate*<ref T0, ref T1, ref T2, ref T3, ref T4, ref T5, ref T6, ref T7, ref T8, ref T9, ref T10, ref T11, ref T12, void> callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.AssertReferenceTypes(true);
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.AssertSparseTypes(World, true);
        return SetCallback((IntPtr)callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.EachRefCallbackPointer).Build();
    }

    /// <summary>
    ///     Creates <see cref="System"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public System<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Each(delegate*<Entity, ref T0, ref T1, ref T2, ref T3, ref T4, ref T5, ref T6, ref T7, ref T8, ref T9, ref T10, ref T11, ref T12, void> callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.AssertReferenceTypes(true);
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.AssertSparseTypes(World, true);
        return SetCallback((IntPtr)callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.EachEntityRefCallbackPointer).Build();
    }

    /// <summary>
    ///     Creates <see cref="System"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public System<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Each(delegate*<Iter, int, ref T0, ref T1, ref T2, ref T3, ref T4, ref T5, ref T6, ref T7, ref T8, ref T9, ref T10, ref T11, ref T12, void> callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.AssertReferenceTypes(true);
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.AssertSparseTypes(World, true);
        return SetCallback((IntPtr)callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.EachIterRefCallbackPointer).Build();
    }

    /// <summary>
    ///     Creates <see cref="System"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public System<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Each(Ecs.EachPointerCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.AssertReferenceTypes(false);
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.AssertSparseTypes(World, true);
        return SetCallback(callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.EachPointerCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="System"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public System<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Each(Ecs.EachEntityPointerCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.AssertReferenceTypes(false);
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.AssertSparseTypes(World, true);
        return SetCallback(callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.EachEntityPointerCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="System"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public System<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Each(Ecs.EachIterPointerCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.AssertReferenceTypes(false);
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.AssertSparseTypes(World, true);
        return SetCallback(callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.EachIterPointerCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="System"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public System<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Each(delegate*<T0*, T1*, T2*, T3*, T4*, T5*, T6*, T7*, T8*, T9*, T10*, T11*, T12*, void> callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.AssertReferenceTypes(false);
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.AssertSparseTypes(World, true);
        return SetCallback((IntPtr)callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.EachPointerCallbackPointer).Build();
    }

    /// <summary>
    ///     Creates <see cref="System"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public System<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Each(delegate*<Entity, T0*, T1*, T2*, T3*, T4*, T5*, T6*, T7*, T8*, T9*, T10*, T11*, T12*, void> callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.AssertReferenceTypes(false);
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.AssertSparseTypes(World, true);
        return SetCallback((IntPtr)callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.EachEntityPointerCallbackPointer).Build();
    }

    /// <summary>
    ///     Creates <see cref="System"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public System<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Each(delegate*<Iter, int, T0*, T1*, T2*, T3*, T4*, T5*, T6*, T7*, T8*, T9*, T10*, T11*, T12*, void> callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.AssertReferenceTypes(false);
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.AssertSparseTypes(World, true);
        return SetCallback((IntPtr)callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.EachIterPointerCallbackPointer).Build();
    }
}
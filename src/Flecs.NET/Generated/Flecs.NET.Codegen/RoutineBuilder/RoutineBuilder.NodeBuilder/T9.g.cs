﻿// RoutineBuilder.NodeBuilder/T9.g.cs
// File was auto-generated by /_/src/Flecs.NET.Codegen/Generators/RoutineBuilder.cs
using System;
using Flecs.NET.Core.BindingContext;

namespace Flecs.NET.Core;

public unsafe partial struct RoutineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8>
{
    /// <summary>
    ///     Creates <see cref="Routine"/> with the provided .Run callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Routine<T0, T1, T2, T3, T4, T5, T6, T7, T8> Run(Ecs.RunCallback callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8>.AssertReferenceTypes(true);
        return SetRun(callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8>.RunCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="Routine"/> with the provided .Run callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Routine<T0, T1, T2, T3, T4, T5, T6, T7, T8> Run(delegate*<Iter, void> callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8>.AssertReferenceTypes(true);
        return SetRun((IntPtr)callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8>.RunCallbackPointer).Build();
    }

    /// <summary>
    ///     Creates <see cref="Routine"/> with the provided .Iter callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Routine<T0, T1, T2, T3, T4, T5, T6, T7, T8> Iter(Ecs.IterFieldCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8> callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8>.AssertReferenceTypes(true);
        return SetCallback(callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8>.IterFieldCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="Routine"/> with the provided .Iter callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Routine<T0, T1, T2, T3, T4, T5, T6, T7, T8> Iter(Ecs.IterSpanCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8> callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8>.AssertReferenceTypes(false);
        return SetCallback(callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8>.IterSpanCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="Routine"/> with the provided .Iter callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Routine<T0, T1, T2, T3, T4, T5, T6, T7, T8> Iter(Ecs.IterPointerCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8> callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8>.AssertReferenceTypes(false);
        return SetCallback(callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8>.IterPointerCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="Routine"/> with the provided .Iter callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Routine<T0, T1, T2, T3, T4, T5, T6, T7, T8> Iter(delegate*<Iter, Field<T0>, Field<T1>, Field<T2>, Field<T3>, Field<T4>, Field<T5>, Field<T6>, Field<T7>, Field<T8>, void> callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8>.AssertReferenceTypes(true);
        return SetCallback((IntPtr)callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8>.IterFieldCallbackPointer).Build();
    }

    /// <summary>
    ///     Creates <see cref="Routine"/> with the provided .Iter callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Routine<T0, T1, T2, T3, T4, T5, T6, T7, T8> Iter(delegate*<Iter, Span<T0>, Span<T1>, Span<T2>, Span<T3>, Span<T4>, Span<T5>, Span<T6>, Span<T7>, Span<T8>, void> callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8>.AssertReferenceTypes(false);
        return SetCallback((IntPtr)callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8>.IterSpanCallbackPointer).Build();
    }

    /// <summary>
    ///     Creates <see cref="Routine"/> with the provided .Iter callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Routine<T0, T1, T2, T3, T4, T5, T6, T7, T8> Iter(delegate*<Iter, T0*, T1*, T2*, T3*, T4*, T5*, T6*, T7*, T8*, void> callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8>.AssertReferenceTypes(false);
        return SetCallback((IntPtr)callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8>.IterPointerCallbackPointer).Build();
    }

    /// <summary>
    ///     Creates <see cref="Routine"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Routine<T0, T1, T2, T3, T4, T5, T6, T7, T8> Each(Ecs.EachRefCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8> callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8>.AssertReferenceTypes(true);
        return SetCallback(callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8>.EachRefCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="Routine"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Routine<T0, T1, T2, T3, T4, T5, T6, T7, T8> Each(Ecs.EachEntityRefCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8> callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8>.AssertReferenceTypes(true);
        return SetCallback(callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8>.EachEntityRefCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="Routine"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Routine<T0, T1, T2, T3, T4, T5, T6, T7, T8> Each(Ecs.EachIterRefCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8> callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8>.AssertReferenceTypes(true);
        return SetCallback(callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8>.EachIterRefCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="Routine"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Routine<T0, T1, T2, T3, T4, T5, T6, T7, T8> Each(delegate*<ref T0, ref T1, ref T2, ref T3, ref T4, ref T5, ref T6, ref T7, ref T8, void> callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8>.AssertReferenceTypes(true);
        return SetCallback((IntPtr)callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8>.EachRefCallbackPointer).Build();
    }

    /// <summary>
    ///     Creates <see cref="Routine"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Routine<T0, T1, T2, T3, T4, T5, T6, T7, T8> Each(delegate*<Entity, ref T0, ref T1, ref T2, ref T3, ref T4, ref T5, ref T6, ref T7, ref T8, void> callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8>.AssertReferenceTypes(true);
        return SetCallback((IntPtr)callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8>.EachEntityRefCallbackPointer).Build();
    }

    /// <summary>
    ///     Creates <see cref="Routine"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Routine<T0, T1, T2, T3, T4, T5, T6, T7, T8> Each(delegate*<Iter, int, ref T0, ref T1, ref T2, ref T3, ref T4, ref T5, ref T6, ref T7, ref T8, void> callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8>.AssertReferenceTypes(true);
        return SetCallback((IntPtr)callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8>.EachIterRefCallbackPointer).Build();
    }

    /// <summary>
    ///     Creates <see cref="Routine"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Routine<T0, T1, T2, T3, T4, T5, T6, T7, T8> Each(Ecs.EachPointerCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8> callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8>.AssertReferenceTypes(false);
        return SetCallback(callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8>.EachPointerCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="Routine"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Routine<T0, T1, T2, T3, T4, T5, T6, T7, T8> Each(Ecs.EachEntityPointerCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8> callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8>.AssertReferenceTypes(false);
        return SetCallback(callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8>.EachEntityPointerCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="Routine"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Routine<T0, T1, T2, T3, T4, T5, T6, T7, T8> Each(Ecs.EachIterPointerCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8> callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8>.AssertReferenceTypes(false);
        return SetCallback(callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8>.EachIterPointerCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="Routine"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Routine<T0, T1, T2, T3, T4, T5, T6, T7, T8> Each(delegate*<T0*, T1*, T2*, T3*, T4*, T5*, T6*, T7*, T8*, void> callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8>.AssertReferenceTypes(false);
        return SetCallback((IntPtr)callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8>.EachPointerCallbackPointer).Build();
    }

    /// <summary>
    ///     Creates <see cref="Routine"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Routine<T0, T1, T2, T3, T4, T5, T6, T7, T8> Each(delegate*<Entity, T0*, T1*, T2*, T3*, T4*, T5*, T6*, T7*, T8*, void> callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8>.AssertReferenceTypes(false);
        return SetCallback((IntPtr)callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8>.EachEntityPointerCallbackPointer).Build();
    }

    /// <summary>
    ///     Creates <see cref="Routine"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Routine<T0, T1, T2, T3, T4, T5, T6, T7, T8> Each(delegate*<Iter, int, T0*, T1*, T2*, T3*, T4*, T5*, T6*, T7*, T8*, void> callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8>.AssertReferenceTypes(false);
        return SetCallback((IntPtr)callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8>.EachIterPointerCallbackPointer).Build();
    }
}
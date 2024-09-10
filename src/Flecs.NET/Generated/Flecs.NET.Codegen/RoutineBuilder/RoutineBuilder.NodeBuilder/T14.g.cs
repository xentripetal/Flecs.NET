﻿// RoutineBuilder.NodeBuilder/T14.g.cs
// File was auto-generated by /_/src/Flecs.NET.Codegen/Generators/RoutineBuilder.cs
using System;
using Flecs.NET.Core.BindingContext;

namespace Flecs.NET.Core;

public unsafe partial struct RoutineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
{
    /// <summary>
    ///     Creates <see cref="Routine"/> with the provided .Run callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Routine<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Run(Ecs.RunCallback callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.AssertReferenceTypes(true);
        return SetRun(callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.RunCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="Routine"/> with the provided .Run callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Routine<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Run(delegate*<Iter, void> callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.AssertReferenceTypes(true);
        return SetRun((IntPtr)callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.RunCallbackPointer).Build();
    }

    /// <summary>
    ///     Creates <see cref="Routine"/> with the provided .Iter callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Routine<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Iter(Ecs.IterFieldCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.AssertReferenceTypes(true);
        return SetCallback(callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.IterFieldCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="Routine"/> with the provided .Iter callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Routine<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Iter(Ecs.IterSpanCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.AssertReferenceTypes(false);
        return SetCallback(callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.IterSpanCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="Routine"/> with the provided .Iter callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Routine<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Iter(Ecs.IterPointerCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.AssertReferenceTypes(false);
        return SetCallback(callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.IterPointerCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="Routine"/> with the provided .Iter callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Routine<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Iter(delegate*<Iter, Field<T0>, Field<T1>, Field<T2>, Field<T3>, Field<T4>, Field<T5>, Field<T6>, Field<T7>, Field<T8>, Field<T9>, Field<T10>, Field<T11>, Field<T12>, Field<T13>, void> callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.AssertReferenceTypes(true);
        return SetCallback((IntPtr)callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.IterFieldCallbackPointer).Build();
    }

    /// <summary>
    ///     Creates <see cref="Routine"/> with the provided .Iter callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Routine<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Iter(delegate*<Iter, Span<T0>, Span<T1>, Span<T2>, Span<T3>, Span<T4>, Span<T5>, Span<T6>, Span<T7>, Span<T8>, Span<T9>, Span<T10>, Span<T11>, Span<T12>, Span<T13>, void> callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.AssertReferenceTypes(false);
        return SetCallback((IntPtr)callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.IterSpanCallbackPointer).Build();
    }

    /// <summary>
    ///     Creates <see cref="Routine"/> with the provided .Iter callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Routine<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Iter(delegate*<Iter, T0*, T1*, T2*, T3*, T4*, T5*, T6*, T7*, T8*, T9*, T10*, T11*, T12*, T13*, void> callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.AssertReferenceTypes(false);
        return SetCallback((IntPtr)callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.IterPointerCallbackPointer).Build();
    }

    /// <summary>
    ///     Creates <see cref="Routine"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Routine<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Each(Ecs.EachRefCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.AssertReferenceTypes(true);
        return SetCallback(callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.EachRefCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="Routine"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Routine<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Each(Ecs.EachEntityRefCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.AssertReferenceTypes(true);
        return SetCallback(callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.EachEntityRefCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="Routine"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Routine<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Each(Ecs.EachIterRefCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.AssertReferenceTypes(true);
        return SetCallback(callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.EachIterRefCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="Routine"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Routine<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Each(delegate*<ref T0, ref T1, ref T2, ref T3, ref T4, ref T5, ref T6, ref T7, ref T8, ref T9, ref T10, ref T11, ref T12, ref T13, void> callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.AssertReferenceTypes(true);
        return SetCallback((IntPtr)callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.EachRefCallbackPointer).Build();
    }

    /// <summary>
    ///     Creates <see cref="Routine"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Routine<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Each(delegate*<Entity, ref T0, ref T1, ref T2, ref T3, ref T4, ref T5, ref T6, ref T7, ref T8, ref T9, ref T10, ref T11, ref T12, ref T13, void> callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.AssertReferenceTypes(true);
        return SetCallback((IntPtr)callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.EachEntityRefCallbackPointer).Build();
    }

    /// <summary>
    ///     Creates <see cref="Routine"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Routine<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Each(delegate*<Iter, int, ref T0, ref T1, ref T2, ref T3, ref T4, ref T5, ref T6, ref T7, ref T8, ref T9, ref T10, ref T11, ref T12, ref T13, void> callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.AssertReferenceTypes(true);
        return SetCallback((IntPtr)callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.EachIterRefCallbackPointer).Build();
    }

    /// <summary>
    ///     Creates <see cref="Routine"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Routine<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Each(Ecs.EachPointerCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.AssertReferenceTypes(false);
        return SetCallback(callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.EachPointerCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="Routine"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Routine<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Each(Ecs.EachEntityPointerCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.AssertReferenceTypes(false);
        return SetCallback(callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.EachEntityPointerCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="Routine"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Routine<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Each(Ecs.EachIterPointerCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.AssertReferenceTypes(false);
        return SetCallback(callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.EachIterPointerCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="Routine"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Routine<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Each(delegate*<T0*, T1*, T2*, T3*, T4*, T5*, T6*, T7*, T8*, T9*, T10*, T11*, T12*, T13*, void> callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.AssertReferenceTypes(false);
        return SetCallback((IntPtr)callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.EachPointerCallbackPointer).Build();
    }

    /// <summary>
    ///     Creates <see cref="Routine"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Routine<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Each(delegate*<Entity, T0*, T1*, T2*, T3*, T4*, T5*, T6*, T7*, T8*, T9*, T10*, T11*, T12*, T13*, void> callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.AssertReferenceTypes(false);
        return SetCallback((IntPtr)callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.EachEntityPointerCallbackPointer).Build();
    }

    /// <summary>
    ///     Creates <see cref="Routine"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    public Routine<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Each(delegate*<Iter, int, T0*, T1*, T2*, T3*, T4*, T5*, T6*, T7*, T8*, T9*, T10*, T11*, T12*, T13*, void> callback)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.AssertReferenceTypes(false);
        return SetCallback((IntPtr)callback, Pointers<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.EachIterPointerCallbackPointer).Build();
    }
}
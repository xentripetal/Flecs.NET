﻿// PageIterable/T6.g.cs
// File was auto-generated by /_/src/Flecs.NET.Codegen/Generators/PageIterable.cs
#nullable enable

using System;
using System.Runtime.CompilerServices;
using static Flecs.NET.Bindings.flecs;

namespace Flecs.NET.Core;

/// <inheritdoc cref="IterIterable"/>
/// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam>
public partial struct PageIterable<T0, T1, T2, T3, T4, T5> : IEquatable<PageIterable<T0, T1, T2, T3, T4, T5>>
{
    private PageIterable _pageIterable;

    /// <summary>
    ///     Creates a page iterable.
    /// </summary>
    /// <param name="pageIterable">The page iterable.</param>
    public PageIterable(PageIterable pageIterable)
    {
        _pageIterable = pageIterable;
    }

    /// <inheritdoc cref="PageIterable(ecs_iter_t, int, int)"/>
    public PageIterable(ecs_iter_t iter, int offset, int limit)
    {
        _pageIterable = new PageIterable(iter, offset, limit);
    }
    
    /// <inheritdoc cref="PageIterable.Equals(PageIterable)"/>
    public bool Equals(PageIterable<T0, T1, T2, T3, T4, T5> other)
    {
        return _pageIterable.Equals(other._pageIterable);
    }
    
    /// <inheritdoc cref="PageIterable.Equals(object)"/>
    public override bool Equals(object? obj)
    {
        return obj is PageIterable<T0, T1, T2, T3, T4, T5> other && Equals(other);
    }
    
    /// <inheritdoc cref="PageIterable.GetHashCode()"/>
    public override int GetHashCode()
    {
        return _pageIterable.GetHashCode();
    }
    
    /// <inheritdoc cref="PageIterable.op_Equality"/>
    public static bool operator ==(PageIterable<T0, T1, T2, T3, T4, T5> left, PageIterable<T0, T1, T2, T3, T4, T5> right)
    {
        return left.Equals(right);
    }
    
    /// <inheritdoc cref="PageIterable.op_Inequality"/>
    public static bool operator !=(PageIterable<T0, T1, T2, T3, T4, T5> left, PageIterable<T0, T1, T2, T3, T4, T5> right)
    {
        return !(left == right);
    }
}

// IIterableBase Interface
public unsafe partial struct PageIterable<T0, T1, T2, T3, T4, T5> : IIterableBase
{
    /// <inheritdoc cref="PageIterable.World"/>
    public ref ecs_world_t* World => ref _pageIterable.World;

    /// <inheritdoc cref="PageIterable.GetIter(ecs_world_t*)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ecs_iter_t GetIter(ecs_world_t* world = null)
    {
        return _pageIterable.GetIter(world);
    }
    
    /// <inheritdoc cref="PageIterable.GetNext(ecs_iter_t*)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool GetNext(ecs_iter_t* it)
    {
        return _pageIterable.GetNext(it);
    }
}

// IIterable<T0, T1, T2, T3, T4, T5> Interface
public unsafe partial struct PageIterable<T0, T1, T2, T3, T4, T5> : IIterable<T0, T1, T2, T3, T4, T5>
{
    /// <inheritdoc cref="PageIterable.Page(int, int)"/>
    public PageIterable<T0, T1, T2, T3, T4, T5> Page(int offset, int limit)
    {
        return new PageIterable<T0, T1, T2, T3, T4, T5>(_pageIterable.Page(offset, limit));
    }
    
    /// <inheritdoc cref="PageIterable.Worker(int, int)"/>
    public WorkerIterable<T0, T1, T2, T3, T4, T5> Worker(int index, int count)
    {
        return new WorkerIterable<T0, T1, T2, T3, T4, T5>(_pageIterable.Worker(index, count));
    }

    /// <inheritdoc cref="PageIterable.Iter(Flecs.NET.Core.World)"/>
    public IterIterable<T0, T1, T2, T3, T4, T5> Iter(World world = default)
    {
        return new(_pageIterable.Iter(world));
    }
    
    /// <inheritdoc cref="PageIterable.Iter(Flecs.NET.Core.Iter)"/>
    public IterIterable<T0, T1, T2, T3, T4, T5> Iter(Iter it)
    {
        return new(_pageIterable.Iter(it));
    }
    
    /// <inheritdoc cref="PageIterable.Iter(Flecs.NET.Core.Entity)"/>
    public IterIterable<T0, T1, T2, T3, T4, T5> Iter(Entity entity)
    {
        return new(_pageIterable.Iter(entity));
    }
    
    /// <inheritdoc cref="PageIterable.Count()"/>
    public int Count()
    {
        return _pageIterable.Count();
    }
    
    /// <inheritdoc cref="PageIterable.IsTrue()"/>
    public bool IsTrue()
    {
        return _pageIterable.IsTrue();
    }
    
    /// <inheritdoc cref="PageIterable.First()"/>
    public Entity First()
    {
        return _pageIterable.First();
    }
    
    /// <inheritdoc cref="PageIterable.SetVar(int, ulong)"/>
    public IterIterable<T0, T1, T2, T3, T4, T5> SetVar(int varId, ulong value)
    {
        return new(_pageIterable.SetVar(varId, value));
    }
    
    /// <inheritdoc cref="PageIterable.SetVar(string, ulong)"/>
    public IterIterable<T0, T1, T2, T3, T4, T5> SetVar(string name, ulong value)
    {
        return new(_pageIterable.SetVar(name, value));
    }
    
    /// <inheritdoc cref="PageIterable.SetVar(string, ecs_table_t*)"/>
    public IterIterable<T0, T1, T2, T3, T4, T5> SetVar(string name, ecs_table_t* value)
    {
        return new(_pageIterable.SetVar(name, value));
    }
    
    /// <inheritdoc cref="PageIterable.SetVar(string, ecs_table_range_t)"/>
    public IterIterable<T0, T1, T2, T3, T4, T5> SetVar(string name, ecs_table_range_t value)
    {
        return new(_pageIterable.SetVar(name, value));
    }
    
    /// <inheritdoc cref="PageIterable.SetVar(string, Table)"/>
    public IterIterable<T0, T1, T2, T3, T4, T5> SetVar(string name, Table value)
    {
        return new(_pageIterable.SetVar(name, value));
    }
    
    /// <inheritdoc cref="PageIterable.SetGroup(ulong)"/>
    public IterIterable<T0, T1, T2, T3, T4, T5> SetGroup(ulong groupId)
    {
        return new(_pageIterable.SetGroup(groupId));
    }
    
    /// <inheritdoc cref="PageIterable.SetGroup{T}()"/>
    public IterIterable<T0, T1, T2, T3, T4, T5> SetGroup<T>()
    {
        return new(_pageIterable.SetGroup<T>()); 
    }
}
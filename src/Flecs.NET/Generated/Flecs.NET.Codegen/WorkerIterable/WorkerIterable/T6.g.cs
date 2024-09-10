﻿// WorkerIterable/T6.g.cs
// File was auto-generated by /_/src/Flecs.NET.Codegen/Generators/WorkerIterable.cs
#nullable enable

using System;
using System.Runtime.CompilerServices;
using static Flecs.NET.Bindings.flecs;

namespace Flecs.NET.Core;

/// <inheritdoc cref="IterIterable"/>
/// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam>
public partial struct WorkerIterable<T0, T1, T2, T3, T4, T5> : IEquatable<WorkerIterable<T0, T1, T2, T3, T4, T5>>
{
    private WorkerIterable _workerIterable;

    /// <summary>
    ///     Creates a worker iterable.
    /// </summary>
    /// <param name="workerIterable">The worker iterable.</param>
    public WorkerIterable(WorkerIterable workerIterable)
    {
        _workerIterable = workerIterable;
    }

    /// <inheritdoc cref="WorkerIterable(ecs_iter_t, int, int)"/>
    public WorkerIterable(ecs_iter_t iter, int index, int count)
    {
        _workerIterable = new WorkerIterable(iter, index, count);
    }
    
    /// <inheritdoc cref="WorkerIterable.Equals(WorkerIterable)"/>
    public bool Equals(WorkerIterable<T0, T1, T2, T3, T4, T5> other)
    {
        return _workerIterable.Equals(other._workerIterable);
    }
    
    /// <inheritdoc cref="WorkerIterable.Equals(object)"/>
    public override bool Equals(object? obj)
    {
        return obj is WorkerIterable<T0, T1, T2, T3, T4, T5> other && Equals(other);
    }
    
    /// <inheritdoc cref="WorkerIterable.GetHashCode()"/>
    public override int GetHashCode()
    {
        return _workerIterable.GetHashCode();
    }
    
    /// <inheritdoc cref="WorkerIterable.op_Equality"/>
    public static bool operator ==(WorkerIterable<T0, T1, T2, T3, T4, T5> left, WorkerIterable<T0, T1, T2, T3, T4, T5> right)
    {
        return left.Equals(right);
    }
    
    /// <inheritdoc cref="WorkerIterable.op_Inequality"/>
    public static bool operator !=(WorkerIterable<T0, T1, T2, T3, T4, T5> left, WorkerIterable<T0, T1, T2, T3, T4, T5> right)
    {
        return !(left == right);
    }
}

// IIterableBase Interface
public unsafe partial struct WorkerIterable<T0, T1, T2, T3, T4, T5> : IIterableBase
{
    /// <inheritdoc cref="WorkerIterable.GetIter(ecs_world_t*)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ecs_iter_t GetIter(ecs_world_t* world = null)
    {
        return _workerIterable.GetIter(world);
    }
    
    /// <inheritdoc cref="WorkerIterable.GetNext(ecs_iter_t*)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool GetNext(ecs_iter_t* it)
    {
        return _workerIterable.GetNext(it);
    }
}

// IIterable<T0, T1, T2, T3, T4, T5> Interface
public unsafe partial struct WorkerIterable<T0, T1, T2, T3, T4, T5> : IIterable<T0, T1, T2, T3, T4, T5>
{
    /// <inheritdoc cref="WorkerIterable.Page(int, int)"/>
    public PageIterable<T0, T1, T2, T3, T4, T5> Page(int offset, int limit)
    {
        return new PageIterable<T0, T1, T2, T3, T4, T5>(_workerIterable.Page(offset, limit));
    }
    
    /// <inheritdoc cref="WorkerIterable.Worker(int, int)"/>
    public WorkerIterable<T0, T1, T2, T3, T4, T5> Worker(int index, int count)
    {
        return new WorkerIterable<T0, T1, T2, T3, T4, T5>(_workerIterable.Worker(index, count));
    }
    
    /// <inheritdoc cref="WorkerIterable.Iter(Flecs.NET.Core.World)"/>
    public IterIterable<T0, T1, T2, T3, T4, T5> Iter(World world = default)
    {
        return new(_workerIterable.Iter(world));
    }
    
    /// <inheritdoc cref="WorkerIterable.Iter(Flecs.NET.Core.Iter)"/>
    public IterIterable<T0, T1, T2, T3, T4, T5> Iter(Iter it)
    {
        return new(_workerIterable.Iter(it));
    }
    
    /// <inheritdoc cref="WorkerIterable.Iter(Flecs.NET.Core.Entity)"/>
    public IterIterable<T0, T1, T2, T3, T4, T5> Iter(Entity entity)
    {
        return new(_workerIterable.Iter(entity));
    }
    
    /// <inheritdoc cref="WorkerIterable.Count()"/>
    public int Count()
    {
        return _workerIterable.Count();
    }
    
    /// <inheritdoc cref="WorkerIterable.IsTrue()"/>
    public bool IsTrue()
    {
        return _workerIterable.IsTrue();
    }
    
    /// <inheritdoc cref="WorkerIterable.First()"/>
    public Entity First()
    {
        return _workerIterable.First();
    }
    
    /// <inheritdoc cref="WorkerIterable.SetVar(int, ulong)"/>
    public IterIterable<T0, T1, T2, T3, T4, T5> SetVar(int varId, ulong value)
    {
        return new(_workerIterable.SetVar(varId, value));
    }
    
    /// <inheritdoc cref="WorkerIterable.SetVar(string, ulong)"/>
    public IterIterable<T0, T1, T2, T3, T4, T5> SetVar(string name, ulong value)
    {
        return new(_workerIterable.SetVar(name, value));
    }
    
    /// <inheritdoc cref="WorkerIterable.SetVar(string, ecs_table_t*)"/>
    public IterIterable<T0, T1, T2, T3, T4, T5> SetVar(string name, ecs_table_t* value)
    {
        return new(_workerIterable.SetVar(name, value));
    }
    
    /// <inheritdoc cref="WorkerIterable.SetVar(string, ecs_table_range_t)"/>
    public IterIterable<T0, T1, T2, T3, T4, T5> SetVar(string name, ecs_table_range_t value)
    {
        return new(_workerIterable.SetVar(name, value));
    }
    
    /// <inheritdoc cref="WorkerIterable.SetVar(string, Table)"/>
    public IterIterable<T0, T1, T2, T3, T4, T5> SetVar(string name, Table value)
    {
        return new(_workerIterable.SetVar(name, value));
    }
    
    /// <inheritdoc cref="WorkerIterable.SetGroup(ulong)"/>
    public IterIterable<T0, T1, T2, T3, T4, T5> SetGroup(ulong groupId)
    {
        return new(_workerIterable.SetGroup(groupId));
    }
    
    /// <inheritdoc cref="WorkerIterable.SetGroup{T}()"/>
    public IterIterable<T0, T1, T2, T3, T4, T5> SetGroup<T>()
    {
        return new(_workerIterable.SetGroup<T>()); 
    }
}
﻿// Query/T10.g.cs
// File was auto-generated by /_/src/Flecs.NET.Codegen/Generators/Query.cs
#nullable enable

using System;
using System.Runtime.CompilerServices;

using static Flecs.NET.Bindings.flecs;

namespace Flecs.NET.Core;

/// <summary>
///     A type-safe wrapper around <see cref="Query"/> that takes 10 type arguments.
/// </summary>
/// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam> <typeparam name="T9">The T9 component type.</typeparam>
public unsafe partial struct Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> : IDisposable, IEquatable<Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>>
{
    private Query _query;

    /// <inheritdoc cref="Query.Handle"/>
    public ref ecs_query_t* Handle => ref _query.Handle;

    /// <inheritdoc cref="Query(ecs_query_t*)"/>
    public Query(ecs_query_t* query)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>.AssertNoTags();
        _query = new Query(query);
    }

    /// <inheritdoc cref="Query(ecs_world_t*, ulong)"/>
    public Query(ecs_world_t* world, ulong entity)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>.AssertNoTags();
        _query = new Query(world, entity);
    }

    /// <inheritdoc cref="Query(Core.Entity)"/>
    public Query(Entity entity)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>.AssertNoTags();
        _query = new Query(entity);
    }

    /// <inheritdoc cref="Query.Dispose()"/>
    public void Dispose()
    {
        _query.Dispose();
    }

    /// <inheritdoc cref="Query.Destruct()"/>
    public void Destruct()
    {
        _query.Destruct();
    }

    /// <inheritdoc cref="Query.Entity()"/>
    public Entity Entity()
    {
        return _query.Entity();
    }

    /// <inheritdoc cref="Query.CPtr()"/>
    public ecs_query_t* CPtr()
    {
        return _query.CPtr();
    }

    /// <inheritdoc cref="Query.Changed()"/>
    public bool Changed()
    {
        return _query.Changed();
    }

    /// <inheritdoc cref="Query.GroupInfo(ulong)"/>
    public ecs_query_group_info_t* GroupInfo(ulong groupId)
    {
        return _query.GroupInfo(groupId);
    }

    /// <inheritdoc cref="Query.GroupCtx(ulong)"/>
    public void* GroupCtx(ulong groupId)
    {
        return _query.GroupCtx(groupId);
    }

    /// <inheritdoc cref="Query.EachTerm(Ecs.TermCallback)"/>
    public void EachTerm(Ecs.TermCallback callback)
    {
        _query.EachTerm(callback);
    }

    /// <inheritdoc cref="Query.Term(int)"/>
    public Term Term(int index)
    {
        return _query.Term(index);
    }

    /// <inheritdoc cref="Query.TermCount()"/>
    public int TermCount()
    {
        return _query.TermCount();
    }

    /// <inheritdoc cref="Query.FieldCount()"/>
    public int FieldCount()
    {
        return _query.FieldCount();
    }

    /// <inheritdoc cref="Query.FindVar(string)"/>
    public int FindVar(string name)
    {
        return _query.FindVar(name);
    }

    /// <inheritdoc cref="Query.Str()"/>
    public string Str()
    {
        return _query.Str();
    }

    /// <inheritdoc cref="Query.Plan()"/>
    public string Plan()
    {
        return _query.Plan();
    }

    /// <inheritdoc cref="Query.To(Query)"/>
    public static ecs_query_t* To(Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> query)
    {
        return query.Handle;
    }

    /// <inheritdoc cref="Query.ToBoolean(Query)"/>
    public static bool ToBoolean(Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> query)
    {
        return query.Handle != null;
    }

    /// <inheritdoc cref="Query.To(Query)"/>
    public static implicit operator ecs_query_t*(Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> query)
    {
        return To(query);
    }

    /// <inheritdoc cref="Query.ToBoolean(Query)"/>
    public static implicit operator bool(Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> query)
    {
        return ToBoolean(query);
    }

    /// <inheritdoc cref="Query.Equals(Query)"/>
    public bool Equals(Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> other)
    {
        return _query.Equals(other._query);
    }

    /// <inheritdoc cref="Query.Equals(object)"/>
    public override bool Equals(object? obj)
    {
        return obj is Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> other && Equals(other);
    }

    /// <inheritdoc cref="Query.GetHashCode()"/>
    public override int GetHashCode()
    {
        return _query.GetHashCode();
    }

    /// <inheritdoc cref="Query.op_Equality"/>
    public static bool operator ==(Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> left, Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> right)
    {
        return left.Equals(right);
    }

    /// <inheritdoc cref="Query.op_Inequality"/>
    public static bool operator !=(Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> left, Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> right)
    {
        return !(left == right);
    }
}

// IIterableBase Interface
public unsafe partial struct Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> : IIterableBase
{
    /// <inheritdoc cref="Query.GetIter(ecs_world_t*)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ecs_iter_t GetIter(ecs_world_t* world = null)
    {
        return _query.GetIter();
    }
    
    /// <inheritdoc cref="Query.GetNext(ecs_iter_t*)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool GetNext(ecs_iter_t* it)
    {
        return _query.GetNext(it);
    }
}

// IIterable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Interface
public unsafe partial struct Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> : IIterable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
{
    /// <inheritdoc cref="Query.Page(int, int)"/>
    public PageIterable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Page(int offset, int limit)
    {
        return new PageIterable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(_query.Page(offset, limit));
    }
    
    /// <inheritdoc cref="Query.Worker(int, int)"/>
    public WorkerIterable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Worker(int index, int count)
    {
        return new WorkerIterable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(_query.Worker(index, count));
    }

    /// <inheritdoc cref="Query.Iter(Flecs.NET.Core.World)"/>
    public IterIterable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Iter(World world = default)
    {
        return new IterIterable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(_query.Iter(world));
    }
    
    /// <inheritdoc cref="Query.Iter(Flecs.NET.Core.Iter)"/>
    public IterIterable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Iter(Iter it)
    {
        return new IterIterable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(_query.Iter(it));
    }
    
    /// <inheritdoc cref="Query.Iter(Flecs.NET.Core.Entity)"/>
    public IterIterable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Iter(Entity entity)
    {
        return new IterIterable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(_query.Iter(entity));
    }
    
    /// <inheritdoc cref="Query.Count()"/>
    public int Count()
    {
        return _query.Count();
    }
    
    /// <inheritdoc cref="Query.IsTrue()"/>
    public bool IsTrue()
    {
        return _query.IsTrue();
    }
    
    /// <inheritdoc cref="Query.First()"/>
    public Entity First()
    {
        return _query.First();
    }
    
    /// <inheritdoc cref="Query.SetVar(int, ulong)"/>
    public IterIterable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> SetVar(int varId, ulong value)
    {
        return new IterIterable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(_query.SetVar(varId, value));
    }
    
    /// <inheritdoc cref="Query.SetVar(string, ulong)"/>
    public IterIterable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> SetVar(string name, ulong value)
    {
        return new IterIterable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(_query.SetVar(name, value));
    }
    
    /// <inheritdoc cref="Query.SetVar(string, ecs_table_t*)"/>
    public IterIterable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> SetVar(string name, ecs_table_t* value)
    {
        return new IterIterable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(_query.SetVar(name, value));
    }
    
    /// <inheritdoc cref="Query.SetVar(string, ecs_table_range_t)"/>
    public IterIterable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> SetVar(string name, ecs_table_range_t value)
    {
        return new IterIterable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(_query.SetVar(name, value));
    }
    
    /// <inheritdoc cref="Query.SetVar(string, Table)"/>
    public IterIterable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> SetVar(string name, Table value)
    {
        return new IterIterable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(_query.SetVar(name, value));
    }
    
    /// <inheritdoc cref="Query.SetGroup(ulong)"/>
    public IterIterable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> SetGroup(ulong groupId)
    {
        return new IterIterable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(_query.SetGroup(groupId));
    }
    
    /// <inheritdoc cref="Query.SetGroup{T}()"/>
    public IterIterable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> SetGroup<T>()
    {
        return new IterIterable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(_query.SetGroup<T>());
    }
}
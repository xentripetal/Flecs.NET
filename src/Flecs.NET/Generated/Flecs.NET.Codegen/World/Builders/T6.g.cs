﻿// Builders/T6.g.cs
// File was auto-generated by /_/src/Flecs.NET.Codegen/Generators/World.cs
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace Flecs.NET.Core;

public unsafe partial struct World
{
    public AlertBuilder AlertBuilder<T0, T1, T2, T3, T4, T5>()
    {
        return new AlertBuilder(Handle).With<T0>().With<T1>().With<T2>().With<T3>().With<T4>().With<T5>();
    }

    public AlertBuilder AlertBuilder<T0, T1, T2, T3, T4, T5>(string name)
    {
        return new AlertBuilder(Handle, name).With<T0>().With<T1>().With<T2>().With<T3>().With<T4>().With<T5>();
    }

    public AlertBuilder AlertBuilder<T0, T1, T2, T3, T4, T5>(ulong entity)
    {
        return new AlertBuilder(Handle, entity).With<T0>().With<T1>().With<T2>().With<T3>().With<T4>().With<T5>();
    }

    public Alert Alert<T0, T1, T2, T3, T4, T5>()
    {
        return AlertBuilder<T0, T1, T2, T3, T4, T5>().Build();
    }

    public Alert Alert<T0, T1, T2, T3, T4, T5>(string name)
    {
        return AlertBuilder<T0, T1, T2, T3, T4, T5>(name).Build();
    }

    public Alert Alert<T0, T1, T2, T3, T4, T5>(ulong entity)
    {
        return AlertBuilder<T0, T1, T2, T3, T4, T5>(entity).Build();
    }
    
    public QueryBuilder<T0, T1, T2, T3, T4, T5> QueryBuilder<T0, T1, T2, T3, T4, T5>()
    {
        return new QueryBuilder<T0, T1, T2, T3, T4, T5>(Handle);
    }

    public QueryBuilder<T0, T1, T2, T3, T4, T5> QueryBuilder<T0, T1, T2, T3, T4, T5>(string name)
    {
        return new QueryBuilder<T0, T1, T2, T3, T4, T5>(Handle, name);
    }

    public QueryBuilder<T0, T1, T2, T3, T4, T5> QueryBuilder<T0, T1, T2, T3, T4, T5>(ulong entity)
    {
        return new QueryBuilder<T0, T1, T2, T3, T4, T5>(Handle, entity);
    }

    public Query<T0, T1, T2, T3, T4, T5> Query<T0, T1, T2, T3, T4, T5>()
    {
        return new QueryBuilder<T0, T1, T2, T3, T4, T5>(Handle).Build();
    }

    public Query<T0, T1, T2, T3, T4, T5> Query<T0, T1, T2, T3, T4, T5>(string name)
    {
        return new QueryBuilder<T0, T1, T2, T3, T4, T5>(Handle, name).Build();
    }

    public Query<T0, T1, T2, T3, T4, T5> Query<T0, T1, T2, T3, T4, T5>(ulong entity)
    {
        return new QueryBuilder<T0, T1, T2, T3, T4, T5>(Handle, entity).Build();
    }

    public RoutineBuilder<T0, T1, T2, T3, T4, T5> Routine<T0, T1, T2, T3, T4, T5>()
    {
        return new RoutineBuilder<T0, T1, T2, T3, T4, T5>(Handle);
    }

    public RoutineBuilder<T0, T1, T2, T3, T4, T5> Routine<T0, T1, T2, T3, T4, T5>(string name)
    {
        return new RoutineBuilder<T0, T1, T2, T3, T4, T5>(Handle, name);
    }

    public ObserverBuilder<T0, T1, T2, T3, T4, T5> Observer<T0, T1, T2, T3, T4, T5>()
    {
        return new ObserverBuilder<T0, T1, T2, T3, T4, T5>(Handle);
    }

    public ObserverBuilder<T0, T1, T2, T3, T4, T5> Observer<T0, T1, T2, T3, T4, T5>(string name)
    {
        return new ObserverBuilder<T0, T1, T2, T3, T4, T5>(Handle, name);
    }
}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
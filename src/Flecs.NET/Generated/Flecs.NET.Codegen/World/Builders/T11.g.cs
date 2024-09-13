﻿// Builders/T11.g.cs
// File was auto-generated by /_/src/Flecs.NET.Codegen/Generators/World.cs
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace Flecs.NET.Core;

public unsafe partial struct World
{
    public AlertBuilder AlertBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>()
    {
        return new AlertBuilder(Handle).With<T0>().With<T1>().With<T2>().With<T3>().With<T4>().With<T5>().With<T6>().With<T7>().With<T8>().With<T9>().With<T10>();
    }

    public AlertBuilder AlertBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string name)
    {
        return new AlertBuilder(Handle, name).With<T0>().With<T1>().With<T2>().With<T3>().With<T4>().With<T5>().With<T6>().With<T7>().With<T8>().With<T9>().With<T10>();
    }

    public AlertBuilder AlertBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ulong entity)
    {
        return new AlertBuilder(Handle, entity).With<T0>().With<T1>().With<T2>().With<T3>().With<T4>().With<T5>().With<T6>().With<T7>().With<T8>().With<T9>().With<T10>();
    }

    public Alert Alert<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>()
    {
        return AlertBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>().Build();
    }

    public Alert Alert<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string name)
    {
        return AlertBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(name).Build();
    }

    public Alert Alert<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ulong entity)
    {
        return AlertBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(entity).Build();
    }
    
    public QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>()
    {
        return new QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Handle);
    }

    public QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string name)
    {
        return new QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Handle, name);
    }

    public QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ulong entity)
    {
        return new QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Handle, entity);
    }

    public Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>()
    {
        return new QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Handle).Build();
    }

    public Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string name)
    {
        return new QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Handle, name).Build();
    }

    public Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ulong entity)
    {
        return new QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Handle, entity).Build();
    }

    public SystemBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> System<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>()
    {
        return new SystemBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Handle);
    }

    public SystemBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> System<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string name)
    {
        return new SystemBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Handle, name);
    }

    public ObserverBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Observer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>()
    {
        return new ObserverBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Handle);
    }

    public ObserverBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Observer<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string name)
    {
        return new ObserverBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Handle, name);
    }
}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
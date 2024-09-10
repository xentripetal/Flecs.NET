﻿// Routine/T4.g.cs
// File was auto-generated by /_/src/Flecs.NET.Codegen/Generators/Routine.cs
#nullable enable

using System;
using static Flecs.NET.Bindings.flecs;

namespace Flecs.NET.Core;

/// <summary>
///     A type-safe wrapper around <see cref="Routine"/> that takes 4 type arguments.
/// </summary>
/// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam>
public unsafe struct Routine<T0, T1, T2, T3> : IEquatable<Routine<T0, T1, T2, T3>>, IEntity
{
    private Routine _routine;

    /// <inheritdoc cref="Routine.Entity"/>
    public ref Entity Entity => ref _routine.Entity;

    /// <inheritdoc cref="Routine.Id"/>
    public ref Id Id => ref _routine.Id;

    /// <inheritdoc cref="Routine.World"/>
    public ref ecs_world_t* World => ref _routine.World;

    /// <summary>
    ///     Creates a new routine with the provided routine.
    /// </summary>
    /// <param name="routine">The routine.</param>
    public Routine(Routine routine)
    {
        TypeHelper<T0, T1, T2, T3>.AssertNoTags();
        _routine = routine;
    }

    /// <inheritdoc cref="Routine(ecs_world_t*, ulong)"/>
    public Routine(ecs_world_t* world, ulong entity)
    {
        TypeHelper<T0, T1, T2, T3>.AssertNoTags();
        _routine = new Routine(world, entity);
    }

    /// <inheritdoc cref="Routine(Core.Entity)"/>
    public Routine(Entity entity)
    {
        TypeHelper<T0, T1, T2, T3>.AssertNoTags();
        _routine = new Routine(entity);
    }

    /// <inheritdoc cref="Routine.Destruct()"/>
    public void Destruct()
    {
        _routine.Destruct();
    }

    ///
    public void Ctx(void* ctx)
    {
        _routine.Ctx(ctx);
    }

    /// <inheritdoc cref="Routine.Ctx()"/>
    public void* Ctx()
    {
        return _routine.Ctx();
    }

    /// <inheritdoc cref="Routine.Query()"/>
    public Query<T0> Query()
    {
        return new Query<T0>(ecs_system_get(World, Entity)->query);
    }

    /// <inheritdoc cref="Routine.Run(float)"/>
    public void Run(float deltaTime = 0)
    {
        _routine.Run(deltaTime);
    }

    /// <inheritdoc cref="Routine.RunWithParam"/>
    public void RunWithParam(float deltaTime = 0, void* param = null)
    {
        _routine.RunWithParam(deltaTime, param);
    }

    /// <inheritdoc cref="Routine.RunWorker"/>
    public void RunWorker(int stageCurrent, int stageCount, float deltaTime = 0)
    {
        _routine.RunWorker(stageCurrent, stageCount, deltaTime);
    }

    /// <inheritdoc cref="Routine.RunWorkerWithParam"/>
    public void RunWorkerWithParam(int stageCurrent, int stageCount, float deltaTime = 0, void* param = null)
    {
        _routine.RunWorkerWithParam(stageCurrent, stageCount, deltaTime, param);
    }

    /// <inheritdoc cref="Routine.Interval(float)"/>
    public void Interval(float interval)
    {
        _routine.Interval(interval);
    }

    /// <inheritdoc cref="Routine.Interval()"/>
    public float Interval()
    {
        return _routine.Interval();
    }

    /// <inheritdoc cref="Routine.Timeout(float)"/>
    public void Timeout(float timeout)
    {
        _routine.Timeout(timeout);
    }

    /// <inheritdoc cref="Routine.Timeout()"/>
    public float Timeout()
    {
        return _routine.Timeout();
    }

    /// <inheritdoc cref="Routine.Rate(int)"/>
    public void Rate(int rate)
    {
        _routine.Rate(rate);
    }

    /// <inheritdoc cref="Routine.Start()"/>
    public void Start()
    {
        _routine.Start();
    }

    /// <inheritdoc cref="Routine.StopTimer()"/>
    public void StopTimer()
    {
        _routine.StopTimer();
    }

    /// <inheritdoc cref="Routine.SetTickSource(ulong)"/>
    public void SetTickSource(ulong entity)
    {
        _routine.SetTickSource(entity);
    }

    /// <inheritdoc cref="Routine.SetTickSource(TimerEntity)"/>
    public void SetTickSource(TimerEntity timerEntity)
    {
        _routine.SetTickSource(timerEntity);
    }

    /// <inheritdoc cref="Routine.SetTickSource{T}()"/>
    public void SetTickSource<T>()
    {
        _routine.SetTickSource<T>();
    }

    /// <inheritdoc cref="Routine.ToUInt64"/>
    public static implicit operator ulong(Routine<T0, T1, T2, T3> routine)
    {
        return ToUInt64(routine);
    }

    /// <inheritdoc cref="Routine.ToId"/>
    public static implicit operator Id(Routine<T0, T1, T2, T3> routine)
    {
        return ToId(routine);
    }

    /// <inheritdoc cref="Routine.ToEntity"/>
    public static implicit operator Entity(Routine<T0, T1, T2, T3> routine)
    {
        return ToEntity(routine);
    }

    /// <inheritdoc cref="Routine.ToUInt64"/>
    public static ulong ToUInt64(Routine<T0, T1, T2, T3> routine)
    {
        return routine.Entity;
    }

    /// <inheritdoc cref="Routine.ToId"/>
    public static Id ToId(Routine<T0, T1, T2, T3> routine)
    {
        return routine.Id;
    }

    /// <inheritdoc cref="Routine.ToEntity"/>
    public static Entity ToEntity(Routine<T0, T1, T2, T3> routine)
    {
        return routine.Entity;
    }

    /// <inheritdoc cref="Routine.ToString()"/>
    public override string ToString()
    {
        return _routine.ToString();
    }

    /// <inheritdoc cref="Routine.Equals(Routine)"/>
    public bool Equals(Routine<T0, T1, T2, T3> other)
    {
        return _routine == other._routine;
    }

    /// <inheritdoc cref="Routine.Equals(object)"/>
    public override bool Equals(object? obj)
    {
        return obj is Routine<T0, T1, T2, T3> routine && Equals(routine);
    }

    /// <inheritdoc cref="Routine.GetHashCode()"/>
    public override int GetHashCode()
    {
        return _routine.GetHashCode();
    }

    /// <inheritdoc cref="Routine.op_Equality"/>
    public static bool operator ==(Routine<T0, T1, T2, T3> left, Routine<T0, T1, T2, T3> right)
    {
        return left.Equals(right);
    }

    /// <inheritdoc cref="Routine.op_Inequality"/>
    public static bool operator !=(Routine<T0, T1, T2, T3> left, Routine<T0, T1, T2, T3> right)
    {
        return !(left == right);
    }
}
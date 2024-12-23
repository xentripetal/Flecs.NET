// /_/src/Flecs.NET/Generated/PipelineBuilder/PipelineBuilder/T6.g.cs
// File was auto-generated by /_/src/Flecs.NET.Codegen/Generators/PipelineBuilder.cs
#nullable enable

using System;
using static Flecs.NET.Bindings.flecs;

namespace Flecs.NET.Core;

/// <summary>
///     A type-safe wrapper around <see cref="PipelineBuilder"/> that takes 6 type arguments.
/// </summary>
/// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam>
public unsafe partial struct PipelineBuilder<T0, T1, T2, T3, T4, T5> : IEquatable<PipelineBuilder<T0, T1, T2, T3, T4, T5>>, IQueryBuilder<PipelineBuilder<T0, T1, T2, T3, T4, T5>, Pipeline<T0, T1, T2, T3, T4, T5>>
{
    private PipelineBuilder _pipelineBuilder;

    /// <inheritdoc cref="PipelineBuilder.World"/>
    public ref ecs_world_t* World => ref _pipelineBuilder.World;
    
    /// <inheritdoc cref="PipelineBuilder.Desc"/>
    public ref ecs_pipeline_desc_t Desc => ref _pipelineBuilder.Desc;
    
    /// <inheritdoc cref="PipelineBuilder.QueryBuilder"/>
    public ref QueryBuilder QueryBuilder => ref _pipelineBuilder.QueryBuilder;

    /// <inheritdoc cref="PipelineBuilder(ecs_world_t*)"/>
    public PipelineBuilder(ecs_world_t* world)
    {
        _pipelineBuilder = new PipelineBuilder(world).With<T0>().With<T1>().With<T2>().With<T3>().With<T4>().With<T5>();
    }

    /// <inheritdoc cref="PipelineBuilder(ecs_world_t*, ulong)"/>
    public PipelineBuilder(ecs_world_t* world, ulong entity)
    {
        _pipelineBuilder = new PipelineBuilder(world, entity).With<T0>().With<T1>().With<T2>().With<T3>().With<T4>().With<T5>();
    }

    /// <inheritdoc cref="PipelineBuilder(ecs_world_t*, string)"/>
    public PipelineBuilder(ecs_world_t* world, string name)
    {
        _pipelineBuilder = new PipelineBuilder(world, name).With<T0>().With<T1>().With<T2>().With<T3>().With<T4>().With<T5>();
    }

    /// <inheritdoc cref="PipelineBuilder.Build()"/>
    public Pipeline<T0, T1, T2, T3, T4, T5> Build()
    {
        return new Pipeline<T0, T1, T2, T3, T4, T5>(_pipelineBuilder.Build());
    }
    
    /// <inheritdoc cref="PipelineBuilder.Equals(PipelineBuilder)"/>
    public bool Equals(PipelineBuilder<T0, T1, T2, T3, T4, T5> other)
    {
        return _pipelineBuilder == other._pipelineBuilder;
    }

    /// <inheritdoc cref="PipelineBuilder.Equals(object)"/>
    public override bool Equals(object? obj)
    {
        return obj is PipelineBuilder<T0, T1, T2, T3, T4, T5>  other && Equals(other);
    }

    /// <inheritdoc cref="PipelineBuilder.GetHashCode()"/>
    public override int GetHashCode()
    {
        return _pipelineBuilder.GetHashCode();
    }

    /// <inheritdoc cref="PipelineBuilder.op_Equality"/>
    public static bool operator ==(PipelineBuilder<T0, T1, T2, T3, T4, T5> left, PipelineBuilder<T0, T1, T2, T3, T4, T5> right)
    {
        return left.Equals(right);
    }

    /// <inheritdoc cref="PipelineBuilder.op_Inequality"/>
    public static bool operator !=(PipelineBuilder<T0, T1, T2, T3, T4, T5> left, PipelineBuilder<T0, T1, T2, T3, T4, T5> right)
    {
        return !(left == right);
    }
}
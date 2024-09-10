﻿// QueryBuilder/T11.g.cs
// File was auto-generated by /_/src/Flecs.NET.Codegen/Generators/QueryBuilder.cs
#nullable enable

using static Flecs.NET.Bindings.flecs;

namespace Flecs.NET.Core;

/// <summary>
///     A type-safe wrapper around <see cref="QueryBuilder"/> that takes 11 type arguments.
/// </summary>
/// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam> <typeparam name="T9">The T9 component type.</typeparam> <typeparam name="T10">The T10 component type.</typeparam>
public unsafe partial struct QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : IQueryBuilder<QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>
{
    private QueryBuilder _queryBuilder;

    ref QueryBuilder IQueryBuilderBase.QueryBuilder => ref _queryBuilder;
    
    /// <inheritdoc cref="QueryBuilder.World"/>
    public ref ecs_world_t* World => ref _queryBuilder.World;
    
    /// <inheritdoc cref="QueryBuilder.Desc"/>
    public ref ecs_query_desc_t Desc => ref _queryBuilder.Desc;

    /// <inheritdoc cref="QueryBuilder(ecs_world_t*)"/>
    public QueryBuilder(ecs_world_t* world)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.AssertNoTags();
        _queryBuilder = new QueryBuilder(world).With<T0>().With<T1>().With<T2>().With<T3>().With<T4>().With<T5>().With<T6>().With<T7>().With<T8>().With<T9>().With<T10>();
    }

    /// <inheritdoc cref="QueryBuilder(ecs_world_t*, ulong)"/>
    public QueryBuilder(ecs_world_t* world, ulong entity)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.AssertNoTags();
        _queryBuilder = new QueryBuilder(world, entity).With<T0>().With<T1>().With<T2>().With<T3>().With<T4>().With<T5>().With<T6>().With<T7>().With<T8>().With<T9>().With<T10>();
    }

    /// <inheritdoc cref="QueryBuilder(ecs_world_t*, string)"/>
    public QueryBuilder(ecs_world_t* world, string name)
    {
        TypeHelper<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.AssertNoTags();
        _queryBuilder = new QueryBuilder(world, name).With<T0>().With<T1>().With<T2>().With<T3>().With<T4>().With<T5>().With<T6>().With<T7>().With<T8>().With<T9>().With<T10>();
    }

    /// <inheritdoc cref="QueryBuilder.Build()"/>
    public Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Build()
    {
        return new Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(_queryBuilder.Build());
    }
    
    /// <inheritdoc cref="QueryBuilder.Equals(QueryBuilder)"/>
    public bool Equals(QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> other)
    {
        return _queryBuilder == other._queryBuilder;
    }

    /// <inheritdoc cref="QueryBuilder.Equals(object)"/>
    public override bool Equals(object? obj)
    {
        return obj is QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>  other && Equals(other);
    }

    /// <inheritdoc cref="QueryBuilder.GetHashCode()"/>
    public override int GetHashCode()
    {
        return _queryBuilder.GetHashCode();
    }

    /// <inheritdoc cref="QueryBuilder.op_Equality"/>
    public static bool operator ==(QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> left, QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> right)
    {
        return left.Equals(right);
    }

    /// <inheritdoc cref="QueryBuilder.op_Inequality"/>
    public static bool operator !=(QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> left, QueryBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> right)
    {
        return !(left == right);
    }
}
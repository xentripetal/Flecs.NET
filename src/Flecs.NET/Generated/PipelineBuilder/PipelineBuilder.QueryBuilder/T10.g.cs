// /_/src/Flecs.NET/Generated/PipelineBuilder/PipelineBuilder.QueryBuilder/T10.g.cs
// File was auto-generated by /_/src/Flecs.NET.Codegen/Generators/PipelineBuilder.cs
using System;
using static Flecs.NET.Bindings.flecs;

namespace Flecs.NET.Core;

public unsafe partial struct PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
{
    /// <inheritdoc cref="Core.QueryBuilder.Self()"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Self()
    {
        Ecs.GetQueryBuilder(ref this).Self();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Id(ulong)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Id(ulong id)
    {
        Ecs.GetQueryBuilder(ref this).Id(id);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Entity(ulong)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Entity(ulong entity)
    {
        Ecs.GetQueryBuilder(ref this).Entity(entity);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Name(string)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Name(string name)
    {
        Ecs.GetQueryBuilder(ref this).Name(name);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Var(string)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Var(string name)
    {
        Ecs.GetQueryBuilder(ref this).Var(name);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Term(ulong)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Term(ulong id)
    {
        Ecs.GetQueryBuilder(ref this).Term(id);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Src()"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Src()
    {
        Ecs.GetQueryBuilder(ref this).Src();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.First()"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> First()
    {
        Ecs.GetQueryBuilder(ref this).First();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Second()"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Second()
    {
        Ecs.GetQueryBuilder(ref this).Second();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Src(ulong)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Src(ulong srcId)
    {
        Ecs.GetQueryBuilder(ref this).Src(srcId);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Src{T}()"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Src<T>()
    {
        Ecs.GetQueryBuilder(ref this).Src<T>();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Src{T}(T)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Src<T>(T value) where T : Enum
    {
        Ecs.GetQueryBuilder(ref this).Src(value);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Src(string)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Src(string name)
    {
        Ecs.GetQueryBuilder(ref this).Src(name);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.First(ulong)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> First(ulong firstId)
    {
        Ecs.GetQueryBuilder(ref this).First(firstId);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.First{T}()"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> First<T>()
    {
        Ecs.GetQueryBuilder(ref this).First<T>();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.First{T}(T)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> First<T>(T value) where T : Enum
    {
        Ecs.GetQueryBuilder(ref this).First(value);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.First(string)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> First(string name)
    {
        Ecs.GetQueryBuilder(ref this).First(name);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Second(ulong)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Second(ulong secondId)
    {
        Ecs.GetQueryBuilder(ref this).Second(secondId);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Second{T}()"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Second<T>()
    {
        Ecs.GetQueryBuilder(ref this).Second<T>();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Second{T}(T)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Second<T>(T value) where T : Enum
    {
        Ecs.GetQueryBuilder(ref this).Second(value);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Second(string)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Second(string secondName)
    {
        Ecs.GetQueryBuilder(ref this).Second(secondName);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Up(ulong)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Up(ulong traverse = 0)
    {
        Ecs.GetQueryBuilder(ref this).Up(traverse);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Up{T}()"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Up<T>()
    {
        Ecs.GetQueryBuilder(ref this).Up<T>();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Up{T}(T)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Up<T>(T value) where T : Enum
    {
        Ecs.GetQueryBuilder(ref this).Up(value);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Cascade(ulong)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Cascade(ulong traverse = 0)
    {
        Ecs.GetQueryBuilder(ref this).Cascade(traverse);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Cascade{T}()"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Cascade<T>()
    {
        Ecs.GetQueryBuilder(ref this).Cascade<T>();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Cascade{T}(T)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Cascade<T>(T value) where T : Enum
    {
        Ecs.GetQueryBuilder(ref this).Cascade(value);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Descend()"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Descend()
    {
        Ecs.GetQueryBuilder(ref this).Descend();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Parent()"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Parent()
    {
        Ecs.GetQueryBuilder(ref this).Parent();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Trav(ulong, uint)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Trav(ulong traverse, uint flags = 0)
    {
        Ecs.GetQueryBuilder(ref this).Trav(traverse, flags);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Trav{T}(uint)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Trav<T>(uint flags = 0)
    {
        Ecs.GetQueryBuilder(ref this).Trav<T>(flags);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Trav{T}(T, uint)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Trav<T>(T value, uint flags = 0) where T : Enum
    {
        Ecs.GetQueryBuilder(ref this).Trav(value, flags);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Flags"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Flags(ulong flags)
    {
        Ecs.GetQueryBuilder(ref this).Flags(flags);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.InOut(ecs_inout_kind_t)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> InOut(ecs_inout_kind_t inOut)
    {
        Ecs.GetQueryBuilder(ref this).InOut(inOut);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.InOutStage(ecs_inout_kind_t)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> InOutStage(ecs_inout_kind_t inOut)
    {
        Ecs.GetQueryBuilder(ref this).InOutStage(inOut);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Write()"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Write()
    {
        Ecs.GetQueryBuilder(ref this).Write();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Read()"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Read()
    {
        Ecs.GetQueryBuilder(ref this).Read();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.ReadWrite()"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ReadWrite()
    {
        Ecs.GetQueryBuilder(ref this).ReadWrite();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.In()"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> In()
    {
        Ecs.GetQueryBuilder(ref this).In();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Out()"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Out()
    {
        Ecs.GetQueryBuilder(ref this).Out();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.InOut()"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> InOut()
    {
        Ecs.GetQueryBuilder(ref this).InOut();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.InOutNone()"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> InOutNone()
    {
        Ecs.GetQueryBuilder(ref this).InOutNone();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Oper(ecs_oper_kind_t)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Oper(ecs_oper_kind_t oper)
    {
        Ecs.GetQueryBuilder(ref this).Oper(oper);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.And()"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> And()
    {
        Ecs.GetQueryBuilder(ref this).And();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Or()"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Or()
    {
        Ecs.GetQueryBuilder(ref this).Or();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Not()"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Not()
    {
        Ecs.GetQueryBuilder(ref this).Not();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Optional()"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Optional()
    {
        Ecs.GetQueryBuilder(ref this).Optional();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.AndFrom()"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> AndFrom()
    {
        Ecs.GetQueryBuilder(ref this).AndFrom();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.OrFrom()"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> OrFrom()
    {
        Ecs.GetQueryBuilder(ref this).OrFrom();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.NotFrom()"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> NotFrom()
    {
        Ecs.GetQueryBuilder(ref this).NotFrom();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Singleton()"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Singleton()
    {
        Ecs.GetQueryBuilder(ref this).Singleton();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Filter()"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Filter()
    {
        Ecs.GetQueryBuilder(ref this).Filter();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.QueryFlags"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> QueryFlags(uint flags)
    {
        Ecs.GetQueryBuilder(ref this).QueryFlags(flags);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.CacheKind(ecs_query_cache_kind_t)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> CacheKind(ecs_query_cache_kind_t kind)
    {
        Ecs.GetQueryBuilder(ref this).CacheKind(kind);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Cached()"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Cached()
    {
        Ecs.GetQueryBuilder(ref this).Cached();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Expr(string)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Expr(string expr)
    {
        Ecs.GetQueryBuilder(ref this).Expr(expr);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.With(Core.Term)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> With(Term term)
    {
        Ecs.GetQueryBuilder(ref this).With(term);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.With(ulong)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> With(ulong id)
    {
        Ecs.GetQueryBuilder(ref this).With(id);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.With(string)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> With(string name)
    {
        Ecs.GetQueryBuilder(ref this).With(name);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.With(ulong, ulong)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> With(ulong first, ulong second)
    {
        Ecs.GetQueryBuilder(ref this).With(first, second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.With(ulong, string)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> With(ulong first, string second)
    {
        Ecs.GetQueryBuilder(ref this).With(first, second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.With(string, ulong)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> With(string first, ulong second)
    {
        Ecs.GetQueryBuilder(ref this).With(first, second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.With(string, string)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> With(string first, string second)
    {
        Ecs.GetQueryBuilder(ref this).With(first, second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.With{T}()"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> With<T>()
    {
        Ecs.GetQueryBuilder(ref this).With<T>();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.With{T}(T)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> With<T>(T value) where T : Enum
    {
        Ecs.GetQueryBuilder(ref this).With(value);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.With{T1}(ulong)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> With<TFirst>(ulong second)
    {
        Ecs.GetQueryBuilder(ref this).With<TFirst>(second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.With{T1}(string)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> With<TFirst>(string second)
    {
        Ecs.GetQueryBuilder(ref this).With<TFirst>(second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.With{T1, T2}()"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> With<TFirst, TSecond>()
    {
        Ecs.GetQueryBuilder(ref this).With<TFirst, TSecond>();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.With{T1, T2}(T2)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> With<TFirst, TSecond>(TSecond second) where TSecond : Enum
    {
        Ecs.GetQueryBuilder(ref this).With<TFirst, TSecond>(second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.With{T1, T2}(T1)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> With<TFirst, TSecond>(TFirst first) where TFirst : Enum
    {
        Ecs.GetQueryBuilder(ref this).With<TFirst, TSecond>(first);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.With{T1}(T1, string)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> With<TFirst>(TFirst first, string second) where TFirst : Enum
    {
        Ecs.GetQueryBuilder(ref this).With(first, second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.With{T2}(string, T2)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> With<TSecond>(string first, TSecond second) where TSecond : Enum
    {
        Ecs.GetQueryBuilder(ref this).With(first, second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.WithSecond{T2}(ulong)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> WithSecond<TSecond>(ulong first)
    {
        Ecs.GetQueryBuilder(ref this).WithSecond<TSecond>(first);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.WithSecond{T2}(string)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> WithSecond<TSecond>(string first)
    {
        Ecs.GetQueryBuilder(ref this).WithSecond<TSecond>(first);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Without(Core.Term)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Without(Term term)
    {
        Ecs.GetQueryBuilder(ref this).Without(term);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Without(ulong)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Without(ulong id)
    {
        Ecs.GetQueryBuilder(ref this).Without(id);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Without(string)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Without(string name)
    {
        Ecs.GetQueryBuilder(ref this).Without(name);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Without(ulong, ulong)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Without(ulong first, ulong second)
    {
        Ecs.GetQueryBuilder(ref this).Without(first, second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Without(ulong, string)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Without(ulong first, string second)
    {
        Ecs.GetQueryBuilder(ref this).Without(first, second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Without(string, ulong)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Without(string first, ulong second)
    {
        Ecs.GetQueryBuilder(ref this).Without(first, second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Without(string, string)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Without(string first, string second)
    {
        Ecs.GetQueryBuilder(ref this).Without(first, second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Without{T}()"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Without<T>()
    {
        Ecs.GetQueryBuilder(ref this).Without<T>();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Without{T}(T)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Without<T>(T value) where T : Enum
    {
        Ecs.GetQueryBuilder(ref this).Without(value);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Without{T1}(ulong)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Without<TFirst>(ulong second)
    {
        Ecs.GetQueryBuilder(ref this).Without<TFirst>(second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Without{T1}(string)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Without<TFirst>(string second)
    {
        Ecs.GetQueryBuilder(ref this).Without<TFirst>(second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Without{T1, T2}()"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Without<TFirst, TSecond>()
    {
        Ecs.GetQueryBuilder(ref this).Without<TFirst, TSecond>();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Without{T1, T2}(T2)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Without<TFirst, TSecond>(TSecond second) where TSecond : Enum
    {
        Ecs.GetQueryBuilder(ref this).Without<TFirst, TSecond>(second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Without{T1, T2}(T1)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Without<TFirst, TSecond>(TFirst first) where TFirst : Enum
    {
        Ecs.GetQueryBuilder(ref this).Without<TFirst, TSecond>(first);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Without{T1}(T1, string)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Without<TFirst>(TFirst first, string second) where TFirst : Enum
    {
        Ecs.GetQueryBuilder(ref this).Without(first, second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Without{T2}(string, T2)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Without<TSecond>(string first, TSecond second) where TSecond : Enum
    {
        Ecs.GetQueryBuilder(ref this).Without(first, second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.WithoutSecond{T2}(ulong)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> WithoutSecond<TSecond>(ulong first)
    {
        Ecs.GetQueryBuilder(ref this).WithoutSecond<TSecond>(first);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.WithoutSecond{T2}(string)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> WithoutSecond<TSecond>(string first)
    {
        Ecs.GetQueryBuilder(ref this).WithoutSecond<TSecond>(first);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Write(Core.Term)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Write(Term term)
    {
        Ecs.GetQueryBuilder(ref this).Write(term);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Write(ulong)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Write(ulong id)
    {
        Ecs.GetQueryBuilder(ref this).Write(id);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Write(string)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Write(string name)
    {
        Ecs.GetQueryBuilder(ref this).Write(name);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Write(ulong, ulong)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Write(ulong first, ulong second)
    {
        Ecs.GetQueryBuilder(ref this).Write(first, second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Write(ulong, string)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Write(ulong first, string second)
    {
        Ecs.GetQueryBuilder(ref this).Write(first, second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Write(string, ulong)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Write(string first, ulong second)
    {
        Ecs.GetQueryBuilder(ref this).Write(first, second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Write(string, string)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Write(string first, string second)
    {
        Ecs.GetQueryBuilder(ref this).Write(first, second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Write{T}()"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Write<T>()
    {
        Ecs.GetQueryBuilder(ref this).Write<T>();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Write{T}(T)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Write<T>(T value) where T : Enum
    {
        Ecs.GetQueryBuilder(ref this).Write(value);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Write{T1}(ulong)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Write<TFirst>(ulong second)
    {
        Ecs.GetQueryBuilder(ref this).Write<TFirst>(second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Write{T1}(string)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Write<TFirst>(string second)
    {
        Ecs.GetQueryBuilder(ref this).Write<TFirst>(second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Write{T1, T2}()"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Write<TFirst, TSecond>()
    {
        Ecs.GetQueryBuilder(ref this).Write<TFirst, TSecond>();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Write{T1, T2}(T2)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Write<TFirst, TSecond>(TSecond second) where TSecond : Enum
    {
        Ecs.GetQueryBuilder(ref this).Write<TFirst, TSecond>(second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Write{T1, T2}(T1)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Write<TFirst, TSecond>(TFirst first) where TFirst : Enum
    {
        Ecs.GetQueryBuilder(ref this).Write<TFirst, TSecond>(first);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Write{T1}(T1, string)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Write<TFirst>(TFirst first, string second) where TFirst : Enum
    {
        Ecs.GetQueryBuilder(ref this).Write(first, second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Write{T2}(string, T2)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Write<TSecond>(string first, TSecond second) where TSecond : Enum
    {
        Ecs.GetQueryBuilder(ref this).Write(first, second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.WriteSecond{T2}(ulong)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> WriteSecond<TSecond>(ulong first)
    {
        Ecs.GetQueryBuilder(ref this).WriteSecond<TSecond>(first);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.WriteSecond{T2}(string)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> WriteSecond<TSecond>(string first)
    {
        Ecs.GetQueryBuilder(ref this).WriteSecond<TSecond>(first);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Read(Core.Term)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Read(Term term)
    {
        Ecs.GetQueryBuilder(ref this).Read(term);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Read(ulong)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Read(ulong id)
    {
        Ecs.GetQueryBuilder(ref this).Read(id);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Read(string)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Read(string name)
    {
        Ecs.GetQueryBuilder(ref this).Read(name);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Read(ulong, ulong)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Read(ulong first, ulong second)
    {
        Ecs.GetQueryBuilder(ref this).Read(first, second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Read(ulong, string)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Read(ulong first, string second)
    {
        Ecs.GetQueryBuilder(ref this).Read(first, second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Read(string, ulong)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Read(string first, ulong second)
    {
        Ecs.GetQueryBuilder(ref this).Read(first, second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Read(string, string)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Read(string first, string second)
    {
        Ecs.GetQueryBuilder(ref this).Read(first, second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Read{T}()"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Read<T>()
    {
        Ecs.GetQueryBuilder(ref this).Read<T>();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Read{T}(T)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Read<T>(T value) where T : Enum
    {
        Ecs.GetQueryBuilder(ref this).Read(value);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Read{T1}(ulong)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Read<TFirst>(ulong second)
    {
        Ecs.GetQueryBuilder(ref this).Read<TFirst>(second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Read{T1}(string)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Read<TFirst>(string second)
    {
        Ecs.GetQueryBuilder(ref this).Read<TFirst>(second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Read{T1, T2}()"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Read<TFirst, TSecond>()
    {
        Ecs.GetQueryBuilder(ref this).Read<TFirst, TSecond>();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Read{T1, T2}(T2)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Read<TFirst, TSecond>(TSecond second) where TSecond : Enum
    {
        Ecs.GetQueryBuilder(ref this).Read<TFirst, TSecond>(second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Read{T1, T2}(T1)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Read<TFirst, TSecond>(TFirst first) where TFirst : Enum
    {
        Ecs.GetQueryBuilder(ref this).Read<TFirst, TSecond>(first);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Read{T1}(T1, string)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Read<TFirst>(TFirst first, string second) where TFirst : Enum
    {
        Ecs.GetQueryBuilder(ref this).Read(first, second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Read{T2}(string, T2)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Read<TSecond>(string first, TSecond second) where TSecond : Enum
    {
        Ecs.GetQueryBuilder(ref this).Read(first, second);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.ReadSecond{T2}(ulong)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ReadSecond<TSecond>(ulong first)
    {
        Ecs.GetQueryBuilder(ref this).ReadSecond<TSecond>(first);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.ReadSecond{T2}(string)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ReadSecond<TSecond>(string first)
    {
        Ecs.GetQueryBuilder(ref this).ReadSecond<TSecond>(first);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.ScopeOpen()"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ScopeOpen()
    {
        Ecs.GetQueryBuilder(ref this).ScopeOpen();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.ScopeClose()"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> ScopeClose()
    {
        Ecs.GetQueryBuilder(ref this).ScopeClose();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.Term()"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Term()
    {
        Ecs.GetQueryBuilder(ref this).Term();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.TermAt{T}()"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> TermAt<T>()
    {
        Ecs.GetQueryBuilder(ref this).TermAt<T>();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.TermAt(int)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> TermAt(int termIndex)
    {
        Ecs.GetQueryBuilder(ref this).TermAt(termIndex);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.TermAt{T}(int)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> TermAt<T>(int termIndex)
    {
        Ecs.GetQueryBuilder(ref this).TermAt<T>(termIndex);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.OrderBy(ulong, Ecs.OrderByCallback)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> OrderBy(ulong component, Ecs.OrderByCallback callback)
    {
        Ecs.GetQueryBuilder(ref this).OrderBy(component, callback);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.OrderBy{T}(Ecs.OrderByCallback)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> OrderBy<T>(Ecs.OrderByCallback callback)
    {
        Ecs.GetQueryBuilder(ref this).OrderBy<T>(callback);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.GroupBy(ulong)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> GroupBy(ulong component)
    {
        Ecs.GetQueryBuilder(ref this).GroupBy(component);
        return ref this;
    }
    
    /// <inheritdoc cref="Core.QueryBuilder.GroupBy(ulong, Ecs.GroupByCallback)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> GroupBy(ulong component, Ecs.GroupByCallback callback)
    {
        Ecs.GetQueryBuilder(ref this).GroupBy(component, callback);
        return ref this;
    }
    
    /// <inheritdoc cref="Core.QueryBuilder.GroupBy{TContext}(ulong, Ecs.GroupByCallback{TContext})"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> GroupBy<TContext>(ulong component, Ecs.GroupByCallback<TContext> callback)
    {
        Ecs.GetQueryBuilder(ref this).GroupBy(component, callback);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.GroupBy{T}()"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> GroupBy<T>()
    {
        Ecs.GetQueryBuilder(ref this).GroupBy<T>();
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.GroupBy{T}(Ecs.GroupByCallback)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> GroupBy<T>(Ecs.GroupByCallback callback)
    {
        Ecs.GetQueryBuilder(ref this).GroupBy<T>(callback);
        return ref this;
    }
    
    /// <inheritdoc cref="Core.QueryBuilder.GroupBy{T, TContext}(Ecs.GroupByCallback{TContext})"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> GroupBy<T, TContext>(Ecs.GroupByCallback<TContext> callback)
    {
        Ecs.GetQueryBuilder(ref this).GroupBy<T, TContext>(callback);
        return ref this;
    }
    
    /// <inheritdoc cref="Core.QueryBuilder.GroupByCtx{T}(T)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> GroupByCtx<T>(T value)
    {
        Ecs.GetQueryBuilder(ref this).GroupByCtx(value);
        return ref this;
    }
    
    /// <inheritdoc cref="Core.QueryBuilder.GroupByCtx{T}(T, Ecs.UserContextFinish{T})"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> GroupByCtx<T>(T value, Ecs.UserContextFinish<T> callback)
    {
        Ecs.GetQueryBuilder(ref this).GroupByCtx(value, callback);
        return ref this;
    }
    
    /// <inheritdoc cref="Core.QueryBuilder.GroupByCtx{T}(T, Ecs.UserContextFinish{T})"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> GroupByCtx<T>(T value, delegate*<ref T, void> callback)
    {
        Ecs.GetQueryBuilder(ref this).GroupByCtx(value, callback);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.OnGroupCreate(Ecs.GroupCreateCallback)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> OnGroupCreate(Ecs.GroupCreateCallback callback)
    {
        Ecs.GetQueryBuilder(ref this).OnGroupCreate(callback);
        return ref this;
    }
    
    /// <inheritdoc cref="Core.QueryBuilder.OnGroupCreate{T}(Ecs.GroupCreateCallback{T})"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> OnGroupCreate<T>(Ecs.GroupCreateCallback<T> callback)
    {
        Ecs.GetQueryBuilder(ref this).OnGroupCreate(callback);
        return ref this;
    }

    /// <inheritdoc cref="Core.QueryBuilder.OnGroupDelete(Ecs.GroupDeleteCallback)"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> OnGroupDelete(Ecs.GroupDeleteCallback callback)
    {
        Ecs.GetQueryBuilder(ref this).OnGroupDelete(callback);
        return ref this;
    }
    
    /// <inheritdoc cref="Core.QueryBuilder.OnGroupDelete{T}(Ecs.GroupDeleteCallback{T})"/>
    public ref PipelineBuilder<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> OnGroupDelete<T>(Ecs.GroupDeleteCallback<T> callback)
    {
        Ecs.GetQueryBuilder(ref this).OnGroupDelete(callback);
        return ref this;
    }
}
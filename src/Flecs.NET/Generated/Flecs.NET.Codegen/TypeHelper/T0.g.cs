﻿// T0.g.cs
// File was auto-generated by /_/src/Flecs.NET.Codegen/Generators/TypeHelper.cs
#nullable enable

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using Flecs.NET.Utilities;

using static Flecs.NET.Bindings.flecs;

namespace Flecs.NET.Core;

[SuppressMessage("ReSharper", "StaticMemberInGenericType")]
internal static unsafe partial class TypeHelper<T0>
{
    private static string[]? _typeNames;
    public static string[] TypeNames => _typeNames ??= [ Type<T0>.FullName ];
    
    public static readonly int Tags = (Type<T0>.IsTag ? 1 << 0 : 0);
    public static readonly int ReferenceTypes = (RuntimeHelpers.IsReferenceOrContainsReferences<T0>() ? 1 << 0 : 0);
    
    private static string GetTypeListString(int fields)
    {
        return string.Join(", ", Enumerable.Range(0, 1)
            .Where(i => (fields & (1 << i)) != 0)
            .Select(i => TypeNames[i]));
    }
    
    [Conditional("DEBUG")]
    public static void AssertNoTags()
    {
        if (Tags == 0)
            return;
    
        Ecs.Error($"Cannot use zero-sized structs as generic type arguments for this struct. Remove the following type arguments: {GetTypeListString(Tags)}");
    }
    
    [Conditional("DEBUG")]
    public static void AssertReferenceTypes(bool allowReferenceTypes)
    {
        if (allowReferenceTypes || ReferenceTypes == 0)
            return;
    
        Ecs.Error($"Cannot use managed types as generic type arguments for callback signatures that retrieve pointers or spans. Remove the following type arguments: {GetTypeListString(ReferenceTypes)}");
    }
    
    [Conditional("DEBUG")]
    public static void AssertSparseTypes(ecs_world_t* world, bool allowSparseTypes)
    {
        if (allowSparseTypes)
            return;
 
        int sparseTypes = (ecs_has_id(world, Type<T0>.Id(world), Ecs.Sparse) == Utils.True ? 1 << 0 : 0);
 
        if (sparseTypes == 0)
            return;
 
        Ecs.Error($"Cannot use sparse components as generic type arguments for this struct when using .Iter() to iterate because sparse fields must be obtained with Iter.FieldAt(). Use .Each()/.Run() to iterate or remove the following types from the list: {GetTypeListString(sparseTypes)}");
    }
}
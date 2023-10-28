const std = @import("std");
const Build = std.build;

pub fn compileFlecs(b: *Build, lib: *Build.Step.Compile) void {
    lib.addCSourceFile(.{ .file = Build.LazyPath.relative("../../submodules/flecs/flecs.c"), .flags = &.{} });
    lib.linkLibC();

    if (lib.optimize == .Debug) {
        lib.strip = false;
    } else {
        lib.defineCMacro("NDEBUG", null);
        lib.strip = true;
    }

    if (lib.target.isWindows()) {
        lib.linkSystemLibraryName("ws2_32");
    }

    b.installArtifact(lib);
}

pub fn build(b: *Build) void {
    const name = "flecs";
    const target = b.standardTargetOptions(.{});
    const optimize = b.standardOptimizeOption(.{});

    compileFlecs(b, b.addSharedLibrary(.{ .name = name, .target = target, .optimize = optimize }));
    compileFlecs(b, b.addStaticLibrary(.{ .name = name, .target = target, .optimize = optimize }));
}

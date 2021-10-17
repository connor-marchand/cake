﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using Cake.Common.Tools.DotNetCore.MSBuild;
using Cake.Core.IO;

namespace Cake.Common.Tools.DotNetCore.Publish
{
    /// <summary>
    /// Contains settings used by <see cref="DotNetCorePublisher" />.
    /// </summary>
    public sealed class DotNetCorePublishSettings : DotNetCoreSettings
    {
        /// <summary>
        /// Gets or sets the output directory.
        /// </summary>
        public DirectoryPath OutputDirectory { get; set; }

        /// <summary>
        /// Gets or sets the target runtime.
        /// </summary>
        public string Runtime { get; set; }

        /// <summary>
        /// Gets or sets a specific framework to compile.
        /// </summary>
        public string Framework { get; set; }

        /// <summary>
        /// Gets or sets the configuration under which to build.
        /// </summary>
        public string Configuration { get; set; }

        /// <summary>
        /// Gets or sets the value that defines what `*` should be replaced with in version field in project.json.
        /// </summary>
        public string VersionSuffix { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to not to build the project before publishing.
        /// This makes build faster, but requires build to be done before publish is executed.
        /// </summary>
        /// <remarks>
        /// Requires .NET Core 2.1 or newer.
        /// </remarks>
        public bool NoBuild { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to ignore project to project references and only build the root project.
        /// </summary>
        /// <remarks>
        /// Requires .NET Core 2.x or newer.
        /// </remarks>
        public bool NoDependencies { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to not do implicit NuGet package restore.
        /// This makes build faster, but requires restore to be done before build is executed.
        /// </summary>
        /// <remarks>
        /// Requires .NET Core 2.x or newer.
        /// </remarks>
        public bool NoRestore { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to display the startup banner or the copyright message.
        /// </summary>
        /// <remarks>
        /// Available since .NET Core 3.0 SDK.
        /// </remarks>
        public bool NoLogo { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to force all dependencies to be resolved even if the last restore was successful. This is equivalent to deleting project.assets.json.
        /// </summary>
        /// <remarks>
        /// Requires .NET Core 2.x or newer.
        /// </remarks>
        public bool Force { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Publish the .NET Core runtime with your application so the runtime doesn't need to be installed on the target machine. Defaults to 'true' if a runtime identifier is specified.
        /// </summary>
        /// <remarks>
        /// Requires .NET Core 2.x or newer.
        /// </remarks>
        public bool? SelfContained { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to package your app into a platform-specific single-file executable.
        /// </summary>
        /// <remarks>
        /// Requires .NET Core 3.x or newer.
        /// </remarks>
        public bool? PublishSingleFile { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to reduce the size of apps by analyzing IL and trimming unused assemblies.
        /// </summary>
        /// <remarks>
        /// Requires .NET Core 3.x or newer.
        /// </remarks>
        public bool? PublishTrimmed { get; set; }

        /// <summary>
        /// Gets or sets a value as to whether tiered compilation quick JIT is enabled.
        /// </summary>
        /// <remarks>
        /// Requires .NET Core 3.x or newer. Tiered compilation is enabled by default in .NET Core 3.
        /// <para>Code generated by Quick JIT may run slower, allocate more memory, or use more stack space.</para>
        /// </remarks>
        public bool? TieredCompilationQuickJit { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether tiered compilation is enabled.
        /// </summary>
        /// <remarks>
        /// Requires .NET Core 3.x or newer. Tiered compilation is enabled by default in .NET Core 3.
        /// </remarks>
        public bool? TieredCompilation { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to compile your application assemblies as ReadyToRun (R2R) format.
        /// </summary>
        /// <remarks>
        /// Requires .NET Core 3.x or newer. Tiered compilation is enabled by default in .NET Core 3.
        /// </remarks>
        public bool? PublishReadyToRun { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to show warnings emitted by ReadyToRun (R2R) compilation.
        /// </summary>
        /// <remarks>
        /// Requires .NET Core 3.x or newer. Tiered compilation is enabled by default in .NET Core 3.
        /// </remarks>
        public bool? PublishReadyToRunShowWarnings { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to bundle native libraries when publishing a platform-specific single-file executable.
        /// </summary>
        /// <remarks>
        /// Requires .NET 5 or newer.
        /// </remarks>
        public bool? IncludeNativeLibrariesForSelfExtract { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to bundle all content when publishing a platform-specific single-file executable.
        /// This will extract all files before running the executable and preserves the original .NET Core single-file deployment behavior.
        /// </summary>
        /// <remarks>
        /// Requires .NET 5 or newer.
        /// </remarks>
        public bool? IncludeAllContentForSelfExtract { get; set; }
        
        /// <summary>
        /// Gets or sets a value indicating whetther or not to compress assemblies in single file app.
        /// This produces a single-file that has all of the embedded assemblies compressed which can
        /// significantly reduce the size of the executable.
        /// </summary>
        /// <remarks>
        /// Requires .NET 6.x or newer.
        /// </remarks>
        public bool? EnableCompressInSingleFile { get; set; }

        /// <summary>
        /// Gets or sets the specified NuGet package sources to use during the restore.
        /// </summary>
        /// <remarks>
        /// Requires .NET Core 2.x or newer.
        /// </remarks>
        public ICollection<string> Sources { get; set; } = new List<string>();

        /// <summary>
        /// Gets or sets additional arguments to be passed to MSBuild.
        /// </summary>
        public DotNetCoreMSBuildSettings MSBuildSettings { get; set; }
    }
}

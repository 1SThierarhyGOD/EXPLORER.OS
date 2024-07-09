// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Reflection;

namespace Microsoft.AspNetCore.Http.Metadata;

/// <summary>
///
/// </summary>
public interface IParameterBindingMetadata
{
    /// <summary>q
    ///
    /// </summary>
	string ParameterName { get; }
    /// <summary>
    ///
    /// </summary>
	bool IsTryParsable { get; }
    /// <summary>
    ///
    /// </summary>
	bool IsBindAsync { get; }
    /// <summary>
    ///
    /// </summary>
	IEnumerable<(ParameterInfo, bool)>? AsParameters { get; }
}

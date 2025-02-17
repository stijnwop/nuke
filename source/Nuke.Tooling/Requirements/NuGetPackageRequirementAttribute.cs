﻿// Copyright 2023 Maintainers of NUKE.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

using System;
using System.Linq;
using JetBrains.Annotations;

namespace Nuke.Common.Tooling
{
    [BaseTypeRequired(typeof(IRequireNuGetPackage))]
    public class NuGetPackageRequirementAttribute : ToolRequirementAttributeBase
    {
        private readonly string _packageId;

        public NuGetPackageRequirementAttribute(string packageId)
        {
            _packageId = packageId;
        }

        public override ToolRequirement GetRequirement(string version = null)
        {
            return NuGetPackageRequirement.Create(_packageId, version);
        }
    }
}

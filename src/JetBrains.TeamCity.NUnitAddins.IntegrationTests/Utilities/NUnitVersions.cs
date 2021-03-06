﻿namespace JetBrains.TeamCity.NUnitAddins.IntegrationTests.Utilities
{
    using System;
    using System.Collections.ObjectModel;

    internal class NUnitVersions
    {
        public static readonly ReadOnlyCollection<string> All = Array.AsReadOnly(new[] { V264, V263 });
        public const string V264 = "NUnit-2.6.4";
        public const string V263 = "NUnit-2.6.3";
    }
}
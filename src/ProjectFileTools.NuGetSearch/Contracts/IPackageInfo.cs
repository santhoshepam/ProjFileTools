﻿using ProjectFileTools.NuGetSearch.Feeds;

namespace ProjectFileTools.NuGetSearch.Contracts
{
    public interface IPackageInfo
    {
        string Id { get; }

        string IconUrl { get; }

        string Description { get; }

        string Authors { get; }

        string LicenseUrl { get; }

        string ProjectUrl { get; }

        string Version { get; }

        FeedKind SourceKind { get; }
    }
}

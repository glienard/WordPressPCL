﻿using System.Collections.Generic;
using WordPressPCL.Models;

namespace WordPressPCL.Utility
{
    /// <summary>
    /// Plugins Query Builder class to construct queries with valid parameters
    /// </summary>
    public class PluginsQueryBuilder : QueryBuilder
    {
        /// <summary>
        /// Current page of the collection.
        /// </summary>
        /// <remarks>Default: 1</remarks>
        [QueryText("page")]
        public int Page { get; set; }

        /// <summary>
        /// Maximum number of items to be returned in result set (1-100).
        /// </summary>
        /// <remarks>Default: 10</remarks>
        [QueryText("per_page")]
        public int PerPage { get; set; }

        /// <summary>
        /// Limit results to those matching a string.
        /// </summary>
        [QueryText("search")]
        public string Search { get; set; }

        /// <summary>
        /// Ensure result set excludes specific IDs.
        /// </summary>
        [QueryText("exclude")]
        public List<int> Exclude { get; set; }

        /// <summary>
        /// Limit result set to specific IDs.
        /// </summary>
        [QueryText("include")]
        public List<int> Include { get; set; }

        /// <summary>
        /// Offset the result set by a specific number of items.
        /// </summary>
        [QueryText("offset")]
        public int Offset { get; set; }


        /// <summary>
        /// Limit result set to users with a specific slug.
        /// </summary>
        [QueryText("slug")]
        public List<string> Slugs { get; set; }

    }
}
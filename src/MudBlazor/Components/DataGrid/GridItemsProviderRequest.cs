﻿// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Threading;

namespace MudBlazor
{
    public class GridItemsProviderRequest<T> : GridStateVirtualize<T>
    {
        internal GridItemsProviderRequest(
            int startIndex, int? count, GridState<T> gridState,
            CancellationToken cancellationToken) : base(gridState)
        {
            StartIndex = startIndex;
            Count = count;
            CancellationToken = cancellationToken;
        }
    }
}
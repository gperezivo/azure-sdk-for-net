// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.AI.TextAnalytics;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class HealthcareJobState
    {
        internal static HealthcareJobState DeserializeHealthcareJobState(JsonElement element)
        {
            Optional<HealthcareResult> results = default;
            Optional<IReadOnlyList<TextAnalyticsErrorInternal>> errors = default;
            Optional<string> nextLink = default;
            DateTimeOffset createdDateTime = default;
            Optional<string> displayName = default;
            Optional<DateTimeOffset> expirationDateTime = default;
            string jobId = default;
            DateTimeOffset lastUpdateDateTime = default;
            JobStatus status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("results"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    results = HealthcareResult.DeserializeHealthcareResult(property.Value);
                    continue;
                }
                if (property.NameEquals("errors"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<TextAnalyticsErrorInternal> array = new List<TextAnalyticsErrorInternal>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TextAnalyticsErrorInternal.DeserializeTextAnalyticsErrorInternal(item));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("@nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdDateTime"))
                {
                    createdDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("displayName"))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expirationDateTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    expirationDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("jobId"))
                {
                    jobId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastUpdateDateTime"))
                {
                    lastUpdateDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = new JobStatus(property.Value.GetString());
                    continue;
                }
            }
            return new HealthcareJobState(createdDateTime, displayName.Value, Optional.ToNullable(expirationDateTime), jobId, lastUpdateDateTime, status, results.Value, Optional.ToList(errors), nextLink.Value);
        }
    }
}

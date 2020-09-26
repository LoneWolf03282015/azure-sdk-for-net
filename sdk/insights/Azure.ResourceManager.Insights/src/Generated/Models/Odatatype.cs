// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Insights.Models
{
    /// <summary> specifies the type of the alert criteria. </summary>
    public readonly partial struct Odatatype : IEquatable<Odatatype>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="Odatatype"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Odatatype(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MicrosoftAzureMonitorSingleResourceMultipleMetricCriteriaValue = "Microsoft.Azure.Monitor.SingleResourceMultipleMetricCriteria";
        private const string MicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaValue = "Microsoft.Azure.Monitor.MultipleResourceMultipleMetricCriteria";
        private const string MicrosoftAzureMonitorWebtestLocationAvailabilityCriteriaValue = "Microsoft.Azure.Monitor.WebtestLocationAvailabilityCriteria";

        /// <summary> Microsoft.Azure.Monitor.SingleResourceMultipleMetricCriteria. </summary>
        public static Odatatype MicrosoftAzureMonitorSingleResourceMultipleMetricCriteria { get; } = new Odatatype(MicrosoftAzureMonitorSingleResourceMultipleMetricCriteriaValue);
        /// <summary> Microsoft.Azure.Monitor.MultipleResourceMultipleMetricCriteria. </summary>
        public static Odatatype MicrosoftAzureMonitorMultipleResourceMultipleMetricCriteria { get; } = new Odatatype(MicrosoftAzureMonitorMultipleResourceMultipleMetricCriteriaValue);
        /// <summary> Microsoft.Azure.Monitor.WebtestLocationAvailabilityCriteria. </summary>
        public static Odatatype MicrosoftAzureMonitorWebtestLocationAvailabilityCriteria { get; } = new Odatatype(MicrosoftAzureMonitorWebtestLocationAvailabilityCriteriaValue);
        /// <summary> Determines if two <see cref="Odatatype"/> values are the same. </summary>
        public static bool operator ==(Odatatype left, Odatatype right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Odatatype"/> values are not the same. </summary>
        public static bool operator !=(Odatatype left, Odatatype right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Odatatype"/>. </summary>
        public static implicit operator Odatatype(string value) => new Odatatype(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Odatatype other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Odatatype other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
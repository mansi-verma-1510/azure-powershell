// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Support
{

    /// <summary>Management information availability state for the app.</summary>
    public partial struct SiteAvailabilityState :
        System.IEquatable<SiteAvailabilityState>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.SiteAvailabilityState DisasterRecoveryMode = @"DisasterRecoveryMode";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.SiteAvailabilityState Limited = @"Limited";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.SiteAvailabilityState Normal = @"Normal";

        /// <summary>the value for an instance of the <see cref="SiteAvailabilityState" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to SiteAvailabilityState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="SiteAvailabilityState" />.</param>
        internal static object CreateFrom(object value)
        {
            return new SiteAvailabilityState(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type SiteAvailabilityState</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.SiteAvailabilityState e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type SiteAvailabilityState (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is SiteAvailabilityState && Equals((SiteAvailabilityState)obj);
        }

        /// <summary>Returns hashCode for enum SiteAvailabilityState</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="SiteAvailabilityState" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private SiteAvailabilityState(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for SiteAvailabilityState</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to SiteAvailabilityState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="SiteAvailabilityState" />.</param>

        public static implicit operator SiteAvailabilityState(string value)
        {
            return new SiteAvailabilityState(value);
        }

        /// <summary>Implicit operator to convert SiteAvailabilityState to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="SiteAvailabilityState" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.SiteAvailabilityState e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum SiteAvailabilityState</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.SiteAvailabilityState e1, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.SiteAvailabilityState e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum SiteAvailabilityState</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.SiteAvailabilityState e1, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.SiteAvailabilityState e2)
        {
            return e2.Equals(e1);
        }
    }
}
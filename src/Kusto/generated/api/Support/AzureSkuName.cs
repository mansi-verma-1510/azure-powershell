// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support
{

    /// <summary>SKU name.</summary>
    public partial struct AzureSkuName :
        System.IEquatable<AzureSkuName>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.AzureSkuName DevNoSlaStandardD11V2 = @"Dev(No SLA)_Standard_D11_v2";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.AzureSkuName DevNoSlaStandardE2AV4 = @"Dev(No SLA)_Standard_E2a_v4";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.AzureSkuName StandardD11V2 = @"Standard_D11_v2";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.AzureSkuName StandardD12V2 = @"Standard_D12_v2";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.AzureSkuName StandardD13V2 = @"Standard_D13_v2";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.AzureSkuName StandardD14V2 = @"Standard_D14_v2";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.AzureSkuName StandardDs13V21TbPs = @"Standard_DS13_v2+1TB_PS";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.AzureSkuName StandardDs13V22TbPs = @"Standard_DS13_v2+2TB_PS";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.AzureSkuName StandardDs14V23TbPs = @"Standard_DS14_v2+3TB_PS";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.AzureSkuName StandardDs14V24TbPs = @"Standard_DS14_v2+4TB_PS";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.AzureSkuName StandardE16AV4 = @"Standard_E16a_v4";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.AzureSkuName StandardE16AsV43TbPs = @"Standard_E16as_v4+3TB_PS";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.AzureSkuName StandardE16AsV44TbPs = @"Standard_E16as_v4+4TB_PS";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.AzureSkuName StandardE2AV4 = @"Standard_E2a_v4";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.AzureSkuName StandardE4AV4 = @"Standard_E4a_v4";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.AzureSkuName StandardE64IV3 = @"Standard_E64i_v3";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.AzureSkuName StandardE80IdsV4 = @"Standard_E80ids_v4";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.AzureSkuName StandardE8AV4 = @"Standard_E8a_v4";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.AzureSkuName StandardE8AsV41TbPs = @"Standard_E8as_v4+1TB_PS";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.AzureSkuName StandardE8AsV42TbPs = @"Standard_E8as_v4+2TB_PS";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.AzureSkuName StandardL16S = @"Standard_L16s";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.AzureSkuName StandardL16SV2 = @"Standard_L16s_v2";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.AzureSkuName StandardL4S = @"Standard_L4s";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.AzureSkuName StandardL8S = @"Standard_L8s";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.AzureSkuName StandardL8SV2 = @"Standard_L8s_v2";

        /// <summary>the value for an instance of the <see cref="AzureSkuName" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Creates an instance of the <see cref="AzureSkuName" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private AzureSkuName(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Conversion from arbitrary object to AzureSkuName</summary>
        /// <param name="value">the value to convert to an instance of <see cref="AzureSkuName" />.</param>
        internal static object CreateFrom(object value)
        {
            return new AzureSkuName(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type AzureSkuName</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.AzureSkuName e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type AzureSkuName (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is AzureSkuName && Equals((AzureSkuName)obj);
        }

        /// <summary>Returns hashCode for enum AzureSkuName</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for AzureSkuName</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to AzureSkuName</summary>
        /// <param name="value">the value to convert to an instance of <see cref="AzureSkuName" />.</param>

        public static implicit operator AzureSkuName(string value)
        {
            return new AzureSkuName(value);
        }

        /// <summary>Implicit operator to convert AzureSkuName to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="AzureSkuName" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.AzureSkuName e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum AzureSkuName</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.AzureSkuName e1, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.AzureSkuName e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum AzureSkuName</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.AzureSkuName e1, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.AzureSkuName e2)
        {
            return e2.Equals(e1);
        }
    }
}
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Support
{

    /// <summary>Enable Geo-redundant or not for server backup.</summary>
    public partial struct GeoRedundantBackup :
        System.IEquatable<GeoRedundantBackup>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Support.GeoRedundantBackup Disabled = @"Disabled";

        public static Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Support.GeoRedundantBackup Enabled = @"Enabled";

        /// <summary>the value for an instance of the <see cref="GeoRedundantBackup" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to GeoRedundantBackup</summary>
        /// <param name="value">the value to convert to an instance of <see cref="GeoRedundantBackup" />.</param>
        internal static object CreateFrom(object value)
        {
            return new GeoRedundantBackup(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type GeoRedundantBackup</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Support.GeoRedundantBackup e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type GeoRedundantBackup (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is GeoRedundantBackup && Equals((GeoRedundantBackup)obj);
        }

        /// <summary>Creates an instance of the <see cref="GeoRedundantBackup"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private GeoRedundantBackup(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns hashCode for enum GeoRedundantBackup</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for GeoRedundantBackup</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to GeoRedundantBackup</summary>
        /// <param name="value">the value to convert to an instance of <see cref="GeoRedundantBackup" />.</param>

        public static implicit operator GeoRedundantBackup(string value)
        {
            return new GeoRedundantBackup(value);
        }

        /// <summary>Implicit operator to convert GeoRedundantBackup to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="GeoRedundantBackup" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Support.GeoRedundantBackup e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum GeoRedundantBackup</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Support.GeoRedundantBackup e1, Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Support.GeoRedundantBackup e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum GeoRedundantBackup</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Support.GeoRedundantBackup e1, Microsoft.Azure.PowerShell.Cmdlets.MariaDb.Support.GeoRedundantBackup e2)
        {
            return e2.Equals(e1);
        }
    }
}
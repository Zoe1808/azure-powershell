// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Extensions;

    public partial class RawCertificateData :
        Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IRawCertificateData,
        Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IRawCertificateDataInternal
    {

        /// <summary>Backing field for <see cref="Certificate" /> property.</summary>
        private string[] _certificate;

        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.PropertyOrigin.Owned)]
        public string[] Certificate { get => this._certificate; set => this._certificate = value; }

        /// <summary>Creates an new <see cref="RawCertificateData" /> instance.</summary>
        public RawCertificateData()
        {

        }
    }
    public partial interface IRawCertificateData :
        Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.IJsonSerializable
    {
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"certificates",
        PossibleTypes = new [] { typeof(string) })]
        string[] Certificate { get; set; }

    }
    internal partial interface IRawCertificateDataInternal

    {
        string[] Certificate { get; set; }

    }
}
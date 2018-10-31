// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for EncryptionScheme.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EncryptionScheme
    {
        /// <summary>
        /// NoEncryption scheme
        /// </summary>
        [EnumMember(Value = "NoEncryption")]
        NoEncryption,
        /// <summary>
        /// EnvelopeEncryption scheme
        /// </summary>
        [EnumMember(Value = "EnvelopeEncryption")]
        EnvelopeEncryption,
        /// <summary>
        /// CommonEncryptionCenc scheme
        /// </summary>
        [EnumMember(Value = "CommonEncryptionCenc")]
        CommonEncryptionCenc,
        /// <summary>
        /// CommonEncryptionCbcs scheme
        /// </summary>
        [EnumMember(Value = "CommonEncryptionCbcs")]
        CommonEncryptionCbcs
    }
    internal static class EncryptionSchemeEnumExtension
    {
        internal static string ToSerializedValue(this EncryptionScheme? value)
        {
            return value == null ? null : ((EncryptionScheme)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this EncryptionScheme value)
        {
            switch( value )
            {
                case EncryptionScheme.NoEncryption:
                    return "NoEncryption";
                case EncryptionScheme.EnvelopeEncryption:
                    return "EnvelopeEncryption";
                case EncryptionScheme.CommonEncryptionCenc:
                    return "CommonEncryptionCenc";
                case EncryptionScheme.CommonEncryptionCbcs:
                    return "CommonEncryptionCbcs";
            }
            return null;
        }

        internal static EncryptionScheme? ParseEncryptionScheme(this string value)
        {
            switch( value )
            {
                case "NoEncryption":
                    return EncryptionScheme.NoEncryption;
                case "EnvelopeEncryption":
                    return EncryptionScheme.EnvelopeEncryption;
                case "CommonEncryptionCenc":
                    return EncryptionScheme.CommonEncryptionCenc;
                case "CommonEncryptionCbcs":
                    return EncryptionScheme.CommonEncryptionCbcs;
            }
            return null;
        }
    }
}
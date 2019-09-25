/* 
 * Allegro REST API
 *
 * https://developer.allegro.pl/about
 *
 * OpenAPI spec version: latest
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;


namespace WebApplication1.ApiModel
{
    /// <summary>
    /// Defines DisputeAuthorRole
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum DisputeAuthorRole
    {
        /// <summary>
        /// Enum BUYER for value: BUYER
        /// </summary>
        [EnumMember(Value = "BUYER")]
        BUYER = 0,
        /// <summary>
        /// Enum ADMIN for value: ADMIN
        /// </summary>
        [EnumMember(Value = "ADMIN")]
        ADMIN = 1    }
}

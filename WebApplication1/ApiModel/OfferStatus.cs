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
    /// The publication status of the current offer. The possible values:    - *INACTIVE* - a draft offer   - *ACTIVATING* - the offer is planned for listing or is during the process of activation   - *ACTIVE* - the offer is active   - *ENDED* - the offer was active and is now ended (for whatever reason)
    /// </summary>
    /// <value>The publication status of the current offer. The possible values:    - *INACTIVE* - a draft offer   - *ACTIVATING* - the offer is planned for listing or is during the process of activation   - *ACTIVE* - the offer is active   - *ENDED* - the offer was active and is now ended (for whatever reason)</value>
        public enum OfferStatus
    {
        /// <summary>
        /// Enum INACTIVE for value: INACTIVE
        /// </summary>
        
        INACTIVE,
        /// <summary>
        /// Enum ACTIVATING for value: ACTIVATING
        /// </summary>
        
        ACTIVATING,
        /// <summary>
        /// Enum ACTIVE for value: ACTIVE
        /// </summary>
        
        ACTIVE,
        /// <summary>
        /// Enum ENDED for value: ENDED
        /// </summary>
        
        ENDED   }
}

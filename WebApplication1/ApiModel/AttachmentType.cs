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
    /// offer attachment type
    /// </summary>
    /// <value>offer attachment type</value>
        public enum AttachmentType
    {
        /// <summary>
        /// Enum MANUAL for value: MANUAL
        /// </summary>
        
        MANUAL,
        /// <summary>
        /// Enum SPECIALOFFERRULES for value: SPECIAL_OFFER_RULES
        /// </summary>
        
        SPECIALOFFERRULES,
        /// <summary>
        /// Enum COMPETITIONRULES for value: COMPETITION_RULES
        /// </summary>
        
        COMPETITIONRULES,
        /// <summary>
        /// Enum BOOKEXCERPT for value: BOOK_EXCERPT
        /// </summary>
        
        BOOKEXCERPT,
        /// <summary>
        /// Enum USERMANUAL for value: USER_MANUAL
        /// </summary>
        
        USERMANUAL,
        /// <summary>
        /// Enum INSTALLATIONINSTRUCTIONS for value: INSTALLATION_INSTRUCTIONS
        /// </summary>
        
        INSTALLATIONINSTRUCTIONS,
        /// <summary>
        /// Enum GAMEINSTRUCTIONS for value: GAME_INSTRUCTIONS
        /// </summary>
        
        GAMEINSTRUCTIONS    }
}
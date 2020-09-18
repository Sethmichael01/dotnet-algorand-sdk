/* 
 * Indexer
 *
 * Algorand ledger analytics API.
 *
 * OpenAPI spec version: 2.0
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
using SwaggerDateConverter = Algorand.V2.Client.SwaggerDateConverter;

namespace Algorand.V2.Model
{
    /// <summary>
    /// AssetResponse
    /// </summary>
    [DataContract]
        public partial class AssetResponse :  IEquatable<AssetResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetResponse" /> class.
        /// </summary>
        /// <param name="asset">asset (required).</param>
        /// <param name="currentRound">Round at which the results were computed. (required).</param>
        public AssetResponse(Asset asset = default(Asset), long? currentRound = default)
        {
            // to ensure "asset" is required (not null)
            if (asset == null)
            {
                throw new InvalidDataException("asset is a required property for AssetResponse and cannot be null");
            }
            else
            {
                this.Asset = asset;
            }
            // to ensure "currentRound" is required (not null)
            if (currentRound == null)
            {
                throw new InvalidDataException("currentRound is a required property for AssetResponse and cannot be null");
            }
            else
            {
                this.CurrentRound = currentRound;
            }
        }
        
        /// <summary>
        /// Gets or Sets Asset
        /// </summary>
        [DataMember(Name="asset", EmitDefaultValue=false)]
        public Asset Asset { get; set; }

        /// <summary>
        /// Round at which the results were computed.
        /// </summary>
        /// <value>Round at which the results were computed.</value>
        [DataMember(Name="current-round", EmitDefaultValue=false)]
        public long? CurrentRound { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssetResponse {\n");
            sb.Append("  Asset: ").Append(Asset).Append("\n");
            sb.Append("  CurrentRound: ").Append(CurrentRound).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssetResponse);
        }

        /// <summary>
        /// Returns true if AssetResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AssetResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssetResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Asset == input.Asset ||
                    (this.Asset != null &&
                    this.Asset.Equals(input.Asset))
                ) && 
                (
                    this.CurrentRound == input.CurrentRound ||
                    (this.CurrentRound != null &&
                    this.CurrentRound.Equals(input.CurrentRound))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Asset != null)
                    hashCode = hashCode * 59 + this.Asset.GetHashCode();
                if (this.CurrentRound != null)
                    hashCode = hashCode * 59 + this.CurrentRound.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}

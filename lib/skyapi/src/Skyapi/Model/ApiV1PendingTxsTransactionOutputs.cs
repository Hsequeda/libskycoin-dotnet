/* 
 * Skycoin REST API.
 *
 * Skycoin is a next-generation cryptocurrency.
 *
 * The version of the OpenAPI document: 0.26.0
 * Contact: contact@skycoin.net
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = Skyapi.Client.OpenAPIDateConverter;

namespace Skyapi.Model
{
    /// <summary>
    /// ApiV1PendingTxsTransactionOutputs
    /// </summary>
    [DataContract]
    public partial class ApiV1PendingTxsTransactionOutputs :  IEquatable<ApiV1PendingTxsTransactionOutputs>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiV1PendingTxsTransactionOutputs" /> class.
        /// </summary>
        /// <param name="uxid">uxid.</param>
        /// <param name="dst">dst.</param>
        /// <param name="coins">coins.</param>
        /// <param name="hours">hours.</param>
        public ApiV1PendingTxsTransactionOutputs(string uxid = default(string), string dst = default(string), string coins = default(string), long? hours = default(long?))
        {
            this.Uxid = uxid;
            this.Dst = dst;
            this.Coins = coins;
            this.Hours = hours;
        }
        
        /// <summary>
        /// Gets or Sets Uxid
        /// </summary>
        [DataMember(Name="uxid", EmitDefaultValue=false)]
        public string Uxid { get; set; }

        /// <summary>
        /// Gets or Sets Dst
        /// </summary>
        [DataMember(Name="dst", EmitDefaultValue=false)]
        public string Dst { get; set; }

        /// <summary>
        /// Gets or Sets Coins
        /// </summary>
        [DataMember(Name="coins", EmitDefaultValue=false)]
        public string Coins { get; set; }

        /// <summary>
        /// Gets or Sets Hours
        /// </summary>
        [DataMember(Name="hours", EmitDefaultValue=false)]
        public long? Hours { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiV1PendingTxsTransactionOutputs {\n");
            sb.Append("  Uxid: ").Append(Uxid).Append("\n");
            sb.Append("  Dst: ").Append(Dst).Append("\n");
            sb.Append("  Coins: ").Append(Coins).Append("\n");
            sb.Append("  Hours: ").Append(Hours).Append("\n");
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
            return this.Equals(input as ApiV1PendingTxsTransactionOutputs);
        }

        /// <summary>
        /// Returns true if ApiV1PendingTxsTransactionOutputs instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiV1PendingTxsTransactionOutputs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiV1PendingTxsTransactionOutputs input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Uxid == input.Uxid ||
                    (this.Uxid != null &&
                    this.Uxid.Equals(input.Uxid))
                ) && 
                (
                    this.Dst == input.Dst ||
                    (this.Dst != null &&
                    this.Dst.Equals(input.Dst))
                ) && 
                (
                    this.Coins == input.Coins ||
                    (this.Coins != null &&
                    this.Coins.Equals(input.Coins))
                ) && 
                (
                    this.Hours == input.Hours ||
                    (this.Hours != null &&
                    this.Hours.Equals(input.Hours))
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
                if (this.Uxid != null)
                    hashCode = hashCode * 59 + this.Uxid.GetHashCode();
                if (this.Dst != null)
                    hashCode = hashCode * 59 + this.Dst.GetHashCode();
                if (this.Coins != null)
                    hashCode = hashCode * 59 + this.Coins.GetHashCode();
                if (this.Hours != null)
                    hashCode = hashCode * 59 + this.Hours.GetHashCode();
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

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
    /// TransactionVerboseTxnInputs
    /// </summary>
    [DataContract]
    public partial class TransactionVerboseTxnInputs :  IEquatable<TransactionVerboseTxnInputs>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionVerboseTxnInputs" /> class.
        /// </summary>
        /// <param name="uxid">uxid.</param>
        /// <param name="owner">owner.</param>
        /// <param name="coins">coins.</param>
        /// <param name="hours">hours.</param>
        /// <param name="calculatedHours">calculatedHours.</param>
        public TransactionVerboseTxnInputs(string uxid = default(string), string owner = default(string), string coins = default(string), long? hours = default(long?), long? calculatedHours = default(long?))
        {
            this.Uxid = uxid;
            this.Owner = owner;
            this.Coins = coins;
            this.Hours = hours;
            this.CalculatedHours = calculatedHours;
        }
        
        /// <summary>
        /// Gets or Sets Uxid
        /// </summary>
        [DataMember(Name="uxid", EmitDefaultValue=false)]
        public string Uxid { get; set; }

        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        public string Owner { get; set; }

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
        /// Gets or Sets CalculatedHours
        /// </summary>
        [DataMember(Name="calculated_hours", EmitDefaultValue=false)]
        public long? CalculatedHours { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionVerboseTxnInputs {\n");
            sb.Append("  Uxid: ").Append(Uxid).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Coins: ").Append(Coins).Append("\n");
            sb.Append("  Hours: ").Append(Hours).Append("\n");
            sb.Append("  CalculatedHours: ").Append(CalculatedHours).Append("\n");
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
            return this.Equals(input as TransactionVerboseTxnInputs);
        }

        /// <summary>
        /// Returns true if TransactionVerboseTxnInputs instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionVerboseTxnInputs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionVerboseTxnInputs input)
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
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
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
                ) && 
                (
                    this.CalculatedHours == input.CalculatedHours ||
                    (this.CalculatedHours != null &&
                    this.CalculatedHours.Equals(input.CalculatedHours))
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
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.Coins != null)
                    hashCode = hashCode * 59 + this.Coins.GetHashCode();
                if (this.Hours != null)
                    hashCode = hashCode * 59 + this.Hours.GetHashCode();
                if (this.CalculatedHours != null)
                    hashCode = hashCode * 59 + this.CalculatedHours.GetHashCode();
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

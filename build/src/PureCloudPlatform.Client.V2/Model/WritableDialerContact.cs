using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// WritableDialerContact
    /// </summary>
    [DataContract]
    public partial class WritableDialerContact :  IEquatable<WritableDialerContact>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WritableDialerContact" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WritableDialerContact() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WritableDialerContact" /> class.
        /// </summary>
        /// <param name="Id">The globally unique identifier for the object..</param>
        /// <param name="ContactListId">The identifier of the contact list containing this contact. (required).</param>
        /// <param name="Data">An ordered map of the contact&#39;s columns and corresponding values. (required).</param>
        /// <param name="Callable">Indicates whether or not the contact can be called..</param>
        /// <param name="PhoneNumberStatus">A map of phone number columns to PhoneNumberStatuses, which indicate if the phone number is callable or not..</param>
        public WritableDialerContact(string Id = null, string ContactListId = null, Dictionary<string, Object> Data = null, bool? Callable = null, Dictionary<string, PhoneNumberStatus> PhoneNumberStatus = null)
        {
            this.Id = Id;
            this.ContactListId = ContactListId;
            this.Data = Data;
            this.Callable = Callable;
            this.PhoneNumberStatus = PhoneNumberStatus;
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// The identifier of the contact list containing this contact.
        /// </summary>
        /// <value>The identifier of the contact list containing this contact.</value>
        [DataMember(Name="contactListId", EmitDefaultValue=false)]
        public string ContactListId { get; set; }
        
        
        
        /// <summary>
        /// An ordered map of the contact&#39;s columns and corresponding values.
        /// </summary>
        /// <value>An ordered map of the contact&#39;s columns and corresponding values.</value>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public Dictionary<string, Object> Data { get; set; }
        
        
        
        /// <summary>
        /// Indicates whether or not the contact can be called.
        /// </summary>
        /// <value>Indicates whether or not the contact can be called.</value>
        [DataMember(Name="callable", EmitDefaultValue=false)]
        public bool? Callable { get; set; }
        
        
        
        /// <summary>
        /// A map of phone number columns to PhoneNumberStatuses, which indicate if the phone number is callable or not.
        /// </summary>
        /// <value>A map of phone number columns to PhoneNumberStatuses, which indicate if the phone number is callable or not.</value>
        [DataMember(Name="phoneNumberStatus", EmitDefaultValue=false)]
        public Dictionary<string, PhoneNumberStatus> PhoneNumberStatus { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WritableDialerContact {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ContactListId: ").Append(ContactListId).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Callable: ").Append(Callable).Append("\n");
            sb.Append("  PhoneNumberStatus: ").Append(PhoneNumberStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as WritableDialerContact);
        }

        /// <summary>
        /// Returns true if WritableDialerContact instances are equal
        /// </summary>
        /// <param name="other">Instance of WritableDialerContact to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WritableDialerContact other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.ContactListId == other.ContactListId ||
                    this.ContactListId != null &&
                    this.ContactListId.Equals(other.ContactListId)
                ) &&
                (
                    this.Data == other.Data ||
                    this.Data != null &&
                    this.Data.SequenceEqual(other.Data)
                ) &&
                (
                    this.Callable == other.Callable ||
                    this.Callable != null &&
                    this.Callable.Equals(other.Callable)
                ) &&
                (
                    this.PhoneNumberStatus == other.PhoneNumberStatus ||
                    this.PhoneNumberStatus != null &&
                    this.PhoneNumberStatus.SequenceEqual(other.PhoneNumberStatus)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.ContactListId != null)
                    hash = hash * 59 + this.ContactListId.GetHashCode();
                
                if (this.Data != null)
                    hash = hash * 59 + this.Data.GetHashCode();
                
                if (this.Callable != null)
                    hash = hash * 59 + this.Callable.GetHashCode();
                
                if (this.PhoneNumberStatus != null)
                    hash = hash * 59 + this.PhoneNumberStatus.GetHashCode();
                
                return hash;
            }
        }
    }

}
// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591

namespace SugarRestSharp.Models
{
	using System;
	using Newtonsoft.Json;
	

    /// <summary>
    /// A class which represents the email_addresses table.
    /// </summary>
	[ModuleProperty(ModuleName = "EmailAddresses", TableName="email_addresses")]
	public partial class EmailAddresses : EntityBase
	{
		[JsonProperty(PropertyName = "id")]
		public virtual string Id { get; set; }

		[JsonProperty(PropertyName = "email_address")]
		public virtual string EmailAddress { get; set; }

		[JsonProperty(PropertyName = "email_address_caps")]
		public virtual string EmailAddressCaps { get; set; }

		[JsonProperty(PropertyName = "invalid_email")]
		public virtual sbyte? InvalidEmail { get; set; }

		[JsonProperty(PropertyName = "opt_out")]
		public virtual sbyte? OptOut { get; set; }

		[JsonProperty(PropertyName = "date_created")]
		public virtual DateTime? DateCreated { get; set; }

		[JsonProperty(PropertyName = "date_modified")]
		public virtual DateTime? DateModified { get; set; }

		[JsonProperty(PropertyName = "deleted")]
		public virtual sbyte? Deleted { get; set; }

	}
}
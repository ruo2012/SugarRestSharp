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
    /// A class which represents the address_book table.
    /// </summary>
	[ModuleProperty(ModuleName = "AddressBook", TableName="address_book")]
	public partial class AddressBook : EntityBase
	{
		[JsonProperty(PropertyName = "assigned_user_id")]
		public virtual string AssignedUserId { get; set; }

		[JsonProperty(PropertyName = "bean")]
		public virtual string Bean { get; set; }

		[JsonProperty(PropertyName = "bean_id")]
		public virtual string BeanId { get; set; }

	}
}
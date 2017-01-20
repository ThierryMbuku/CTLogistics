//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CTLogistics
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Client
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public int IDNumber { get; set; }
        [Required]
        public string PostalAddress { get; set; }
        [Required]
        public string EmailAddress { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Comments { get; set; }
        [Required]
        public int UserRoleId { get; set; }
        [Required]
        public System.DateTime DatOfBirth { get; set; }
        [Required]
        public int CellPhone { get; set; }
    
        public virtual UserRole UserRole { get; set; }
    }
}
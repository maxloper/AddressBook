using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AddressBook.Models
{
    public class Contact
    {
        [Required]
        [Display(Name="First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name="Last Name")]
        public string LastName { get; set; }
        
        [Required]
        [Display(Name ="address line 1 ")]
        public string Address1  { get; set; }
        [Display(Name = "address line 2 ")]
        public string Address2  { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Phone { get; set; }

        public int Id { get; set; }
        
        
        [NotMapped]
        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }

    }
}
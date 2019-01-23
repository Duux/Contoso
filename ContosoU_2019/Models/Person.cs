using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoU_2019.Models
{
    //jconnors: Part 2: Create the data models 
    //1. Create the person abstract class (inheritance)
    public abstract class Person
    {
        public int ID { get; set; }
        //The ID property will bcome the PK colum of the database table
        //by default EF interprets a property named "ID" || "classnameID" as the PK

        [Required, Display(Name = "First Name"), StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters")]
        public string FirstName { get; set; }

        [Required, Display(Name = "Last Name"), StringLength(65, ErrorMessage = "Last name cannot be longer than 65 characters")]
        public string LastName { get; set; }

        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required, StringLength(150, ErrorMessage = "Address cannot be over 150 characters")]
        public string Address { get; set; }

        [Required, StringLength(60, ErrorMessage = "City cannot be over 60 characters")]
        public string City { get; set; }

        [Required, Display(Name = "Postal Code"), DataType(DataType.PostalCode), Column(TypeName = "nchar(7)"), StringLength(7, ErrorMessage = "PostalCode cannot be over 7 characters")]
        public string PostalCode { get; set; }

        [Required, Column(TypeName = "nchar(2)"), StringLength(2, ErrorMessage = "Province can only be 2 characters long")]
        public string Province { get; set; }


        //Fullname
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }

        //IdFullName: Readonly property
        public string IdFullName
        {
            get
            {
                return "(" + ID + ") " + FullName;
            }
        }

        //FullAddress: Readonly property
        public string FullAddress
        {
            get
            {
                return Address + ", " + City + ", " + Province + ", " + PostalCode;
            }
        }
    }
}

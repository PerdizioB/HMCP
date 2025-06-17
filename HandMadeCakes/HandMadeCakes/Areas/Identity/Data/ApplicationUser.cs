using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HandMadeCakes.Areas.Identity.Data;

    public class ApplicationUser: IdentityUser
{
    [PersonalData]
    [Column(TypeName = "nvarchar(100)")]
    public string FirstName { get; set; }

    [PersonalData]
    [Column(TypeName = "nvarchar(100)")]
    public string LastName { get; set; }

    public string City { get; set; }

    public string Address { get; set; }

    public string PostalCode { get; set; }




}


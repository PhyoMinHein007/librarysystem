using System;
using System.Collections.Generic;


namespace Library.Base;

public partial class User
{
    public string UserId { get; set; } 

    public string UserName { get; set; } 
    public string Password { get; set; }
    public string UserRoleId { get; set; }  //FK

   

}

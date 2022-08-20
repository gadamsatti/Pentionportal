using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PensionManagementAuthAPI.Model
{
    public class UserConstants
    {
        public static List<UserModel> Users = new List<UserModel>()
        {
              new UserModel() { Username = "akhil", EmailAddress = "akhil@email.com", Password = "password123", GivenName = "akhil", Surname = "gadamsetti", Role = "Administrator" },
            new UserModel() { Username = "elyse_seller", EmailAddress = "elyse.seller@email.com", Password = "MyPass_w0rd", GivenName = "Elyse", Surname = "Lambert", Role = "Seller" },
        };
    }
}

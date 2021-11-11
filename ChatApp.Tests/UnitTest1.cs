using System;
using System.Threading.Tasks;

using Xunit;

namespace ChatApp.Tests
{
    public class UnitTest1
    {
       


        [Fact]
        public void Test1()
        {
          
                //if (ModelState.IsValid)
                //{
                //    var user = await userManager.FindByNameAsync(model.UserName);

                //    if (user == null)
                //    {
                //        user = new User
                //        {
                //            Id = Guid.NewGuid().ToString(),
                //            UserName = model.UserName,
                //            Email = model.UserName
                //        };

                //        var result = await userManager.CreateAsync(user, model.Password);

                //        if (result.Succeeded)
                //        {
                //            var token = await userManager.GenerateEmailConfirmationTokenAsync(user);
                //            var confirmationEmail = Url.Action("ConfirmEmailAddress", "User",
                //                new { token = token, email = user.Email }, Request.Scheme);
                //            System.IO.File.WriteAllText("confirmationLink.txt", confirmationEmail);
                //        }
                //    }

                //    return Ok("success");
                //}

                //return Ok("error?");
            

        }
    }
}

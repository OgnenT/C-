using FakeFacebook.Logger;
using System;
using System.Linq;
using WebApi.Exceptions;
using WebApi.Service;

namespace FakeFacebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var allUsers = UserService.GetAllUsers();
            //foreach (var user in allUsers)
            //{
            //    Console.WriteLine(user.FirstName);
            //}
            try
            {
                // var userByID = UserService.GetUserById(4);
                var usersFriends = UserService.GetAllUsersFriends(null);
                foreach (var user in usersFriends)
                {
                    Console.WriteLine(user.FirstName);
                }
                // Console.WriteLine(userByID.FirstName);
            }
            catch (UserServiceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                var logger = new UserExceptionsLogger();
                logger.LogException(ex);
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("I proceed to work");



            Console.WriteLine("-----------------------------------------------\nAll Admins:");
            var allAdmins = AdminService.GetAllAdmins();
            foreach (var item in allAdmins)
            {
                Console.WriteLine(item.FName);
            }
            Console.WriteLine("-----------------------------------------------");

            try
            {
                var adminById = AdminService.GetAdminById(60);
                Console.WriteLine(adminById.FName);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message + "\nPlease insert 10, 20, 30, 40 or 50!");
            }


            Console.WriteLine("---------------------------------------------");

            try
            {
                //Tuka vo ovj slucaj se menuva vrednosta vo metodata, dokolku stavis 10 ke bide null, zosto toa e prviot admin
                // koj nema friends, dokolku stavis 60 sto e nepostoecki admin vlaga vo vtoriot catch.
                var randomAdmin = AdminService.GetAdminById(60);

                var friendsOfAdmin = AdminService.GetAllAdminFriends(randomAdmin);
                friendsOfAdmin.ForEach(adminFriends => Console.WriteLine("Friends: " + adminFriends.FName));
            }
            // Tuka dokolku gi zakomentirame prvite dva catch-a, programot ke vleze vo posledniot cath i ke se ispise exception-ot
            // vo AdnubExceptionLogger .txt vo dadenata lokacijata!
            catch (NullReferenceException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message + "\nOh no, not a null (no friends)!!!");
                Console.ResetColor();
            }
            catch (InvalidOperationException ex)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(ex.Message + "\nPlease use Id: 10, 20, 30, 40 or 50!!");
                Console.ResetColor();
            }

            catch (Exception ex)
            {
                var logger = new AdminExceptionsLogger();
                logger.LogException(ex);
                Console.WriteLine(ex.Message);
                //throw new Exception();
            }


            Console.WriteLine("Continue ---------------------------------------------");


            Console.ReadLine();
        }
    }
}

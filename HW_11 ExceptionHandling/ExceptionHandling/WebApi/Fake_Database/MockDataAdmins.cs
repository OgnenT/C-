using System;
using System.Collections.Generic;
using System.Text;
using WebApi.Models;

namespace WebApi.Fake_Database
{
    internal static class MockDataAdmins
    {
        public static List<Admin> GetMockedAdmins()
        {
            Admin goce = new Admin
            {
                ID = 10,
                FName = "Goce",
                LName = "Kabov",
            };
            Admin miki = new Admin
            {
                ID = 20,
                FName = "Miodrag",
                LName = "Cekik",
                Friends = new List<Admin> { goce }

            };
            Admin ognen = new Admin
            {
                ID = 30,
                FName = "Ognen",
                LName = "Temelkovski",
                Friends = new List<Admin> { goce, miki }
            };
            Admin neno = new Admin
            {
                ID = 40,
                FName = "Nenad",
                LName = "Popovski"
            };
            Admin boki = new Admin
            {
                ID = 50,
                FName = "Bojan",
                LName = "Damevski",
                Friends = new List<Admin> { goce, miki, neno, ognen}
            };

            return new List<Admin> { goce, miki, ognen, neno, boki };
        }
    }
}

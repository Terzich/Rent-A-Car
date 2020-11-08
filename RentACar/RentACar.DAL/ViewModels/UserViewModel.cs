using RentACar.DAL.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.DAL.ViewModels
{
    public class UserViewModel
    {
        public UserViewModel()
        {

        }
        public UserViewModel(User user)
        {
            Id = user.Id;
            FirstName = user.FirstName;
            Lastname = user.Lastname;
            Username = user.Username;
            DateofBirth = user.DateofBirth;
            CityId = user.CityId;
            CityName = user.City.Name;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public DateTime DateofBirth { get; set; }
        public int CityId { get; set; }
        public string CityName { get; set; }


    }
}

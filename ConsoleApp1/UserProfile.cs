using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class UserProfile:Profile
    {
        private MapperConfiguration _config;
        public UserProfile()
        {
            _config = new MapperConfiguration(
                cfg=>
                {
                    cfg.CreateMap<UserDTO, User>()
                    .ForMember(dst => dst.Name
                    , opt => opt.MapFrom(src => src.FirstName + "," + src.LastName))
                    .ForMember(dest=>dest.UserContact,opt=>opt.MapFrom(src=>src.UserContactDTO));
                    
                    cfg.CreateMap<ContactDTO, Contact>();
                    
                });
        }
        public User Map(UserDTO dto)
        {
            var mapper = _config.CreateMapper();
            return mapper.Map<UserDTO,User>(dto);
        }

    }

    public abstract class Kingdom
    {
        public Kingdom()
        {

        }
        public void GetDetail()
        {
            Console.WriteLine("Jungle Book");
        }
    }
}

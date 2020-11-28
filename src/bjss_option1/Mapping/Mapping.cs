using System;
using AutoMapper;
using bjss_option1.Models;
using bjss_option1.Entities;

namespace bjss_option1.Mapping
{
    public static class Mapping
    {
        public static void CreateMappings()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Personal, PersonalEntity>());

            config.CreateMapper().Map(x.)

        }
    }
}

﻿using AutoMapper;
using Cwmosh.Dtos;
using Cwmosh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cwmosh.App_Start
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
        }
    }
}
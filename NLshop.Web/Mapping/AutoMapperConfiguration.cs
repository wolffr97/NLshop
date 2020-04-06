﻿using AutoMapper;
using NLshop.Web.Models;
using NLShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NLshop.Web.Mapping
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.CreateMap<Post, PostViewModel>();
            Mapper.CreateMap<PostCategory, PostCategoryViewModel>();
            Mapper.CreateMap<Tag, TagViewModel>();

        }


    }
}
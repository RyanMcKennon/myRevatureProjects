using AutoMapper;
using Monster.App.DataAcess.Models;
using MonsterApp.dataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Monster.App.DataAcess
{
    public class GenderAutoMapper
    {
        private MapperConfiguration mapper = new MapperConfiguration( m => m.CreateMap<Gender,GenderDAO>().ForMember(d => d.id, o => o.MapFrom(s => s.GenderID)));
    }
}
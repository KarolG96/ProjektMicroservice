using AutoMapper;
using Projekt.Services.CouponAPI.Models.Dto;

namespace Projekt.Services.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto, CouponDto>();
                config.CreateMap<CouponDto, CouponDto>();
            });
            return mappingConfig;
        }
    }
}

using AutoMapper;
using MangoAgain.Models.Domain;
using MangoAgain.Models.DTO;

namespace MangoAgain
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDTO, Coupon>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}

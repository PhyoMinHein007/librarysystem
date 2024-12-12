using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace Library.Entity
{
    public static class BuildMap
    {
        private static MapperConfiguration _mapperConfig = null;
        private static IMapper _mapper = null;
        private static IServiceProvider _serviceProvider = null;

        public static IMapper Mapper
        {
            get
            {
                if (_mapper == null)
                {
                    _mapperConfig = new MapperConfiguration(cfg =>
                    {
                        cfg.AddProfile<BizOMapper>();
                    });
                    _mapperConfig.AssertConfigurationIsValid();
                    _mapper = _mapperConfig.CreateMapper();

                    var services = new ServiceCollection();
                    services.AddAutoMapper(typeof(BizOMapper));
                    _serviceProvider = services.BuildServiceProvider();
                }
                return _mapper;
            }
        }
    }
}

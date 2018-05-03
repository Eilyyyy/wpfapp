using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using WpfApp.Services.Abstract;

namespace WpfApp.Services
{
    public class AutoMapperEntityMapper : IEntityMapper
    {
        private readonly IMapper _mapper;

        public AutoMapperEntityMapper(IMapper mapper)
        {
            _mapper = mapper;
        }

        public TD Map<TS, TD>(TS source)
        {
            return _mapper.Map<TS, TD>(source);
        }
    }
}

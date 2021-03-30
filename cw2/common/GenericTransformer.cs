using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw2.common
{
    interface GenericTransformer<DOMAIN, DTO>
    {
        DOMAIN dtoToDomain(DTO dto);

        DTO domainToDto(DOMAIN dto);
    }
}

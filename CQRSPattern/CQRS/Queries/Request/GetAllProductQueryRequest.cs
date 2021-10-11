﻿using CQRSPattern.CQRS.Queries.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSPattern.CQRS.Queries.Request
{
    public class GetAllProductQueryRequest:IRequest<List<GetAllProductQueryResponse>>
    {
    }
}

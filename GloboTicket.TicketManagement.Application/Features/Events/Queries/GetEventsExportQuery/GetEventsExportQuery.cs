﻿using GloboTicket.TicketManagement.Application.Features.Events.Queries.GetEventsExportQuery;
using MediatR;

namespace GloboTicket.TicketManagement.Application.Features.Events.Queries.GetEventsExport
{
    public class GetEventsExportQuery : IRequest<EventExportFileVm>
    {
    }
}

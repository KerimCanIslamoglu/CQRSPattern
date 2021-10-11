using CQRSPattern.CQRS.Commands.Request;
using CQRSPattern.CQRS.Commands.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSPattern.CQRS.Handlers.CommandHandlers
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommandRequest, DeleteProductCommandResponse>
    {
        private ApplicationDbContext _db;

        public DeleteProductCommandHandler(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<DeleteProductCommandResponse> Handle(DeleteProductCommandRequest request, CancellationToken cancellationToken)
        {
            var deleteProduct = _db.Products.FirstOrDefault(p => p.Id == request.Id);
           _db.Products.Remove(deleteProduct);

            await _db.SaveChangesAsync();

            return new DeleteProductCommandResponse
            {
                IsSuccess = true
            };
        }
    }
}

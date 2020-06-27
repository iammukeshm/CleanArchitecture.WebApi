using Application.Interfaces.Repositories;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Products.Commands
{
    public partial class CreateProductCommand : IRequest<int>
    {
        public string Name { get; set; }
        public string Barcode { get; set; }
        public string Description { get; set; }
        public decimal Rate { get; set; }
    }
    public class CreateProductCommandHandler: IRequestHandler<CreateProductCommand, int>
    {
        private readonly IProductRepositoryAsync _productRepository;
        public CreateProductCommandHandler(IProductRepositoryAsync productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product();
            product.Barcode = request.Barcode;
            product.Description = request.Description;
            product.Name = request.Name;
            product.Rate = request.Rate;

            await _productRepository.AddAsync(product);
            return product.Id;
        }
    }
}

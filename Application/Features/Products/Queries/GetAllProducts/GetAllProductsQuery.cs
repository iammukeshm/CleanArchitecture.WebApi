using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Application.Interfaces.Repositories;
using Application.Wrappers;
using AutoMapper;
using MediatR;

namespace Application.Features.Products.Queries.GetAllProducts
{
    public class GetAllProductsQuery : IRequest<PagedResponse<IEnumerable<GetAllProductsViewModel>>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }

    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery,
        PagedResponse<IEnumerable<GetAllProductsViewModel>>>
    {
        private readonly IMapper _mapper;
        private readonly IProductRepositoryAsync _productRepository;

        public GetAllProductsQueryHandler(IProductRepositoryAsync productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<PagedResponse<IEnumerable<GetAllProductsViewModel>>> Handle(GetAllProductsQuery request,
            CancellationToken cancellationToken)
        {
            var validFilter = _mapper.Map<GetAllProductsParameter>(request);
            var product = await _productRepository.GetPagedReponseAsync(validFilter.PageNumber, validFilter.PageSize);
            var productViewModel = _mapper.Map<IEnumerable<GetAllProductsViewModel>>(product);
            return new PagedResponse<IEnumerable<GetAllProductsViewModel>>(productViewModel, validFilter.PageNumber,
                validFilter.PageSize);
        }
    }
}
using WebAplication.Abstraction;
using WebAplication.Dto;
using WebAplication.Repository;

namespace WebAplication.Graph.Mutation
{
    public class Mutation(IProductRepository productRepository)
    {
        public int AddProduct(ProductDto productDto) => productRepository.AddProduct(productDto);
        public int AddProductGroup([Service] IProductGroupRepository productGroupRepository, ProductGroupDto productGroupDto) => productGroupRepository.AddProductGroup(productGroupDto);
        public int AddStorage([Service] IStorageRepository storageRepository, StorageDto storageDto) => storageRepository.AddStorage(storageDto);
    }
}

using WebAplication.Dto;

namespace WebAplication.Abstraction
{
    public interface IStorageRepository
    {
        IEnumerable<StorageDto> GetAllStorage();
        int AddStorage(StorageDto storageDto);
        void DeleteStorage(int id);
    }
}

using RealEstate_Dapper_Api.Dtos.ContactDtos;

namespace RealEstate_Dapper_Api.Repositories.ContactRepository
{
    public interface IContactRepository
    {

        public Task<List<ResultContactDto>> GetAllContactAsync();
        public Task<List<Last4ContactResultDto>> GetLast4Contact();

        void CreateContact(CreateContactDto createContactDto);
        void DeleteContact(int id);
        Task<GetByIdContactDto> GetContact(int id);
    }
}

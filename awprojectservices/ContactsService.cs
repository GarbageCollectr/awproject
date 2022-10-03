using awprojectmodels;

namespace awprojectservices
{
    public class ContactsService : IContactsService
    {
        public Task<IList<Contact>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Contact> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> AddOrUpdateAsync(Contact contact)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(Contact contact)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsAsync(int id)
        {
            throw new NotImplementedException();
        }


    }
}

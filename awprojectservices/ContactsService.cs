using awprojectmodels;
using awprojectrepositories;

namespace awprojectservices
{
    public class ContactsService : IContactsService
    {
        private IContactsRepository _contactsRepository;

        public ContactsService(IContactsRepository contactsRepository)
        {
            _contactsRepository = contactsRepository;
        }

        public async Task<IList<Contact>> GetAllAsync()
        {
            return await _contactsRepository.GetAllAsync();
        }

        public async Task<Contact> GetAsync(int id)
        {
            return await _contactsRepository.GetAsync(id);
        }

        public async Task<int> AddOrUpdateAsync(Contact contact)
        {
            return await _contactsRepository.AddOrUpdateAsync(contact);
        }

        public async Task<int> DeleteAsync(Contact contact)
        {
            return await _contactsRepository.DeleteAsync(contact);
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await _contactsRepository.DeleteAsync(id);
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await _contactsRepository.ExistsAsync(id);
        }


    }
}

using AddressBook.Models;
namespace AddressBook.Services.Interfaces
{
    public interface IAddressBookService
    {
        public Task<IEnumerable<Category>> GetUserCategoriesAsync(string appUserId);

        public Task AddContactToCategoryAsync(int categoryId, int contactId);

        public Task<IEnumerable<Category>> GetContactCategoriesAsync(int contactId);

        public Task RemoveContactFromCategoryAsync(int categoryId, int contactId);

        public Task <IEnumerable<int>> GetContactCategoryIdsAsync(int contactId);


    }
}

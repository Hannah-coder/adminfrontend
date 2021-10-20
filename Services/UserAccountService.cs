using AdminFrontEnd.Data;
using AdminFrontEnd.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminFrontEnd.Services
{
    public class UserAccountService
    {
        #region Property
        private readonly ApplicationDbContext _applicationDbContext;
        #endregion

        #region Constructor
        public UserAccountService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        #endregion

        #region Get List of User Accounts
        public async Task<List<UserAccounts>> GetUserAccountsAsync()
        {
            //return (List<UserAccounts>)await _monitoringAPIClient.GetUserAccounts();
            return await _applicationDbContext.UserAccounts.ToListAsync();
        }
        #endregion

        #region Create User Account
        public async Task<bool> CreateUserAccountAsync(UserAccounts userAccount)
        {
            await _applicationDbContext.UserAccounts.AddAsync(userAccount);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Get user account by Id
        public async Task<UserAccounts> GetUserAccountsAsync(int Id)
        {
            UserAccounts userAccount = await _applicationDbContext.UserAccounts.FirstOrDefaultAsync(c => c.UserId.Equals(Id));
            return userAccount;
        }
        #endregion

        #region Update user account
        public async Task<bool> UpdateUserAccountAsync(UserAccounts userAccount)
        {
            _applicationDbContext.UserAccounts.Update(userAccount);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Delete user account
        public async Task<bool> DeleteUserAccountAsync(UserAccounts userAccount)
        {
            _applicationDbContext.Remove(userAccount);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }
        #endregion
    }
}

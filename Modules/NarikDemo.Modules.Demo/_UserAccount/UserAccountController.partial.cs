using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Narik.Common.Data.DomainService;
using Narik.Common.Shared.Models;

namespace NarikDemo.Modules.Demo._UserAccount
{
    public partial class UserAccountController
    {
        private readonly IPasswordHasher<ApplicationUser> _passwordHasher;

        public UserAccountController(IPasswordHasher<ApplicationUser> passwordHasher)
        {
            _passwordHasher = passwordHasher;
        }

        protected override EntityUpdateFiledsInfo GetEntityUpdateFiledsInfo(UserAccountViewModel entity)
        {
            var preventItems = new List<string>();
            if (entity.Password == "$$default")
                preventItems.Add("Password");
            return new EntityUpdateFiledsInfo(preventItems);
        }

        protected override void CompleteBeforeSubmitPost(UserAccountViewModel entity, PostData<UserAccountViewModel> postData, bool isNew)
        {
            var currentId = Convert.ToInt32(SessionHelper.User.UserId);
            entity.CreateBy = currentId;
            entity.Password = _passwordHasher.HashPassword(null, entity.UserName.ToLower() + entity.Password);
           
        }

        protected  override async Task<string> ValidateBeforeSubmitPostAsync(UserAccountViewModel entity, PostData<UserAccountViewModel> postData, bool isNew)
        {
            var existUserId =await DomainService.ExistsUserName(entity.UserName,entity.Id);
            if (existUserId)
                return "errors.DUPLICATE_USER_NAME";
            if (entity.UserName?.ToLower()=="admin")
                return "errors.ADMIN_IS_NOT_EDITABLE";
            return await base.ValidateBeforeSubmitPostAsync(entity, postData, isNew);
        }

        

        protected override async Task<string> DoBeforeDeleteAsync(List<ChangeSetEntry> changes)
        {
            var ids = changes.Select(x => x.Entity).OfType<UserAccountViewModel>().Select(x=>x.Id).ToList();
            var isAdminId =await  DomainService.IsAdminId(ids);
            if (isAdminId)
                return  "errors.ADMIN_IS_NOT_EDITABLE";
            return null;
        }
    }
}

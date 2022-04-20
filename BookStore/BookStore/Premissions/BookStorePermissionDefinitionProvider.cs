﻿using BookStore.Localization;
using Volo.Abp.Localization;
using Volo.Abp.Authorization.Permissions;

namespace BookStore.Permissions
{
    public class BookStorePermissionDefinitionProvider : PermissionDefinitionProvider
    {

        public override void Define(IPermissionDefinitionContext context)
        {
            var bookStoreGroup = context.AddGroup(BookStorePermissions.GroupName, L("Permission:BookStore"));

            var authorsPermission = bookStoreGroup.AddPermission(BookStorePermissions.Authors.Default, L("Permission:Authors"));
            authorsPermission.AddChild(BookStorePermissions.Authors.Create, L("Permission:Authors.Create"));
            authorsPermission.AddChild(BookStorePermissions.Authors.Edit, L("Permission:Authors.Edit"));
            authorsPermission.AddChild(BookStorePermissions.Authors.Delete, L("Permission:Authors.Delete"));

        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<BookStoreResource>(name);
        }
    }
}

namespace BookStore.Premissions
{
    public static class BookStorePermissions
    {
        public const string GroupName = "BookStore";

        public static class Authors
        {
            public const string Default = GroupName + ".Authors";
            public const string Create = Default + ".Create";
            public const string Edit = Default + ".Edit";
            public const string Delete = Default + ".Delete";
        }

    }
}

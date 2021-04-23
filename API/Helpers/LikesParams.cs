namespace API.Helpers
{
    public class LikesParams : PaginationParams
    {
        internal int userId;

        public int UserId { get; set; }
        public string Predicate { get; set; }
    }
}
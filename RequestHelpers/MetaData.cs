namespace API.RequestHelpers
{
    // This is the DataType of the RESULT that we will send back to our client after all the search, sort, pagination,...
    // These information will help us display in the UI
    public class MetaData
    {
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
    }
} 
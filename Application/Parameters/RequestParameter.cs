namespace Application.Filters
{
    public class RequestParameter
    {
        public RequestParameter()
        {
            PageNumber = 1;
            PageSize = 10;
        }

        public RequestParameter(int pageNumber, int pageSize)
        {
            PageNumber = pageNumber < 1 ? 1 : pageNumber;
            PageSize = pageSize > 10 ? 10 : pageSize;
        }

        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
}
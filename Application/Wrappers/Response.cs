using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Wrappers
{
    public class Response<T>
    {
        public Response()
        {
        }
        public Response(T data)
        {
            Succeeded = true;
            Message = string.Empty;
            Errors = null;
            Data = data;
        }
        public bool Succeeded { get; set; }

        public List<string> Errors { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
    }
}

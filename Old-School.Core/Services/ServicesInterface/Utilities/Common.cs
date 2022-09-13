using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Old_School.Core.Services.ServicesInterface.Utilities
{
    public class Common
    {
        public class ServiceReturnType<T>
        {
            public bool Status { get; set; }
            public string Message { get; set; }
            public T Data { get; set; }
            public T Error { get; set; }
        }
    }
}

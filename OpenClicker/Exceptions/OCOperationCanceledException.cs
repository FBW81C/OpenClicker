using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OpenClicker.Exceptions;
public class OCOperationCanceledException : Exception
{
    public OCOperationCanceledException()
    {
    }

    public OCOperationCanceledException(string? message) : base(message)
    {
    }

    public OCOperationCanceledException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected OCOperationCanceledException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OpenClicker.Exceptions;
public class OCInvalidFile : Exception
{
    public OCInvalidFile()
    {
    }

    public OCInvalidFile(string? message) : base(message)
    {
    }

    public OCInvalidFile(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected OCInvalidFile(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}

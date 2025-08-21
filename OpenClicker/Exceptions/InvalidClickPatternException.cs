using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OpenClicker.Exceptions;
public class InvalidClickPatternException : Exception
{
    public InvalidClickPatternException()
    {
    }

    public InvalidClickPatternException(string? message) : base(message)
    {
    }

    public InvalidClickPatternException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected InvalidClickPatternException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}

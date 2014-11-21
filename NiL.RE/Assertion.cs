using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiL.RE
{
    internal abstract class Assertion : Term
    {

    }

    /// <summary>
    /// ^
    /// </summary>
    internal sealed class StartOfStream : Assertion
    {

    }

    /// <summary>
    /// $
    /// </summary>
    internal sealed class EndOfStream : Assertion
    {

    }

    /// <summary>
    /// \b
    /// </summary>
    internal sealed class BoundOfWord : Assertion
    {

    }

    /// <summary>
    /// \B
    /// </summary>
    internal sealed class NotBoundOfWort : Assertion
    {

    }

    /// <summary>
    /// ( ? = Disjunction )
    /// </summary>
    internal sealed class Preview : Assertion
    {

    }

    /// <summary>
    /// ( ? ! Disjunction )
    /// </summary>
    internal sealed class NegativePreview : Assertion
    {

    }
}

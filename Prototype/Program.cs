using System.Collections.Generic;

namespace Prototype
{
    class Program
    {

        static void Main(string[] args)
        {
            List<LinePiece> pieces = new List<LinePiece>();
            LinePiece piece1 = new LinePiece(Size.Medium);

            pieces.Add(piece1);

            //T zamanında
            pieces.Add(piece1.Clone() as LinePiece);

        }
    }
}

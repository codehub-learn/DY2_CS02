using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DY2_CS02
{
    internal class Triangle : Cat, IShape, ISpanFormattable, IEquatable<Triangle>, IComparable<Triangle>
    {
        public int baseCM { get; set; }
        public int heightCM { get; set; }

        public int CompareTo(Triangle? other)
        {
            throw new NotImplementedException();
        }

        public bool Equals(Triangle? other)
        {
            throw new NotImplementedException();
        }

        public float GetArea()
        {
            return 0.5f * baseCM * heightCM;
        }

        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            throw new NotImplementedException();
        }

        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }
    }
}

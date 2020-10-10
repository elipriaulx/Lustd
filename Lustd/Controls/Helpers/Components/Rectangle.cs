using System;
using System.Runtime.InteropServices;
using System.Windows;

namespace Lustd.Controls.Helpers.Components
{
    [StructLayout(LayoutKind.Sequential, Pack = 0)]
    public struct Rectangle
    {
        public int left;
        public int top;
        public int right;
        public int bottom;

        public static readonly Rectangle Empty;

        public int Width => Math.Abs(right - left);

        public int Height => bottom - top;

        public Rectangle(int left, int top, int right, int bottom)
        {
            this.left = left;
            this.top = top;
            this.right = right;
            this.bottom = bottom;
        }


        public Rectangle(Rectangle rcSrc)
        {
            left = rcSrc.left;
            top = rcSrc.top;
            right = rcSrc.right;
            bottom = rcSrc.bottom;
        }

        public bool IsEmpty => left >= right || top >= bottom;

        public override string ToString()
        {
            return $"Rectangle - Left: {left}, Top: {top}, Right: {right}, Bottom: {bottom}";
        }

        public override bool Equals(object obj)
        {
            return obj is Rectangle rectangle && this == rectangle;
        }

        public override int GetHashCode()
        {
            return left.GetHashCode() + top.GetHashCode() + right.GetHashCode() + bottom.GetHashCode();
        }

        public static bool operator ==(Rectangle lhs, Rectangle rhs)
        {
            return lhs.left == rhs.left && lhs.top == rhs.top && lhs.right == rhs.right && lhs.bottom == rhs.bottom;
        }

        public static bool operator !=(Rectangle lhs, Rectangle rhs)
        {
            return !(lhs == rhs);
        }
    }
}
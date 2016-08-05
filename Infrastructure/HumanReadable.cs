using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure
{

    public static class HumanReadable
    {

        static string asterIt( char[] arg, int arglen )
        {
            for (int i = 0; i < arglen; i++)
                arg[i] = '*';

            return new string( arg );
        }

        static string editTransfer( string str, Mask m )
        {
            char[] mask = m.FullMask.ToCharArray();
            int masklen = m.MaskLen;
            char[] result = new char[masklen];
            int destlen = masklen;

            bool numeric = (m.MaskType & MType.Nmrc) == MType.Nmrc;
            bool stringi = (m.MaskType & MType.Strn) == MType.Strn;
            bool toleft = (m.MaskType & MType.Left) == MType.Left;
            bool toright = (m.MaskType & MType.Right) == MType.Right;
            bool tocnter = (m.MaskType & MType.Center) == MType.Center;
            bool edited = (m.MaskType & MType.Edit) == MType.Edit;
            bool trimed = (m.MaskType & MType.Trim) == MType.Trim;

            if (trimed)
                str = str.Trim();

            char[] source = str.ToCharArray();
            int srcelen = str.Length;

            int start;
            int end;

            if (numeric) {
                if (str.Length > m.MaskLen)
                    return asterIt( result, destlen );
            }

            int d;
            int s;
            int destorg = 0;

            if (!edited) {
                if (masklen > srcelen) {
                    if (!trimed) {
                        destlen = masklen;
                        result = new char[destlen];
                    }
                    else
                        return str;
                }
                else if (stringi)
                    toleft = true;
            again:
                if (toleft) {

                    for (s = 0, d = destorg; s < srcelen && d < destlen; d++, s++)
                        result[d] = source[s];

                    for (; d < destlen; d++)
                        result[d] = ' ';

                    return new string( result );
                }

                if (toright) {

                    for (s = (srcelen - 1), d = (destlen - 1); s >= 0 && d >= 0; s--, d--)
                        result[d] = source[s];

                    for (; d >= 0; d--)
                        result[d] = ' ';

                    return new string( result );
                }

                if (tocnter) {
                    int dif = masklen - srcelen;
                    if (dif <= 0) {
                        if (numeric)
                            return asterIt( result, destlen );
                        else {
                            toleft = true;
                            goto again;
                        }
                    }

                    destorg = dif / 2;
                    toleft = true;
                    goto again;

                }
            }
            else {
                string echars = "@#0";
                int y = 0;
                for (s = 0, d = 0; s < srcelen && d < destlen; ) {
                    char? x;
                    if (y < masklen)
                        x = mask[y++];
                    else
                        x = null;
                    if (x != null && echars.Strchr( x.Value ))
                        result[d++] = source[s++];
                    else if (x != null)
                        result[d++] = x.Value;
                    else
                        result[d++] = '?';

                }

                for (; d < destlen; d++)
                    result[d] = '?';

                return new string( result );

            }

            return str;
        }

        public static string ToString( this string str, Mask m )
        {

            if (m.MaskLen <= 0 || m.MaskLen == str.Length)
                return str;

            return editTransfer( str, m );
        }

        public static string ToString( this Boolean b, Mask m )
        {
            return b ? m.TString : m.FString;
        }

        public static string ToString( this Boolean? b, Mask m )
        {
            return b == null ? m.NilString : (b.Value ? m.TString : m.FString);
        }

        public static string ToString( this Byte b, Mask m )
        {
            string str = b.ToString( m.RawMask );

            if (m.MaskLen <= 0 || m.MaskLen == str.Length)
                return str;

            return editTransfer( str, m );
        }

        public static string ToString( this Byte? b, Mask m )
        {
            return b == null ? m.NilString : b.Value.ToString( m );
        }

        public static string ToString( this SByte b, Mask m )
        {
            string str = b.ToString( m.RawMask );

            if (m.MaskLen <= 0 || m.MaskLen == str.Length)
                return str;

            return editTransfer( str, m );
        }

        public static string ToString( this SByte? b, Mask m )
        {
            return b == null ? m.NilString : b.Value.ToString( m );
        }


        public static string ToString( this Int64 v, Mask m )
        {
            string str = v.ToString( m.RawMask );

            if (m.MaskLen <= 0 || m.MaskLen == str.Length)
                return str;

            return editTransfer( str, m );

        }

        public static string ToString( this Int64? v, Mask m )
        {
            if (v == null)
                return m.NilString;
            else
                return v.Value.ToString( m );

        }

        public static string ToString( this Double v, Mask m )
        {
            string str = v.ToString( m.RawMask );

            if (m.MaskLen <= 0 || m.MaskLen == str.Length)
                return str;

            return editTransfer( str, m );

        }

        public static string ToString( this Double? v, Mask m )
        {
            if (v == null)
                return m.NilString;
            else
                return v.Value.ToString( m );

        }

        public static string ToString( this Decimal v, Mask m )
        {
            string str = v.ToString( m.RawMask );

            if (m.MaskLen <= 0 || m.MaskLen == str.Length)
                return str;

            return editTransfer( str, m );

        }

        public static string ToString( this Decimal? v, Mask m )
        {
            if (v == null)
                return m.NilString;
            else
                return v.Value.ToString( m );

        }

        public static string ToString( this DateTime v, Mask m )
        {
            string str = v.ToString( m.RawMask );

            if (m.MaskLen <= 0 || m.MaskLen == str.Length)
                return str;

            return editTransfer( str, m );

        }

        public static string ToString( this DateTime? v, Mask m )
        {
            if (v == null)
                return m.NilString;
            else
                return v.Value.ToString( m );

        }




        public static bool Strchr( this string str, char c )
        {
            if (str.IndexOf( c ) > -1)
                return true;
            else
                return false;
        }
    }
}

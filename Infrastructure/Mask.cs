using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure
{
    public enum MType
    {
        None = 0x0000,
        Left = 0x0001,
        Center = 0x0002,
        Right = 0x0004,
        Type = 0x0008,
        Nmrc = 0x0010 | Type,
        Date = 0x0020 | Type,
        Strn = 0x0040 | Type,
        Bool = 0x0080 | Type,
        Trim = 0x4000,
        Edit = 0x8000
    }

    public class Mask
    {
        MType mType = MType.None;

        string tStr = "Si";
        string fStr = "No";

        string mask;
        string sfmask = "{0}";
        int mlen;
        int prec = 0;

        string nilStr = "?";

        protected void evalMask()
        {
            bool periodSeen = false;
            bool dateMaybe = false;
            bool nmrcMaybe = false;
            char[] cc = mask.ToCharArray();
            for (int i = 0; i < cc.Length; i++) {
                if ("dmyDMY".IndexOf( cc[i] ) > -1)
                    dateMaybe = true;
                else if ("#0".IndexOf( cc[i] ) > -1) {
                    nmrcMaybe = true;
                    if (periodSeen)
                        prec++;
                }
                else if (cc[i] == '.' && nmrcMaybe)
                    periodSeen = true;
            }
            if (dateMaybe)
                mType = MType.Date;
            else if (nmrcMaybe)
                mType = MType.Nmrc;
        }

        public Mask( string m )
        {
            mask = m;
            mlen = m.Length;
            evalMask();
        }

        public Mask( MType t, int len )
        {
            mType = t;
            mlen = len;
        }

        protected void checkEditMask()
        {
            if ((mType & MType.Edit) == MType.Edit)
                return;

            char[] amask = mask.ToCharArray();

            int pc = 0;

            for (int i = 0; i < mask.Length; i++) {
                if (amask[i] == '.')
                    pc++;
            }

            if (pc > 1) {
                mType |= MType.Edit;
                return;
            }

            string echars = (mType & MType.Strn) == MType.Strn ? "@#0" : "#0.";

            for (int i = 0; i < mask.Length; i++) {
                //if ( amask[i] != '@' && amask[i] != '#' && amask[i] != '0' && amask[i] != '.' ) {
                if (!echars.Strchr( amask[i] )) {
                    mType |= MType.Edit;
                    break;
                }
            }
        }

        //public override string ToString ()
        //{
        //	 return mask;
        //}

        public Mask( MType t, string m )
        {
            mType = t;
            mlen = m.Length;
            mask = m;
            evalMask();
            if ((mType & MType.Strn) == MType.Strn || (mType & MType.Nmrc) == MType.Nmrc)
                checkEditMask();
        }

        public Mask( string t, string f )
        {
            if (t != null)
                tStr = t;
            if (f != null)
                fStr = f;

            mType = MType.Bool;
        }

        public Mask( string t, string f, int len )
            : this( t, f )
        {
            if (len > 0)
                mlen = len;
        }

        public string TString { get { return tStr; } }
        public string FString { get { return fStr; } }

        public MType MaskType
        {
            get { return mType; }
            set { mType = value; }
        }

        public string SFMask { get { return sfmask; } }

        public string RawMask
        {
            get
            {
                if ((mType & MType.Edit) == MType.Edit)
                    return null;
                return mask;
            }
        }

        public string FullMask
        {
            get
            {
                string pmask = mask;
                if (!pmask.Contains( ":" )) {
                    string len = pmask.Length.ToString();
                    pmask = "{0," + len + ":" + mask + "}";
                }
                else
                    pmask = "{0," + mask + "}";
                return pmask;

            }
        }

        public string ToStringMask
        {
            get
            {
                if (mType == MType.Nmrc) {
                    if (prec == 0)
                        return FullMask;
                    else
                        return "F" + prec.ToString();
                }
                else
                    return mask;
            }
        }

        public int MaskLen { get { return mlen; } }

        public string NilString { get { return nilStr; } }

        public string ApplyMask( string n )
        {
            if (n == null) {
                char[] ra = new char[mask.Length];
                int x = this.mType == MType.Nmrc ? ra.Length - 1 : 0;
                for (int i = 0; i < ra.Length; i++) {
                    if (i == x)
                        ra[i] = nilStr[0];
                    else
                        ra[i] = ' ';
                }
                return new string( ra );
            }
            if (n.Length > mask.Length)
                return new string( '*', mask.Length );

            char[] sa = n.ToCharArray();
            char[] da = mask.ToCharArray();

            int s = sa.Length - 1;
            int d = da.Length - 1;

            for (; d >= 0; ) {
                da[d--] = sa[s--];
                if (s < 0)
                    break;
            }

            for (; d >= 0; d--) {
                if (da[d] == '#')
                    da[d] = ' ';
            }

            return new string( da );

        }
    }
}

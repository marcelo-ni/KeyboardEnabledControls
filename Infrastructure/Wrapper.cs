using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure
{
    public class Wrapper
    {
        Byte _byte;
        SByte _sbyte;

        Byte? _nbyte;
        SByte? _nsbyte;

        Int16 _int16;
        Int16? _nint16;

        Int32 _int32;
        Int32? _nint32;

        Int64 _int64;
        //UInt64 _uint64;

        Int64? _nint64;
        //UInt64? _nuint64;


        Double _double;
        Double? _ndouble;

        Decimal _decimal;
        Decimal? _ndecimal;

        Boolean _boolean;
        Boolean? _nboolean;

        Char _char;
        Char? _nchar;

        DateTime _datetime;
        DateTime? _ndatetime;

        String _string;

        VType _tcode;

        Mask _mask;

        static public Wrapper CopyWrapper( Wrapper w )
        {
            Wrapper retval = new Wrapper( "-", null );
            switch (w._tcode) {
                case VType.Boolean :
                    retval = new Wrapper( w._boolean, w.Mask );
                    break;
                case VType.nBoolean :
                    retval = new Wrapper( w._nboolean, w.Mask );
                    break;
                case VType.Byte :
                    retval = new Wrapper( w._byte, w.Mask );
                    break;
                case VType.nByte :
                    retval = new Wrapper( w._nbyte, w.Mask );
                    break;
                case VType.SByte :
                    retval = new Wrapper( w._sbyte, w.Mask );
                    break;
                case VType.nSByte :
                    retval = new Wrapper( w._nsbyte, w.Mask );
                    break;
                case VType.Char :
                    retval = new Wrapper( w._char, w.Mask );
                    break;
                case VType.nChar :
                    retval = new Wrapper( w._nchar, w.Mask );
                    break;
                case VType.DateTime :
                    retval = new Wrapper( w._datetime, w.Mask );
                    break;
                case VType.nDateTime :
                    retval = new Wrapper( w._ndatetime, w.Mask );
                    break;
                case VType.Decimal :
                    retval = new Wrapper( w._decimal, w.Mask );
                    break;
                case VType.nDecimal :
                    retval = new Wrapper( w._ndecimal, w.Mask );
                    break;
                case VType.Double :
                    retval = new Wrapper( w._double, w.Mask );
                    break;
                case VType.nDouble :
                    retval = new Wrapper( w._ndouble, w.Mask );
                    break;
                case VType.Int16 :
                    retval = new Wrapper( w._int16, w.Mask );
                    break;
                case VType.nInt16 :
                    retval = new Wrapper( w._nint16, w.Mask );
                    break;
                case VType.Int32:
                    retval = new Wrapper( w._int32, w.Mask );
                    break;
                case VType.nInt32:
                    retval = new Wrapper( w._nint32, w.Mask );
                    break;
                case VType.Int64:
                    retval = new Wrapper( w._int64, w.Mask );
                    break;
                case VType.nInt64:
                    retval = new Wrapper( w._nint64, w.Mask );
                    break;
                case VType.String :
                    retval = new Wrapper( w._string, w.Mask );
                    break;
                case VType.nString :
                    retval = new Wrapper( w._string, w.Mask, true );
                    break;
            }

            return retval;
        }



        public Wrapper( Byte b, Mask mask )
        {
            _mask = mask != null ? mask : new Mask( "###" );
            if (_mask.MaskType == MType.None)
                _mask.MaskType = MType.Nmrc | MType.Right;
            _tcode = VType.Byte;
            _byte = b;
        }

        public Wrapper( Byte? b, Mask mask )
        {
            _mask = mask != null ? mask : new Mask( "###" );
            if (_mask.MaskType == MType.None)
                _mask.MaskType = MType.Nmrc | MType.Right;
            _tcode = VType.nByte;
            _nbyte = b;
        }


        public Wrapper( SByte b, Mask mask )
        {
            _mask = mask != null ? mask : new Mask( "###" );
            if (_mask.MaskType == MType.None)
                _mask.MaskType = MType.Nmrc | MType.Right;

            _tcode = VType.SByte;
            _sbyte = b;
        }

        public Wrapper( SByte? b, Mask mask )
        {
            _mask = mask != null ? mask : new Mask( "###" );
            if (_mask.MaskType == MType.None)
                _mask.MaskType = MType.Nmrc | MType.Right;

            _tcode = VType.nSByte;
            _nsbyte = b;
        }

        public Wrapper( Int16 b, Mask mask )
        {
            _mask = mask != null ? mask : new Mask( "#####" );
            if (_mask.MaskType == MType.None)
                _mask.MaskType = MType.Nmrc | MType.Right;

            _tcode = VType.Int16;
            _int16 = b;
        }

        public Wrapper( Int16? b, Mask mask )
        {
            _mask = mask != null ? mask : new Mask( "#####" );
            if (_mask.MaskType == MType.None)
                _mask.MaskType = MType.Nmrc | MType.Right;

            _tcode = VType.nInt16;
            _nint16 = b;
        }

        public Wrapper( Int32 b, Mask mask )
        {
            _mask = mask != null ? mask : new Mask( "#####" );
            if (_mask.MaskType == MType.None)
                _mask.MaskType = MType.Nmrc | MType.Right;

            _tcode = VType.Int32;
            _int32 = b;
        }

        public Wrapper( Int32? b, Mask mask )
        {
            _mask = mask != null ? mask : new Mask( "#####" );
            if (_mask.MaskType == MType.None)
                _mask.MaskType = MType.Nmrc | MType.Right;

            _tcode = VType.nInt32;
            _nint32 = b;
        }




        public Wrapper( Int64 b, Mask mask )
        {
            _mask = mask != null ? mask : new Mask( "#####" );
            if (_mask.MaskType == MType.None)
                _mask.MaskType = MType.Nmrc | MType.Right;

            _tcode = VType.Int64;
            _int64 = b;
        }

        //public Wrapper( UInt64 b, Mask mask )
        //{
        //	_mask = mask; _tcode = VType.UInt64;
        //	_uint64 = b;
        //}

        public Wrapper( Int64? b, Mask mask )
        {
            _mask = mask != null ? mask : new Mask( "#####" );
            if (_mask.MaskType == MType.None)
                _mask.MaskType = MType.Nmrc | MType.Right;

            _tcode = VType.nInt64;
            _nint64 = b;
        }

        public Wrapper( Double b, Mask mask )
        {
            _mask = mask != null ? mask : new Mask( "#####.##" );
            if (_mask.MaskType == MType.None)
                _mask.MaskType = MType.Nmrc | MType.Right;

            _tcode = VType.Double;
            _double = b;
        }

        public Wrapper( Double? b, Mask mask )
        {
            _mask = mask != null ? mask : new Mask( "#####.##" );
            if (_mask.MaskType == MType.None)
                _mask.MaskType = MType.Nmrc | MType.Right;

            _tcode = VType.nDouble;
            _ndouble = b;
        }

        public Wrapper( Decimal b, Mask mask )
        {
            _mask = mask != null ? mask : new Mask( "#####.##" );
            if (_mask.MaskType == MType.None)
                _mask.MaskType = MType.Nmrc | MType.Right;

            _tcode = VType.Decimal;
            _decimal = b;
        }

        public Wrapper( Decimal? b, Mask mask )
        {
            _mask = mask != null ? mask : new Mask( "#####.##" );
            if (_mask.MaskType == MType.None)
                _mask.MaskType = MType.Nmrc | MType.Right;

            _tcode = VType.nDecimal;
            _ndecimal = b;
        }

        public Wrapper( Boolean b, Mask mask )
        {
            _mask = mask != null ? mask : new Mask( "V", "F" );
            if (_mask.MaskType == MType.None)
                _mask.MaskType = MType.Bool | MType.Center;

            _tcode = VType.Boolean;
            _boolean = b;
        }

        public Wrapper( Boolean? b, Mask mask )
        {
            _mask = mask != null ? mask : new Mask( "V", "F" );
            if (_mask.MaskType == MType.None)
                _mask.MaskType = MType.Bool | MType.Center;

            _tcode = VType.nBoolean;
            _nboolean = b;
        }

        public Wrapper( Char b, Mask mask )
        {
            _mask = mask;
            _tcode = VType.Char;
            _char = b;
        }

        public Wrapper( Char? b, Mask mask )
        {
            _mask = mask;
            _tcode = VType.nChar;
            _nchar = b;
        }

        public Wrapper( DateTime b, Mask mask )
        {
            _mask = mask != null ? mask : new Mask( "yyyy-MM-dd" );
            if (_mask.MaskType == MType.None)
                _mask.MaskType = MType.Date | MType.Left;

            _tcode = VType.DateTime;
            _datetime = b;
        }

        public Wrapper( DateTime? b, Mask mask )
        {
            _mask = mask != null ? mask : new Mask( "yyyy-MM-dd" );
            if (_mask.MaskType == MType.None)
                _mask.MaskType = MType.Date | MType.Left;

            _tcode = VType.nDateTime;
            _ndatetime = b;
        }

        public Wrapper( string b, Mask mask )
        {
            _mask = mask != null ? mask : new Mask( MType.Strn | MType.Left, 10 );
            if (_mask.MaskType == MType.None)
                _mask.MaskType = MType.Strn | MType.Left;

            _tcode = VType.String;
            _string = b;
        }

        public Wrapper( string b, Mask mask, bool nil ) : this( b, mask )
        {
            _tcode = VType.nString;            
        }


        //public Wrapper( UInt64? b, Mask mask )
        //{
        //	_mask = mask; _tcode = VType.nUInt64;
        //	_nuint64 = b;
        //}

        public bool HasValue
        {
            get
            {
                if ((_tcode & VType.Nullable) != VType.Nullable)
                    return true;

                if (_tcode == VType.String)
                    return _string != null;

                bool has = false;

                switch (_tcode) {
                    case VType.nByte:
                        has = _nbyte.HasValue;
                        break;
                    case VType.nSByte:
                        has = _nsbyte.HasValue;
                        break;
                    case VType.nInt64:
                        has = _nint64.HasValue;
                        break;
                    //case VType.nUInt64 :
                    //	has = _nuint64.HasValue;
                    //	break;
                    case VType.nDouble:
                        has = _ndouble.HasValue;
                        break;
                    case VType.nDecimal:
                        has = _ndecimal.HasValue;
                        break;
                    case VType.nBoolean:
                        has = _nboolean.HasValue;
                        break;
                    case VType.nChar:
                        has = _nchar.HasValue;
                        break;
                    case VType.nDateTime:
                        has = _ndatetime.HasValue;
                        break;

                }

                return has;
            }
        }

        public VType VType { get { return _tcode; } }

        public Type TypeOf
        {
            get
            {
                Type t = typeof( Boolean );

                switch (_tcode) {
                    case VType.nBoolean:
                        t = typeof( Boolean? );
                        break;
                    case VType.Byte:
                        t = typeof( Byte );
                        break;
                    case VType.nByte:
                        t = typeof( Byte? );
                        break;
                    case VType.SByte:
                        t = typeof( SByte );
                        break;
                    case VType.nSByte:
                        t = typeof( SByte? );
                        break;
                    case VType.Char:
                        t = typeof( Char );
                        break;
                    case VType.nChar:
                        t = typeof( Char? );
                        break;
                    case VType.Int16:
                        t = typeof( Int16 );
                        break;
                    case VType.nInt16:
                        t = typeof( Int16? );
                        break;
                    case VType.Int32:
                        t = typeof( Int32 );
                        break;
                    case VType.nInt32:
                        t = typeof( Int32? );
                        break;
                    case VType.Int64:
                        t = typeof( Int64 );
                        break;
                    case VType.nInt64:
                        t = typeof( Int64? );
                        break;
                    case VType.UInt16:
                        t = typeof( UInt16 );
                        break;
                    case VType.nUInt16:
                        t = typeof( UInt16? );
                        break;
                    case VType.UInt32:
                        t = typeof( UInt32 );
                        break;
                    case VType.nUInt32:
                        t = typeof( UInt32? );
                        break;
                    case VType.UInt64:
                        t = typeof( UInt64 );
                        break;
                    case VType.nUInt64:
                        t = typeof( UInt64? );
                        break;
                    case VType.Double:
                        t = typeof( Double );
                        break;
                    case VType.nDouble:
                        t = typeof( Double? );
                        break;
                    case VType.Decimal:
                        t = typeof( Decimal );
                        break;
                    case VType.nDecimal:
                        t = typeof( Decimal? );
                        break;
                    case VType.DateTime:
                        t = typeof( DateTime );
                        break;
                    case VType.nDateTime:
                        t = typeof( DateTime? );
                        break;
                    case VType.String:
                        t = typeof( string );
                        break;
                }

                return t;
            }
        }

        private void checkType( VType t )
        {
            if (t != _tcode)
                throw new VariantException( t, _tcode );
        }

        private void checkBaseType( VType t )
        {
            if ((t & _tcode) != t)
                throw new VariantException( t, _tcode );
        }


        public bool Try( out Byte r )
        {
            checkBaseType( VType.Byte );
            r = 0;
            bool ok = true;
            if ((ok = HasValue))
                r = (_tcode & VType.Nullable) == VType.Nullable ?
                     _nbyte.Value :
                     _byte;
            return ok;
        }

        public bool Try( out SByte r )
        {
            checkBaseType( VType.SByte );
            r = 0;
            bool ok = true;
            if ((ok = HasValue))
                r = (_tcode & VType.Nullable) == VType.Nullable ?
                     _nsbyte.Value :
                     _sbyte;
            return ok;
        }

        public bool Try( out Int16 r )
        {
            checkBaseType( VType.Int16 );
            r = 0;
            bool ok = true;
            if ((ok = HasValue))
                r = (_tcode & VType.Nullable) == VType.Nullable ?
                     _nint16.Value :
                     _int16;
            return ok;
        }

        public bool Try( out Int32 r )
        {
            checkBaseType( VType.Int32 );
            r = 0;
            bool ok = true;
            if ((ok = HasValue))
                r = (_tcode & VType.Nullable) == VType.Nullable ?
                     _nint32.Value :
                     _int32;
            return ok;
        }

        public bool Try( out Int64 r )
        {
            checkBaseType( VType.Int64 );
            r = 0;
            bool ok = true;
            if ((ok = HasValue))
                r = (_tcode & VType.Nullable) == VType.Nullable ?
                     _nint64.Value :
                     _int64;
            return ok;
        }

        public bool Try( out Double r )
        {
            checkBaseType( VType.Double );
            r = 0;
            bool ok = true;
            if ((ok = HasValue))
                r = (_tcode & VType.Nullable) == VType.Nullable ?
                     _ndouble.Value :
                     _double;
            return ok;
        }

        public bool Try( out Decimal r )
        {
            checkBaseType( VType.Decimal );
            r = 0;
            bool ok = true;
            if ((ok = HasValue))
                r = (_tcode & VType.Nullable) == VType.Nullable ?
                     _ndecimal.Value :
                     _decimal;
            return ok;
        }

        public bool Try( out Boolean r )
        {
            checkBaseType( VType.Boolean );
            r = false;
            bool ok = true;
            if ((ok = HasValue))
                r = (_tcode & VType.Nullable) == VType.Nullable ?
                     _nboolean.Value :
                     _boolean;
            return ok;
        }

        public bool Try( out Char r )
        {
            checkBaseType( VType.Char );
            r = ' ';
            bool ok = true;
            if ((ok = HasValue))
                r = (_tcode & VType.Nullable) == VType.Nullable ?
                     _nchar.Value :
                     _char;
            return ok;
        }

        public bool Try( out DateTime r )
        {
            checkBaseType( VType.DateTime );
            r = DateTime.MinValue;
            bool ok = true;
            if ((ok = HasValue))
                r = (_tcode & VType.Nullable) == VType.Nullable ?
                     _ndatetime.Value :
                     _datetime;
            return ok;
        }

        public bool Try( out string r )
        {
            checkBaseType( VType.String );
            r = String.Empty;
            bool ok = _string != null;
            if (ok)
                r = _string;
            return ok;
        }

        public bool TryCast( out Decimal r )
        {
            //checkBaseType( VType.Decimal );
            if ((_tcode & VType.Numeric) != VType.Numeric)
                throw new VariantException( VType.Numeric, _tcode );
            r = Decimal.MinValue;
            bool ok = true;
            if ((ok = HasValue)) {
                switch (_tcode) {
                    case VType.Byte:
                        r = (Decimal)_byte;
                        break;
                    case VType.nByte:
                        r = (Decimal)_nbyte.Value;
                        break;
                    case VType.SByte:
                        r = (Decimal)_sbyte;
                        break;
                    case VType.nSByte:
                        r = (Decimal)_nsbyte.Value;
                        break;
                    case VType.Int64:
                        r = (Decimal)_int64;
                        break;
                    case VType.nInt64:
                        r = (Decimal)_nint64.Value;
                        break;
                    case VType.Double:
                        r = (Decimal)_double;
                        break;
                    case VType.nDouble:
                        r = (Decimal)_ndouble.Value;
                        break;
                    case VType.Decimal:
                        r = _decimal;
                        break;
                    case VType.nDecimal:
                        r = _ndecimal.Value;
                        break;

                }
                //r = ( _tcode & VType.Nullable ) == VType.Nullable ? 
                //     ((Decimal?)_value).Value : 
                //     (Decimal)_value;
            }
            return ok;
        }

        public static bool operator ==( Wrapper a, Wrapper b )
        {
            // If both are null, or both are same instance, return true.
            if (System.Object.ReferenceEquals( a, b )) {
                return true;
            }

            // If one is null, but not both, return false.
            if (((object)a == null) || ((object)b == null)) {
                return false;
            }

            if ((a._tcode & VType.Numeric) == VType.Numeric) {
                if ((b._tcode & VType.Numeric) != VType.Numeric)
                    return false;
                Decimal av, bv;
                bool oka, okb;

                oka = a.TryCast( out av );
                okb = b.TryCast( out bv );

                if (!oka != okb)
                    return false;
                else if (oka)
                    return av == bv;
                else
                    return true;
            }
            else if (a._tcode == VType.DateTime) {
                if (b._tcode != VType.DateTime)
                    return false;
                DateTime av, bv;
                bool oka, okb;

                oka = a.Try( out av );
                okb = b.Try( out bv );

                if (!oka || !okb)
                    return false;
                else
                    return av.Year == bv.Year &&
                            av.Month == bv.Month &&
                            av.Day == bv.Day &&
                            av.Hour == bv.Hour &&
                            av.Minute == bv.Minute &&
                            av.Second == bv.Second;
            }
            else if (a._tcode == VType.String) {
                if (b._tcode != VType.String)
                    return false;
                return a._string == b._string;
            }

            return false;

            // Return true if the fields match:
        }

        public static bool operator !=( Wrapper a, Wrapper b )
        {
            return !(a == b);
        }

        private static VType getType( Wrapper a, Wrapper b )
        {
            return (VType)Math.Max( (int)a._tcode, (int)b._tcode );
        }

        private static Wrapper getResultType( Wrapper a, Wrapper b )
        {
            if ((int)a._tcode >= (int)b._tcode)
                return a;
            else
                return b;
        }


        private static Wrapper operate( Wrapper rt, Decimal a, Decimal b, char op )
        {

            if ((rt._tcode & VType.Numeric) != VType.Numeric)
                return bad;

            Decimal v = 0M;

            switch (op) {
                case '+':
                    v = a + b;
                    break;
                case '-':
                    v = a - b;
                    break;
                case '*':
                    v = a * b;
                    break;
                case '/':
                    if (b != 0M)
                        v = a / b;
                    else
                        v = Decimal.MinValue;
                    break;
            }

            Wrapper r = null;

            switch (rt._tcode) {
                case VType.Int16:
                case VType.Int32:
                case VType.Int64:
                    r = new Wrapper( (Int64)v, rt.Mask );
                    break;
                case VType.nInt16:
                case VType.nInt32:
                case VType.nInt64:
                    r = new Wrapper( (Int64?)v, rt.Mask );
                    break;
                case VType.Decimal:
                    r = new Wrapper( v, rt.Mask );
                    break;
                case VType.nDecimal:
                    r = new Wrapper( (Decimal?)v, rt.Mask );
                    break;
                case VType.Double:
                    r = new Wrapper( (Double)v, rt.Mask );
                    break;
                case VType.nDouble:
                    r = new Wrapper( (Double?)v, rt.Mask );
                    break;

            }

            return r; // new Wrapper( v, null );
        }

        private static bool getValue( Wrapper q, out Decimal here )
        {
            here = 0M;
            return q.TryCast( out here );
        }

        private static Wrapper bad
        {

            get { return new Wrapper( Decimal.MinValue, null ); }
        }

        private static bool checkNumeric( Wrapper a, Wrapper b )
        {
            if ((a._tcode & VType.Numeric) == VType.Numeric) {
                if ((b._tcode & VType.Numeric) != VType.Numeric)
                    return false;
                else
                    return true;
            }
            else
                return false;
        }

        public static Wrapper operator +( Wrapper a, Wrapper b )
        {
            if (!checkNumeric( a, b ))
                return bad;

            Decimal av, bv;

            if (!getValue( a, out av ))
                return bad;

            if (!getValue( b, out bv ))
                return bad;

            return operate( getResultType( a, b ), av, bv, '+' );
        }

        public static Wrapper operator -( Wrapper a, Wrapper b )
        {
            if (!checkNumeric( a, b ))
                return bad;

            Decimal av, bv;

            if (!getValue( a, out av ))
                return bad;

            if (!getValue( b, out bv ))
                return bad;

            return operate( getResultType( a, b ), av, bv, '-' );
        }

        public static Wrapper operator *( Wrapper a, Wrapper b )
        {
            if (!checkNumeric( a, b ))
                return bad;

            Decimal av, bv;

            if (!getValue( a, out av ))
                return bad;

            if (!getValue( b, out bv ))
                return bad;

            return operate( getResultType( a, b ), av, bv, '*' );
        }

        public static Wrapper operator /( Wrapper a, Wrapper b )
        {
            if (!checkNumeric( a, b ))
                return bad;

            Decimal av, bv;

            if (!getValue( a, out av ))
                return bad;

            if (!getValue( b, out bv ))
                return bad;

            return operate( getResultType( a, b ), av, bv, '/' );
        }

        public void Set( Boolean b )
        {
            checkType( VType.Boolean );
            _boolean = b;
        }

        public void Set( Boolean? b )
        {
            checkType( VType.nBoolean );
            _nboolean = b;
        }

        public void Set( Byte b )
        {
            checkType( VType.Byte );
            _byte = b;
        }

        public void Set( Byte? b )
        {
            checkType( VType.nByte );
            _nbyte = b;
        }

        public void Set( SByte b )
        {
            checkType( VType.SByte );
            _sbyte = b;
        }

        public void Set( SByte? b )
        {
            checkType( VType.nSByte );
            _nsbyte = b;
        }

        public void Set( Char b )
        {
            checkType( VType.Char );
            _char = b;
        }

        public void Set( Char? b )
        {
            checkType( VType.nChar );
            _nchar = b;
        }

        public void Set( Int64 b )
        {
            checkType( VType.Int64 );
            _int64 = b;
        }

        public void Set( Int64? b )
        {
            checkType( VType.nInt64 );
            _nint64 = b;
        }

        public void Set( Decimal b )
        {
            checkType( VType.Decimal );
            _decimal = b;
        }

        public void Set( Decimal? b )
        {
            checkType( VType.nDecimal );
            _ndecimal = b;
        }

        public void Set( Double b )
        {
            checkType( VType.Double );
            _double = b;
        }

        public void Set( Double? b )
        {
            checkType( VType.nDouble );
            _ndouble = b;
        }

        public void Set( DateTime b )
        {
            checkType( VType.DateTime );
            _datetime = b;
        }

        public void Set( DateTime? b )
        {
            checkType( VType.nDateTime );
            _ndatetime = b;
        }

        public void Set( string s )
        {
            _string = s;
        }

        public void Set( Wrapper w )
        {
            if ((_tcode & VType.Numeric) != VType.Numeric) {
                if (w._tcode != _tcode)
                    throw new VariantException( w._tcode, _tcode );
                switch (_tcode) {
                    case VType.Boolean:
                        _boolean = w._boolean;
                        break;
                    case VType.nBoolean:
                        _nboolean = w._nboolean;
                        break;
                    case VType.Char:
                        _char = w._char;
                        break;
                    case VType.nChar:
                        _nchar = w._nchar;
                        break;
                    case VType.DateTime:
                        _datetime = w._datetime;
                        break;
                    case VType.nDateTime:
                        _ndatetime = w._ndatetime;
                        break;
                    case VType.String:
                        _string = w._string;
                        break;

                }
            }
            else {
                //bool done = false;
                Decimal vv;
                bool castok = w.TryCast( out vv );

                switch (_tcode) {
                    case VType.Byte:
                        _byte = (Byte)vv;
                        break;
                    case VType.nByte:
                        if (castok)
                            _nbyte = (Byte?)vv;
                        else
                            _nbyte = null;
                        break;
                    case VType.SByte:
                        _sbyte = (SByte)vv;
                        break;
                    case VType.nSByte:
                        if (castok)
                            _nsbyte = (SByte?)vv;
                        else
                            _nsbyte = null;
                        break;
                    case VType.Int64:
                        _int64 = (Int64)vv;
                        break;
                    case VType.nInt64:
                        if (castok)
                            _nint64 = (Int64?)vv;
                        else
                            _nint64 = null;
                        break;
                    case VType.Double:
                        _double = (Double)vv;
                        break;
                    case VType.nDouble:
                        if (castok)
                            _ndouble = (Double?)vv;
                        else
                            _ndouble = null;
                        break;
                    case VType.Decimal:
                        _decimal = vv;
                        break;
                    case VType.nDecimal:
                        if (castok)
                            _ndecimal = (Decimal?)vv;
                        else
                            _ndecimal = null;
                        break;


                }

            }
            //} set
        }

        public override string ToString()
        {
            string m;
            string t;
            if (_mask == null)
                m = "{0}";
            else
                m = _mask.ToStringMask;
            string r = String.Empty;

            switch (_tcode) {
                case VType.Boolean:
                    r = _boolean.ToString( _mask );
                    break;
                case VType.nBoolean:
                    r = _nboolean.ToString( _mask );
                    break;
                case VType.Char:
                    r = _char.ToString();
                    break;
                case VType.nChar:
                    r = _nchar == null ? "?" : _nchar.Value.ToString();
                    break;
                case VType.DateTime:
                    r = _datetime.ToString( _mask );
                    break;
                case VType.nDateTime:
                    r = _ndatetime.ToString( _mask );
                    break;
                case VType.String:
                    r = _string; // .ToString( _mask );
                    break;
                case VType.nString:
                    r = _string;
                    break;
                case VType.Byte:
                    r = _byte.ToString( _mask );
                    break;
                case VType.nByte:
                    r = _nbyte.ToString( _mask );
                    break;
                case VType.SByte:
                    r = _sbyte.ToString( _mask );
                    break;
                case VType.nSByte:
                    r = _nsbyte.ToString( _mask );
                    break;
                case VType.Int64:
                    r = String.Format( m, _int64 );// _int64.ToString( _mask );
                    break;
                case VType.nInt64:
                    r = _nint64.ToString( _mask );
                    break;
                case VType.Double:
                    t = _double.ToString( m );
                    r = _mask.ApplyMask( t ); //_double.ToString( m ); // String.Format( m, _double );
                    break;
                case VType.nDouble:
                    if (!_ndouble.HasValue)
                        t = null;
                    else
                        t = _ndouble.Value.ToString( m );
                    r = _mask.ApplyMask( t );
                    break;
                case VType.Decimal:
                    t = _decimal.ToString( m ); //String.Format( m, _decimal ); // _decimal.ToString( _mask.ToString() );
                    r = _mask.ApplyMask( t );
                    break;
                case VType.nDecimal:
                    if (!_ndecimal.HasValue)
                        t = null;
                    else
                        t = _ndecimal.Value.ToString( m );
                    r = _mask.ApplyMask( t );
                    break;
            }
            return r;
        }

        public Mask Mask { get { return _mask; } set { _mask = value; } }

    }


    public enum VType
    {
        Restricted = 128,
        Numeric = 256,
        Empty = 0,
        Object = 1,
        DBNull = 2,
        Boolean = 3 | Restricted,
        Char = 4 | Restricted,
        SByte = 5 | Numeric,
        Byte = 6 | Numeric,
        Int16 = 7 | Numeric,
        UInt16 = 8 | Numeric,
        Int32 = 9 | Numeric,
        UInt32 = 10 | Numeric,
        Int64 = 11 | Numeric,
        UInt64 = 12 | Numeric,
        Single = 13 | Numeric,
        Double = 14 | Numeric,
        Decimal = 15 | Numeric,
        DateTime = 16 | Restricted,
        String = 18 | Restricted,
        Reference = 19,

        Nullable = 1024,

        nBoolean = Boolean | Nullable,
        nChar = Char | Nullable,
        nSByte = SByte | Nullable,
        nByte = Byte | Nullable,
        nInt16 = Int16 | Nullable,
        nUInt16 = UInt16 | Nullable,
        nInt32 = Int32 | Nullable,
        nUInt32 = UInt32 | Nullable,
        nInt64 = Int64 | Nullable,
        nUInt64 = UInt64 | Nullable,
        nSingle = Single | Nullable,
        nDouble = Double | Nullable,
        nDecimal = Decimal | Nullable,
        nDateTime = DateTime | Nullable,
        nString = String | Nullable,
    }

    public class VariantException : Exception
    {
        public VariantException( VType req, VType stored )
            : base( String.Format( "Variant Exception: Req {0} vs {1}", req.ToString(), stored.ToString() ) )
        {

        }

    }

}





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KeyboardEnabledControls
{
    public class Masker
    {
        static char defaultDigitMask = '#';

        char digitChar = defaultDigitMask;
        
        static char defaultLetterMask = '@';
        char letterChar = defaultLetterMask;

        static char defaultAnyMask = '%';
        char anyChar = defaultAnyMask;

        static public char DefaultDigitMask { get { return defaultDigitMask; } }
        static public char DefaultLetterMask { get { return defaultLetterMask; } }
        static public char DefaultAnyMask { get { return defaultAnyMask; } }

        public char DigitMask
        {
            get { return digitChar; }
            set { digitChar = value; } 
        }

        public char LetterMask
        {
            get { return letterChar; }
            set { letterChar = value; }
        }

        public char AnyMask
        {
            get { return anyChar; }
            set { anyChar = value; }
        }

        public Masker( char digit, char letter, char any )
        {
            digitChar = digit;
            letterChar = letter;
            anyChar = any;
        }

        public int RawLength { get { return rawLength; } }

        public int[] IndexTranslator { get { return indexTranslator; } }

        int rawLength;
        int[] indexTranslator;
        string mask = String.Empty;

        protected void evalMask()
        {
            string masker = new string( new char[] { digitChar, letterChar, anyChar } );

            rawLength = 0;
            for (int i = 0; i < mask.Length; i++) {
                if (masker.Contains( mask[i] )) {
                    rawLength++;
                }
            }

            indexTranslator = new int[rawLength];

            int d = 0;
            int s = 0;
            for ( ; s < mask.Length; s++) {
                if (masker.Contains( mask[s] )) {
                    indexTranslator[d++] = s; 
                }
            }
        }

        public string Mask 
        { 
            get { return mask; } 
            set 
            { 
                mask = value;
                evalMask();
            } 
        }

        public Masker( string _mask )
        {
            Mask = _mask;
        }

        public Masker( string _mask, char digit, char letter, char any )
            : this( digit, letter, any )
        {
            mask = _mask;  
        }

        public Masker() {}

        protected string maskIt( string raw )
        {
            string masker = new string( new char[] { digitChar, letterChar, anyChar } );
            char[] result = new char[mask.Length];

            //int rmax = raw.Length - 1;

            int k = 0;
            int r = 0;
            int d = 0;

            for (; k < result.Length; k++, d ++ ) {
                if (masker.Contains( mask[k] )) {
                    if (r < raw.Length)
                        result[d] = raw[r++];
                    else
                        result[d] = '0';
                }
                else
                    result[d] = mask[k];
            }

            return new string( result );
        }

        public string MaskIt( string raw )
        {
            return maskIt( raw );
        }

        public string MaskIt( Int32 i )
        {
            return maskIt( i.ToString() );
        }

        public string MaskIt( Int64 i )
        {
            return maskIt( i.ToString() );
        }

        public string GetString( string masked )
        {
            string masker = new string( new char[] { digitChar, letterChar, anyChar } );
            char[] result = new char[rawLength];

            int k = 0;
            int d = 0;

            for (; k < mask.Length && d < result.Length; k ++ ) {
                if (masker.Contains( mask[k] ))
                    result[d++] = masked[k];            
            }

            return new string( result );
        }

        public Int32 GetInt32( string masked )
        {
            string temp = GetString( masked );

            Int32 result;

            if (!Int32.TryParse( temp, out result ))
                result = 0;

            return result;
        }

        public Int64 GetInt64( string masked )
        {
            string temp = GetString( masked );

            Int64 result;

            if (!Int64.TryParse( temp, out result ))
                result = 0;

            return result;
        }
    }
}

using System;

namespace array
{
    public static class DeduplicateCharacters
    {
        public static string RunBasic(string source)
        {
            int[] ascii = new int[256];
            
            for(int i=0; i<256; i++)
            {
                ascii[i] = 0;
            } 

            int resultLenght = 0;

            for(int i=0; i<source.Length ;i++)
            {
                int charCode = source[i];
                ascii[charCode]++;

                if(ascii[charCode]==1)
                {
                    resultLenght++;
                }
            }

            char[] result = new char[resultLenght];

            int j = 0;
            for(int i=0; i<source.Length ;i++)
            {
                int charCode = source[i];

                if(ascii[charCode]>=1)
                {
                    result[j] = source[i];
                    ascii[charCode]=0;
                    j++;
                }
            }

            return new string(result);
        }
    }
}

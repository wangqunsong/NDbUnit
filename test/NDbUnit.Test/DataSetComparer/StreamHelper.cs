﻿using System.IO;

namespace NDbUnit.Test.DataSetComparer
{
    public static class StreamHelper
    {
        public static FileStream ReadOnlyStreamFromFilename(string filename)
        {
            return new FileStream(filename, FileMode.Open, FileAccess.Read);
        }    
    }
}
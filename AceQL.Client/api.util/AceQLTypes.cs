﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AceQL.Client.api.util
{
    internal class AceQLTypes
    {
        internal static readonly String BINARY = "BINARY";
        internal static readonly String BIT = "BIT";
        internal static readonly String BLOB = "BLOB";
        internal static readonly String CHAR = "CHAR";
        internal static readonly String CHARACTER = "CHARACTER";
        internal static readonly String CLOB = "CLOB";
        internal static readonly String DATE = "DATE";
        internal static readonly String DECIMAL = "DECIMAL";
        internal static readonly String DOUBLE_PRECISION = "DOUBLE PRECISION";
        internal static readonly String FLOAT = "FLOAT";
        internal static readonly String INTEGER = "INTEGER";
        internal static readonly String LONGVARBINARY = "LONGVARBINARY";
        internal static readonly String LONGVARCHAR = "LONGVARCHAR";
        internal static readonly String NUMERIC = "NUMERIC";
        internal static readonly String REAL = "REAL";
        internal static readonly String SMALLINT = "SMALLINT";
        internal static readonly String TIME = "TIME";
        internal static readonly String TIMESTAMP = "TIMESTAMP";
        internal static readonly String TINYINT = "TINYINT";
        internal static readonly String URL = "URL";
        internal static readonly String VARBINARY = "VARBINARY";
        internal static readonly String VARCHAR = "VARCHAR";

        internal static bool IsDateTimeType(string colType)
        {
            if (colType.Equals(AceQLTypes.DATE) || colType.Equals(AceQLTypes.TIME) || colType.Equals(AceQLTypes.TIMESTAMP))  {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal static bool IsStringType(string colType)
        {
            if (colType.Equals(AceQLTypes.CHAR) || colType.Equals(AceQLTypes.CHARACTER) || colType.Equals(AceQLTypes.VARCHAR))  {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

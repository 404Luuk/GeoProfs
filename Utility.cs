#region snippet_full
#if SQLiteVersion
#region snippet_sl
using System;

namespace GeoProfs
{
    public static class Utility
    {
        public static string GetLastChars(Guid token)
        {
            return token.ToString().Substring(
                                    token.ToString().Length - 3);
        }
    }
}
#endregion
#else
#region snippet
namespace GeoProfs
{
    public static class Utility
    {
        public static string GetLastChars(byte[] token)
        {
            return token[7].ToString();
        }
    }
}
#endregion
#endif
#endregion
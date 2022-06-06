#if UNITY_ANDROID || UNITY_IPHONE || UNITY_STANDALONE_OSX || UNITY_TVOS
// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("xOFhFir4K5fB7salbNGA8v7FSmZ8C0dnAxLBozLzByk1QFaor311ccoxz0xvKRou4xWu0lvAGZsxiIA994tFIOCtpam9WeXCh5cszdrRDqk7aEPsqY7cNDIW0I4Qf8EFSsYR/p3BXovVDRGqbISorCqiBy1z6EsifyHVIbkr9StXxIiujMwHWhbdo7WWgVgUr9TbjZpCwUWbTl6cpSsYpZD0xG2YOf4/IrjtGTeCTLe49V3TuvjhFRiCmHDlmIgamteqyW/PfuzPTEJNfc9MR0/PTExN6IUhQORQXPNrwSBzszltEUC2CmMLylhfsbSfD7LLrqzPuhq+Bs+uSr4Zc83kV7t9z0xvfUBLRGfLBcu6QExMTEhNTmuG6JueRLBmnk9OTE1M");
        private static int[] order = new int[] { 7,13,10,10,10,11,12,9,8,10,13,12,12,13,14 };
        private static int key = 77;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
#endif

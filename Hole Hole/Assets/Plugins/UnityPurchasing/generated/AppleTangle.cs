#if UNITY_ANDROID || UNITY_IPHONE || UNITY_STANDALONE_OSX || UNITY_TVOS
// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class AppleTangle
    {
        private static byte[] data = System.Convert.FromBase64String("AxASBRgSFFECBRAFFBwUHwUCX0F0cXLzcH5xQfNwe3PzcHBxleDYeBb+ecVRhrrdXVEeAcdOcEH9xjK+buCqbzYhmnScLwj1XJpH0yY9JJ15L0HzcGB3ciRsUXXzcHlB83B1QbhoA4Qsf6QOLuqDVHLLJP48LHyANA9uPRoh5zD4tQUTemHyMPZC+/BREB8VURIUAwUYFxgSEAUYHh9RAQEdFFEyFAMFGBcYEhAFGB4fUTAEVZOaoMYBrn40kFa7gBwJnJbEZmZXQVV3ciR1emJsMAEBHRRRMhQDBVEeF1EFGRRRBRkUH1EQAQEdGBIQ8WVaoRg25Qd4j4Ua/F8x14Y2PA5RMjBB83BTQXx3eFv3OfeGfHBwcMZqzOIzVWNbtn5sxzztLxK5OvFmQkcrQRNAekF4d3IkdXdicyQiQGI4qQfuQmUU0AbluFxzcnBxcNLzcGdBZXdyJHVyYnwwAQEdFFEjHh4FRENARUFCRytmfEJEQUNBSENARUFu9PL0auhMNkaD2Oox/12lwOFjqSMUHRgQHxIUUR4fUQUZGAJREhQDW/c594Z8cHB0dHFBE0B6QXh3ciTa0gDjNiIksN5eMMKJipIBvJfSPahHDrD2JKjW6MhDM4qppADvD9Aj5O8LfdU2+iqlZ0ZCurV+PL9lGKB1d2JzJCJAYkFgd3IkdXtiezABAbESQgaGS3ZdJ5qrflB/q8sCaD7EXzHXhjY8DnkvQW53ciRsUnVpQWcVRFJkOmQobMLlhoft774hy7ApIV1REhQDBRgXGBIQBRRRAR4dGBIIHRRROB8SX0BXQVV3ciR1emJsMAFeQfCyd3lad3B0dHZzc0Hwx2vwwkHzdcpB83LS0XJzcHNzcHNBfHd4C0HzcAdBf3dyJGx+cHCOdXVyc3AIURACAgQcFAJREBISFAEFEB8SFEfoPVwJxpz96q2CBuqDB6MGQT6w/gLwEbdqKnhe48OJNTmBEUnvZITZrQ9TRLtUpKh+pxql01VSYIbQ3XadDEjy+iJRokm1wM7rPnsajlqNfuxMglo4WWu5j7/EyH+oL22nukz6aPiviDodhHbaU0FzmWlPiSF4ogEdFFEjHh4FUTIwQW9mfEFHQUVDz4UC6p+jFX66CD5FqdNPiAmOGrlMVxZR+0Ibhnzzvq+a0l6IIhsqFcBBKZ0rdUP9GcL+bK8UAo4WLxTNfHd4W/c594Z8cHB0dHFy83BwcS3zcHF3eFv3OfeGEhV0cEHwg0FbdwUZHgMYBQhAZ0Fld3IkdXJifDABd3IkbH91Z3VlWqEYNuUHeI+FGvx5WndwdHR2c3BnbxkFBQECS15eBh8VURIeHxUYBRgeHwJRHhdRBAIUQWB3ciR1e2J7MAEBHRRROB8SX0ATHRRRAgUQHxUQAxVRBRQDHAJREBgXGBIQBRgeH1EwBAUZHgMYBQhABgZfEAEBHRRfEh4cXhABAR0UEhB3QX53ciRsYnBwjnV0QXJwcI5BbMRL3IV+f3HjesBQZ18FpE18qhNnDjDZ6YiguxftVRpgodLKlWpbsm4FGBcYEhAFFFETCFEQHwhRARADBSjWdHgNZjEnYG8Fosb6Uko20qQeIdv7pKuVjaF4dkbBBARQ");
        private static int[] order = new int[] { 46,14,21,15,33,19,25,45,33,53,10,41,32,13,59,33,27,32,45,49,38,59,24,58,45,59,57,31,38,44,33,37,46,38,40,48,55,54,51,45,54,59,50,56,57,47,54,49,51,51,56,53,56,59,55,57,58,57,59,59,60 };
        private static int key = 113;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
#endif

using System;

namespace LibSugar
{
    public static partial class Sugar
    {
        public static void Run(this Action f) => f();
        public static U Run<U>(this Func<U> f) => f();

        public static U Let<T, U>(this T v, Func<T, U> f) => f(v);
        public static T Also<T>(this T v, Action<T> f)
        {
            f(v);
            return v;
        }
    }
}

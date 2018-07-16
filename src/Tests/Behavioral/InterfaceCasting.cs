// package main -- go2cs converted at 2018 July 16 19:42:07 UTC
// Original source: D:\Projects\go2cs\src\Tests\Behavioral\InterfaceCasting.go

using fmt = go.fmt_package;
using static go.builtin;

namespace go
{
    public static partial class main_package
    {
        public partial struct MyError
        {
            public GoString description;
        }


        public static GoString Error(this MyError err)
        {
            return fmt.Sprintf("error: %s", err.description);
        }

        // error is an interface - MyError is cast to error interface upon return
        private static error f()
        {
            return MyError{"foo"};
        }

        private static void Main()
        {
            fmt.Printf("%v\n", f()); // error: foo
        }
    }
}

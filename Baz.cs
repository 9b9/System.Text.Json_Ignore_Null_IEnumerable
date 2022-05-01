using System.Collections.Generic;

namespace Sample
{
    public class Baz
    {
        public Baz(IEnumerable<string> bar, int foo)
        {
            Bar = bar;
            Foo = foo;
        }

        public IEnumerable<string> Bar { get; set; }

        public int Foo { get; set; }
    }
}
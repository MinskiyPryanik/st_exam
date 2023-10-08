using System.Collections.Generic;

namespace yieldSample
{
    internal partial class Program
    {
        class Numbers
        {
            public IEnumerator<int> GetEnumerator()
            {
                for (int i = 0; i <= 10; i++)
                {
                    yield return i;
                }
            }
        }
    }
}

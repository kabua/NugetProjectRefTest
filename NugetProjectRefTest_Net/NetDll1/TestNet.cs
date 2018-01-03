using NetDll2;

namespace NetDll1
{
    public class TestNet
    {
	    public TestNet()
	    {
		    _inner = new TestNet2();
	    }

	    public string Name => _inner.Name;

	    private readonly TestNet2 _inner;
    }
}

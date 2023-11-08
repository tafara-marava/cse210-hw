public class Encyclopedia
{

    Reference _r;


    public Encyclopedia(Reference r)
    {
        _r = r;
    }

    public void ShowEncyclopedia()
    {
        _r.Display();
    }


}
namespace GeometricObjetsLibrary;

public abstract class Creator
{
    //public string InputStr { get; set; }

    public Creator(string input)
    {
        //InputStr = input;
    }
    public abstract GeometricModel Create();
}

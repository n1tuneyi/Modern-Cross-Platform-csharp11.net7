namespace Packt.Shared;

public interface INoImplementation
{
    void Alpha();
}
public interface ISomeImplementation
{
    void Alpha();
    void Beta()
    {
       
    }
}
public abstract class PartiallyImplemented 
{
    public abstract void Gamma(); 
    public virtual void Delta() 
    {
        
    }
}

public class FullyImplemented : PartiallyImplemented, ISomeImplementation
{
    public void Alpha()
    {
        
    }

    public override void Gamma()
    {
        
    }
}

public class Singer
{
    public virtual void Sing()
    {
        WriteLine("Singing...");
    }
}
public class LadyGaga : Singer
{
    public sealed override void Sing()
    {
        WriteLine("Singing with style...");
    }
}
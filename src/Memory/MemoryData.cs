namespace PHP.Runtime.Memory;

public class MemoryData
{
    public dynamic Data;

    protected MemoryData(int value) => Data = value;

    public void Set(uint value) => Data = value;
    
    public static MemoryData from(int value) => new MemoryData(value);
}
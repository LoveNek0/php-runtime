namespace PHP.Runtime.Memory.Containers;

public class MemoryData
{
    public readonly MemoryNull NULL = new MemoryNull();
    
    public MemoryType Type => _type;

    protected MemoryType _type;

    protected MemoryData(MemoryType type) => _type = type;
    
    public abstract MemoryB
    
    //public static MemoryData from(int value) => (value);

    
    public static MemoryData operator +(MemoryData left, MemoryData right)
    {
        return MemoryData.from(left.Data + right.Data);
    }
    public static MemoryData operator -(MemoryData left, MemoryData right)
    {
        return MemoryData.from(left.Data - right.Data);
    }
    public static MemoryData operator *(MemoryData left, MemoryData right)
    {
        return MemoryData.from(left.Data * right.Data);
    }
    public static MemoryData operator /(MemoryData left, MemoryData right)
    {
        return MemoryData.from(left.Data / right.Data);
    }
    public static MemoryData operator %(MemoryData left, MemoryData right)
    {
        return MemoryData.from(left.Data % right.Data);
    }
    public static MemoryData Pow(MemoryData left, MemoryData right)
    {
        return MemoryData.from(Math.Pow(left.Data, right.Data));
    }
    public static MemoryData Concat(MemoryData left, MemoryData right)
    {
        return MemoryData.from(1);
    }
}
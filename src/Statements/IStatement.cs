using PHP.Runtime.Memory;

namespace PHP.Runtime.Statements;

internal interface IStatement
{
    public MemoryData Call(MemoryContainer memoryContainer);
}
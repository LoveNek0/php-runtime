using PHP.Runtime.Memory;
using PHP.Runtime.Memory.Containers;

namespace PHP.Runtime.Statements;

internal interface IStatement
{
    public MemoryData Call(MemoryContainer memoryContainer);
}
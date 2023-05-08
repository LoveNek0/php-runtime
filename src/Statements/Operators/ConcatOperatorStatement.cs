using PHP.Runtime.Memory;
using PHP.Runtime.Memory.Containers;

namespace PHP.Runtime.Statements.Operators;

internal class ConcatOperatorStatement : IStatement
{
    private readonly IStatement _left;
    private readonly IStatement _right;
    
    public ConcatOperatorStatement(IStatement left, IStatement right)
    {
        _left = left;
        _right = right;
    }

    public MemoryData Call(MemoryContainer memoryContainer) =>
        MemoryData.Concat(_left.Call(memoryContainer), _right.Call(memoryContainer));
}
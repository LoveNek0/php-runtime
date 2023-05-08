using PHP.Runtime.Memory;
using PHP.Runtime.Memory.Containers;

namespace PHP.Runtime.Statements;

internal class DataStatement : IStatement
{
    private readonly dynamic _data;

    public DataStatement(bool data) => this._data = data;
    public DataStatement(sbyte data) => this._data = data;
    public DataStatement(byte data) => this._data = data;
    public DataStatement(short data) => this._data = data;
    public DataStatement(int data) => this._data = data;
    public DataStatement(long data) => this._data = data;
    public DataStatement(ushort data) => this._data = data;
    public DataStatement(uint data) => this._data = data;
    public DataStatement(ulong data) => this._data = data;
    public DataStatement(float data) => this._data = data;
    public DataStatement(double data) => this._data = data;
    public DataStatement(string data) => this._data = data;
    
    public MemoryData Call(MemoryContainer memoryContainer) => MemoryData.from(_data);
}
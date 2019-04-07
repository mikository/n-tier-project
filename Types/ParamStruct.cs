using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    public struct ParamStruct
    {
            public string name;
            public object value;
            public SqlDbType type;
            public int size;
            public ParameterDirection direction;
            public ParamStruct(string Name, object Value, SqlDbType Type, ParameterDirection Direction, int Size = 0)
            {
                name = Name;
                value = Value;
                type = Type;
                size = Size;
                direction = Direction;
        }
    }
}

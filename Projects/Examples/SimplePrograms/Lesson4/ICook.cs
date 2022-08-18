using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson4
{
    //інтерфейс що використувує узагальнений тип Generic
    interface ICook<T>
    {
        T GetFood();

    //Food GetFood();

    }
}

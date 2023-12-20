using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace startup.util
{
    /// <summary>
    /// 오브젝트 풀링에 대한 기능을 나타내기 위한 인터페이스입니다.
    /// </summary>
    public interface IObjectPoolable
    {
        /// <summary>
        /// 오브젝트가 현재 재사용 될 수 있음에 대한 여부를 나타냅니다.
        /// </summary>
        /// <returns>재사용 가능한 상태라면 true 를 리턴합니다.</returns>
        public bool IsRecyclable();

    }
}

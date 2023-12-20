using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace startup.util
{
    /// <summary>
    /// 오브젝트 풀링을 수행하는 클래스입니다.
    /// 풀링 대상을 형식 매개 변수 T 에 전달합니다.
    /// 형식 매개 변수의 조건은 IObjectPoolable 인터페이스를 구현하는 클래스 입니다.
    /// </summary>
    public class ObjectPool<T>
        where T : class, IObjectPoolable
    {
        // 풀링시킬 객체들을 참조할 리스트
        private List<T> _PoolObjects = new();

        /// <summary>
        /// 재사용 가능한 객체를 풀에 등록시킵니다.
        /// </summary>
        /// <param name="newRecyclableObject">등록시킬 객체를 전달합니다.</param>
        /// <returns>등록시킨 객체를 반환합니다.</returns>
        public T RegisterRecyclableObject(T newRecyclableObject)
        {
            _PoolObjects.Add(newRecyclableObject);
            return newRecyclableObject;
        }

        /// <summary>
        /// 재활용 가능한 객체를 찾아 반환합니다.
        /// </summary>
        /// <returns></returns>
        public T GetRecycleObject()
        {
            // 재활용 가능한 객체를 리스트에서 찾습니다.
            T recycleObject = _PoolObjects.Find((T poolObject) => poolObject.IsRecyclable());

            // 찾은 오브젝트를 반환합니다.
            return recycleObject;
        }

    }
}

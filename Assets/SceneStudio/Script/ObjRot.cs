using UnityEngine;

namespace SceneStudio
{
    /// <summary>
    /// 対象の回転(掴んでいる時だけ)
    /// </summary>
    public class ObjRot : MonoBehaviour
    {
        /// <summary>
        /// 回転する対象
        /// </summary>
        private Transform target;

        private void Awake()
        {
            target = transform.parent;
        }

        void Update()
        {
            transform.position = target.position;

            if (transform.parent != null && transform.parent != target)
            {
                target.rotation = transform.rotation;
            }
        }
    }
}
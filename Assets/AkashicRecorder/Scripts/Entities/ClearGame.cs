using UnityEngine;

namespace AkashicRecorder
{
    public class ClearGame : MonoBehaviour
    {
        void Start()
        {
            AkashicManager.Instance.SetEndTime();
        }
    }
}
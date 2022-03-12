using UnityEngine;

namespace AkashicRecorder
{
    public class StartGame : MonoBehaviour
    {
        void Start()
        {
            AkashicManager.Instance.SetStartTime();
        }
    }
}
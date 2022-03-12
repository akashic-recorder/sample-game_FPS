using System;
using UnityEngine;

namespace AkashicRecorder
{
    public sealed class AkashicManager : SingletonMonoBehaviour<AkashicManager>
    {
        [SerializeField] string eventName = "Akashic FPS Stage-1";
        [SerializeField] int EventDispatcher = 1;
        string _address = "";

        string _privateKey = "https://akaschic-recorder-api.herokuapp.com/api/v1/private_key";

        public DateTime StartTime { get; private set; }
        public DateTime EndTime { get; private set; }
        
        public string Address => _address;

        public void SetAddress(string address)
        {
            _address = address;
            Debug.Log($"Wallet address: {_address}");
        }
        
        public void SetStartTime()
        {
            StartTime = DateTime.UtcNow;
            Debug.Log("Start Game Time: " + StartTime.ToString("yyyy-MM-dd HH:mm:ss.fff"));
        }
        
        public void SetEndTime()
        {
            EndTime = DateTime.UtcNow;
            Debug.Log("End Game Time: " + EndTime.ToString("yyyy-MM-dd HH:mm:ss.fff"));
        }
        
    }
}
using System;
using UnityEngine;

namespace AkashicRecorder
{
    public sealed class AkashicManager : SingletonMonoBehaviour<AkashicManager>
    {
        [SerializeField] string eventName = "Akashic FPS Stage-1";
        [SerializeField] int EventId = 1;
        string _address = "";

        string _hostUri = "https://akaschic-recorder-api.herokuapp.com/";
        string _postUri => $"events";

        public ClearData Data { get; private set; } = new ClearData();
        
        public string Address => _address;

        public void SetAddress(string address)
        {
            _address = address;
            Debug.Log($"Wallet address: {_address}");
        }
        
        public void SetStartTime()
        {
            Data.start_time = DateTime.UtcNow;
            Debug.Log("Start Game Time: " + Data.start_time.ToString("yyyy-MM-dd HH:mm:ss.fff"));
        }
        
        public void SetEndTime()
        {
            Data.end_time = DateTime.UtcNow;
            Debug.Log("End Game Time: " + Data.end_time.ToString("yyyy-MM-dd HH:mm:ss.fff"));
            
            CallApi();
        }

        void CallApi()
        {
            var url = $"{_hostUri}?address={_address}&start_time={Data.start_time.ToString("yyyy-MM-dd HH:mm:ss.fff")}&end_time={Data.end_time.ToString("yyyy-MM-dd HH:mm:ss.fff")}";
            
            Data.event_name = eventName;
            Data.event_id = EventId;
            Data.wallet_address = _address;
            
            var json = JsonUtility.ToJson(Data);

            Debug.Log(json);
        }
    }
}
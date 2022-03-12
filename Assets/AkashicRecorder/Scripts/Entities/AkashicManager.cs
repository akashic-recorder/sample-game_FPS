using System;
using UnityEngine;

namespace AkashicRecorder
{
    public sealed class AkashicManager : SingletonMonoBehaviour<AkashicManager>
    {
        static string _address = "";
        public static string Address => _address;
        string _privateKey = "https://akaschic-recorder-api.herokuapp.com/about";
        
        public void SetAddress(string address)
        {
            _address = address;
            Debug.Log($"Wallet address: {_address}");
        }
    }
}
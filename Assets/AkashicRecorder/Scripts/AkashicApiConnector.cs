using System;
using Unity.FPS.Game;
using UnityEngine;

[RequireComponent(typeof(Health))]
public class AkashicApiConnector : MonoBehaviour
{
    [SerializeField] int _eventId = 0;
    DateTime _startTime, _endTime;
    
    string event_name;
    public int rank_num;
    public string wallet_address;

    
    Health _health;
    
    
    void Start()
    {
        Debug.Log(DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.fff") + ": AkashicApiConnector.Start()");
        _health = GetComponent<Health>();
        _health.OnDie += ConnectApi;
    }

    void ConnectApi()
    {
        Debug.Log($"connect wallet and call API");
    }
}
using Unity.FPS.Game;
using UnityEngine;

[RequireComponent(typeof(Health))]
public class AkashicApiConnector : MonoBehaviour
{
    Health _health;
    
    void Start()
    {
        _health = GetComponent<Health>();
        _health.OnDie += ConnectApi;
    }

    void ConnectApi()
    {
        Debug.Log($"connect wallet and call API");
    }
}
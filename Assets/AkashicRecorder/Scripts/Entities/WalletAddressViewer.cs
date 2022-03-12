using TMPro;
using UnityEngine;

namespace AkashicRecorder
{
    public sealed class WalletAddressViewer : MonoBehaviour
    {
        [SerializeField] TextMeshProUGUI walletAddressText;

        void Start()
        {
            walletAddressText.text = "Your Address: " + AkashicManager.Instance.Address;
        }
    }
}
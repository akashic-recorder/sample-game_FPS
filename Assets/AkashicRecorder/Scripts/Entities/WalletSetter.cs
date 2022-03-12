using TMPro;
using UnityEngine;

namespace AkashicRecorder
{
    [RequireComponent(typeof(TMP_InputField))]
    public sealed class WalletSetter : MonoBehaviour
    {
        TMP_InputField _inputField;
        
        void Start()
        {
            _inputField = GetComponent<TMP_InputField>();
            _inputField.onEndEdit.AddListener(SetAddress);
        }

        void SetAddress(string address)
        {
            AkashicManager.Instance.SetAddress(address);
        }
    }
}
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
            
            CheckAddress();
        }
        
        void CheckAddress()
        {
            if (!string.IsNullOrEmpty(AkashicManager.Instance.Address))
            {
                _inputField.text = AkashicManager.Instance.Address;
            }
        }

        void SetAddress(string address)
        {
            AkashicManager.Instance.SetAddress(address);
        }
    }
}
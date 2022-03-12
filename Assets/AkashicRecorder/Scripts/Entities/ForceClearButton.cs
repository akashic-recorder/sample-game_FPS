using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace AkashicRecorder
{
    public sealed class ForceClearButton : MonoBehaviour
    {
        [SerializeField] Button _button;

        void Start()
        {
            _button.onClick.AddListener(() => SceneManager.LoadScene("WinScene"));
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                _button.gameObject.SetActive(!_button.gameObject.activeSelf);
            }
        }
    }
}
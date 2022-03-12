using AkashicRecorder;
using Unity.FPS.Game;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

namespace Unity.FPS.UI
{
    public class LoadSceneButton : MonoBehaviour
    {
        public string SceneName = "";

        void Update()
        {
            if (EventSystem.current.currentSelectedGameObject == gameObject
                && Input.GetButtonDown(GameConstants.k_ButtonNameSubmit))
            {
                LoadTargetScene();
            }
        }

        public void LoadTargetScene()
        {
            SceneManager.LoadScene(SceneName);
            
            if(SceneName == "MainScene")
            {
                AkashicManager.Instance.SetStartTime();
            }
            else if(SceneName == "WinScene")
            {
                AkashicManager.Instance.SetEndTime();
            }
        }
    }
}
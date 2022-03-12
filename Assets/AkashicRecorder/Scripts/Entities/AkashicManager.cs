using System;
using System.Collections;
using System.Text;
using UniRx;
using UniRx.InternalUtil;
using UnityEngine;
using UnityEngine.Networking;

namespace AkashicRecorder
{
    public sealed class AkashicManager : SingletonMonoBehaviour<AkashicManager>
    {
        [SerializeField] string eventName = "Akashic FPS Stage-1";
        [SerializeField] int EventId = 1;
        string _address = "";

        string _hostUri = "https://akaschic-recorder-api.herokuapp.com";
        string _postUri => $"{_hostUri}/api/1/80001/{_address}";
        // ${host}/api/1/80001/${address}

        public ClearData Data { get; private set; } = new ClearData();

        public string Address => _address;

        public void SetAddress(string address)
        {
            _address = address;
            Debug.Log($"Wallet address: {_address}");
        }

        public void SetStartTime()
        {
            Data.start_time = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.fff");
            Debug.Log("Start Game Time: " + Data.start_time);
        }

        public void SetEndTime()
        {
            Data.end_time = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.fff");
            Debug.Log("End Game Time: " + Data.end_time);

            MainThreadDispatcher.StartUpdateMicroCoroutine(CallApi());
        }

        IEnumerator CallApi()
        {
            Data.event_id = EventId.ToString();
            Data.event_name = eventName;
            Data.rank_num = 1.ToString();
            Data.wallet_address = _address;

            var json = JsonUtility.ToJson(Data);

            Debug.Log($"{_postUri}\n{json}");

            var www = new UnityWebRequest(_postUri, UnityWebRequest.kHttpVerbPOST)
            {
                uploadHandler = new UploadHandlerRaw(Encoding.UTF8.GetBytes(json)),
                downloadHandler = new DownloadHandlerBuffer()
            };

            www.SetRequestHeader( "Content-Type", "application/json" );
            
            var operation = www.SendWebRequest();

            operation.completed += _ =>
            {
                Debug.Log($"is_done: {operation.isDone}, handler: {operation.webRequest.downloadHandler.text}, error: {operation.webRequest.error}, http error: {operation.webRequest.isHttpError} network status: {operation.webRequest.isNetworkError}");
            };

            yield return operation;
        }
    }
}
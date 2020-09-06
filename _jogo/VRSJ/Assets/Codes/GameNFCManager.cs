using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NFC;

	public class GameNFCManager : MonoBehaviour
	{
		[SerializeField]
		private Raycaster game;

		public void Start()
		{
#if (!UNITY_EDITOR)
			NativeNFCManager.AddNFCTagDetectedListener(OnNFCTagDetected);
			NativeNFCManager.AddNDEFReadFinishedListener(OnNDEFReadFinished);
			Debug.Log("NFC Tag Info Read Supported: " + NativeNFCManager.IsNFCTagInfoReadSupported());
			Debug.Log("NDEF Read Supported: " + NativeNFCManager.IsNDEFReadSupported());
			Debug.Log("NDEF Write Supported: " + NativeNFCManager.IsNDEFWriteSupported());
			Debug.Log("NFC Enabled: " + NativeNFCManager.IsNFCEnabled());
			Debug.Log("NDEF Push Enabled: " + NativeNFCManager.IsNDEFPushEnabled());
#endif

#if (!UNITY_EDITOR) && !UNITY_IOS
		NativeNFCManager.Enable();
#endif
	}

	private void OnEnable()
		{
#if (!UNITY_EDITOR) && !UNITY_IOS
			NativeNFCManager.Enable();
#endif
			game.gameObject.SetActive(true);
		}

		private void OnDisable()
		{
#if (!UNITY_EDITOR) && !UNITY_IOS
			NativeNFCManager.Disable();
#endif
			if (game != null)
			{
				game.gameObject.SetActive(false);
			}
		}

		public void OnStartNFCReadClick()
		{
#if (!UNITY_EDITOR)
			NativeNFCManager.ResetOnTimeout = true;
			NativeNFCManager.Enable();
#endif
		}

		public void OnNFCTagDetected(NFCTag tag)
		{
			game.UpdateTagInfo(tag);
		}

		public void OnNDEFReadFinished(NDEFReadResult result)
		{
			string readResultString = string.Empty;
			if (result.Success)
			{
				readResultString = string.Format("NDEF Message was read successfully from tag {0}", result.TagID);
				//game.UpdateNDEFMessage(result.Message);
			}
			else
			{
				readResultString = string.Format("Failed to read NDEF Message from tag {0}\nError: {1}", result.TagID, result.Error);
			}
			Debug.Log(readResultString);
		}
	}
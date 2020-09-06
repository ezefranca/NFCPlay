using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NFC;

public class Game : MonoBehaviour
{

	private Rigidbody ball;

	private void Awake()
	{
		ball = GetComponent<Rigidbody>();
	}

	public void UpdateTagInfo(NFCTag tag)
	{
		string technologiesString = string.Empty;
		NFCTechnology[] technologies = tag.Technologies;
		int length = technologies.Length;
		if (length > 0)
		{
			ball.AddForce(Vector3.up * 200.0f);
		}
	}

	public void UpdateNDEFMessage(NDEFMessage message)
	{
		List<NDEFRecord> records = message.Records;

		int length = records.Count;
		if (length > 0)
		{
			//ball.AddForce(Vector3.up * -20.0f);
		}
	}

	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			ball.AddForce(Vector3.up * 200.0f);
			Debug.Log("Pressed primary button.");
		}

		if (Input.GetMouseButtonDown(1)) {
			ball.AddForce(Vector3.up * 200.0f);
			Debug.Log("Pressed secondary button.");
		}

		if (Input.GetMouseButtonDown(2)) {
			ball.AddForce(Vector3.up * 200.0f);
			Debug.Log("Pressed middle click.");
		}
	}
}
using NFC.JSON;
using System;

namespace NFC
{
	/// <summary>Record class that defines unknown data</summary>
	[Serializable]
	public class UnknownRecord: NDEFRecord
	{
		public UnknownRecord(string uri)
		{
			this.type = NDEFRecordType.UNKNOWN;
		}

		public UnknownRecord(JSONObject jsonObject)
		{
			ParseJSON(jsonObject);
		}
	}
}

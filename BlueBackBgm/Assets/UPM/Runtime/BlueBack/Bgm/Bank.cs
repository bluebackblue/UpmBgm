

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief ＢＧＭ。バンク。
*/


/** BlueBack.Bgm
*/
namespace BlueBack.Bgm
{
	/** Bank
	*/
	#if(UNITY_EDITOR)
	[System.Serializable]
	#endif
	public sealed class Bank
	{
		/** bankname
		*/
		public string bankname;

		/** list
		*/
		public Bank_Item[] list;
	}
}


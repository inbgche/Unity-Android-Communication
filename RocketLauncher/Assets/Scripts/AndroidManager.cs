using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AndroidManager : MonoBehaviour
{
	private AndroidJavaObject curActivity;
	public string strLog = "No Java Log";
	static AndroidManager _instance;
	public Text _text;
	public static AndroidManager GetInstance()
	{
		if( _instance == null )
		{
			_instance = new GameObject("AndroidManager").AddComponent<AndroidManager>();   
		}
		return _instance;
	}
	void Awake()
	{

		#if UNITY_ANDROID 
		AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
		//AndroidJavaClass jc = new AndroidJavaClass("great.good.com.rolauncher");
		curActivity = jc.GetStatic<AndroidJavaObject>("currentActivity");
		#endif


		_text = (Text)GameObject.Find ("Canvas/Text").GetComponent<Text>();
		_text.text = strLog;
	}
	void Start ()
	{
	}
	public void CallJavaFunc( string strFuncName, string strTemp )
	{
		if( curActivity == null )
		{
			strLog = curActivity + " is null";
			return;
		}

		strLog = "Before call " + strFuncName;
		//curActivity.Call(strFuncName, new object[] { strTemp } );

		curActivity.Call( strFuncName, strTemp );
		strLog = strFuncName + " is Called with param " + strTemp;
	}
	void SetJavaLog(string strJavaLog)
	{
		strLog = strJavaLog;
		_text.text = strLog;
	}
}
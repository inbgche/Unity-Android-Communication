using UnityEngine;
using System.Collections;


public class Test : MonoBehaviour {

	void Start()
	{
		AndroidManager.GetInstance();
	}

	public void OnClickButton()
	{
		AndroidManager.GetInstance().CallJavaFunc( "javaTestFunc", "UnityJavaJarTest" );
		Debug.Log ("Go");
	}

}

# Unity-Android-Communication
Example app of communication between Unity and Android. (Android Studio and Unity Project)

* These are a sample Unity and a Android Studio project that communicate each other. 
* The unity app can call android native API

In C# (Caller)
```c#     
    AndroidManager.GetInstance().CallJavaFunc( "javaTestFunc", "UnityJavaJarTest" );
```

In Android (Callee)
```
    public void javaTestFunc(String strFromUnity) { 
        /* ... Do something here with java native api ... */ 
    } 
```

* And the android can call Unity too.

In Android (Caller)
```
    UnityPlayer.UnitySendMessage("AndroidManager", "SetJavaLog", strFromUnity + "HelloWorld"); 
```

In C# (Callee)
```
    void SetJavaLog(string strJavaLog)
  	{
  		strLog = strJavaLog;
  		_text.text = strLog;
  	}
```



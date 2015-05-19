package com.good.great.test01;

import android.os.Bundle;
import android.util.Log;

import com.unity3d.player.UnityPlayer;
import com.unity3d.player.UnityPlayerActivity;

public class MainActivity extends UnityPlayerActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
    }

    public void javaTestFunc(String strFromUnity) {

        //java to unity
        UnityPlayer.UnitySendMessage("AndroidManager", "SetJavaLog", strFromUnity + "HelloWorld");


    }

}



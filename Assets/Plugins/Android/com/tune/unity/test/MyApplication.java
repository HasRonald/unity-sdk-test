package com.tune.unity.test;

import com.tune.Tune;
import com.tune.ma.application.TuneApplication;

public class MyApplication extends TuneApplication {
    @Override
    public void onCreate() {
        super.onCreate();

        Tune tune = Tune.init(this, "190163", "198dacaee0fd940d83ad259a27ec6fd5", true);
        tune.setPluginName("unity");
        tune.setPackageName("com.tune.unity.test");
    }
}

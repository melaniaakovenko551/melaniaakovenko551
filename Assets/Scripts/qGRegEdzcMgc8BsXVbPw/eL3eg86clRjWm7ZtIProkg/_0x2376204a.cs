using UnityEngine;

public class _0x2376204a : MonoBehaviour
{
    public bool IsOnlyWinGameEndEnabled;
    public static _0x2376204a Instance;
    private void _0x30e3ce31()
    {
        {
#if !B_LOGS
        {
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
        }
#endif
        }

        QualitySettings.vSyncCount = 1;
        Application.runInBackground = true;
    //Application.targetFrameRate = 60;
    // Time.fixedDeltaTime = 0.03f; // USE CUSTOM PHYSICS TIME FOR OPTIMIZATION IF NEEDED
    // Add this once at startup to silence the specific assertion
    }

    public bool IsStoryEnabled;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this.gameObject.GetComponent<_0x2376204a>();
            DontDestroyOnLoad(this.gameObject);
            this._0x30e3ce31();
        }
        else
        {
            this._0xe28203e5();
            Destroy(this.gameObject);
        }
    }

    public bool IsCheckScoreEnabled;
    public bool IsLevelSelectorEnabled;
    public bool IsSkipSplashEnabled;
    public bool IsTutorialEnabled;
    public bool IsLevelIncrementOnWin;
    public bool IsTimerEnabled;
    public bool IsBestScoreEnabled;
    private void _0xe28203e5()
    {
    }
}
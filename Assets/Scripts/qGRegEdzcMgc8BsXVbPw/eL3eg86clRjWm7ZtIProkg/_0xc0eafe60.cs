using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xc0eafe60 : MonoBehaviour
{
    public List<Button> PauseButtons = new();
    public void _0x0e207193()
    {
        if (_0x2376204a.Instance.IsOnlyWinGameEndEnabled)
            this._0x2252f68a();
        if (!this.IsGameEnd)
        {
            this._0xfc7c79ad();
            _0x3ede361b.IsAfterLevelComplete = false;
            _0x3ede361b.IsAfterLevelFailed = true;
            _0x4cff3fbe _0xb4efc9b1 = _0xa9368346.Instance._0x6e2becba(_0xd8d0855e._0xd7a180dc.LOSE).GetComponent<_0x4cff3fbe>();
            if (_0x2376204a.Instance.IsCheckScoreEnabled)
                _0xb4efc9b1.ContentMainText.text = $"{this.ScoreCurrent}/{this._0x569a3cdc}";
            else
                _0xb4efc9b1.ContentMainText.text = $"{this.ScoreCurrent}";
            _0xb4efc9b1.ContentAdditionalText.text = $"{0}";
            _0xd8d0855e._0xd165425b._0xd82d10c8 += 0;
            _0xa9368346.Instance._0x4d67d626(_0xd8d0855e._0xd7a180dc.LOSE);
        }
    }

    private void Start()
    {
        this.IsGameEnd = false;
        this.TimeLeft = this._0xc748acb3;
        this.CurrentGameIndex = _0x3ede361b.Instance._0x65b0d5ee;
        foreach (Button _0xee6d4ae4 in this.HomeButtons)
            _0xee6d4ae4.onClick.AddListener(() =>
            {
                this._0xc58c85a4();
            });
        foreach (Button _0xe18e72b9 in this.PauseButtons)
            _0xe18e72b9.onClick.AddListener(() =>
            {
                _0x3ede361b.Instance._0x1f527a59(false);
                _0xa9368346.Instance._0x4d67d626(_0xd8d0855e._0xd7a180dc.PAUSE);
            });
        this._0x4f278714();
        this.LevelNumberText.ForEach(_0x31931129 => _0x31931129.text = $"LVL {_0x3ede361b._0xd0111961._0xab404c30 + 1}");
        if (_0x2376204a.Instance.IsTimerEnabled)
        {
            this._0x1f9ee4de();
            this.StartCoroutine(this._0x167c0f7d());
        }
    }

    [HideInInspector]
    public int ScoreCurrent;
    public List<TMP_Text> ScoreText = new();
    private void _0x33512768()
    {
        if (this.ScoreCurrent > _0x3ede361b._0xd0111961._0xd892689c)
            _0x3ede361b._0xd0111961._0xd892689c = this.ScoreCurrent;
        if (_0x2376204a.Instance.IsCheckScoreEnabled)
            if (this.ScoreCurrent >= this._0x569a3cdc)
                this._0x2252f68a();
    }

    private int _0xc748acb3 => this.CustomTimeInitial + _0x3ede361b._0xd0111961._0xab404c30 * 10;

    public List<Button> HomeButtons = new();
    private void _0xfc7c79ad()
    {
        this.IsGameEnd = true;
        _0x3ede361b.IsAfterLevelComplete = true;
    }

    public void _0xdd17ee86(int scoreToAdd)
    {
        if (!this.IsGameEnd)
        {
            this.ScoreCurrent += scoreToAdd;
            this._0x4f278714();
            this._0x33512768();
        }
    }

    private int _0x9b267454 => this.ScoreCurrent;

    public List<TMP_Text> TimerText = new();
    public int CustomTargetScore = 10;
    private void _0x4f278714()
    {
        if (_0x2376204a.Instance.IsCheckScoreEnabled)
            this.ScoreText.ForEach(_0x31931129 => _0x31931129.text = $"{this.ScoreCurrent}/{this._0x569a3cdc}");
        else
            this.ScoreText.ForEach(_0x31931129 => _0x31931129.text = $"{this.ScoreCurrent}");
    }

    public void _0xc58c85a4()
    {
        _0x3ede361b.Instance._0x1f527a59(true);
        _0x3ede361b.Instance.LoadSceneByIndex(_0xd8d0855e._0xe62aa36f.SCENE_0);
    }

    public int CustomTimeInitial = 30;
    private int _0x569a3cdc => this.CustomTargetScore + _0x3ede361b._0xd0111961._0xab404c30 * 10;

    [HideInInspector]
    public int TimeLeft;
    private static _0xc0eafe60 _0x208cb567;
    private void _0x31bfffb5()
    {
        if (this.ScoreCurrent >= this._0x569a3cdc)
            this._0x2252f68a();
        else
            this._0x0e207193();
    }

    private void Awake()
    {
        _0x208cb567 = this.gameObject.GetComponent<_0xc0eafe60>();
    }

    private IEnumerator _0x167c0f7d()
    {
        this._0x1f9ee4de();
        while (!this.IsGameEnd && this.TimeLeft > 0 && _0x3ede361b.Instance._0x65b0d5ee == this.CurrentGameIndex)
        {
            yield return new WaitForSeconds(1f);
            if (_0x3ede361b.Instance._0x35d68e81)
            {
                if (this.IsGameEnd)
                    break;
                this.TimeLeft--;
                this._0x1f9ee4de();
            }
        }

        if (!this.IsGameEnd)
            this._0x0e207193();
    }

    [HideInInspector]
    public int CurrentGameIndex;
    public void _0x2252f68a()
    {
        if (!this.IsGameEnd)
        {
            this._0xfc7c79ad();
            _0x3ede361b.IsAfterLevelComplete = true;
            _0x3ede361b.IsAfterLevelFailed = false;
            _0x4cff3fbe _0x6c2aeca3 = _0xa9368346.Instance._0x6e2becba(_0xd8d0855e._0xd7a180dc.WIN).GetComponent<_0x4cff3fbe>();
            if (_0x2376204a.Instance.IsCheckScoreEnabled)
                _0x6c2aeca3.ContentMainText.text = $"{this.ScoreCurrent}/{this._0x569a3cdc}";
            else
                _0x6c2aeca3.ContentMainText.text = $"{this.ScoreCurrent}";
            if (_0x2376204a.Instance.IsBestScoreEnabled)
            {
                if (this.ScoreCurrent > _0xd8d0855e._0xd165425b._0xd82d10c8)
                    _0xd8d0855e._0xd165425b._0xd82d10c8 = this.ScoreCurrent;
                _0x6c2aeca3.ContentAdditionalText.text = $"{_0xd8d0855e._0xd165425b._0xd82d10c8}";
            }
            else
            {
                _0x6c2aeca3.ContentAdditionalText.text = $"{this._0x9b267454}";
                _0xd8d0855e._0xd165425b._0xd82d10c8 += this._0x9b267454;
            }

            if (_0x2376204a.Instance.IsLevelIncrementOnWin)
                ++_0x3ede361b._0xd0111961._0xab404c30;
            _0xa9368346.Instance._0x4d67d626(_0xd8d0855e._0xd7a180dc.WIN);
        }
    }

    private void _0x1f9ee4de()
    {
        this.TimerText.ForEach(_0x31931129 => _0x31931129.text = TimeSpan.FromSeconds(this.TimeLeft).ToString(_0x426e45b8._0x8da0d72a(new byte[6] { 66, 66, 115, 21, 92, 92 }, 47)));
    }

    public List<TMP_Text> LevelNumberText = new();
    public List<TMP_Text> SubtitleText = new();
    [HideInInspector]
    public bool IsGameEnd;
}

internal static class _0x426e45b8
{
    internal static string _0x8da0d72a(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}
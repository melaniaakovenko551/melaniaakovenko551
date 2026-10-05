using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public static class _0xd8d0855e
{
    public static class _0xd165425b
    {
        public static int _0xd82d10c8
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x96429707._0xc94faef7(new byte[5] { 93, 113, 119, 112, 109 }, 30)))
                    PlayerPrefs.SetInt(_0x96429707._0xc94faef7(new byte[5] { 129, 173, 171, 172, 177 }, 194), 0);
                return PlayerPrefs.GetInt(_0x96429707._0xc94faef7(new byte[5] { 32, 12, 10, 13, 16 }, 99));
            }

            set
            {
                PlayerPrefs.SetInt(_0x96429707._0xc94faef7(new byte[5] { 109, 65, 71, 64, 93 }, 46), value);
                _0x3ede361b.Instance._0x88244216();
            }
        }
    }

    public class _0x22600ad4
    {
        private static readonly _0x22600ad4 _0xf0c8112c = new();
        public static readonly _0x22600ad4[] ALL_SCENES_SETTING_SINGLETONS =
        {
            _0xf0c8112c,
            _0xf0c8112c,
            _0xf0c8112c,
        };
        private int _0x591e782a => 0;
        private int _0x806e4834 => 10;
        private string _0xd84d8232 => _0x96429707._0xc94faef7(new byte[4] { 17, 57, 50, 41 }, 92);
        private string _0x316acb4b => _0x96429707._0xc94faef7(new byte[8] { 253, 244, 231, 244, 253, 202, 129, 204 }, 177);

        private int _0xbd370af8
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x96429707._0xc94faef7(new byte[25] { 160, 150, 145, 145, 134, 141, 151, 164, 143, 140, 129, 130, 143, 160, 139, 130, 147, 151, 134, 145, 170, 141, 135, 134, 155 }, 227)))
                    PlayerPrefs.SetInt(_0x96429707._0xc94faef7(new byte[25] { 104, 94, 89, 89, 78, 69, 95, 108, 71, 68, 73, 74, 71, 104, 67, 74, 91, 95, 78, 89, 98, 69, 79, 78, 83 }, 43), 0);
                return PlayerPrefs.GetInt(_0x96429707._0xc94faef7(new byte[25] { 59, 13, 10, 10, 29, 22, 12, 63, 20, 23, 26, 25, 20, 59, 16, 25, 8, 12, 29, 10, 49, 22, 28, 29, 0 }, 120));
            }

            set => PlayerPrefs.SetInt(_0x96429707._0xc94faef7(new byte[25] { 138, 188, 187, 187, 172, 167, 189, 142, 165, 166, 171, 168, 165, 138, 161, 168, 185, 189, 172, 187, 128, 167, 173, 172, 177 }, 201), value);
        }

        public int _0xab404c30
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0xd84d8232}CurrentLevelIndex"))
                    PlayerPrefs.SetInt($"{this._0xd84d8232}CurrentLevelIndex", 0);
                return PlayerPrefs.GetInt($"{this._0xd84d8232}CurrentLevelIndex");
            }

            set => PlayerPrefs.SetInt($"{this._0xd84d8232}CurrentLevelIndex", value);
        }

        public int _0xd892689c
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0xd84d8232}BestScore"))
                    this._0xd892689c = 0;
                return PlayerPrefs.GetInt($"{this._0xd84d8232}BestScore");
            }

            set => PlayerPrefs.SetInt($"{this._0xd84d8232}BestScore", value);
        }

        public bool _0xf83fc287
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0xd84d8232}IsGameTutorPassed"))
                    PlayerPrefs.SetInt($"{this._0xd84d8232}IsGameTutorPassed", Convert.ToInt32(false));
                return PlayerPrefs.GetInt($"{this._0xd84d8232}IsGameTutorPassed") == 1;
            }

            set => PlayerPrefs.SetInt($"{this._0xd84d8232}IsGameTutorPassed", Convert.ToInt32(value));
        }
    }

    public static class _0xe62aa36f
    {
        public static readonly int SCENE_0 = 0;
        public static readonly int SCENE_1 = 1;
    }

    public static class _0xd7a180dc
    {
        public static readonly int PAUSE = 6;
        public static readonly int WIN = 7;
        public static readonly int LOSE = 8;
    }

    public static class _0x1a8d0e5d
    {
        public static readonly int SPLASH = 0;
        public static readonly int DEFAULT = 1;
        public static readonly int EMPTY = 2;
        public static readonly int TUTORIAL0 = 13;
        public static readonly int TUTORIAL1 = 14;
        public static readonly int TUTORIAL2 = 15;
        public static readonly int TUTORIAL3 = 16;
        public static readonly int TUTORIAL4 = 17;
        public static readonly int TUTORIAL5 = 18;
        public static readonly int TUTORIAL6 = 19;
    }
}

internal static class _0x96429707
{
    internal static string _0xc94faef7(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}
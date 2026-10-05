using AndroidInstallReferrer;
using DG.Tweening;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Unity.Notifications.Android;
using Unity.Services.Authentication;
using Unity.Services.CloudSave;
using Unity.Services.CloudSave.Models;
using Unity.Services.CloudSave.Models.Data.Player;
using Unity.Services.Core;
using Unity.Services.PushNotifications;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Application = UnityEngine.Application;

public class _0xe283a8a2 : MonoBehaviour
{
    private Canvas _0x05ddd695;
    private IEnumerator _0xd7655a6e(IEnumerator _0xb25a49cc, TaskCompletionSource<bool> _0x7b8b02be)
    {
        yield return _0xb25a49cc;
        _0x7b8b02be.SetResult(true);
    }

    private float _0x8772d573 = 0f;
    private bool _0x2d8cf389(string _0xec81e716)
    {
        try
        {
            using (var _0xd9eb230a = new AndroidJavaClass(_0x4485c675._0xec57cfb3(new byte[30] { 88, 84, 86, 21, 78, 85, 82, 79, 66, 8, 95, 21, 75, 87, 90, 66, 94, 73, 21, 110, 85, 82, 79, 66, 107, 87, 90, 66, 94, 73 }, 59)))
            using (var _0x12ee7cb8 = _0xd9eb230a.GetStatic<AndroidJavaObject>(_0x4485c675._0xec57cfb3(new byte[15] { 230, 240, 247, 247, 224, 235, 241, 196, 230, 241, 236, 243, 236, 241, 252 }, 133)))
            using (var _0xe01beb38 = new AndroidJavaClass(_0x4485c675._0xec57cfb3(new byte[15] { 225, 238, 228, 242, 239, 233, 228, 174, 238, 229, 244, 174, 213, 242, 233 }, 128)))
            using (var _0x16a13cdc = _0xe01beb38.CallStatic<AndroidJavaObject>(_0x4485c675._0xec57cfb3(new byte[5] { 97, 112, 99, 98, 116 }, 17), _0xec81e716))
            using (var _0xcbd79df9 = new AndroidJavaObject(_0x4485c675._0xec57cfb3(new byte[22] { 130, 141, 135, 145, 140, 138, 135, 205, 128, 140, 141, 151, 134, 141, 151, 205, 170, 141, 151, 134, 141, 151 }, 227), _0x4485c675._0xec57cfb3(new byte[26] { 199, 200, 194, 212, 201, 207, 194, 136, 207, 200, 210, 195, 200, 210, 136, 199, 197, 210, 207, 201, 200, 136, 240, 239, 227, 241 }, 166), _0x16a13cdc))
            {
                WLog(_0x4485c675._0xec57cfb3(new byte[26] { 133, 174, 180, 169, 171, 163, 138, 175, 173, 163, 230, 169, 182, 163, 168, 230, 163, 190, 178, 163, 180, 168, 167, 170, 252, 230 }, 198) + _0xec81e716);
                _0xcbd79df9.Call<AndroidJavaObject>(_0x4485c675._0xec57cfb3(new byte[11] { 144, 149, 149, 178, 144, 133, 148, 150, 158, 131, 136 }, 241), _0x4485c675._0xec57cfb3(new byte[33] { 125, 114, 120, 110, 115, 117, 120, 50, 117, 114, 104, 121, 114, 104, 50, 127, 125, 104, 121, 123, 115, 110, 101, 50, 94, 78, 83, 75, 79, 93, 94, 80, 89 }, 28));
                _0xcbd79df9.Call<AndroidJavaObject>(_0x4485c675._0xec57cfb3(new byte[8] { 5, 0, 0, 34, 8, 5, 3, 23 }, 100), 0x10000000);
                _0x12ee7cb8.Call(_0x4485c675._0xec57cfb3(new byte[13] { 157, 154, 143, 156, 154, 175, 141, 154, 135, 152, 135, 154, 151 }, 238), _0xcbd79df9);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x4485c675._0xec57cfb3(new byte[28] { 93, 118, 108, 113, 115, 123, 82, 119, 117, 123, 62, 123, 102, 106, 123, 108, 112, 127, 114, 62, 120, 127, 119, 114, 123, 122, 36, 62 }, 30) + e.Message);
            Application.OpenURL(_0xec81e716);
            return true;
        }
    }

    internal bool isApplicationFocus = false;
    private async Task<bool> _0x3b9d551f()
    {
        _0xe2e54031.Instance?._0x4cba5af7();
        PushNotificationsService.Instance.OnRemoteNotificationReceived += (_0x3d74394c) =>
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x4485c675._0xec57cfb3(new byte[32] { 145, 158, 175, 185, 190, 151, 234, 159, 164, 163, 190, 179, 234, 154, 191, 185, 162, 234, 132, 165, 190, 163, 172, 163, 169, 171, 190, 163, 165, 164, 240, 234 }, 202) + string.Join(_0x4485c675._0xec57cfb3(new byte[1] { 221 }, 212), _0x3d74394c));
                }
#endif
            }
        };
        try
        {
            _0x9a509e9a = await PushNotificationsService.Instance.RegisterForPushNotificationsAsync();
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x4485c675._0xec57cfb3(new byte[31] { 205, 194, 243, 229, 226, 203, 182, 208, 247, 255, 250, 243, 242, 182, 226, 249, 182, 241, 243, 226, 182, 230, 227, 229, 254, 182, 226, 249, 253, 243, 248 }, 150));
                }
#endif
            }

            _0x9a509e9a = "";
        }

        _0x0d60a9fa = !string.IsNullOrEmpty(_0x9a509e9a);
        _0x0e1d2c8a = _0x3d5f12ad();
        {
#if B_LOGS
            Debug.Log(_0x4485c675._0xec57cfb3(new byte[25] { 183, 184, 137, 159, 152, 177, 204, 185, 130, 133, 152, 149, 204, 188, 153, 159, 132, 204, 184, 131, 135, 137, 130, 214, 204 }, 236) + _0x9a509e9a);
#endif
        }

        _0xe2e54031.Instance?._0xdc88c535();
        return false;
    }

    private AndroidJavaObject _0xebf05fdf { get; set; }

    private string _0xcdc795d7 = "";
    // PART 3
    private string _0xc0f6617e()
    {
        try
        {
            var _0xa25f3495 = new AndroidJavaClass(_0x4485c675._0xec57cfb3(new byte[30] { 36, 40, 42, 105, 50, 41, 46, 51, 62, 116, 35, 105, 55, 43, 38, 62, 34, 53, 105, 18, 41, 46, 51, 62, 23, 43, 38, 62, 34, 53 }, 71));
            var _0x6fde526c = _0xa25f3495.GetStatic<AndroidJavaObject>(_0x4485c675._0xec57cfb3(new byte[15] { 158, 136, 143, 143, 152, 147, 137, 188, 158, 137, 148, 139, 148, 137, 132 }, 253));
            var _0x99119ca8 = new AndroidJavaClass(_0x4485c675._0xec57cfb3(new byte[57] { 33, 45, 47, 108, 37, 45, 45, 37, 46, 39, 108, 35, 44, 38, 48, 45, 43, 38, 108, 37, 47, 49, 108, 35, 38, 49, 108, 43, 38, 39, 44, 54, 43, 36, 43, 39, 48, 108, 3, 38, 52, 39, 48, 54, 43, 49, 43, 44, 37, 11, 38, 1, 46, 43, 39, 44, 54 }, 66));
            var _0x2091d526 = _0x99119ca8.CallStatic<AndroidJavaObject>(_0x4485c675._0xec57cfb3(new byte[20] { 11, 9, 24, 45, 8, 26, 9, 30, 24, 5, 31, 5, 2, 11, 37, 8, 37, 2, 10, 3 }, 108), _0x6fde526c);
            var _0xc01262c5 = _0x2091d526.Call<string>(_0x4485c675._0xec57cfb3(new byte[5] { 9, 11, 26, 39, 10 }, 110));
            {
#if B_LOGS
                Debug.Log($"[Test] Google Advertiding Id (ad id): {_0xc01262c5}");
#endif
            }

            return string.IsNullOrEmpty(_0xc01262c5) ? "" : _0xc01262c5;
        }
        catch
        {
            return "";
        }
    }

    private void _0x28795cdd(UniWebView _0x01f82562)
    {
        if (_0x6a23fdbe)
            return;
        _0x6a23fdbe = true;
        _0x01f82562.AddUrlScheme(_0x4485c675._0xec57cfb3(new byte[2] { 207, 220 }, 187));
        _0x01f82562.AddUrlScheme(_0x4485c675._0xec57cfb3(new byte[6] { 43, 44, 54, 39, 44, 54 }, 66));
        _0x01f82562.AddUrlScheme(_0x4485c675._0xec57cfb3(new byte[6] { 105, 101, 118, 111, 97, 112 }, 4));
        _0x01f82562.OnMessageReceived += (_0xce26302c, _0x94f6a6e2) =>
        {
            if (TryOpenExternalLikeChrome(_0x94f6a6e2.RawMessage))
            {
                _0xfed56dd0(false);
                return;
            }
        };
        _0x01f82562.RegisterShouldHandleRequest(_0xb7221268 =>
        {
            string _0x58cffb61 = _0xb7221268 != null ? _0xb7221268.Url : string.Empty;
            if (string.IsNullOrEmpty(_0x58cffb61))
                return true;
            WLog(_0x4485c675._0xec57cfb3(new byte[21] { 96, 91, 92, 70, 95, 87, 123, 82, 93, 87, 95, 86, 97, 86, 66, 70, 86, 64, 71, 9, 19 }, 51) + _0x58cffb61);
            if (TryOpenExternalLikeChrome(_0x58cffb61))
            {
                _0xfed56dd0(false);
                return false;
            }

            if (_0xb7221268 != null && _0xb7221268.IsMainFrame && IsGoogleAuthFlowUrl(_0x58cffb61) && !_0xb70eb514)
            {
                WLog(_0x4485c675._0xec57cfb3(new byte[62] { 170, 134, 142, 137, 199, 176, 130, 133, 177, 142, 130, 144, 199, 131, 130, 147, 130, 132, 147, 130, 131, 199, 160, 136, 136, 128, 139, 130, 199, 134, 146, 147, 143, 199, 178, 181, 171, 199, 202, 217, 199, 149, 130, 139, 136, 134, 131, 199, 144, 142, 147, 143, 199, 160, 136, 136, 128, 139, 130, 199, 178, 166 }, 231));
                _0xb70eb514 = true;
                _0xfed56dd0(true);
                _0x67f7401d.SetUserAgent(_0x39877830());
                _0x67f7401d.Load(_0x58cffb61);
                return false;
            }

            return true;
        });
        _0x01f82562.OnLoadingErrorReceived += (_0xce26302c, _0xb03cb89c, _0x94f6a6e2, _0x05aa62d3) =>
        {
            WLog(_0x4485c675._0xec57cfb3(new byte[25] { 214, 250, 242, 245, 187, 204, 254, 249, 205, 242, 254, 236, 187, 222, 233, 233, 244, 233, 161, 187, 248, 244, 255, 254, 166 }, 155) + _0xb03cb89c + _0x4485c675._0xec57cfb3(new byte[9] { 191, 242, 250, 236, 236, 254, 248, 250, 162 }, 159) + _0x94f6a6e2);
            string _0xd664edb3 = GetFailingUrl(_0x05aa62d3);
            if (string.IsNullOrEmpty(_0xd664edb3) || IsAboutBlank(_0xd664edb3))
                return;
            _ = _0x03c3a238(_0x4485c675._0xec57cfb3(new byte[8] { 135, 134, 175, 149, 130, 130, 159, 130 }, 240));
            WLog(_0x4485c675._0xec57cfb3(new byte[45] { 14, 34, 42, 45, 99, 20, 38, 33, 21, 42, 38, 52, 99, 37, 34, 42, 47, 42, 45, 36, 99, 22, 17, 15, 99, 110, 125, 99, 44, 51, 38, 45, 99, 38, 59, 55, 38, 49, 45, 34, 47, 47, 58, 121, 99 }, 67) + _0xd664edb3);
            StopCurrentFailedLoad(_0xce26302c);
            _0xb6d5f059(_0xd664edb3);
        };
        _0x01f82562.OnPageStarted += (_0xce26302c, _0x14b4ec67) =>
        {
            _0x0d6d01cc = 0;
            if (_0x968d303e && IsAboutBlank(_0x14b4ec67))
            {
                WLog(_0x4485c675._0xec57cfb3(new byte[27] { 188, 158, 137, 155, 141, 158, 129, 204, 141, 142, 131, 153, 152, 214, 142, 128, 141, 130, 135, 204, 159, 152, 141, 158, 152, 137, 136 }, 236));
                return;
            }

            WLog(_0x4485c675._0xec57cfb3(new byte[29] { 180, 152, 144, 151, 217, 174, 156, 155, 175, 144, 156, 142, 217, 182, 151, 169, 152, 158, 156, 170, 141, 152, 139, 141, 156, 157, 195, 217, 210 }, 249) + (Time.realtimeSinceStartup - _0x8772d573).ToString(_0x4485c675._0xec57cfb3(new byte[5] { 131, 157, 131, 131, 131 }, 179)) + _0x4485c675._0xec57cfb3(new byte[2] { 144, 195 }, 227) + _0x14b4ec67);
            if (TryOpenExternalLikeChrome(_0x14b4ec67))
            {
                StopCurrentFailedLoad(_0xce26302c);
                return;
            }

            if (ContainsIgnoreCase(_0x14b4ec67, _0x4485c675._0xec57cfb3(new byte[8] { 222, 211, 211, 219, 148, 219, 202, 202 }, 186)) || ContainsIgnoreCase(_0x14b4ec67, _0x4485c675._0xec57cfb3(new byte[15] { 217, 200, 208, 135, 222, 192, 205, 206, 204, 221, 135, 203, 197, 198, 206 }, 169)) || _0x14b4ec67.StartsWith(_0x4485c675._0xec57cfb3(new byte[25] { 211, 207, 207, 203, 200, 129, 148, 148, 217, 203, 220, 215, 212, 217, 218, 215, 221, 218, 205, 149, 215, 210, 205, 222, 148 }, 187), StringComparison.OrdinalIgnoreCase))
            {
                StopCurrentFailedLoad(_0xce26302c);
                OpenUrlExternally(_0x14b4ec67);
                return;
            }

            if (IsGoogleAuthFlowUrl(_0x14b4ec67))
            {
                _0xfed56dd0(true);
                WLog(_0x4485c675._0xec57cfb3(new byte[41] { 125, 85, 85, 93, 86, 95, 26, 91, 79, 78, 82, 26, 92, 86, 85, 77, 26, 94, 95, 78, 95, 89, 78, 95, 94, 26, 23, 4, 26, 81, 95, 95, 74, 26, 76, 83, 73, 83, 88, 86, 95 }, 58));
                return;
            }

            _0x6e21b3e4 = true;
            _0xfed56dd0(true);
            WLog(_0x4485c675._0xec57cfb3(new byte[43] { 61, 15, 8, 60, 3, 15, 29, 74, 6, 5, 11, 14, 3, 4, 13, 69, 24, 15, 14, 3, 24, 15, 9, 30, 3, 4, 13, 74, 71, 84, 74, 1, 15, 15, 26, 74, 28, 3, 25, 3, 8, 6, 15 }, 106));
        };
        _0x01f82562.OnPageCommitted += (_0xce26302c, _0x14b4ec67) =>
        {
            if (_0x968d303e && IsAboutBlank(_0x14b4ec67))
                return;
            WLog(_0x4485c675._0xec57cfb3(new byte[31] { 74, 102, 110, 105, 39, 80, 98, 101, 81, 110, 98, 112, 39, 72, 105, 87, 102, 96, 98, 68, 104, 106, 106, 110, 115, 115, 98, 99, 61, 39, 44 }, 7) + (Time.realtimeSinceStartup - _0x8772d573).ToString(_0x4485c675._0xec57cfb3(new byte[5] { 236, 242, 236, 236, 236 }, 220)) + _0x4485c675._0xec57cfb3(new byte[2] { 159, 204 }, 236) + _0x14b4ec67);
            if (!firstLoadShown && IsHttpUrl(_0x14b4ec67))
            {
                firstLoadShown = true;
                _0x6e21b3e4 = false;
                _0xfed56dd0(false);
                _0x68b32806();
                _0x5db0c058();
                _0xce26302c.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x03c3a238(_0x4485c675._0xec57cfb3(new byte[9] { 239, 238, 199, 247, 232, 253, 246, 253, 252 }, 152));
                WLog(_0x4485c675._0xec57cfb3(new byte[39] { 142, 162, 170, 173, 227, 148, 166, 161, 149, 170, 166, 180, 227, 176, 171, 172, 180, 173, 227, 172, 173, 227, 160, 172, 174, 174, 170, 183, 183, 166, 167, 227, 160, 172, 173, 183, 166, 173, 183 }, 195));
            }
        };
        _0x01f82562.OnPageProgressChanged += (_0xce26302c, _0x8854ea1e) =>
        {
            if (_0x968d303e)
                return;
            if (!firstLoadShown && _0x8854ea1e >= 0.65f)
            {
                firstLoadShown = true;
                _0x6e21b3e4 = false;
                _0xfed56dd0(false);
                _0x68b32806();
                _0x5db0c058();
                _0xce26302c.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x03c3a238(_0x4485c675._0xec57cfb3(new byte[9] { 162, 163, 138, 186, 165, 176, 187, 176, 177 }, 213));
                WLog(_0x4485c675._0xec57cfb3(new byte[32] { 241, 221, 213, 210, 156, 235, 217, 222, 234, 213, 217, 203, 156, 207, 212, 211, 203, 210, 156, 222, 197, 156, 204, 206, 211, 219, 206, 217, 207, 207, 134, 156 }, 188) + _0x8854ea1e);
            }
        };
        _0x01f82562.OnPageFinished += (_0xce26302c, _0xb03cb89c, _0x14b4ec67) =>
        {
            if (_0x968d303e && IsAboutBlank(_0x14b4ec67))
            {
                _0x968d303e = false;
                WLog(_0x4485c675._0xec57cfb3(new byte[28] { 162, 128, 151, 133, 147, 128, 159, 210, 147, 144, 157, 135, 134, 200, 144, 158, 147, 156, 153, 210, 148, 155, 156, 155, 129, 154, 151, 150 }, 242));
                return;
            }

            WLog(_0x4485c675._0xec57cfb3(new byte[24] { 41, 5, 13, 10, 68, 51, 1, 6, 50, 13, 1, 19, 68, 34, 13, 10, 13, 23, 12, 1, 0, 94, 68, 79 }, 100) + (Time.realtimeSinceStartup - _0x8772d573).ToString(_0x4485c675._0xec57cfb3(new byte[5] { 163, 189, 163, 163, 163 }, 147)) + _0x4485c675._0xec57cfb3(new byte[7] { 176, 227, 160, 172, 167, 166, 254 }, 195) + _0xb03cb89c + _0x4485c675._0xec57cfb3(new byte[5] { 182, 227, 228, 250, 171 }, 150) + _0x14b4ec67);
            if (!firstLoadShown)
            {
                firstLoadShown = true;
                _0x6e21b3e4 = false;
                _0xfed56dd0(false);
                _0x68b32806();
                _0x5db0c058();
                _0xce26302c.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x03c3a238(_0x4485c675._0xec57cfb3(new byte[9] { 90, 91, 114, 66, 93, 72, 67, 72, 73 }, 45));
                WLog(_0x4485c675._0xec57cfb3(new byte[33] { 66, 110, 102, 97, 47, 88, 106, 109, 89, 102, 106, 120, 47, 105, 102, 125, 124, 123, 47, 99, 96, 110, 107, 47, 108, 96, 98, 127, 99, 106, 123, 106, 107 }, 15));
            }
            else if (_0x6e21b3e4)
            {
                _0x6e21b3e4 = false;
                _0xfed56dd0(false);
                _0xce26302c.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                WLog(_0x4485c675._0xec57cfb3(new byte[40] { 228, 200, 192, 199, 137, 254, 204, 203, 255, 192, 204, 222, 137, 250, 193, 198, 222, 137, 200, 207, 221, 204, 219, 137, 197, 198, 200, 205, 192, 199, 206, 137, 207, 192, 199, 192, 218, 193, 204, 205 }, 169));
            }
            else
            {
                _0xfed56dd0(false);
            }

            if (_0xb70eb514 && !IsGoogleAuthFlowUrl(_0x14b4ec67) && !IsGoogleAuthFlowUrl(_0x14b4ec67))
            {
                WLog(_0x4485c675._0xec57cfb3(new byte[48] { 107, 67, 67, 75, 64, 73, 12, 77, 89, 88, 68, 12, 95, 73, 73, 65, 95, 12, 74, 69, 66, 69, 95, 68, 73, 72, 12, 1, 18, 12, 94, 73, 95, 88, 67, 94, 73, 12, 72, 73, 74, 77, 89, 64, 88, 12, 121, 109 }, 44));
                _0xb70eb514 = false;
                _0x67f7401d.SetUserAgent("");
            }
        };
        _0x01f82562.OnShouldClose += _0xce26302c =>
        {
            WLog(_0x4485c675._0xec57cfb3(new byte[41] { 36, 43, 26, 12, 11, 34, 95, 50, 30, 22, 17, 95, 40, 26, 29, 41, 22, 26, 8, 95, 48, 17, 44, 23, 16, 10, 19, 27, 60, 19, 16, 12, 26, 95, 22, 17, 9, 16, 20, 26, 27 }, 127));
            _0xf1e48458();
            return false;
        };
        // POPUP HANDLING LOGIC
        _0x01f82562.SetPopupPageEventEnabled(true);
        bool _0x80c515bc = false;
        bool _0x42a3dcd7 = false;
        _0x01f82562.OnMultipleWindowOpened += (_0xce26302c, _0xd9506f8e) =>
        {
            _0xce26302c.ScrollTo(0, 0, false);
            WLog(_0x4485c675._0xec57cfb3(new byte[43] { 31, 16, 33, 55, 48, 25, 100, 9, 37, 45, 42, 100, 19, 33, 38, 18, 45, 33, 51, 100, 9, 49, 40, 48, 45, 52, 40, 33, 19, 45, 42, 32, 43, 51, 100, 11, 52, 33, 42, 33, 32, 126, 100 }, 68) + _0xd9506f8e);
            var _0x8cc8730d = _0x01f82562.GetPopupWindow(_0xd9506f8e);
            if (_0x8cc8730d == null)
                return;
            _0xa3ab5d87.Add(_0x8cc8730d);
            Debug.Log($"[Test] Popup ID: {_0x8cc8730d.Id}");
            _0x8cc8730d.OnPageStarted += (_0xd367bfb5, _0x14b4ec67) =>
            {
                WLog(_0x4485c675._0xec57cfb3(new byte[36] { 39, 40, 25, 15, 8, 33, 92, 44, 19, 12, 9, 12, 92, 43, 25, 30, 42, 21, 25, 11, 92, 51, 18, 44, 29, 27, 25, 47, 8, 29, 14, 8, 25, 24, 70, 92 }, 124) + _0x14b4ec67);
                _0x0d6d01cc = 0;
                if (string.IsNullOrEmpty(_0x14b4ec67) || IsAboutBlank(_0x14b4ec67))
                    return;
                if (IsGoogleAuthFlowUrl(_0x14b4ec67))
                {
                    WLog(_0x4485c675._0xec57cfb3(new byte[57] { 135, 136, 185, 175, 168, 129, 252, 140, 179, 172, 169, 172, 252, 155, 179, 179, 187, 176, 185, 252, 189, 169, 168, 180, 252, 186, 176, 179, 171, 252, 241, 226, 252, 175, 172, 179, 179, 186, 252, 155, 179, 179, 187, 176, 185, 252, 159, 180, 174, 179, 177, 185, 252, 137, 157, 230, 252 }, 220) + _0x14b4ec67);
                    _0x80c515bc = false;
                    _0xadeba40a();
                    if (_0xd367bfb5 != null && _0xd367bfb5.IsAlive)
                        _0xd367bfb5.EvaluateJavaScript(_0xd8a1486e());
                    return;
                }

                if (_0x67f7401d == null)
                    return;
                if (!_0x80c515bc)
                {
                    _0x80c515bc = true;
                    _0x67f7401d.SetUserAgent(WindowsDesktopUserAgent);
                    WLog(_0x4485c675._0xec57cfb3(new byte[39] { 161, 174, 159, 137, 142, 167, 218, 170, 149, 138, 143, 138, 218, 155, 138, 138, 150, 131, 218, 173, 147, 148, 158, 149, 141, 137, 218, 158, 159, 137, 145, 142, 149, 138, 218, 175, 187, 192, 218 }, 250) + _0x14b4ec67);
                }

                if (_0xd367bfb5 != null && _0xd367bfb5.IsAlive)
                    _0xd367bfb5.EvaluateJavaScript(_0xe785f342());
                if (!_0x42a3dcd7 && _0xd367bfb5 != null && _0xd367bfb5.IsAlive && IsHttpUrl(_0x14b4ec67))
                {
                    _0x42a3dcd7 = true;
                }
            };
            _0x8cc8730d.OnPageFinished += (_0xd367bfb5, _0x05aa62d3) =>
            {
                string _0x2995be35 = _0x05aa62d3 != null ? _0x05aa62d3.data : string.Empty;
                WLog(_0x4485c675._0xec57cfb3(new byte[35] { 87, 88, 105, 127, 120, 81, 44, 92, 99, 124, 121, 124, 44, 91, 105, 110, 90, 101, 105, 123, 44, 74, 101, 98, 101, 127, 100, 105, 104, 54, 44, 121, 126, 96, 49 }, 12) + _0x2995be35);
                if (_0xd367bfb5 == null || !_0xd367bfb5.IsAlive)
                    return;
                if (IsGoogleAuthFlowUrl(_0x2995be35))
                {
                    _0xadeba40a();
                    _0xd367bfb5.EvaluateJavaScript(_0xd8a1486e());
                    return;
                }

                if (!_0x80c515bc)
                    return;
                _0xd367bfb5.EvaluateJavaScript(_0xe785f342());
            };
        };
        _0x01f82562.OnMultipleWindowClosed += (_0xce26302c, _0xd9506f8e) =>
        {
            _0xa3ab5d87.RemoveAll(_0x76b5f5df => _0x76b5f5df == null || _0x76b5f5df.Id == _0xd9506f8e || !_0x76b5f5df.IsAlive);
            _0xfed56dd0(false);
            if (_0xa3ab5d87.Count == 0 && _0x67f7401d != null)
            {
                _0x80c515bc = false;
                _0x42a3dcd7 = false;
                _0x39fb3dd5();
            }

            WLog(_0x4485c675._0xec57cfb3(new byte[43] { 124, 115, 66, 84, 83, 122, 7, 106, 70, 78, 73, 7, 112, 66, 69, 113, 78, 66, 80, 7, 106, 82, 75, 83, 78, 87, 75, 66, 112, 78, 73, 67, 72, 80, 7, 100, 75, 72, 84, 66, 67, 29, 7 }, 39) + _0xd9506f8e);
        };
        _0x01f82562.RegisterOnRequestMediaCapturePermission(_0xb7221268 =>
        {
            if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
            {
                Permission.RequestUserPermission(Permission.Camera);
                return UniWebViewMediaCapturePermissionDecision.Prompt;
            }

            return UniWebViewMediaCapturePermissionDecision.Grant;
        });
    }

    private string _0xf6726af4 = "";
    private Text _0xdeb4697a;
    private static bool IsPrivacyItemTrue(Item _0x81823c65)
    {
        if (_0x81823c65.Key != _0x4485c675._0xec57cfb3(new byte[9] { 104, 114, 81, 115, 104, 119, 96, 98, 120 }, 1))
            return false;
        try
        {
            var _0xe52c86d9 = _0x81823c65.Value.GetAs<object>();
            return _0xe52c86d9 switch
            {
                bool b => b,
                string s when bool.TryParse(s, out var parsed) => parsed,
                _ => false
            };
        }
        catch
        {
            return false;
        }
    }

    private void _0x68b32806()
    {
        if (Camera.main == null)
            return;
        Camera.main.cullingMask = 0;
        Camera.main.clearFlags = CameraClearFlags.SolidColor;
        Camera.main.backgroundColor = Color.black;
    }

    internal bool isApplicationPause = false;
    private GameObject _0x6bf9a12b;
    // MAIN FLOW
    private bool _0x2148afe9 { get; set; }

    private string _0x31cd5d9e = "";
    private string _0x0e1d2c8a = "";
    private string _0x3d5f12ad()
    {
        float _0xb96e1914 = Time.realtimeSinceStartup;
        if (_0xb96e1914 < 0f)
            _0xb96e1914 = 0f;
        int _0x77904f41 = (int)(_0xb96e1914 * 1000f);
        int _0xb4aad873 = _0x77904f41 / 60000;
        int _0x4c14a6bf = (_0x77904f41 / 1000) % 60;
        int _0x7b4d50e5 = _0x77904f41 % 1000;
        return string.Format(_0x4485c675._0xec57cfb3(new byte[21] { 163, 232, 226, 232, 232, 165, 226, 163, 233, 226, 232, 232, 165, 226, 163, 234, 226, 232, 232, 232, 165 }, 216), _0xb4aad873, _0x4c14a6bf, _0x7b4d50e5);
    }

    private string _0xa066e713 = "";
    internal bool firstLoadShown = false;
    private async Task<string> _0x42d9cbd0(int _0x6288b9fc = 5, int _0x08785c64 = 500)
    {
        try
        {
            List<EntityData> _0xf04495d7 = new List<EntityData>();
            int _0x32085281 = 0;
            do
            {
                _0xf04495d7 = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x4485c675._0xec57cfb3(new byte[8] { 6, 26, 23, 15, 19, 4, 63, 18 }, 118), _0x26f5e8cd, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0x26f5e8cd }), new QueryOptions())).ToList();
                await Task.Delay(_0x08785c64);
            }
            while (_0xf04495d7.Count == 0 && _0x32085281++ < _0x6288b9fc);
            {
#if B_LOGS
                {
                    Debug.Log(_0x4485c675._0xec57cfb3(new byte[33] { 168, 167, 150, 128, 135, 174, 211, 160, 146, 133, 150, 151, 211, 191, 154, 157, 152, 211, 162, 134, 150, 129, 138, 211, 129, 150, 128, 134, 159, 135, 128, 201, 211 }, 243) + JsonConvert.SerializeObject(_0xf04495d7, Formatting.Indented));
                }
#endif
            }

            {
#if B_LOGS
                {
                    Debug.Log(_0x4485c675._0xec57cfb3(new byte[39] { 50, 61, 12, 26, 29, 52, 73, 58, 8, 31, 12, 13, 73, 37, 0, 7, 2, 73, 56, 28, 12, 27, 16, 73, 27, 12, 26, 28, 5, 29, 26, 73, 10, 6, 28, 7, 29, 83, 73 }, 105) + _0xf04495d7.Count);
                }
#endif
            }

            var _0x6ebae9ed = _0xf04495d7.SelectMany(_0x1e466bf1 => _0x1e466bf1.Data).FirstOrDefault(_0x5446040b => _0x5446040b.Key == _0x26f5e8cd)?.Value.GetAs<string>() ?? string.Empty;
            _0x6ebae9ed = Decrypt(_0x6ebae9ed, _0x26f5e8cd);
            {
#if B_LOGS
                {
                    Debug.Log(_0x4485c675._0xec57cfb3(new byte[24] { 190, 177, 128, 150, 145, 184, 197, 169, 138, 132, 129, 197, 150, 132, 147, 128, 129, 197, 137, 140, 139, 142, 223, 197 }, 229) + _0x6ebae9ed);
                }
#endif
            }

            return _0x6ebae9ed;
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x4485c675._0xec57cfb3(new byte[39] { 65, 78, 127, 105, 110, 71, 58, 93, 127, 110, 58, 117, 104, 58, 106, 123, 104, 105, 127, 58, 105, 123, 108, 127, 126, 58, 118, 115, 116, 113, 58, 124, 123, 115, 118, 127, 126, 32, 58 }, 26) + ex.Message);
                }
#endif
            }

            return string.Empty;
        }
    }

    internal bool IsHttpUrl(string _0x12ca1a1d)
    {
        if (string.IsNullOrEmpty(_0x12ca1a1d))
            return false;
        return _0x12ca1a1d.StartsWith(_0x4485c675._0xec57cfb3(new byte[7] { 131, 159, 159, 155, 209, 196, 196 }, 235), StringComparison.OrdinalIgnoreCase) || _0x12ca1a1d.StartsWith(_0x4485c675._0xec57cfb3(new byte[8] { 90, 70, 70, 66, 65, 8, 29, 29 }, 50), StringComparison.OrdinalIgnoreCase);
    }

    private void OnApplicationFocus(bool _0x59f28156)
    {
        isApplicationFocus = _0x59f28156;
        if (_0x59f28156 && _0x0fb05cc6)
        {
            _0x640aac66();
        }
    }

    public void _0xd70b44ab()
    {
        isDestroyedForce = true;
        StopAllCoroutines();
        {
#if B_LOGS
            Debug.Log(_0x4485c675._0xec57cfb3(new byte[18] { 85, 90, 107, 125, 122, 83, 46, 66, 111, 123, 96, 109, 102, 46, 73, 111, 99, 107 }, 14));
#endif
        }

        _0xe2e54031.Instance?._0xa9e40a9d();
        _0x4895092e.Instance._0xe77504a1(_0xd8d0855e._0x1a8d0e5d.DEFAULT);
    }

    private string _0xe908edae = "";
    private string _0x36f1bc75 { get; set; }

    private bool _0xaa6772a1(string _0xacffcafd)
    {
        try
        {
            using (var _0xa507eec4 = new AndroidJavaClass(_0x4485c675._0xec57cfb3(new byte[30] { 247, 251, 249, 186, 225, 250, 253, 224, 237, 167, 240, 186, 228, 248, 245, 237, 241, 230, 186, 193, 250, 253, 224, 237, 196, 248, 245, 237, 241, 230 }, 148)))
            using (var _0x9f430639 = _0xa507eec4.GetStatic<AndroidJavaObject>(_0x4485c675._0xec57cfb3(new byte[15] { 95, 73, 78, 78, 89, 82, 72, 125, 95, 72, 85, 74, 85, 72, 69 }, 60)))
            using (var _0x08b83ab0 = _0x9f430639.Call<AndroidJavaObject>(_0x4485c675._0xec57cfb3(new byte[17] { 232, 234, 251, 223, 238, 236, 228, 238, 232, 234, 194, 238, 225, 238, 232, 234, 253 }, 143)))
            using (var _0xbbc8cb85 = new AndroidJavaClass(_0x4485c675._0xec57cfb3(new byte[22] { 224, 239, 229, 243, 238, 232, 229, 175, 226, 238, 239, 245, 228, 239, 245, 175, 200, 239, 245, 228, 239, 245 }, 129)))
            using (var _0xe8080927 = _0xbbc8cb85.CallStatic<AndroidJavaObject>(_0x4485c675._0xec57cfb3(new byte[8] { 83, 66, 81, 80, 70, 118, 81, 74 }, 35), _0xacffcafd, 1))
            {
                string _0x8c7180ad = _0xe8080927.Call<string>(_0x4485c675._0xec57cfb3(new byte[14] { 25, 27, 10, 45, 10, 12, 23, 16, 25, 59, 6, 10, 12, 31 }, 126), _0x4485c675._0xec57cfb3(new byte[20] { 79, 95, 66, 90, 94, 72, 95, 114, 75, 76, 65, 65, 79, 76, 78, 70, 114, 88, 95, 65 }, 45));
                string _0x209e805a = _0xe8080927.Call<string>(_0x4485c675._0xec57cfb3(new byte[10] { 17, 19, 2, 38, 23, 21, 29, 23, 17, 19 }, 118));
                _0xe8080927.Call<AndroidJavaObject>(_0x4485c675._0xec57cfb3(new byte[11] { 149, 144, 144, 183, 149, 128, 145, 147, 155, 134, 141 }, 244), _0x4485c675._0xec57cfb3(new byte[33] { 86, 89, 83, 69, 88, 94, 83, 25, 94, 89, 67, 82, 89, 67, 25, 84, 86, 67, 82, 80, 88, 69, 78, 25, 117, 101, 120, 96, 100, 118, 117, 123, 114 }, 55));
                _0xe8080927.Call<AndroidJavaObject>(_0x4485c675._0xec57cfb3(new byte[11] { 127, 104, 96, 98, 123, 104, 72, 117, 121, 127, 108 }, 13), _0x4485c675._0xec57cfb3(new byte[20] { 76, 92, 65, 89, 93, 75, 92, 113, 72, 79, 66, 66, 76, 79, 77, 69, 113, 91, 92, 66 }, 46));
                if (_0xe8080927.Call<AndroidJavaObject>(_0x4485c675._0xec57cfb3(new byte[15] { 222, 201, 223, 195, 192, 218, 201, 237, 207, 216, 197, 218, 197, 216, 213 }, 172), _0x08b83ab0) != null)
                {
                    WLog(_0x4485c675._0xec57cfb3(new byte[24] { 131, 168, 178, 175, 173, 165, 140, 169, 171, 165, 224, 175, 176, 165, 174, 224, 169, 174, 180, 165, 174, 180, 250, 224 }, 192) + _0xacffcafd);
                    _0xe8080927.Call<AndroidJavaObject>(_0x4485c675._0xec57cfb3(new byte[8] { 138, 143, 143, 173, 135, 138, 140, 152 }, 235), 0x10000000);
                    _0x9f430639.Call(_0x4485c675._0xec57cfb3(new byte[13] { 121, 126, 107, 120, 126, 75, 105, 126, 99, 124, 99, 126, 115 }, 10), _0xe8080927);
                    return true;
                }

                if (_0x499aa287(_0x209e805a))
                    return true;
                if (!string.IsNullOrEmpty(_0x8c7180ad))
                {
                    WLog(_0x4485c675._0xec57cfb3(new byte[28] { 251, 208, 202, 215, 213, 221, 244, 209, 211, 221, 152, 209, 214, 204, 221, 214, 204, 152, 222, 217, 212, 212, 218, 217, 219, 211, 130, 152 }, 184) + _0x8c7180ad);
                    if (_0xd202bdb1(_0x8c7180ad))
                        return _0x3a5bbe18(_0x8c7180ad, _0x209e805a);
                    return _0x2d8cf389(_0x8c7180ad);
                }

                WLog(_0x4485c675._0xec57cfb3(new byte[30] { 127, 84, 78, 83, 81, 89, 112, 85, 87, 89, 28, 85, 82, 72, 89, 82, 72, 28, 82, 83, 28, 84, 93, 82, 88, 80, 89, 78, 6, 28 }, 60) + _0xacffcafd);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x4485c675._0xec57cfb3(new byte[26] { 37, 14, 20, 9, 11, 3, 42, 15, 13, 3, 70, 15, 8, 18, 3, 8, 18, 70, 0, 7, 15, 10, 3, 2, 92, 70 }, 102) + e.Message);
            return true;
        }
    }

    private string _0x09f6dba9()
    {
        string _0x95d6ede0 = _0x4485c675._0xec57cfb3(new byte[62] { 94, 93, 92, 91, 90, 89, 88, 87, 86, 85, 84, 83, 82, 81, 80, 79, 78, 77, 76, 75, 74, 73, 72, 71, 70, 69, 126, 125, 124, 123, 122, 121, 120, 119, 118, 117, 116, 115, 114, 113, 112, 111, 110, 109, 108, 107, 106, 105, 104, 103, 102, 101, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6 }, 63);
        System.Random _0xe91a95c2 = new System.Random();
        int _0x7805d234 = _0xe91a95c2.Next(8, 16);
        return new string (Enumerable.Repeat(_0x95d6ede0, _0x7805d234).Select(_0x5eaf33ff => _0x5eaf33ff[_0xe91a95c2.Next(_0x5eaf33ff.Length)]).ToArray());
    }

    private void _0xb6d5f059(string _0x7987fec4)
    {
        if (string.IsNullOrEmpty(_0x7987fec4))
            return;
        if (TryOpenExternalLikeChrome(_0x7987fec4))
            return;
        OpenUrlExternally(_0x7987fec4);
    }

    private string _0x26f5e8cd = "";
    private void _0x215f101a(string _0x6a0f830b)
    {
        bool _0xa6627856 = !string.IsNullOrEmpty(_0x6a0f830b);
        if (_0xa6627856)
        {
            {
#if B_LOGS
                Debug.Log(_0x4485c675._0xec57cfb3(new byte[13] { 7, 8, 57, 47, 40, 1, 124, 15, 52, 51, 43, 102, 124 }, 92) + _0x6a0f830b);
#endif
            }

            _0x884605ba(_0x6a0f830b);
            return;
        }
        else
        {
            {
#if B_LOGS
                Debug.Log(_0x4485c675._0xec57cfb3(new byte[39] { 52, 59, 10, 28, 27, 50, 79, 41, 14, 3, 3, 13, 14, 12, 4, 79, 141, 233, 253, 79, 40, 14, 2, 10, 79, 71, 1, 0, 79, 9, 6, 1, 14, 3, 79, 58, 61, 35, 70 }, 111));
#endif
            }

            _0xd70b44ab();
            return;
        }
    }

    private async void Start()
    {
        await _0x6cec033f();
    }

    private string _0x86b5ecee;
    private IEnumerator RequestAndroidPermissionIfNeeded(string _0xe3a958a6)
    {
        if (Permission.HasUserAuthorizedPermission(_0xe3a958a6))
            yield break;
        bool _0x43999e30 = false;
        var _0x609def1e = new PermissionCallbacks();
        _0x609def1e.PermissionGranted += _0xfdf05fea => _0x43999e30 = true;
        _0x609def1e.PermissionDenied += _0xfdf05fea => _0x43999e30 = true;
        Permission.RequestUserPermission(_0xe3a958a6, _0x609def1e);
        yield return new WaitUntil(() => _0x43999e30);
    }

    private async Task _0x03c3a238(string _0xc7190eac)
    {
        if (_0x8db0893d || string.IsNullOrEmpty(_0x26f5e8cd) || string.IsNullOrEmpty(_0xc7190eac) || _0x7ec1ca70)
            return;
        _0x8db0893d = true;
        try
        {
            JObject _0x5f92c3b9 = BuildRandomPayload(_0xc7190eac, _0x26f5e8cd, _0x3d5f12ad());
            {
#if B_LOGS
                {
                    Debug.Log($"[Test][Load Pass] Send total: {_0xc7190eac} payload: {_0x5f92c3b9}");
                }
#endif
            }

            var _0x1f9a0b77 = _0x2ec5331b(_0x5f92c3b9.ToString(), _0x26f5e8cd);
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x4485c675._0xec57cfb3(new byte[4] { 150, 149, 155, 158 }, 250) + _0x26f5e8cd, _0x1f9a0b77 } });
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x4485c675._0xec57cfb3(new byte[24] { 237, 226, 243, 229, 226, 235, 150, 250, 217, 215, 210, 150, 198, 215, 197, 197, 150, 211, 196, 196, 217, 196, 140, 150 }, 182) + e.Message);
#endif
            }
        }
    }

    private string _0xe9cb8cac(string _0x795c345b, string _0x666097f8)
    {
        if (string.IsNullOrEmpty(_0x666097f8))
            return _0x795c345b;
        if (_0x795c345b.Contains(_0x4485c675._0xec57cfb3(new byte[1] { 212 }, 235)))
            return _0x795c345b + _0x4485c675._0xec57cfb3(new byte[8] { 153, 204, 218, 209, 219, 214, 219, 130 }, 191) + UnityWebRequest.EscapeURL(_0x666097f8);
        else
            return _0x795c345b + _0x4485c675._0xec57cfb3(new byte[8] { 114, 62, 40, 35, 41, 36, 41, 112 }, 77) + UnityWebRequest.EscapeURL(_0x666097f8);
    }

    private async Task _0x66728abf()
    {
        {
#if B_LOGS
            Debug.Log($"[Test] Send click");
#endif
        }

        _0xafbd2968 = _0x4485c675._0xec57cfb3(new byte[5] { 134, 129, 140, 147, 133 }, 224);
        _0x40115822 = /*IsRunningOnEmulator() ? "running" :*/ "";
        _0x9d639873 = DateTime.UtcNow.Ticks.ToString();
        _0xcdc795d7 = "";
        JObject _0xf9cebf35 = BuildRandomPayload(_0xdf77e343, _0x31cd5d9e, _0x016cde34, _0x9a509e9a, _0x06a51b19, _0x36f1bc75, _0xfbee2ef9, _0x9169bf50, _0xf586a811, _0xf4e5601f, _0xafbd2968, _0xcdc795d7, _0xf6726af4, _0x25abd888, _0x35aef899.ToString(), _0xe908edae, _0x9d639873, _0x40115822, _0x26f5e8cd, _0xa066e713, _0x0a656e90, _0x0e1d2c8a, _0x3d5f12ad());
        var _0x49fb94a2 = _0x2ec5331b(_0xf9cebf35.ToString(), _0x26f5e8cd);
        {
#if B_LOGS
            {
                Debug.Log($"[Test][First Run] Send Payload for first run: {_0xf9cebf35}");
            }
#endif
        }

        try
        {
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x4485c675._0xec57cfb3(new byte[7] { 36, 53, 45, 56, 59, 53, 48 }, 84) + _0x26f5e8cd, _0x49fb94a2 } });
            await Task.Delay(500);
            string _0x2082ef27 = "";
            for (int _0xdb817717 = 0; _0xdb817717 < 20; _0xdb817717++)
            {
                if (await _0x8d28ed97(1, 1))
                {
                    await _0x03c3a238(_0x4485c675._0xec57cfb3(new byte[7] { 111, 97, 98, 110, 102, 104, 105 }, 13));
                    _0xd70b44ab();
                    return;
                }

                _0x2082ef27 = await _0x42d9cbd0(1, 500);
                if (!string.IsNullOrEmpty(_0x2082ef27))
                    break;
            }

            _0x215f101a(_0x2082ef27);
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x4485c675._0xec57cfb3(new byte[22] { 16, 31, 14, 24, 31, 22, 107, 12, 46, 37, 46, 57, 42, 39, 107, 46, 57, 57, 36, 57, 113, 107 }, 75) + e.Message);
#endif
            }

            _0xd70b44ab();
        }
    }

    private bool _0x5e353014 = false;
    private JObject BuildRandomPayload(params string[] _0x5f16484e)
    {
        JObject _0x3ee71a9c = new JObject();
        foreach (var _0xcc3f164a in _0x5f16484e)
        {
            string _0x53335055 = _0x09f6dba9();
            {
#if B_LOGS
                Debug.Log($"[Test] Crypto key={_0x53335055} val={_0xcc3f164a}");
#endif
            }

            _0x3ee71a9c.Add(_0x53335055, _0xcc3f164a == null ? "" : _0xcc3f164a);
        }

        return _0x3ee71a9c;
    }

    private bool _0x6e21b3e4 = false;
    private string _0x06a51b19 = "";
    private string _0x92908f30 = "";
    private bool _0xced80b9c = false;
    private string _0xdf77e343 = "";
    private string _0xd8a1486e()
    {
        string _0x7443668f = _0x39877830();
        if (string.IsNullOrEmpty(_0x7443668f))
            return _0x4485c675._0xec57cfb3(new byte[7] { 209, 200, 206, 195, 135, 151, 156 }, 167);
        string _0x68924913 = _0x7443668f.Replace(_0x4485c675._0xec57cfb3(new byte[1] { 206 }, 146), _0x4485c675._0xec57cfb3(new byte[2] { 213, 213 }, 137)).Replace(_0x4485c675._0xec57cfb3(new byte[1] { 191 }, 152), _0x4485c675._0xec57cfb3(new byte[2] { 141, 246 }, 209));
        var _0xc60a0d21 = Regex.Match(_0x7443668f, _0x4485c675._0xec57cfb3(new byte[12] { 88, 115, 105, 116, 118, 126, 52, 51, 71, 127, 48, 50 }, 27));
        string _0xa9e2749d = _0xc60a0d21.Success ? _0xc60a0d21.Groups[1].Value : _0x4485c675._0xec57cfb3(new byte[3] { 155, 152, 154 }, 170);
        return _0x4485c675._0xec57cfb3(new byte[12] { 116, 58, 41, 50, 63, 40, 53, 51, 50, 116, 117, 39 }, 92) + _0x4485c675._0xec57cfb3(new byte[8] { 178, 165, 182, 228, 177, 165, 249, 227 }, 196) + _0x68924913 + _0x4485c675._0xec57cfb3(new byte[2] { 119, 107 }, 80) + _0x4485c675._0xec57cfb3(new byte[30] { 17, 6, 21, 71, 23, 21, 8, 19, 8, 90, 41, 6, 17, 14, 0, 6, 19, 8, 21, 73, 23, 21, 8, 19, 8, 19, 30, 23, 2, 92 }, 103) + _0x4485c675._0xec57cfb3(new byte[121] { 97, 114, 105, 100, 115, 110, 104, 105, 39, 99, 98, 97, 47, 104, 101, 109, 43, 108, 98, 126, 43, 113, 102, 107, 46, 124, 115, 117, 126, 124, 72, 101, 109, 98, 100, 115, 41, 99, 98, 97, 110, 105, 98, 87, 117, 104, 119, 98, 117, 115, 126, 47, 104, 101, 109, 43, 108, 98, 126, 43, 124, 96, 98, 115, 61, 97, 114, 105, 100, 115, 110, 104, 105, 47, 46, 124, 117, 98, 115, 114, 117, 105, 39, 113, 102, 107, 60, 122, 43, 100, 104, 105, 97, 110, 96, 114, 117, 102, 101, 107, 98, 61, 115, 117, 114, 98, 122, 46, 60, 122, 100, 102, 115, 100, 111, 47, 98, 46, 124, 122, 122 }, 7) + _0x4485c675._0xec57cfb3(new byte[26] { 183, 182, 181, 251, 163, 161, 188, 167, 188, 255, 244, 166, 160, 182, 161, 146, 180, 182, 189, 167, 244, 255, 166, 178, 250, 232 }, 211) + _0x4485c675._0xec57cfb3(new byte[52] { 127, 126, 125, 51, 107, 105, 116, 111, 116, 55, 60, 122, 107, 107, 77, 126, 105, 104, 114, 116, 117, 60, 55, 110, 122, 53, 105, 126, 107, 119, 122, 120, 126, 51, 52, 69, 86, 116, 97, 114, 119, 119, 122, 71, 52, 52, 55, 60, 60, 50, 50, 32 }, 27) + _0x4485c675._0xec57cfb3(new byte[37] { 182, 183, 180, 250, 162, 160, 189, 166, 189, 254, 245, 162, 190, 179, 166, 180, 189, 160, 191, 245, 254, 245, 158, 187, 188, 167, 170, 242, 179, 160, 191, 164, 234, 190, 245, 251, 233 }, 210) + _0x4485c675._0xec57cfb3(new byte[34] { 73, 72, 75, 5, 93, 95, 66, 89, 66, 1, 10, 91, 72, 67, 73, 66, 95, 10, 1, 10, 106, 66, 66, 74, 65, 72, 13, 100, 67, 78, 3, 10, 4, 22 }, 45) + _0x4485c675._0xec57cfb3(new byte[30] { 209, 208, 211, 157, 197, 199, 218, 193, 218, 153, 146, 216, 212, 205, 225, 218, 192, 214, 221, 229, 218, 220, 219, 193, 198, 146, 153, 128, 156, 142 }, 181) + _0x4485c675._0xec57cfb3(new byte[48] { 125, 123, 112, 114, 127, 104, 123, 41, 124, 104, 109, 52, 114, 107, 123, 104, 103, 109, 122, 51, 82, 114, 107, 123, 104, 103, 109, 51, 46, 74, 97, 123, 102, 100, 96, 124, 100, 46, 37, 127, 108, 123, 122, 96, 102, 103, 51, 46 }, 9) + _0xa9e2749d + _0x4485c675._0xec57cfb3(new byte[35] { 71, 29, 76, 27, 2, 18, 1, 14, 4, 90, 71, 39, 15, 15, 7, 12, 5, 64, 35, 8, 18, 15, 13, 5, 71, 76, 22, 5, 18, 19, 9, 15, 14, 90, 71 }, 96) + _0xa9e2749d + _0x4485c675._0xec57cfb3(new byte[238] { 9, 83, 2, 85, 76, 92, 79, 64, 74, 20, 9, 96, 65, 90, 19, 111, 17, 108, 92, 79, 64, 74, 9, 2, 88, 75, 92, 93, 71, 65, 64, 20, 9, 28, 26, 9, 83, 115, 2, 67, 65, 76, 71, 66, 75, 20, 90, 92, 91, 75, 2, 94, 66, 79, 90, 72, 65, 92, 67, 20, 9, 111, 64, 74, 92, 65, 71, 74, 9, 2, 73, 75, 90, 102, 71, 73, 70, 107, 64, 90, 92, 65, 94, 87, 120, 79, 66, 91, 75, 93, 20, 72, 91, 64, 77, 90, 71, 65, 64, 6, 7, 85, 92, 75, 90, 91, 92, 64, 14, 126, 92, 65, 67, 71, 93, 75, 0, 92, 75, 93, 65, 66, 88, 75, 6, 85, 79, 92, 77, 70, 71, 90, 75, 77, 90, 91, 92, 75, 20, 9, 79, 92, 67, 9, 2, 76, 71, 90, 64, 75, 93, 93, 20, 9, 24, 26, 9, 2, 67, 65, 76, 71, 66, 75, 20, 90, 92, 91, 75, 2, 67, 65, 74, 75, 66, 20, 9, 9, 2, 94, 66, 79, 90, 72, 65, 92, 67, 20, 9, 111, 64, 74, 92, 65, 71, 74, 9, 2, 94, 66, 79, 90, 72, 65, 92, 67, 120, 75, 92, 93, 71, 65, 64, 20, 9, 31, 26, 0, 30, 0, 30, 9, 2, 91, 79, 104, 91, 66, 66, 120, 75, 92, 93, 71, 65, 64, 20, 9 }, 46) + _0xa9e2749d + _0x4485c675._0xec57cfb3(new byte[117] { 243, 237, 243, 237, 243, 237, 250, 160, 244, 230, 160, 160, 230, 146, 191, 183, 184, 190, 169, 243, 185, 184, 187, 180, 179, 184, 141, 175, 178, 173, 184, 175, 169, 164, 245, 173, 175, 178, 169, 178, 241, 250, 168, 174, 184, 175, 156, 186, 184, 179, 169, 153, 188, 169, 188, 250, 241, 166, 186, 184, 169, 231, 187, 168, 179, 190, 169, 180, 178, 179, 245, 244, 166, 175, 184, 169, 168, 175, 179, 253, 168, 188, 185, 230, 160, 241, 190, 178, 179, 187, 180, 186, 168, 175, 188, 191, 177, 184, 231, 169, 175, 168, 184, 160, 244, 230, 160, 190, 188, 169, 190, 181, 245, 184, 244, 166, 160 }, 221) + _0x4485c675._0xec57cfb3(new byte[5] { 248, 172, 173, 172, 190 }, 133);
    }

    private int _0x8014450e = -1;
    private void _0x3465a680(string _0x8acedc4a)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x4485c675._0xec57cfb3(new byte[34] { 170, 165, 148, 130, 133, 172, 209, 183, 148, 133, 146, 153, 209, 180, 137, 133, 131, 144, 209, 161, 132, 130, 153, 209, 181, 144, 133, 144, 209, 163, 144, 134, 203, 209 }, 241) + _0x8acedc4a);
#endif
            }
        }

        var _0x6333d599 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x8acedc4a);
        StartCoroutine(_0xacbb65f0(_0x6333d599));
    }

    internal void _0x5db0c058()
    {
        Rect _0x50c6f135 = Screen.safeArea;
        Vector2 _0x40d16127 = new Vector2(Screen.width, Screen.height);
        if (_0x50c6f135 == lastSafe && _0x40d16127 == lastSize)
            return;
        // Apply manual padding
        _0x50c6f135.xMin += _0xb0a9c2b2;
        _0x50c6f135.xMax -= _0x898f3f49;
        _0x50c6f135.yMin += _0x267c051a;
        _0x50c6f135.yMax -= _0x57312e44;
        // Convert Unity safe area -> native WebView frame
        Rect _0xb73033af = new Rect(_0x50c6f135.x, _0x40d16127.y - _0x50c6f135.y - _0x50c6f135.height, // Y flip for native coordinate system
 _0x50c6f135.width, _0x50c6f135.height);
        _0x67f7401d.Frame = _0xb73033af;
        lastSafe = Screen.safeArea;
        lastSize = _0x40d16127;
    }

    private string _0x25abd888 = "";
    private static string ReadPushField(Dictionary<string, object> _0xd1ebaac1, string _0xd22740cf)
    {
        if (_0xd1ebaac1 == null || string.IsNullOrEmpty(_0xd22740cf))
            return string.Empty;
        if (_0xd1ebaac1.TryGetValue(_0x4485c675._0xec57cfb3(new byte[16] { 222, 223, 196, 217, 214, 217, 211, 209, 196, 217, 223, 222, 244, 209, 196, 209 }, 176), out var raw))
        {
            try
            {
                var _0x08c21d1a = JsonConvert.DeserializeObject<Dictionary<string, object>>(raw?.ToString());
                if (_0x08c21d1a != null && _0x08c21d1a.TryGetValue(_0xd22740cf, out var nestedVal))
                {
                    var _0x98d0c78f = nestedVal?.ToString();
                    if (!string.IsNullOrEmpty(_0x98d0c78f))
                        return _0x98d0c78f;
                }
            }
            catch
            {
            }
        }

        if (_0xd1ebaac1.TryGetValue(_0xd22740cf, out var flatVal))
            return flatVal?.ToString() ?? string.Empty;
        return string.Empty;
    }

    private bool _0x6a23fdbe = false;
    private Canvas _0x536fa6dd()
    {
        if (_0x05ddd695 != null)
            return _0x05ddd695;
        var _0x6dff6ddb = gameObject.GetComponentInChildren<Canvas>();
        if (_0x6dff6ddb == null)
        {
            var _0x0701e831 = new GameObject(_0x4485c675._0xec57cfb3(new byte[6] { 102, 68, 75, 83, 68, 86 }, 37), typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster));
            _0x6dff6ddb = _0x0701e831.GetComponent<Canvas>();
            _0x6dff6ddb.transform.SetParent(transform, false);
            _0x6dff6ddb.renderMode = RenderMode.ScreenSpaceOverlay;
        }

        _0x05ddd695 = _0x6dff6ddb;
        return _0x05ddd695;
    }

    private IEnumerator _0xacbb65f0(Dictionary<string, object> _0x3eda31f3)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x4485c675._0xec57cfb3(new byte[30] { 26, 21, 36, 50, 53, 28, 97, 7, 36, 53, 34, 41, 97, 4, 57, 53, 51, 32, 97, 17, 52, 50, 41, 97, 5, 32, 53, 32, 123, 97 }, 65) + string.Join(_0x4485c675._0xec57cfb3(new byte[1] { 209 }, 216), _0x3eda31f3));
#endif
            }
        }

        string _0x9540bd67 = "";
        // Primary source: nested JSON under "notificationData"
        if (_0x3eda31f3 != null && _0x3eda31f3.TryGetValue(_0x4485c675._0xec57cfb3(new byte[16] { 250, 251, 224, 253, 242, 253, 247, 245, 224, 253, 251, 250, 208, 245, 224, 245 }, 148), out var raw))
        {
            try
            {
                var _0xde42efa7 = raw?.ToString();
                var _0x4757564c = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0xde42efa7);
                if (_0x4757564c != null && _0x4757564c.TryGetValue(_0x4485c675._0xec57cfb3(new byte[6] { 16, 6, 13, 7, 10, 7 }, 99), out var val))
                {
                    _0x9540bd67 = val?.ToString();
                }
            }
            catch (Exception e)
            {
#if B_LOGS
                Debug.LogError(_0x4485c675._0xec57cfb3(new byte[30] { 105, 102, 87, 65, 70, 18, 98, 71, 65, 90, 111, 18, 120, 97, 125, 124, 18, 66, 83, 64, 65, 87, 18, 87, 64, 64, 93, 64, 8, 18 }, 50) + e);
#endif
            }
        }

        // Fallback: flat structure
        if (string.IsNullOrEmpty(_0x9540bd67) && _0x3eda31f3 != null && _0x3eda31f3.TryGetValue(_0x4485c675._0xec57cfb3(new byte[6] { 56, 46, 37, 47, 34, 47 }, 75), out var lab))
        {
            _0x9540bd67 = lab?.ToString();
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x4485c675._0xec57cfb3(new byte[38] { 121, 118, 71, 81, 86, 2, 114, 87, 81, 74, 127, 2, 100, 71, 86, 65, 74, 71, 70, 2, 81, 71, 76, 70, 75, 70, 2, 68, 80, 77, 79, 2, 72, 81, 77, 76, 24, 2 }, 34) + _0x9540bd67);
            }
#endif
        }

        if (string.IsNullOrEmpty(_0x9540bd67))
            yield break;
        {
#if B_LOGS
            {
                Debug.Log(_0x4485c675._0xec57cfb3(new byte[38] { 188, 179, 130, 148, 147, 199, 183, 146, 148, 143, 186, 199, 176, 134, 142, 147, 199, 147, 136, 199, 136, 151, 130, 137, 199, 144, 142, 147, 143, 199, 148, 130, 137, 131, 142, 131, 221, 199 }, 231) + _0x9540bd67);
            }
#endif
        }

        _0xf57aa3dc = _0x9540bd67;
        yield return new WaitUntil(() => _0x0fb05cc6);
        var _0x554b731d = _0x42d9cbd0(2, 100);
        yield return new WaitUntil(() => _0x554b731d.IsCompleted);
        string _0xda32b286 = _0x554b731d.Result;
        if (!string.IsNullOrEmpty(_0xda32b286))
        {
            string _0x0e72b6ee = _0xe9cb8cac(_0xda32b286, _0x9540bd67);
            {
#if B_LOGS
                Debug.Log(_0x4485c675._0xec57cfb3(new byte[33] { 176, 191, 142, 152, 159, 203, 187, 158, 152, 131, 182, 203, 185, 142, 135, 132, 138, 143, 203, 188, 142, 137, 189, 130, 142, 156, 203, 156, 130, 159, 131, 209, 203 }, 235) + _0x0e72b6ee);
#endif
            }

            _0x67f7401d.Load(_0x0e72b6ee);
        }
    }

    private UniWebViewPopup _0x98931c38()
    {
        for (int _0x37e82162 = _0xa3ab5d87.Count - 1; _0x37e82162 >= 0; _0x37e82162--)
        {
            var _0xc361326e = _0xa3ab5d87[_0x37e82162];
            if (_0xc361326e != null && _0xc361326e.IsAlive)
                return _0xc361326e;
            _0xa3ab5d87.RemoveAt(_0x37e82162);
        }

        return null;
    }

    private string _0xf586a811 = "";
    private string _0x016cde34 = "";
    // NATIVE WEB VIEW METHODS
    private UniWebView _0x67f7401d = null;
    private Task _0x9b589a98(IEnumerator _0x4f60fa12)
    {
        var _0x2755cf8a = new TaskCompletionSource<bool>();
        StartCoroutine(_0xd7655a6e(_0x4f60fa12, _0x2755cf8a));
        return _0x2755cf8a.Task;
    }

    private bool _0x968d303e = false;
    private string _0x9a509e9a = "";
    private bool OpenUrlExternally(string _0x8b3ca21a)
    {
        return _0x2d8cf389(_0x8b3ca21a);
    }

    private string GetFailingUrl(UniWebViewNativeResultPayload _0x48fefb12)
    {
        if (_0x48fefb12 == null || _0x48fefb12.Extra == null)
            return null;
        object _0x187d3efb;
        if (!_0x48fefb12.Extra.TryGetValue(UniWebViewNativeResultPayload.ExtraFailingURLKey, out _0x187d3efb))
            return null;
        return _0x187d3efb as string;
    }

    private void _0xadeba40a()
    {
        _0xb70eb514 = true;
        if (_0x67f7401d != null)
            _0x67f7401d.SetUserAgent(_0x39877830());
    }

    private async Task _0x6cec033f()
    {
        if (await _0xed2b14b6())
            return;
        if (await _0x3b9d551f())
            return;
        if (await _0xdaf23018())
            return;
        _0x3a372c7d();
        await _0x9b589a98(_0x22f6d072());
        _0xf586a811 = await _0x84a6ae53();
        await _0x66728abf();
    }

    private void OnApplicationPause(bool _0x1c1443fa)
    {
        isApplicationPause = _0x1c1443fa;
    }

    private string _0x0a656e90 = "";
    private void _0x1f2f4dc7()
    {
        if (_0x6bf9a12b != null)
            return;
        var _0xad77ef52 = _0x536fa6dd();
        _0x6bf9a12b = new GameObject(_0x4485c675._0xec57cfb3(new byte[14] { 50, 0, 7, 51, 12, 0, 18, 54, 21, 12, 11, 11, 0, 23 }, 101), typeof(RectTransform), typeof(Text));
        _0x4f33f644 = _0x6bf9a12b.GetComponent<RectTransform>();
        _0x4f33f644.SetParent(_0xad77ef52.transform, false);
        _0x4f33f644.anchorMin = new Vector2(0.5f, 0.5f);
        _0x4f33f644.anchorMax = new Vector2(0.5f, 0.5f);
        _0x4f33f644.pivot = new Vector2(0.5f, 0.5f);
        _0x4f33f644.sizeDelta = new Vector2(600f, 600f);
        _0x4f33f644.anchoredPosition = Vector2.zero;
        _0xdeb4697a = _0x6bf9a12b.GetComponent<Text>();
        _0xdeb4697a.text = _0x4485c675._0xec57cfb3(new byte[1] { 180 }, 155);
        _0xdeb4697a.font = Resources.GetBuiltinResource<Font>(_0x4485c675._0xec57cfb3(new byte[17] { 104, 65, 67, 69, 71, 93, 118, 81, 74, 80, 77, 73, 65, 10, 80, 80, 66 }, 36));
        _0xdeb4697a.fontSize = 200;
        _0xdeb4697a.alignment = TextAnchor.MiddleCenter;
        _0xdeb4697a.color = Color.white;
        _0xdeb4697a.raycastTarget = false;
        _0x6bf9a12b.SetActive(false);
    }

    internal bool ContainsIgnoreCase(string _0x1959afd9, string _0xa7246474)
    {
        if (string.IsNullOrEmpty(_0x1959afd9) || string.IsNullOrEmpty(_0xa7246474))
            return false;
        return _0x1959afd9.IndexOf(_0xa7246474, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    internal void Update()
    {
        if (_0x67f7401d == null)
            return;
        if (_0x277ea63e())
            _0xf1e48458();
        if (!isApplicationFocus || isApplicationPause)
            return;
        _0x5db0c058();
        if (_0xced80b9c && _0x4f33f644 != null)
            _0x4f33f644.Rotate(0f, 0f, -360f * Time.deltaTime);
    }

    private IEnumerator _0xfd46380f(string _0xdaa68e98)
    {
        if (_0x67f7401d != null && _0x0fb05cc6)
            yield break;
        _0x67f7401d = gameObject.AddComponent<UniWebView>();
        _0xc9648540(_0x67f7401d);
        _0x28795cdd(_0x67f7401d);
        _0x67f7401d.BackgroundColor = Color.clear;
        var _0xa2cd1625 = SceneManager.GetActiveScene().GetRootGameObjects();
        if (Camera.main != null)
        {
            Camera.main.clearFlags = CameraClearFlags.SolidColor;
            Camera.main.backgroundColor = Color.clear;
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForEndOfFrame();
        _0x5db0c058();
        yield return new WaitForEndOfFrame();
        _0x0fb05cc6 = true;
        _0x1f2f4dc7();
        _0xfed56dd0(true);
        _0x968d303e = false;
        _0xb70eb514 = false;
        _0xa3ab5d87.Clear();
        _0x8014450e = -1;
        firstLoadShown = false;
        _0x6e21b3e4 = false;
        _0x5e353014 = false;
        _0x67f7401d.SetUserAgent("");
        _0x8772d573 = Time.realtimeSinceStartup;
        _0x67f7401d.Stop();
        _0x67f7401d.Load(_0xdaa68e98);
        _0x67f7401d.Show(false, UniWebViewTransitionEdge.None, 0f, null);
        WLog(_0x4485c675._0xec57cfb3(new byte[25] { 100, 72, 64, 71, 9, 126, 76, 75, 127, 64, 76, 94, 9, 96, 71, 64, 93, 64, 72, 69, 9, 122, 65, 70, 94 }, 41));
    }

    private bool _0xb70eb514 = false;
    internal bool IsGoogleAuthFlowUrl(string _0xfd42d8de)
    {
        if (string.IsNullOrEmpty(_0xfd42d8de))
            return false;
        return _0xfd42d8de.IndexOf(_0x4485c675._0xec57cfb3(new byte[19] { 123, 121, 121, 117, 111, 116, 110, 105, 52, 125, 117, 117, 125, 118, 127, 52, 121, 117, 119 }, 26), StringComparison.OrdinalIgnoreCase) >= 0 || _0xfd42d8de.IndexOf(_0x4485c675._0xec57cfb3(new byte[16] { 143, 141, 141, 129, 155, 128, 154, 157, 192, 137, 129, 129, 137, 130, 139, 192 }, 238), StringComparison.OrdinalIgnoreCase) >= 0 || _0xfd42d8de.IndexOf(_0x4485c675._0xec57cfb3(new byte[21] { 104, 96, 96, 104, 99, 106, 122, 124, 106, 125, 108, 96, 97, 123, 106, 97, 123, 33, 108, 96, 98 }, 15), StringComparison.OrdinalIgnoreCase) >= 0 || _0xfd42d8de.IndexOf(_0x4485c675._0xec57cfb3(new byte[11] { 185, 173, 170, 191, 170, 183, 189, 240, 189, 177, 179 }, 222), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    internal Rect lastSafe = Rect.zero;
    private string _0x9169bf50 = "";
    private string _0x39877830()
    {
        if (string.IsNullOrEmpty(_0x9169bf50) && _0x67f7401d != null)
            _0x9169bf50 = _0x67f7401d.GetUserAgent();
        if (string.IsNullOrEmpty(_0x9169bf50))
            return string.Empty;
        string _0x61ffd056 = Regex.Replace(_0x9169bf50, _0x4485c675._0xec57cfb3(new byte[11] { 253, 210, 139, 154, 253, 210, 139, 214, 215, 253, 195 }, 161), string.Empty);
        _0x61ffd056 = Regex.Replace(_0x61ffd056, _0x4485c675._0xec57cfb3(new byte[15] { 177, 158, 198, 175, 152, 132, 129, 137, 194, 182, 179, 214, 196, 176, 198 }, 237), string.Empty);
        _0x61ffd056 = Regex.Replace(_0x61ffd056, _0x4485c675._0xec57cfb3(new byte[15] { 162, 145, 134, 135, 157, 155, 154, 219, 192, 168, 218, 196, 168, 135, 222 }, 244), string.Empty);
        return Regex.Replace(_0x61ffd056, _0x4485c675._0xec57cfb3(new byte[6] { 53, 26, 18, 91, 69, 20 }, 105), _0x4485c675._0xec57cfb3(new byte[1] { 7 }, 39)).Trim();
    }

    internal bool _0xd202bdb1(string _0x6cd145d6)
    {
        return _0x6cd145d6.StartsWith(_0x4485c675._0xec57cfb3(new byte[9] { 241, 253, 238, 247, 249, 232, 166, 179, 179 }, 156), StringComparison.OrdinalIgnoreCase) || _0x6cd145d6.StartsWith(_0x4485c675._0xec57cfb3(new byte[24] { 114, 110, 110, 106, 105, 32, 53, 53, 106, 118, 123, 99, 52, 125, 117, 117, 125, 118, 127, 52, 121, 117, 119, 53 }, 26), StringComparison.OrdinalIgnoreCase) || _0x6cd145d6.StartsWith(_0x4485c675._0xec57cfb3(new byte[23] { 250, 230, 230, 226, 168, 189, 189, 226, 254, 243, 235, 188, 245, 253, 253, 245, 254, 247, 188, 241, 253, 255, 189 }, 146), StringComparison.OrdinalIgnoreCase);
    }

    // WEB VIEW LOGIC END
    internal void _0x0ed8d199()
    {
        // Ensure channel exists (safe to call multiple times)
        var _0x49fdf84b = new AndroidNotificationChannel
        {
            Id = _0x4485c675._0xec57cfb3(new byte[15] { 242, 243, 240, 247, 227, 250, 226, 201, 245, 254, 247, 248, 248, 243, 250 }, 150),
            Name = _0x4485c675._0xec57cfb3(new byte[15] { 156, 189, 190, 185, 173, 180, 172, 248, 155, 176, 185, 182, 182, 189, 180 }, 216),
            Importance = Importance.High,
            Description = _0x4485c675._0xec57cfb3(new byte[21] { 181, 151, 156, 151, 128, 147, 158, 210, 156, 157, 134, 155, 148, 155, 145, 147, 134, 155, 157, 156, 129 }, 242)
        };
        AndroidNotificationCenter.RegisterNotificationChannel(_0x49fdf84b);
        // Build notification
        var _0x1819beb1 = new AndroidNotification
        {
            Title = _0x2180c59b[UnityEngine.Random.Range(0, _0x2180c59b.Length)],
            Text = _0x4485c675._0xec57cfb3(new byte[21] { 159, 172, 187, 254, 167, 177, 171, 254, 173, 171, 172, 187, 254, 170, 177, 254, 187, 166, 183, 170, 225 }, 222),
            FireTime = System.DateTime.Now
        };
        // Send immediately
        AndroidNotificationCenter.SendNotification(_0x1819beb1, _0x4485c675._0xec57cfb3(new byte[15] { 8, 9, 10, 13, 25, 0, 24, 51, 15, 4, 13, 2, 2, 9, 0 }, 108));
    }

    private string _0xdb561a24()
    {
        try
        {
            using (var _0x4c76a0e8 = new AndroidJavaClass(_0x4485c675._0xec57cfb3(new byte[30] { 65, 77, 79, 12, 87, 76, 75, 86, 91, 17, 70, 12, 82, 78, 67, 91, 71, 80, 12, 119, 76, 75, 86, 91, 114, 78, 67, 91, 71, 80 }, 34)))
            {
                var _0x167e521b = _0x4c76a0e8.GetStatic<AndroidJavaObject>(_0x4485c675._0xec57cfb3(new byte[15] { 252, 234, 237, 237, 250, 241, 235, 222, 252, 235, 246, 233, 246, 235, 230 }, 159));
                var _0x62afae00 = _0x167e521b.Call<AndroidJavaObject>(_0x4485c675._0xec57cfb3(new byte[21] { 176, 178, 163, 150, 167, 167, 187, 190, 180, 182, 163, 190, 184, 185, 148, 184, 185, 163, 178, 175, 163 }, 215));
                using (var _0x75c70d02 = new AndroidJavaClass(_0x4485c675._0xec57cfb3(new byte[26] { 18, 29, 23, 1, 28, 26, 23, 93, 4, 22, 17, 24, 26, 7, 93, 36, 22, 17, 32, 22, 7, 7, 26, 29, 20, 0 }, 115)))
                {
                    return _0x75c70d02.CallStatic<string>(_0x4485c675._0xec57cfb3(new byte[19] { 246, 244, 229, 213, 244, 247, 240, 228, 253, 229, 196, 226, 244, 227, 208, 246, 244, 255, 229 }, 145), _0x62afae00);
                }
            }
        }
        catch
        {
            return "";
        }
    }

    private bool _0xb58108b4()
    {
        if (_0xd83c2557())
            return true;
        if (_0x67f7401d != null && _0x67f7401d.CanGoBack)
        {
            WLog(_0x4485c675._0xec57cfb3(new byte[36] { 10, 35, 48, 38, 53, 35, 48, 39, 98, 32, 35, 33, 41, 98, 111, 124, 98, 47, 35, 43, 44, 98, 21, 39, 32, 20, 43, 39, 53, 98, 5, 45, 0, 35, 33, 41 }, 66));
            _0x67f7401d.GoBack();
            return true;
        }

        return false;
    }

    private bool _0x277ea63e()
    {
        var _0xff70fdb2 = Keyboard.current;
        return _0xff70fdb2 != null && _0xff70fdb2.escapeKey.wasPressedThisFrame;
    }

    private bool _0xbefc27cf(int _0x483d87fe, string _0xc000c4ee, string _0x6c4c9f78)
    {
        if (string.IsNullOrEmpty(_0x6c4c9f78))
            return false;
        if (!IsHttpUrl(_0x6c4c9f78))
            return true;
        if (string.IsNullOrEmpty(_0xc000c4ee))
            return false;
        return _0xc000c4ee.IndexOf(_0x4485c675._0xec57cfb3(new byte[20] { 82, 69, 69, 72, 84, 88, 89, 89, 82, 84, 67, 94, 88, 89, 72, 69, 82, 68, 82, 67 }, 23), StringComparison.OrdinalIgnoreCase) >= 0 || _0xc000c4ee.IndexOf(_0x4485c675._0xec57cfb3(new byte[22] { 189, 170, 170, 167, 187, 183, 182, 182, 189, 187, 172, 177, 183, 182, 167, 170, 189, 190, 173, 171, 189, 188 }, 248), StringComparison.OrdinalIgnoreCase) >= 0 || _0xc000c4ee.IndexOf(_0x4485c675._0xec57cfb3(new byte[21] { 214, 193, 193, 204, 208, 220, 221, 221, 214, 208, 199, 218, 220, 221, 204, 208, 223, 220, 192, 214, 215 }, 147), StringComparison.OrdinalIgnoreCase) >= 0 || _0xc000c4ee.IndexOf(_0x4485c675._0xec57cfb3(new byte[22] { 67, 84, 84, 89, 83, 72, 77, 72, 73, 81, 72, 89, 83, 84, 74, 89, 85, 69, 78, 67, 75, 67 }, 6), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private IEnumerator _0xd51bb6c4(float _0xc53cdec4)
    {
        yield return new WaitForSeconds(_0xc53cdec4);
        if (!_0x2148afe9)
        {
            _0x2148afe9 = true;
            {
#if B_LOGS
                {
                    Debug.Log($"[Test] Refferer timeout apply: {_0x06a51b19}");
                }
#endif
            }
        }
    }

    internal bool IsAboutBlank(string _0x9aa482fc)
    {
        if (string.IsNullOrEmpty(_0x9aa482fc))
            return false;
        return _0x9aa482fc.StartsWith(_0x4485c675._0xec57cfb3(new byte[11] { 36, 39, 42, 48, 49, 127, 39, 41, 36, 43, 46 }, 69), StringComparison.OrdinalIgnoreCase);
    }

    private void _0xc9648540(UniWebView _0x955974d3)
    {
        _0x955974d3.BackgroundColor = Color.clear;
        _0x955974d3.SetSupportMultipleWindows(true, true);
        _0x955974d3.SetBackButtonEnabled(false);
        _0x67f7401d.SetUserAgent(_0x39877830());
    }

    private int _0x57312e44 = 5, _0x267c051a = 5, _0xb0a9c2b2 = 5, _0x898f3f49 = 5;
    private async Task<bool> _0x8d28ed97(int _0x88028bef = 5, int _0xa7056ea7 = 500)
    {
        List<EntityData> _0xfafe38c4 = new List<EntityData>();
        int _0x4fcce521 = 0;
        do
        {
            try
            {
                _0xfafe38c4 = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x4485c675._0xec57cfb3(new byte[8] { 111, 115, 126, 102, 122, 109, 86, 123 }, 31), _0x26f5e8cd, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0x4485c675._0xec57cfb3(new byte[9] { 143, 149, 182, 148, 143, 144, 135, 133, 159 }, 230) }), new QueryOptions())).ToList();
            }
            catch (Exception e)
            {
                {
#if B_LOGS
                    {
                        Debug.Log(_0x4485c675._0xec57cfb3(new byte[32] { 238, 225, 208, 198, 193, 232, 149, 196, 192, 208, 199, 204, 244, 198, 204, 219, 214, 231, 208, 198, 192, 217, 193, 198, 149, 208, 199, 199, 218, 199, 143, 149 }, 181) + e.Message);
                    }
#endif
                }
            }

            await Task.Delay(_0xa7056ea7);
        }
        while (_0xfafe38c4.Count == 0 && _0x4fcce521++ < _0x88028bef);
        {
#if B_LOGS
            {
                Debug.Log(_0x4485c675._0xec57cfb3(new byte[32] { 99, 108, 93, 75, 76, 101, 24, 113, 75, 104, 74, 81, 78, 89, 91, 65, 24, 105, 77, 93, 74, 65, 24, 74, 93, 75, 77, 84, 76, 75, 2, 24 }, 56) + JsonConvert.SerializeObject(_0xfafe38c4, Formatting.Indented));
            }
#endif
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x4485c675._0xec57cfb3(new byte[38] { 81, 94, 111, 121, 126, 87, 42, 67, 121, 90, 120, 99, 124, 107, 105, 115, 42, 91, 127, 111, 120, 115, 42, 120, 111, 121, 127, 102, 126, 121, 42, 105, 101, 127, 100, 126, 48, 42 }, 10) + _0xfafe38c4.Count);
            }
#endif
        }

        bool _0x33b4d40f = true;
        if (_0xfafe38c4.Count == 0)
        {
            _0x33b4d40f = false;
        }
        else
        {
            _0x33b4d40f = _0xfafe38c4.Any(_0x1e466bf1 => _0x1e466bf1.Data.Any(IsPrivacyItemTrue));
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x4485c675._0xec57cfb3(new byte[25] { 214, 217, 232, 254, 249, 208, 173, 196, 254, 221, 255, 228, 251, 236, 238, 244, 173, 255, 232, 254, 248, 225, 249, 183, 173 }, 141) + _0x33b4d40f);
            }
#endif
        }

        return _0x33b4d40f;
    }

    private readonly List<UniWebViewPopup> _0xa3ab5d87 = new List<UniWebViewPopup>();
    private string _0xfbee2ef9 { get; set; }

    private void _0xf1e48458()
    {
        WLog(_0x4485c675._0xec57cfb3(new byte[21] { 165, 140, 159, 137, 154, 140, 159, 136, 205, 143, 140, 142, 134, 205, 157, 159, 136, 158, 158, 136, 137 }, 237));
        if (Time.frameCount == _0x8014450e)
            return;
        _0x8014450e = Time.frameCount;
        if (_0xb58108b4())
            return;
        _0xe9b50ac1();
    }

    // WEB VIEW LOGIC
    public bool _0x0fb05cc6 { get; set; }

    private Action _0xb08278de;
    private bool _0x0d60a9fa = false;
    private void _0xfed56dd0(bool _0xec6bdeb0)
    {
        _0x1f2f4dc7();
        _0x6bf9a12b.SetActive(_0xec6bdeb0);
        _0xced80b9c = _0xec6bdeb0;
        if (_0xec6bdeb0)
        {
            _0x6bf9a12b.transform.SetAsLastSibling();
            if (_0x4f33f644 != null)
                _0x4f33f644.localRotation = Quaternion.identity;
        }
    }

    private void _0x39fb3dd5()
    {
        if (_0x67f7401d == null)
            return;
        if (_0xb70eb514)
            _0x67f7401d.SetUserAgent(_0x39877830());
        else
            _0x67f7401d.SetUserAgent("");
    }

    /* ============================= */
    /* ENCRYPT / DECRYPT             */
    /* ============================= */
    private string _0x2ec5331b(string _0x9409255d, string _0x795bc6b8)
    {
        try
        {
            using var _0x8894dfa3 = Aes.Create();
            _0x8894dfa3.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0x795bc6b8));
            _0x8894dfa3.GenerateIV();
            using var _0x687ed60e = new MemoryStream();
            _0x687ed60e.Write(_0x8894dfa3.IV, 0, _0x8894dfa3.IV.Length);
            using (var _0x3ffec12f = new CryptoStream(_0x687ed60e, _0x8894dfa3.CreateEncryptor(), CryptoStreamMode.Write))
            {
                var _0xb147e335 = Encoding.UTF8.GetBytes(_0x9409255d);
                _0x3ffec12f.Write(_0xb147e335, 0, _0xb147e335.Length);
                _0x3ffec12f.FlushFinalBlock();
            }

            return Convert.ToBase64String(_0x687ed60e.ToArray());
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private void StopCurrentFailedLoad(UniWebView _0x63e03766)
    {
        _0xfed56dd0(false);
        if (_0x63e03766 == null)
            return;
        _0x63e03766.Stop();
        if (_0x63e03766.CanGoBack)
            _0x63e03766.GoBack();
    }

    internal bool isDestroyedForce = false;
    private async Task<bool> _0xdaf23018()
    {
        {
#if B_LOGS
            Debug.Log(_0x4485c675._0xec57cfb3(new byte[29] { 42, 37, 20, 2, 5, 44, 81, 56, 2, 33, 3, 24, 7, 16, 18, 8, 48, 31, 21, 34, 16, 7, 20, 21, 50, 25, 20, 18, 26 }, 113));
#endif
        }

        string _0xa0b1b60f = "";
        for (int _0xefc5a2b1 = 0; _0xefc5a2b1 < 2; _0xefc5a2b1++)
        {
            if (await _0x8d28ed97(1, 100))
            {
                await _0x03c3a238(_0x4485c675._0xec57cfb3(new byte[7] { 66, 76, 79, 67, 75, 69, 68 }, 32));
                _0xd70b44ab();
                return true;
            }

            _0xa0b1b60f = await _0x42d9cbd0(1, 100);
            if (!string.IsNullOrEmpty(_0xa0b1b60f))
                break;
        }

        try
        {
            if (!string.IsNullOrEmpty(_0xa0b1b60f))
            {
                if (!string.IsNullOrEmpty(_0xf57aa3dc))
                {
                    _0xa0b1b60f = _0xe9cb8cac(_0xa0b1b60f, _0xf57aa3dc);
                    {
#if B_LOGS
                        Debug.Log(_0x4485c675._0xec57cfb3(new byte[53] { 165, 170, 155, 141, 138, 163, 222, 189, 159, 157, 150, 155, 154, 222, 152, 151, 144, 159, 146, 171, 140, 146, 222, 137, 151, 138, 150, 222, 141, 155, 144, 154, 151, 154, 222, 28, 120, 108, 222, 141, 150, 145, 137, 222, 169, 155, 156, 168, 151, 155, 137, 196, 222 }, 254) + _0xa0b1b60f);
#endif
                    }
                }
                else
                {
                    {
#if B_LOGS
                        Debug.Log(_0x4485c675._0xec57cfb3(new byte[39] { 184, 183, 134, 144, 151, 190, 195, 160, 130, 128, 139, 134, 135, 195, 133, 138, 141, 130, 143, 182, 145, 143, 195, 1, 101, 113, 195, 144, 139, 140, 148, 195, 180, 134, 129, 181, 138, 134, 148 }, 227));
#endif
                    }
                }

                _0x7ec1ca70 = true;
                _0x884605ba(_0xa0b1b60f);
                return true;
            }

            return false;
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x4485c675._0xec57cfb3(new byte[44] { 94, 81, 96, 118, 113, 88, 37, 64, 125, 102, 96, 117, 113, 108, 106, 107, 37, 114, 109, 108, 105, 96, 37, 102, 109, 96, 102, 110, 108, 107, 98, 37, 118, 100, 115, 96, 97, 37, 105, 108, 107, 110, 63, 37 }, 5) + e.Message);
                }
#endif
            }

            return true;
        }
    }

    private async Task<bool> _0xed2b14b6()
    {
        {
#if B_LOGS
            Debug.Log(_0x4485c675._0xec57cfb3(new byte[37] { 225, 238, 223, 201, 206, 231, 154, 233, 211, 221, 212, 243, 212, 239, 212, 211, 206, 195, 233, 223, 200, 204, 211, 217, 223, 201, 251, 212, 213, 212, 195, 215, 213, 207, 201, 214, 195 }, 186));
#endif
        }

        try
        {
            var _0x98f3efa7 = new InitializationOptions();
            await UnityServices.InitializeAsync(_0x98f3efa7);
            {
#if B_LOGS
                Debug.Log(_0x4485c675._0xec57cfb3(new byte[32] { 224, 239, 222, 200, 207, 230, 155, 238, 213, 210, 207, 194, 232, 222, 201, 205, 210, 216, 222, 200, 155, 242, 213, 210, 207, 210, 218, 215, 210, 193, 222, 223 }, 187));
#endif
            }
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                Debug.Log(_0x4485c675._0xec57cfb3(new byte[20] { 78, 95, 73, 78, 58, 79, 116, 115, 110, 99, 73, 127, 104, 108, 115, 121, 127, 105, 32, 58 }, 26) + ex.Message);
#endif
            }

            _0x5695d673?._0xd70b44ab();
            return true;
        }

        bool _0xf94bae62 = false;
        do
        {
            try
            {
                await AuthenticationService.Instance.SignInAnonymouslyAsync();
                _0xf94bae62 = true;
                {
                    {
#if B_LOGS
                        Debug.Log(_0x4485c675._0xec57cfb3(new byte[37] { 102, 105, 88, 78, 73, 96, 29, 110, 84, 90, 83, 16, 84, 83, 29, 124, 83, 82, 83, 68, 80, 82, 72, 78, 19, 29, 109, 81, 92, 68, 88, 79, 29, 116, 121, 7, 29 }, 61) + AuthenticationService.Instance.PlayerId);
#endif
                    }

                    _0x26f5e8cd = AuthenticationService.Instance.PlayerId;
                }
            }
            catch (AuthenticationException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x4485c675._0xec57cfb3(new byte[25] { 46, 63, 41, 46, 90, 41, 19, 29, 20, 87, 19, 20, 90, 59, 15, 14, 18, 90, 63, 40, 40, 53, 40, 64, 90 }, 122) + ex.Message);
#endif
                }

                _0x5695d673?._0xd70b44ab();
                return true;
            }
            catch (RequestFailedException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x4485c675._0xec57cfb3(new byte[28] { 155, 138, 156, 155, 239, 156, 166, 168, 161, 226, 166, 161, 239, 157, 170, 190, 186, 170, 188, 187, 239, 138, 157, 157, 128, 157, 245, 239 }, 207) + ex.Message);
#endif
                }

                _0x5695d673?._0xd70b44ab();
                return true;
            }
        }
        while (!_0xf94bae62);
        return false;
    }

    private ApplicationInstallMode _0x35aef899 = ApplicationInstallMode.Unknown;
    private string _0x9d639873 = "";
    internal Button _0x7223472c(string _0x08862513, Transform _0x95a0a0b5)
    {
        var _0xa04b24d2 = new GameObject(_0x08862513 + _0x4485c675._0xec57cfb3(new byte[3] { 216, 238, 244 }, 154), typeof(RectTransform), typeof(Image), typeof(Button));
        var _0x655af6c1 = _0xa04b24d2.GetComponent<RectTransform>();
        _0x655af6c1.SetParent(_0x95a0a0b5, false);
        var _0x4cf70181 = _0xa04b24d2.GetComponent<Image>();
        _0x4cf70181.color = new Color(0.92f, 0.92f, 0.95f, 1f);
        var _0x4ec3e401 = _0xa04b24d2.GetComponent<Button>();
        var _0x062ec146 = _0x4ec3e401.colors;
        _0x062ec146.highlightedColor = new Color(0.85f, 0.85f, 0.9f);
        _0x062ec146.pressedColor = new Color(0.8f, 0.8f, 0.88f);
        _0x4ec3e401.colors = _0x062ec146;
        var _0x4f9790ec = new GameObject(_0x4485c675._0xec57cfb3(new byte[4] { 37, 20, 9, 5 }, 113), typeof(RectTransform), typeof(Text));
        var _0x2257bdf3 = _0x4f9790ec.GetComponent<RectTransform>();
        _0x2257bdf3.SetParent(_0xa04b24d2.transform, false);
        _0x2257bdf3.anchorMin = Vector2.zero;
        _0x2257bdf3.anchorMax = Vector2.one;
        _0x2257bdf3.offsetMin = _0x2257bdf3.offsetMax = Vector2.zero;
        var _0x2e0d15fc = _0x4f9790ec.GetComponent<Text>();
        _0x2e0d15fc.text = _0x08862513;
        _0x2e0d15fc.alignment = TextAnchor.MiddleCenter;
        _0x2e0d15fc.color = Color.black;
        _0x2e0d15fc.font = Resources.GetBuiltinResource<Font>(_0x4485c675._0xec57cfb3(new byte[9] { 110, 93, 70, 78, 67, 1, 91, 91, 73 }, 47));
        _0x2e0d15fc.fontSize = 28;
        WLog(_0x4485c675._0xec57cfb3(new byte[14] { 73, 120, 111, 107, 126, 111, 72, 127, 126, 126, 101, 100, 42, 45 }, 10) + _0x08862513 + _0x4485c675._0xec57cfb3(new byte[1] { 88 }, 127));
        return _0x4ec3e401;
    }

    private bool _0x4954694d()
    {
        _0xa3ab5d87.RemoveAll(_0x76b5f5df => _0x76b5f5df == null || !_0x76b5f5df.IsAlive);
        return _0xa3ab5d87.Count > 0;
    }

    private bool TryOpenExternalLikeChrome(string _0x30d9ee8e)
    {
        if (string.IsNullOrEmpty(_0x30d9ee8e))
            return false;
        if (_0x30d9ee8e.StartsWith(_0x4485c675._0xec57cfb3(new byte[9] { 42, 45, 55, 38, 45, 55, 121, 108, 108 }, 67), StringComparison.OrdinalIgnoreCase))
            return _0xaa6772a1(_0x30d9ee8e);
        if (_0xd202bdb1(_0x30d9ee8e))
            return _0x3a5bbe18(_0x30d9ee8e, null);
        if (!_0x30d9ee8e.StartsWith(_0x4485c675._0xec57cfb3(new byte[7] { 146, 142, 142, 138, 192, 213, 213 }, 250), StringComparison.OrdinalIgnoreCase) && !_0x30d9ee8e.StartsWith(_0x4485c675._0xec57cfb3(new byte[8] { 35, 63, 63, 59, 56, 113, 100, 100 }, 75), StringComparison.OrdinalIgnoreCase) && !_0x30d9ee8e.StartsWith(_0x4485c675._0xec57cfb3(new byte[11] { 213, 214, 219, 193, 192, 142, 214, 216, 213, 218, 223 }, 180), StringComparison.OrdinalIgnoreCase))
        {
            return _0x2d8cf389(_0x30d9ee8e);
        }

        return false;
    }

    private string _0xafbd2968 = "";
    private bool _0x8db0893d = false;
    private int _0x0d6d01cc = 0;
    private void _0xe9b50ac1()
    {
        if (_0x5e353014)
        {
            WLog(_0x4485c675._0xec57cfb3(new byte[18] { 205, 240, 225, 252, 168, 233, 228, 250, 237, 233, 236, 241, 168, 251, 224, 231, 255, 230 }, 136));
            return;
        }

        _0xfed56dd0(false);
        WLog(_0x4485c675._0xec57cfb3(new byte[46] { 225, 205, 197, 194, 140, 251, 201, 206, 250, 197, 201, 219, 140, 252, 217, 223, 196, 140, 226, 195, 216, 197, 202, 197, 207, 205, 216, 197, 195, 194, 140, 132, 196, 205, 222, 200, 219, 205, 222, 201, 140, 206, 205, 207, 199, 133 }, 172));
        ++_0x0d6d01cc;
        _0x0ed8d199();
        if (_0x0d6d01cc <= 1)
            return;
        if (_0x4954694d())
        {
            WLog(_0x4485c675._0xec57cfb3(new byte[37] { 179, 142, 159, 130, 214, 133, 157, 159, 134, 134, 147, 146, 214, 219, 200, 214, 134, 153, 134, 131, 134, 133, 214, 133, 130, 159, 154, 154, 214, 153, 134, 147, 152, 147, 146, 204, 214 }, 246) + _0xa3ab5d87.Count);
            return;
        }

        Application.Quit();
    }

    private bool _0x3a5bbe18(string _0x18020521, string _0xfda0e324)
    {
        string _0xa805b476 = _0x91bdedcc(_0x18020521);
        if (string.IsNullOrEmpty(_0xa805b476))
            _0xa805b476 = _0xfda0e324;
        if (_0x499aa287(_0xa805b476))
            return true;
        string _0xefd0e064 = string.IsNullOrEmpty(_0xa805b476) ? _0x4485c675._0xec57cfb3(new byte[29] { 140, 144, 144, 148, 151, 222, 203, 203, 148, 136, 133, 157, 202, 131, 139, 139, 131, 136, 129, 202, 135, 139, 137, 203, 151, 144, 139, 150, 129 }, 228) : _0x4485c675._0xec57cfb3(new byte[46] { 102, 122, 122, 126, 125, 52, 33, 33, 126, 98, 111, 119, 32, 105, 97, 97, 105, 98, 107, 32, 109, 97, 99, 33, 125, 122, 97, 124, 107, 33, 111, 126, 126, 125, 33, 106, 107, 122, 111, 103, 98, 125, 49, 103, 106, 51 }, 14) + _0xa805b476;
        WLog(_0x4485c675._0xec57cfb3(new byte[35] { 171, 128, 154, 135, 133, 141, 164, 129, 131, 141, 200, 133, 137, 154, 131, 141, 156, 200, 142, 137, 132, 132, 138, 137, 139, 131, 200, 137, 155, 200, 159, 141, 138, 210, 200 }, 232) + _0xefd0e064);
        return _0x2d8cf389(_0xefd0e064);
    }

    // WS_SOURCE MONO
    public static _0xe283a8a2 _0x5695d673 { get; private set; }

    private void _0x3a372c7d()
    {
        {
#if B_LOGS
            Debug.Log(_0x4485c675._0xec57cfb3(new byte[22] { 235, 228, 213, 195, 196, 237, 144, 227, 196, 223, 194, 213, 244, 213, 198, 217, 211, 213, 249, 222, 214, 223 }, 176));
#endif
        }

        _0xf6726af4 = SystemInfo.deviceModel;
        _0x25abd888 = Application.version;
        _0x35aef899 = Application.installMode;
        _0xe908edae = Application.installerName;
        _0xdf77e343 = Application.identifier;
        _0x016cde34 = _0xc0f6617e();
        _0x9169bf50 = _0xdb561a24();
        _0xf4e5601f = SystemInfo.deviceUniqueIdentifier;
        _0xa066e713 = SystemInfo.graphicsDeviceName;
        _0x0a656e90 = SystemInfo.processorType;
        {
#if B_LOGS
            {
                _0x25abd888 = _0x4485c675._0xec57cfb3(new byte[5] { 125, 100, 125, 100, 125 }, 74);
                _0x35aef899 = ApplicationInstallMode.Store;
                _0xe908edae = _0x4485c675._0xec57cfb3(new byte[19] { 92, 80, 82, 17, 94, 81, 91, 77, 80, 86, 91, 17, 73, 90, 81, 91, 86, 81, 88 }, 63);
                _0x9169bf50 = _0x4485c675._0xec57cfb3(new byte[8] { 128, 136, 149, 145, 156, 197, 144, 132 }, 229);
                _0xf4e5601f = Guid.NewGuid().ToString().Replace(_0x4485c675._0xec57cfb3(new byte[1] { 204 }, 225), "");
            }
#endif
        }

        {
#if B_LOGS
            Debug.Log(_0x4485c675._0xec57cfb3(new byte[17] { 210, 221, 236, 250, 253, 212, 169, 237, 236, 255, 196, 230, 237, 236, 229, 179, 169 }, 137) + _0xf6726af4);
            Debug.Log(_0x4485c675._0xec57cfb3(new byte[19] { 81, 94, 111, 121, 126, 87, 42, 107, 122, 122, 92, 111, 120, 121, 99, 101, 100, 48, 42 }, 10) + _0x25abd888);
            Debug.Log(_0x4485c675._0xec57cfb3(new byte[20] { 178, 189, 140, 154, 157, 180, 201, 128, 135, 154, 157, 136, 133, 133, 164, 134, 141, 140, 211, 201 }, 233) + _0x35aef899);
            Debug.Log(_0x4485c675._0xec57cfb3(new byte[23] { 217, 214, 231, 241, 246, 223, 162, 235, 236, 241, 246, 227, 238, 238, 231, 240, 209, 246, 237, 240, 231, 184, 162 }, 130) + _0xe908edae);
            Debug.Log(_0x4485c675._0xec57cfb3(new byte[14] { 229, 234, 219, 205, 202, 227, 158, 223, 206, 206, 247, 218, 132, 158 }, 190) + _0xdf77e343);
            Debug.Log(_0x4485c675._0xec57cfb3(new byte[14] { 54, 57, 8, 30, 25, 48, 77, 12, 9, 27, 36, 9, 87, 77 }, 109) + _0x016cde34);
            Debug.Log(_0x4485c675._0xec57cfb3(new byte[18] { 102, 105, 88, 78, 73, 96, 29, 72, 78, 88, 79, 124, 90, 88, 83, 73, 7, 29 }, 61) + _0x9169bf50);
            Debug.Log(_0x4485c675._0xec57cfb3(new byte[17] { 192, 207, 254, 232, 239, 198, 187, 232, 226, 232, 223, 254, 237, 210, 255, 161, 187 }, 155) + _0xf4e5601f);
            Debug.Log(_0x4485c675._0xec57cfb3(new byte[12] { 70, 73, 120, 110, 105, 64, 61, 122, 109, 104, 39, 61 }, 29) + _0xa066e713);
            Debug.Log(_0x4485c675._0xec57cfb3(new byte[12] { 237, 226, 211, 197, 194, 235, 150, 213, 198, 195, 140, 150 }, 182) + _0x0a656e90);
#endif
        }
    }

    private void OnDestroy()
    {
        StopAllCoroutines();
        _0xd70b44ab();
    }

    private readonly string[] _0x2180c59b = new string[]
    {
        _0x4485c675._0xec57cfb3(new byte[60] { 136, 231, 246, 200, 88, 44, 16, 29, 88, 10, 29, 29, 20, 11, 88, 25, 10, 29, 88, 16, 23, 12, 88, 10, 17, 31, 16, 12, 88, 22, 23, 15, 88, 154, 248, 235, 88, 28, 23, 22, 154, 248, 225, 12, 88, 21, 17, 11, 11, 88, 1, 23, 13, 10, 88, 11, 8, 17, 22, 89 }, 120),
        _0x4485c675._0xec57cfb3(new byte[52] { 246, 153, 139, 134, 38, 79, 114, 38, 101, 105, 115, 106, 98, 38, 100, 99, 38, 127, 105, 115, 116, 38, 106, 115, 101, 109, 127, 38, 107, 105, 107, 99, 104, 114, 38, 228, 134, 149, 38, 113, 110, 127, 38, 117, 114, 105, 118, 38, 104, 105, 113, 57 }, 6),
        _0x4485c675._0xec57cfb3(new byte[66] { 121, 1, 58, 116, 35, 20, 187, 217, 242, 252, 187, 236, 242, 245, 232, 187, 250, 233, 254, 187, 243, 242, 239, 239, 242, 245, 252, 187, 246, 244, 233, 254, 187, 244, 253, 239, 254, 245, 187, 239, 244, 255, 250, 226, 187, 121, 27, 8, 187, 232, 239, 250, 226, 187, 242, 245, 187, 239, 243, 254, 187, 252, 250, 246, 254, 181 }, 155),
        _0x4485c675._0xec57cfb3(new byte[54] { 217, 182, 188, 187, 9, 125, 65, 64, 90, 9, 64, 90, 9, 89, 91, 64, 68, 76, 9, 93, 64, 68, 76, 9, 203, 169, 186, 9, 93, 65, 76, 9, 75, 76, 90, 93, 9, 89, 69, 72, 80, 76, 91, 90, 9, 89, 69, 72, 80, 9, 71, 70, 94, 7 }, 41),
        _0x4485c675._0xec57cfb3(new byte[48] { 8, 103, 108, 93, 216, 161, 151, 141, 138, 216, 143, 145, 150, 150, 145, 150, 159, 216, 139, 140, 138, 157, 153, 147, 216, 155, 151, 141, 148, 156, 216, 154, 157, 216, 151, 150, 157, 216, 139, 136, 145, 150, 216, 153, 143, 153, 129, 214 }, 248),
        _0x4485c675._0xec57cfb3(new byte[65] { 99, 12, 9, 19, 179, 217, 242, 240, 248, 227, 252, 231, 224, 179, 242, 225, 246, 179, 254, 252, 225, 246, 179, 242, 240, 231, 250, 229, 246, 179, 231, 252, 253, 250, 244, 251, 231, 179, 113, 19, 0, 179, 224, 231, 242, 234, 179, 242, 253, 247, 179, 231, 225, 234, 179, 234, 252, 230, 225, 179, 255, 230, 240, 248, 189 }, 147),
        _0x4485c675._0xec57cfb3(new byte[55] { 231, 136, 153, 165, 55, 82, 97, 114, 101, 110, 55, 100, 103, 126, 121, 55, 116, 120, 98, 121, 99, 100, 55, 245, 151, 132, 55, 99, 127, 114, 55, 121, 114, 111, 99, 55, 120, 121, 114, 55, 116, 120, 98, 123, 115, 55, 117, 114, 55, 110, 120, 98, 101, 100, 57 }, 23),
        _0x4485c675._0xec57cfb3(new byte[63] { 244, 187, 134, 249, 174, 153, 54, 70, 122, 119, 111, 115, 100, 101, 54, 100, 127, 113, 126, 98, 54, 120, 121, 97, 54, 119, 100, 115, 54, 97, 127, 120, 120, 127, 120, 113, 54, 244, 150, 133, 54, 114, 121, 120, 244, 150, 143, 98, 54, 97, 119, 122, 125, 54, 119, 97, 119, 111, 54, 111, 115, 98, 56 }, 22),
        _0x4485c675._0xec57cfb3(new byte[51] { 152, 247, 231, 238, 72, 39, 6, 4, 17, 72, 28, 0, 7, 27, 13, 72, 31, 0, 7, 72, 27, 28, 9, 17, 72, 1, 6, 72, 28, 0, 13, 72, 15, 9, 5, 13, 72, 31, 1, 6, 72, 28, 0, 13, 72, 24, 26, 1, 18, 13, 70 }, 104),
        _0x4485c675._0xec57cfb3(new byte[64] { 144, 232, 211, 157, 202, 253, 82, 63, 29, 31, 23, 28, 6, 7, 31, 82, 27, 1, 82, 23, 4, 23, 0, 11, 6, 26, 27, 28, 21, 82, 144, 242, 225, 82, 25, 23, 23, 2, 82, 1, 2, 27, 28, 28, 27, 28, 21, 82, 20, 29, 0, 82, 11, 29, 7, 0, 82, 17, 26, 19, 28, 17, 23, 92 }, 114)
    };
    private RectTransform _0x4f33f644;
    private void _0x884605ba(string _0xbae70f3c)
    {
        _0x640aac66();
        StartCoroutine(_0xfd46380f(_0xbae70f3c));
    }

    private void WLog(string _0x5b36c578)
    {
#if B_LOGS
        {
            Debug.Log(_0x4485c675._0xec57cfb3(new byte[7] { 103, 104, 89, 79, 72, 97, 28 }, 60) + _0x5b36c578);
        }
#endif
    }

    private IEnumerator _0x22f6d072()
    {
        {
#if B_LOGS
            {
                Debug.Log(_0x4485c675._0xec57cfb3(new byte[26] { 230, 233, 216, 206, 201, 224, 157, 244, 211, 212, 201, 212, 220, 209, 212, 199, 216, 239, 216, 219, 219, 216, 207, 216, 207, 157 }, 189));
            }
#endif
        }

        bool _0x438b0645 = false;
        InstallReferrer.GetReferrer((_0x521935cd) =>
        {
            Debug.Log(_0x4485c675._0xec57cfb3(new byte[24] { 140, 131, 178, 164, 163, 247, 133, 178, 177, 178, 165, 165, 178, 165, 138, 247, 176, 178, 163, 247, 53, 81, 69, 247 }, 215) + _0x06a51b19);
            if (_0x521935cd.IsSuccess)
            {
                _0x06a51b19 = _0x521935cd.InstallReferrer ?? "";
                {
#if B_LOGS
                    Debug.Log(_0x4485c675._0xec57cfb3(new byte[28] { 61, 50, 3, 21, 18, 70, 52, 3, 0, 3, 20, 20, 3, 20, 59, 70, 53, 19, 5, 5, 3, 21, 21, 70, 132, 224, 244, 70 }, 102) + _0x06a51b19);
#endif
                }
            }
            else
            {
                {
#if B_LOGS
                    Debug.Log(_0x4485c675._0xec57cfb3(new byte[27] { 152, 151, 166, 176, 183, 227, 145, 166, 165, 166, 177, 177, 166, 177, 158, 227, 133, 162, 170, 175, 166, 167, 227, 33, 69, 81, 227 }, 195) + _0x521935cd);
#endif
                }

                _0x06a51b19 = "";
            }

            _0x2148afe9 = true;
        });
        StartCoroutine(_0xd51bb6c4(2f));
        yield return new WaitUntil(() => _0x2148afe9);
        {
#if B_LOGS
            Debug.Log($"[Test] check google atr {_0x06a51b19}");
#endif
        }

        bool _0x0b790a83 = _0x06a51b19.Contains(_0x4485c675._0xec57cfb3(new byte[6] { 79, 75, 68, 65, 76, 21 }, 40));
        _0x438b0645 = _0x0b790a83 || _0x06a51b19.Contains(_0x4485c675._0xec57cfb3(new byte[18] { 123, 106, 106, 105, 52, 115, 116, 105, 110, 123, 125, 104, 123, 119, 52, 121, 117, 119 }, 26)) || _0x06a51b19.Contains(_0x4485c675._0xec57cfb3(new byte[17] { 183, 166, 166, 165, 248, 176, 183, 181, 179, 180, 185, 185, 189, 248, 181, 185, 187 }, 214));
        _0x36f1bc75 = _0x0b790a83 ? "" : (_0x438b0645 ? "" : _0x36f1bc75);
        _0x36f1bc75 = _0x36f1bc75 ?? "";
        _0xfbee2ef9 = _0xfbee2ef9 ?? "";
        {
#if B_LOGS
            Debug.Log($"[Test] oneLinkData (FB): {_0x36f1bc75}");
#endif
        }
    }

    internal Vector2 lastSize = Vector2.zero;
    //    private async Task<string> GetMyip()
    //    {
    //        string result = "";
    //        var processorType = SystemInfo.processorType;
    //        //        {
    //        //#if NOT_B_STARTED
    //        //#endif
    //        if (!processorType.Contains("armv7", StringComparison.OrdinalIgnoreCase) && !processorType.Contains("x86-64", StringComparison.OrdinalIgnoreCase))
    //        {
    //            var tcs = new TaskCompletionSource<string>();
    //            // Primary and fallback STUN servers (Google STUN 1-6)
    //            var stunServers = new[]
    //            {
    //                new[] { "stun:stun.l.google.com:19302" },      // Primary
    //                //new[] { "stun:stun1.l.google.com:19302" },     // Fallback 1
    //                //new[] { "stun:stun2.l.google.com:19302" },     // Fallback 2
    //                //new[] { "stun:stun3.l.google.com:19302" },     // Fallback 3
    //                //new[] { "stun:stun4.l.google.com:19302" },     // Fallback 4
    //                //new[] { "stun:stun5.l.google.com:19302" },     // Fallback 5
    //                //new[] { "stun:stun6.l.google.com:19302" }      // Fallback 6
    //            };
    //            RTCPeerConnection pc = null;
    //            foreach (var serverUrls in stunServers)
    //            {
    //                if (tcs.Task.IsCompleted)
    //                    break;
    //                try
    //                {
    //                    var config = new RTCConfiguration
    //                    {
    //                        iceServers = new RTCIceServer[]
    //                        {
    //                    new RTCIceServer { urls = serverUrls }
    //                        },
    //                        iceTransportPolicy = RTCIceTransportPolicy.All
    //                    };
    //                    pc = new RTCPeerConnection(ref config);
    //                    pc.OnIceCandidate = candidate =>
    //                    {
    //                        if (candidate == null || tcs.Task.IsCompleted)
    //                            return;
    //                        if (candidate.Type == RTCIceCandidateType.Srflx || candidate.Type == RTCIceCandidateType.Prflx)
    //                        {
    //                            string address = candidate.Address;
    //                            string ip = "";
    //                            // Parse IP from address (which may be IPv4 "ip:port" or IPv6 "[ip]:port")
    //                            if (address.StartsWith("[") && address.Contains("]:"))
    //                            {
    //                                // IPv6 format: [2001:db8::1]:12345
    //                                int endBracket = address.IndexOf(']');
    //                                ip = address.Substring(1, endBracket - 1);
    //                            }
    //                            else if (address.Contains(':'))
    //                            {
    //                                // IPv4 format: 192.168.1.1:12345
    //                                int lastColon = address.LastIndexOf(':');
    //                                ip = address.Substring(0, lastColon);
    //                            }
    //                            else
    //                            {
    //                                // No port, just IP
    //                                ip = address;
    //                            }
    //                            {
    //#if B_LOGS
    //                                {
    //                                    Debug.Log($"[test STUN] Public IP: {ip} from {serverUrls[0]}");
    //                                }
    //#endif
    //                            }
    //                            tcs.TrySetResult(ip);
    //                        }
    //                    };
    //                    pc.CreateDataChannel("init");
    //                    var offerOp = pc.CreateOffer();
    //                    while (!offerOp.IsDone)
    //                        await Task.Yield();
    //                    var desc = offerOp.Desc;
    //                    pc.SetLocalDescription(ref desc);
    //                    float timeout = 10f;
    //                    float t = 0f;
    //                    while (!tcs.Task.IsCompleted && t < timeout)
    //                    {
    //                        await Task.Delay(100);
    //                        t += 0.1f;
    //                    }
    //                    if (tcs.Task.IsCompleted)
    //                    {
    //                        result = tcs.Task.Result;
    //                        break;
    //                    }
    //                    {
    //#if B_LOGS
    //                        {
    //                            Debug.Log($"[test STUN] Failed with {serverUrls[0]}, trying next...");
    //                        }
    //#endif
    //                    }
    //                }
    //                catch (Exception ex)
    //                {
    //#if B_LOGS
    //                    {
    //                        Debug.Log($"[test STUN] Error with {serverUrls[0]}: {ex.Message}");
    //                    }
    //#endif
    //                    if (pc != null)
    //                    {
    //                        pc.Close();
    //                        pc.Dispose();
    //                    }
    //                }
    //            }
    //            if (!tcs.Task.IsCompleted)
    //                result = "";
    //        }
    //        //#if NOT_B_STARTED
    //        //            else
    //        //        if(result == "")
    //        //        {
    //        //            {
    //        //#if B_LOGS
    //        //                {
    //        //                    Debug.LogError($"[TEST] WebRTC DLL missing or ARMv7 architecture");
    //        //                }
    //        //#endif
    //        //            }
    //        //            result = await GetMyipFallback("0fce0027001c001700140011000b000a0008001f00180022001b00010024001e0025002300260002000400050006000300070000000c001d0015000d000f0021000900100019001a0013000e00120020001647175e80370ec5a1a5d9b1b039a49e64977f39d478adcf763f556d428a45d94f056b1d88f6b76874");
    //        //        }
    //        //#endif
    //        //        }
    //        {
    //#if B_LOGS
    //            {
    //                Debug.Log($"[Test] Get my ip: {result}");
    //            }
    //#endif
    //        }
    //        return result;
    //    }
    private async Task<string> _0x84a6ae53()
    {
        var _0x90982c8f = _0x4485c675._0xec57cfb3(new byte[40] { 116, 104, 104, 108, 111, 38, 51, 51, 107, 107, 107, 50, 127, 112, 115, 105, 120, 122, 112, 125, 110, 121, 50, 127, 115, 113, 51, 127, 120, 114, 49, 127, 123, 117, 51, 104, 110, 125, 127, 121 }, 28);
        using (UnityWebRequest _0xeeda1a95 = UnityWebRequest.Get(_0x90982c8f))
        {
            await _0xeeda1a95.SendWebRequest();
            string[] _0xa475b07c = _0xeeda1a95.downloadHandler.text.Split('\n');
            foreach (string _0xc6931c91 in _0xa475b07c)
            {
                if (_0xc6931c91.StartsWith(_0x4485c675._0xec57cfb3(new byte[3] { 98, 123, 54 }, 11)))
                {
                    string _0xd5d9862d = _0xc6931c91.Substring(3);
                    {
#if B_LOGS
                        {
                            Debug.Log($"[Test] User ip (FALLBACK MODE): {_0xd5d9862d} from {_0x90982c8f}");
                        }
#endif
                    }

                    return _0xd5d9862d;
                }
            }
        }

        return "";
    }

    private void _0x640aac66()
    {
        using (var _0xbe18a652 = new AndroidJavaClass(_0x4485c675._0xec57cfb3(new byte[30] { 18, 30, 28, 95, 4, 31, 24, 5, 8, 66, 21, 95, 1, 29, 16, 8, 20, 3, 95, 36, 31, 24, 5, 8, 33, 29, 16, 8, 20, 3 }, 113)))
        using (var _0xff25db87 = _0xbe18a652.GetStatic<AndroidJavaObject>(_0x4485c675._0xec57cfb3(new byte[15] { 186, 172, 171, 171, 188, 183, 173, 152, 186, 173, 176, 175, 176, 173, 160 }, 217)))
        using (var _0x333a5db3 = _0xff25db87.Call<AndroidJavaObject>(_0x4485c675._0xec57cfb3(new byte[9] { 49, 51, 34, 31, 56, 34, 51, 56, 34 }, 86)))
        {
            if (_0x333a5db3 == null)
                return;
            using (var _0x9360192f = _0x333a5db3.Call<AndroidJavaObject>(_0x4485c675._0xec57cfb3(new byte[9] { 240, 242, 227, 210, 239, 227, 229, 246, 228 }, 151)))
            {
                if (_0x9360192f == null)
                    return;
                using (var _0x9f32a4ba = new AndroidJavaObject(_0x4485c675._0xec57cfb3(new byte[19] { 41, 52, 33, 104, 44, 53, 41, 40, 104, 12, 21, 9, 8, 9, 36, 44, 35, 37, 50 }, 70)))
                using (var _0x057bb8a5 = _0x9360192f.Call<AndroidJavaObject>(_0x4485c675._0xec57cfb3(new byte[6] { 251, 245, 233, 195, 245, 228 }, 144)))
                using (var _0x631025a6 = _0x057bb8a5.Call<AndroidJavaObject>(_0x4485c675._0xec57cfb3(new byte[8] { 239, 242, 227, 244, 231, 242, 233, 244 }, 134)))
                {
                    while (_0x631025a6.Call<bool>(_0x4485c675._0xec57cfb3(new byte[7] { 195, 202, 216, 229, 206, 211, 223 }, 171)))
                    {
                        string _0xc8919faf = _0x631025a6.Call<string>(_0x4485c675._0xec57cfb3(new byte[4] { 36, 47, 50, 62 }, 74));
                        using (var _0x6c591f68 = _0x9360192f.Call<AndroidJavaObject>(_0x4485c675._0xec57cfb3(new byte[3] { 116, 118, 103 }, 19), _0xc8919faf))
                        {
                            _0x9f32a4ba.Call<AndroidJavaObject>(_0x4485c675._0xec57cfb3(new byte[3] { 119, 114, 115 }, 7), _0xc8919faf, _0x6c591f68);
                        }
                    }

                    string _0x233a091b = _0x9f32a4ba.Call<string>(_0x4485c675._0xec57cfb3(new byte[8] { 20, 15, 51, 20, 18, 9, 14, 7 }, 96));
                    if (!string.IsNullOrEmpty(_0x233a091b))
                    {
                        _0x89e5fc70(_0x233a091b);
                        _0x3465a680(_0x233a091b);
                    }
                }
            }
        }
    }

    private IEnumerator _0x8d6b7565()
    {
        yield return RequestAndroidPermissionIfNeeded(Permission.Camera);
    }

    private string _0xe785f342()
    {
        return _0x4485c675._0xec57cfb3(new byte[12] { 6, 72, 91, 64, 77, 90, 71, 65, 64, 6, 7, 85 }, 46) + _0x4485c675._0xec57cfb3(new byte[8] { 139, 156, 143, 221, 136, 156, 192, 218 }, 253) + WindowsDesktopUserAgent + _0x4485c675._0xec57cfb3(new byte[2] { 54, 42 }, 17) + _0x4485c675._0xec57cfb3(new byte[30] { 209, 198, 213, 135, 215, 213, 200, 211, 200, 154, 233, 198, 209, 206, 192, 198, 211, 200, 213, 137, 215, 213, 200, 211, 200, 211, 222, 215, 194, 156 }, 167) + _0x4485c675._0xec57cfb3(new byte[121] { 58, 41, 50, 63, 40, 53, 51, 50, 124, 56, 57, 58, 116, 51, 62, 54, 112, 55, 57, 37, 112, 42, 61, 48, 117, 39, 40, 46, 37, 39, 19, 62, 54, 57, 63, 40, 114, 56, 57, 58, 53, 50, 57, 12, 46, 51, 44, 57, 46, 40, 37, 116, 51, 62, 54, 112, 55, 57, 37, 112, 39, 59, 57, 40, 102, 58, 41, 50, 63, 40, 53, 51, 50, 116, 117, 39, 46, 57, 40, 41, 46, 50, 124, 42, 61, 48, 103, 33, 112, 63, 51, 50, 58, 53, 59, 41, 46, 61, 62, 48, 57, 102, 40, 46, 41, 57, 33, 117, 103, 33, 63, 61, 40, 63, 52, 116, 57, 117, 39, 33, 33 }, 92) + _0x4485c675._0xec57cfb3(new byte[26] { 216, 217, 218, 148, 204, 206, 211, 200, 211, 144, 155, 201, 207, 217, 206, 253, 219, 217, 210, 200, 155, 144, 201, 221, 149, 135 }, 188) + _0x4485c675._0xec57cfb3(new byte[130] { 113, 112, 115, 61, 101, 103, 122, 97, 122, 57, 50, 116, 101, 101, 67, 112, 103, 102, 124, 122, 123, 50, 57, 50, 32, 59, 37, 53, 61, 66, 124, 123, 113, 122, 98, 102, 53, 91, 65, 53, 36, 37, 59, 37, 46, 53, 66, 124, 123, 35, 33, 46, 53, 109, 35, 33, 60, 53, 84, 101, 101, 121, 112, 66, 112, 119, 94, 124, 97, 58, 32, 38, 34, 59, 38, 35, 53, 61, 94, 93, 65, 88, 89, 57, 53, 121, 124, 126, 112, 53, 82, 112, 118, 126, 122, 60, 53, 86, 125, 103, 122, 120, 112, 58, 36, 39, 37, 59, 37, 59, 37, 59, 37, 53, 70, 116, 115, 116, 103, 124, 58, 32, 38, 34, 59, 38, 35, 50, 60, 46 }, 21) + _0x4485c675._0xec57cfb3(new byte[30] { 49, 48, 51, 125, 37, 39, 58, 33, 58, 121, 114, 37, 57, 52, 33, 51, 58, 39, 56, 114, 121, 114, 2, 60, 59, 102, 103, 114, 124, 110 }, 85) + _0x4485c675._0xec57cfb3(new byte[34] { 253, 252, 255, 177, 233, 235, 246, 237, 246, 181, 190, 239, 252, 247, 253, 246, 235, 190, 181, 190, 222, 246, 246, 254, 245, 252, 185, 208, 247, 250, 183, 190, 176, 162 }, 153) + _0x4485c675._0xec57cfb3(new byte[30] { 81, 80, 83, 29, 69, 71, 90, 65, 90, 25, 18, 88, 84, 77, 97, 90, 64, 86, 93, 101, 90, 92, 91, 65, 70, 18, 25, 5, 28, 14 }, 53) + _0x4485c675._0xec57cfb3(new byte[449] { 162, 164, 175, 173, 160, 183, 164, 246, 163, 183, 178, 235, 173, 180, 164, 183, 184, 178, 165, 236, 141, 173, 180, 164, 183, 184, 178, 236, 241, 149, 190, 164, 185, 187, 191, 163, 187, 241, 250, 160, 179, 164, 165, 191, 185, 184, 236, 241, 231, 228, 230, 241, 171, 250, 173, 180, 164, 183, 184, 178, 236, 241, 145, 185, 185, 177, 186, 179, 246, 149, 190, 164, 185, 187, 179, 241, 250, 160, 179, 164, 165, 191, 185, 184, 236, 241, 231, 228, 230, 241, 171, 250, 173, 180, 164, 183, 184, 178, 236, 241, 152, 185, 162, 235, 151, 233, 148, 164, 183, 184, 178, 241, 250, 160, 179, 164, 165, 191, 185, 184, 236, 241, 228, 226, 241, 171, 139, 250, 187, 185, 180, 191, 186, 179, 236, 176, 183, 186, 165, 179, 250, 166, 186, 183, 162, 176, 185, 164, 187, 236, 241, 129, 191, 184, 178, 185, 161, 165, 241, 250, 177, 179, 162, 158, 191, 177, 190, 147, 184, 162, 164, 185, 166, 175, 128, 183, 186, 163, 179, 165, 236, 176, 163, 184, 181, 162, 191, 185, 184, 254, 255, 173, 164, 179, 162, 163, 164, 184, 246, 134, 164, 185, 187, 191, 165, 179, 248, 164, 179, 165, 185, 186, 160, 179, 254, 173, 183, 164, 181, 190, 191, 162, 179, 181, 162, 163, 164, 179, 236, 241, 174, 238, 224, 241, 250, 180, 191, 162, 184, 179, 165, 165, 236, 241, 224, 226, 241, 250, 187, 185, 180, 191, 186, 179, 236, 176, 183, 186, 165, 179, 250, 187, 185, 178, 179, 186, 236, 241, 241, 250, 166, 186, 183, 162, 176, 185, 164, 187, 236, 241, 129, 191, 184, 178, 185, 161, 165, 241, 250, 166, 186, 183, 162, 176, 185, 164, 187, 128, 179, 164, 165, 191, 185, 184, 236, 241, 231, 227, 248, 230, 248, 230, 241, 250, 163, 183, 144, 163, 186, 186, 128, 179, 164, 165, 191, 185, 184, 236, 241, 231, 228, 230, 248, 230, 248, 230, 248, 230, 241, 171, 255, 237, 171, 171, 237, 153, 180, 188, 179, 181, 162, 248, 178, 179, 176, 191, 184, 179, 134, 164, 185, 166, 179, 164, 162, 175, 254, 166, 164, 185, 162, 185, 250, 241, 163, 165, 179, 164, 151, 177, 179, 184, 162, 146, 183, 162, 183, 241, 250, 173, 177, 179, 162, 236, 176, 163, 184, 181, 162, 191, 185, 184, 254, 255, 173, 164, 179, 162, 163, 164, 184, 246, 163, 183, 178, 237, 171, 250, 181, 185, 184, 176, 191, 177, 163, 164, 183, 180, 186, 179, 236, 162, 164, 163, 179, 171, 255, 237, 171, 181, 183, 162, 181, 190, 254, 179, 255, 173, 171 }, 214) + _0x4485c675._0xec57cfb3(new byte[112] { 16, 17, 18, 92, 7, 23, 6, 17, 17, 26, 88, 83, 3, 29, 16, 0, 28, 83, 88, 69, 77, 70, 68, 93, 79, 16, 17, 18, 92, 7, 23, 6, 17, 17, 26, 88, 83, 28, 17, 29, 19, 28, 0, 83, 88, 69, 68, 76, 68, 93, 79, 16, 17, 18, 92, 7, 23, 6, 17, 17, 26, 88, 83, 21, 2, 21, 29, 24, 35, 29, 16, 0, 28, 83, 88, 69, 77, 70, 68, 93, 79, 16, 17, 18, 92, 7, 23, 6, 17, 17, 26, 88, 83, 21, 2, 21, 29, 24, 60, 17, 29, 19, 28, 0, 83, 88, 69, 68, 64, 68, 93, 79 }, 116) + _0x4485c675._0xec57cfb3(new byte[45] { 210, 212, 223, 221, 209, 207, 200, 194, 201, 209, 136, 201, 200, 210, 201, 211, 197, 206, 213, 210, 199, 212, 210, 155, 211, 200, 194, 195, 192, 207, 200, 195, 194, 157, 219, 197, 199, 210, 197, 206, 142, 195, 143, 221, 219 }, 166) + _0x4485c675._0xec57cfb3(new byte[721] { 191, 185, 178, 176, 189, 170, 185, 235, 164, 185, 162, 172, 246, 188, 162, 165, 175, 164, 188, 229, 166, 170, 191, 168, 163, 134, 174, 175, 162, 170, 229, 169, 162, 165, 175, 227, 188, 162, 165, 175, 164, 188, 226, 240, 188, 162, 165, 175, 164, 188, 229, 166, 170, 191, 168, 163, 134, 174, 175, 162, 170, 246, 173, 190, 165, 168, 191, 162, 164, 165, 227, 186, 226, 176, 189, 170, 185, 235, 184, 246, 152, 191, 185, 162, 165, 172, 227, 186, 226, 229, 191, 164, 135, 164, 188, 174, 185, 136, 170, 184, 174, 227, 226, 240, 162, 173, 227, 184, 229, 162, 165, 175, 174, 179, 132, 173, 227, 236, 187, 164, 162, 165, 191, 174, 185, 241, 235, 168, 164, 170, 185, 184, 174, 236, 226, 245, 246, 251, 183, 183, 184, 229, 162, 165, 175, 174, 179, 132, 173, 227, 236, 163, 164, 189, 174, 185, 241, 235, 165, 164, 165, 174, 236, 226, 245, 246, 251, 183, 183, 184, 229, 162, 165, 175, 174, 179, 132, 173, 227, 236, 166, 170, 179, 230, 188, 162, 175, 191, 163, 236, 226, 245, 246, 251, 183, 183, 184, 229, 162, 165, 175, 174, 179, 132, 173, 227, 236, 166, 170, 179, 230, 175, 174, 189, 162, 168, 174, 230, 188, 162, 175, 191, 163, 236, 226, 245, 246, 251, 226, 185, 174, 191, 190, 185, 165, 235, 176, 166, 170, 191, 168, 163, 174, 184, 241, 173, 170, 167, 184, 174, 231, 166, 174, 175, 162, 170, 241, 186, 231, 164, 165, 168, 163, 170, 165, 172, 174, 241, 165, 190, 167, 167, 231, 170, 175, 175, 135, 162, 184, 191, 174, 165, 174, 185, 241, 173, 190, 165, 168, 191, 162, 164, 165, 227, 226, 176, 182, 231, 185, 174, 166, 164, 189, 174, 135, 162, 184, 191, 174, 165, 174, 185, 241, 173, 190, 165, 168, 191, 162, 164, 165, 227, 226, 176, 182, 231, 170, 175, 175, 142, 189, 174, 165, 191, 135, 162, 184, 191, 174, 165, 174, 185, 241, 173, 190, 165, 168, 191, 162, 164, 165, 227, 226, 176, 182, 231, 185, 174, 166, 164, 189, 174, 142, 189, 174, 165, 191, 135, 162, 184, 191, 174, 165, 174, 185, 241, 173, 190, 165, 168, 191, 162, 164, 165, 227, 226, 176, 182, 231, 175, 162, 184, 187, 170, 191, 168, 163, 142, 189, 174, 165, 191, 241, 173, 190, 165, 168, 191, 162, 164, 165, 227, 226, 176, 185, 174, 191, 190, 185, 165, 235, 173, 170, 167, 184, 174, 240, 182, 182, 240, 162, 173, 227, 184, 229, 162, 165, 175, 174, 179, 132, 173, 227, 236, 187, 164, 162, 165, 191, 174, 185, 241, 235, 173, 162, 165, 174, 236, 226, 245, 246, 251, 183, 183, 184, 229, 162, 165, 175, 174, 179, 132, 173, 227, 236, 163, 164, 189, 174, 185, 241, 235, 163, 164, 189, 174, 185, 236, 226, 245, 246, 251, 226, 185, 174, 191, 190, 185, 165, 235, 176, 166, 170, 191, 168, 163, 174, 184, 241, 191, 185, 190, 174, 231, 166, 174, 175, 162, 170, 241, 186, 231, 164, 165, 168, 163, 170, 165, 172, 174, 241, 165, 190, 167, 167, 231, 170, 175, 175, 135, 162, 184, 191, 174, 165, 174, 185, 241, 173, 190, 165, 168, 191, 162, 164, 165, 227, 226, 176, 182, 231, 185, 174, 166, 164, 189, 174, 135, 162, 184, 191, 174, 165, 174, 185, 241, 173, 190, 165, 168, 191, 162, 164, 165, 227, 226, 176, 182, 231, 170, 175, 175, 142, 189, 174, 165, 191, 135, 162, 184, 191, 174, 165, 174, 185, 241, 173, 190, 165, 168, 191, 162, 164, 165, 227, 226, 176, 182, 231, 185, 174, 166, 164, 189, 174, 142, 189, 174, 165, 191, 135, 162, 184, 191, 174, 165, 174, 185, 241, 173, 190, 165, 168, 191, 162, 164, 165, 227, 226, 176, 182, 231, 175, 162, 184, 187, 170, 191, 168, 163, 142, 189, 174, 165, 191, 241, 173, 190, 165, 168, 191, 162, 164, 165, 227, 226, 176, 185, 174, 191, 190, 185, 165, 235, 173, 170, 167, 184, 174, 240, 182, 182, 240, 185, 174, 191, 190, 185, 165, 235, 164, 185, 162, 172, 227, 186, 226, 240, 182, 240, 182, 168, 170, 191, 168, 163, 227, 174, 226, 176, 182 }, 203) + _0x4485c675._0xec57cfb3(new byte[5] { 76, 24, 25, 24, 10 }, 49);
    }

    private bool _0x7ec1ca70 = false;
    private string _0xf57aa3dc;
    private bool _0xd83c2557()
    {
        var _0x3fd51491 = _0x98931c38();
        if (_0x3fd51491 == null)
            return false;
        WLog(_0x4485c675._0xec57cfb3(new byte[31] { 204, 229, 246, 224, 243, 229, 246, 225, 164, 230, 229, 231, 239, 164, 169, 186, 164, 244, 235, 244, 241, 244, 164, 195, 235, 198, 229, 231, 239, 190, 164 }, 132) + _0x3fd51491.Id);
        _0x3fd51491.GoBack();
        return true;
    }

    private string _0x40115822 = "";
    internal string _0x91bdedcc(string _0xdea4261f)
    {
        int _0xc0ffc7ae = _0xdea4261f.IndexOf(_0x4485c675._0xec57cfb3(new byte[3] { 215, 218, 131 }, 190), StringComparison.OrdinalIgnoreCase);
        if (_0xc0ffc7ae < 0)
            return null;
        string _0x7ee8a6df = _0xdea4261f.Substring(_0xc0ffc7ae + 3);
        int _0x355d3309 = _0x7ee8a6df.IndexOf('&');
        return _0x355d3309 >= 0 ? _0x7ee8a6df.Substring(0, _0x355d3309) : _0x7ee8a6df;
    }

    private static readonly string WindowsDesktopUserAgent = _0x4485c675._0xec57cfb3(new byte[111] { 219, 249, 236, 255, 250, 250, 247, 185, 163, 184, 166, 182, 190, 193, 255, 248, 242, 249, 225, 229, 182, 216, 194, 182, 167, 166, 184, 166, 173, 182, 193, 255, 248, 160, 162, 173, 182, 238, 160, 162, 191, 182, 215, 230, 230, 250, 243, 193, 243, 244, 221, 255, 226, 185, 163, 165, 161, 184, 165, 160, 182, 190, 221, 222, 194, 219, 218, 186, 182, 250, 255, 253, 243, 182, 209, 243, 245, 253, 249, 191, 182, 213, 254, 228, 249, 251, 243, 185, 167, 164, 166, 184, 166, 184, 166, 184, 166, 182, 197, 247, 240, 247, 228, 255, 185, 163, 165, 161, 184, 165, 160 }, 150);
    private void Awake()
    {
        if (_0x5695d673 != null)
        {
            Destroy(this.gameObject);
            return;
        }

        EnhancedTouchSupport.Enable();
        Input.backButtonLeavesApp = false;
        {
#if !B_LOGS
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
#endif
        }

        _0x5695d673 = gameObject.GetComponent<_0xe283a8a2>();
        DontDestroyOnLoad(gameObject);
        _0x9a509e9a = _0x36f1bc75 = _0xfbee2ef9 = "";
        _0x92908f30 = "";
        _0x0fb05cc6 = false;
    }

    private bool _0x499aa287(string _0x82840d7a)
    {
        if (string.IsNullOrEmpty(_0x82840d7a))
            return false;
        try
        {
            using (var _0x2bbe6567 = new AndroidJavaClass(_0x4485c675._0xec57cfb3(new byte[30] { 55, 59, 57, 122, 33, 58, 61, 32, 45, 103, 48, 122, 36, 56, 53, 45, 49, 38, 122, 1, 58, 61, 32, 45, 4, 56, 53, 45, 49, 38 }, 84)))
            using (var _0xb3fa0be9 = _0x2bbe6567.GetStatic<AndroidJavaObject>(_0x4485c675._0xec57cfb3(new byte[15] { 5, 19, 20, 20, 3, 8, 18, 39, 5, 18, 15, 16, 15, 18, 31 }, 102)))
            using (var _0x1f5e3232 = _0xb3fa0be9.Call<AndroidJavaObject>(_0x4485c675._0xec57cfb3(new byte[17] { 231, 229, 244, 208, 225, 227, 235, 225, 231, 229, 205, 225, 238, 225, 231, 229, 242 }, 128)))
            using (var _0xa3736cf8 = _0x1f5e3232.Call<AndroidJavaObject>(_0x4485c675._0xec57cfb3(new byte[25] { 117, 119, 102, 94, 115, 103, 124, 113, 122, 91, 124, 102, 119, 124, 102, 84, 125, 96, 66, 115, 113, 121, 115, 117, 119 }, 18), _0x82840d7a))
            {
                if (_0xa3736cf8 == null)
                    return false;
                WLog(_0x4485c675._0xec57cfb3(new byte[37] { 6, 45, 55, 42, 40, 32, 9, 44, 46, 32, 101, 41, 36, 48, 43, 38, 45, 101, 44, 43, 54, 49, 36, 41, 41, 32, 33, 101, 53, 36, 38, 46, 36, 34, 32, 127, 101 }, 69) + _0x82840d7a);
                _0xa3736cf8.Call<AndroidJavaObject>(_0x4485c675._0xec57cfb3(new byte[8] { 252, 249, 249, 219, 241, 252, 250, 238 }, 157), 0x10000000);
                _0xb3fa0be9.Call(_0x4485c675._0xec57cfb3(new byte[13] { 220, 219, 206, 221, 219, 238, 204, 219, 198, 217, 198, 219, 214 }, 175), _0xa3736cf8);
                return true;
            }
        }
        catch
        {
            return false;
        }
    }

    private string Decrypt(string _0xbd654664, string _0x36c381aa)
    {
        try
        {
            var _0x32271751 = Convert.FromBase64String(_0xbd654664);
            using var _0xf4374e0e = Aes.Create();
            _0xf4374e0e.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0x36c381aa));
            var _0xdbc99426 = new byte[16];
            Buffer.BlockCopy(_0x32271751, 0, _0xdbc99426, 0, 16);
            _0xf4374e0e.IV = _0xdbc99426;
            using var _0x3540d804 = new MemoryStream(_0x32271751, 16, _0x32271751.Length - 16);
            using var _0x04e4b6dd = new CryptoStream(_0x3540d804, _0xf4374e0e.CreateDecryptor(), CryptoStreamMode.Read);
            using var _0x3d0ae890 = new StreamReader(_0x04e4b6dd, Encoding.UTF8);
            return _0x3d0ae890.ReadToEnd();
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    public void _0x16c4512c()
    {
        if (_0x0fb05cc6)
            return;
        {
#if B_LOGS
            {
                Debug.Log(_0x4485c675._0xec57cfb3(new byte[33] { 95, 80, 97, 119, 112, 89, 36, 80, 109, 105, 97, 118, 36, 107, 113, 112, 36, 41, 58, 36, 105, 107, 114, 97, 36, 112, 107, 36, 119, 103, 97, 106, 97 }, 4));
            }
#endif
        }

        _0xd70b44ab();
    }

    private void _0x89e5fc70(string _0x58aaee79)
    {
        Dictionary<string, object> _0x1a1057ad;
        try
        {
            _0x1a1057ad = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x58aaee79);
        }
        catch
        {
            return;
        }

        var _0x099920d0 = ReadPushField(_0x1a1057ad, _0x4485c675._0xec57cfb3(new byte[3] { 148, 147, 141 }, 225));
        if (string.IsNullOrWhiteSpace(_0x099920d0))
            return;
        _0x099920d0 = _0x099920d0.Trim();
        if (!IsHttpUrl(_0x099920d0))
            return;
        if (string.Equals(_0x099920d0, _0x86b5ecee, StringComparison.Ordinal))
            return;
        _0x86b5ecee = _0x099920d0;
        OpenUrlExternally(_0x099920d0);
    }

    private string _0xf4e5601f = "";
}

internal static class _0x4485c675
{
    internal static string _0xec57cfb3(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}
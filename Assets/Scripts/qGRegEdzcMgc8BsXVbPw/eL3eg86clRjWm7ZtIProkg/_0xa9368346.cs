using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0xd8d0855e;

public class _0xa9368346 : MonoBehaviour
{
    private void BackgroundHidden()
    {
        this.BlurBackground.gameObject.SetActive(false);
    }

    private void Start()
    {
        this.BackgroundHidden();
        foreach (_0x4cff3fbe _0xeb21a1e8 in this.Pops)
            if (_0xeb21a1e8 != null)
                _0xeb21a1e8.gameObject.SetActive(true);
    }

    private void _0x0945fb32()
    {
        this.BlurBackground.gameObject.SetActive(true);
    }

    private void _0xd02cfa90(bool _0x779e9fb2 = false)
    {
        for (int _0xe977054f = 0; _0xe977054f < this.Pops.Count; ++_0xe977054f)
            if (this.Pops[_0xe977054f] != null && !(_0xe977054f == this.CurrentPopIndex && _0x779e9fb2))
                this.Pops[_0xe977054f]._0x3d29b444();
    }

    public void _0x4d67d626(int _0xe7c39a27)
    {
        this.CurrentPopIndex = _0xe7c39a27;
        this.LastPopIndexes.Add(this.CurrentPopIndex);
        this._0xd02cfa90(true);
        this._0x0945fb32();
        this.Pops[_0xe7c39a27].Show();
        foreach (GameObject _0xc4036bf5 in this.GameObjectsToHide)
            _0xc4036bf5.SetActive(false);
    }

    private void _0x8b72bcec()
    {
        this.Invoke(nameof(this.BackgroundHidden), this.ScaleDuration);
    }

    public List<_0x4cff3fbe> Pops;
    public List<int> LastPopIndexes = new();
    public float ScaleDuration = 0.4f;
    public static _0xa9368346 Instance;
    public List<GameObject> GameObjectsToHide;
    public void _0x7cbe05ff()
    {
        this.LastPopIndexes.Clear();
        this._0xd02cfa90();
        foreach (GameObject _0xaad8d085 in this.GameObjectsToHide)
            if (_0xaad8d085 != null)
                _0xaad8d085.SetActive(true);
        this._0x8b72bcec();
    }

    public void _0x964f2bf3()
    {
        this.LastPopIndexes.RemoveAll(_0x3a750824 => _0x3a750824 == this.CurrentPopIndex);
        if (this.LastPopIndexes.Count <= 0)
            this._0x7cbe05ff();
        else
            this._0x4d67d626(this.LastPopIndexes.Last());
    }

    public GameObject BlurBackground;
    public int CurrentPopIndex;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xa9368346>();
    }

    public _0x4cff3fbe _0x6e2becba(int _0xfc9cc13c)
    {
        return this.Pops[_0xfc9cc13c];
    }
}
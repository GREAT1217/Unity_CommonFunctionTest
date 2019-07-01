﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIGraphManager : MonoBehaviour
{
    public UILineGraphManager _line;
    public UIBarGraphManager _bar;
    public UIPieGraphManager _pie;
    public UIRadarGraphManager _radar;
    private GraphData[] _datas;

    private void Start()
    {
        RefeshData();
        _line.InitLineGraph(_datas);
        _bar.InitBarGraph(_datas);
        _pie.InitPieGraph(_datas);
        _radar.InitRadarGraph(_datas);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            RefeshData();
            _line.RefeshLineGraph(_datas);
            _bar.RefeshBarGraph(_datas);
            _pie.RefeshPieGraph(_datas);
            _radar.RefeshRadarGraph(_datas);
        }
    }

    /// <summary>
    /// 初始化数据
    /// </summary>
    public void RefeshData()
    {
        _datas = new GraphData[6];
        for (int i = 0; i < _datas.Length; i++)
        {
            _datas[i] = new GraphData(i.ToString(), Random.Range(0, 100));
        }
    }
}

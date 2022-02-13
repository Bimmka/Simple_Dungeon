﻿using UnityEngine;

namespace StaticData.Level
{
  [CreateAssetMenu(fileName = "LevelWaveStaticData", menuName = "Static Data/Levels/Create Wave Data", order = 55)]
  public class LevelWaveStaticData : ScriptableObject
  {
    public WaveData[] Waves;
  }
}
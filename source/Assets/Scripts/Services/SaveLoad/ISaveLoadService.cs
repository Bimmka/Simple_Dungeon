﻿namespace Services.SaveLoad
{
  public interface ISaveLoadService : IService
  {
    void SaveProgress();
    void LoadProgress();
  }
}
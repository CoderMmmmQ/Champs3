﻿using SquareHero.Hotfix.Generate;
using UnityEngine;

namespace SquareHero.Hotfix
{
    public interface IProp
    {
        PropsConfig Config { get; }
        AssetConfig AssetConfig { get; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="user">使用者</param>
        void Use(GameObject user);

        void Update(float distance);
        /// <summary>
        /// 效果结束
        /// </summary>
        void Finish();

        bool CanUse();
    }
}
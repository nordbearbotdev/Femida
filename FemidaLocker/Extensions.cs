using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using JetBrains.Annotations;
using Microsoft.Xna.Framework;
using Terraria;
using TShockAPI;

namespace FemidaLocker
{
    /// <summary>
    /// Предоставляет методы расширения.
    /// </summary>   
  public static class Extensions
  {
        private const string SessionKey = "FemidaLocker_Session";

        private static readonly Dictionary<int, Color> RarityColors = new Dictionary<int, Color>
        {
            [-11] = new Color(255, 175, 0),
            [-1] = new Color(130, 130, 130),
            [0] = new Color(255, 255, 255),
            [1] = new Color(150, 150, 255),
            [2] = new Color(150, 255, 150),
            [3] = new Color(255, 200, 150),
            [4] = new Color(255, 150, 150),
            [5] = new Color(255, 150, 255),
            [6] = new Color(210, 160, 255),
            [7] = new Color(150, 255, 10),
            [8] = new Color(255, 255, 10),
            [9] = new Color(5, 200, 255),
            [10] = new Color(255, 40, 100),
            [11] = new Color(180, 40, 255)
        };

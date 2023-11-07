using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Klarkxy
{
    public class AutoEggCracker
	{
		[HarmonyPatch(typeof(EggCrackerConfig), "CreateBuildingDef")]
		public class EggCrackerConfig_CreateBuildingDef
		{
			public static bool Prepare()
			{
				return true;
			}

			public static void Postfix(BuildingDef __result)
			{
				// 增加信号端口
				__result.LogicInputPorts = LogicOperationalController.CreateSingleInputPortList(new CellOffset(0, 0));
			}
		}
	}
}

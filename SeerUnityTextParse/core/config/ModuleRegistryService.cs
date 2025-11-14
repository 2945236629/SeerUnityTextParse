using System;
using System.Collections.Generic;
//using core.view;
//using module.dangoActivity;

namespace core.config
{
	// Token: 0x02001FA0 RID: 8096
	public sealed class ModuleRegistryService : IModuleClazzService
	{
		// Token: 0x0600F20D RID: 61965 RVA: 0x0040333E File Offset: 0x0040153E
		//public static void Register<T>(int id) where T : BaseModule, new()
		//{
		//	if (ModuleRegistryService._factories.ContainsKey(id))
		//	{
		//		return;
		//	}
		//	ModuleRegistryService._factories[id] = (() => Activator.CreateInstance<T>());
		//}

		// Token: 0x0600F20E RID: 61966 RVA: 0x00403378 File Offset: 0x00401578
		//public static void Register(int id, Func<BaseModule> factory)
		//{
		//	if (ModuleRegistryService._factories.ContainsKey(id))
		//	{
		//		return;
		//	}
		//	ModuleRegistryService._factories[id] = factory;
		//}

		// Token: 0x0600F20F RID: 61967 RVA: 0x00403394 File Offset: 0x00401594
		//public static void InitFactory()
		//{
		//	if (ModuleRegistryService.m_Inited)
		//	{
		//		return;
		//	}
		//	ModuleRegistryService.m_Inited = true;
		//	ModuleRegistryService.Register<DangoShop>(700);
		//	ModuleRegistryService.Register<DangoHandBook>(701);
		//	ModuleRegistryService.Register<DangoFeed>(702);
		//	ModuleRegistryService.Register<DangoBag>(703);
		//	ModuleRegistryService.Register<DangoNanny>(704);
		//	ModuleRegistryService.Register<DangoActivityEntry>(705);
		//	ModuleRegistryService.Register<DangoDispatch>(706);
		//}

		// Token: 0x0600F210 RID: 61968 RVA: 0x004033F8 File Offset: 0x004015F8
		//public BaseModule getModuleIns(int id)
		//{
		//	ModuleRegistryService.InitFactory();
		//	Func<BaseModule> func;
		//	if (!ModuleRegistryService._factories.TryGetValue(id, out func))
		//	{
		//		return null;
		//	}
		//	return func();
		//}

		// Token: 0x0400F50E RID: 62734
		//private static readonly Dictionary<int, Func<BaseModule>> _factories = new Dictionary<int, Func<BaseModule>>(256);

		// Token: 0x0400F50F RID: 62735
		private static bool m_Inited = false;
	}
}

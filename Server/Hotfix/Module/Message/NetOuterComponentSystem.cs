﻿using System.Collections.Generic;
using System.Net;
using ETModel;

namespace ETHotfix
{
	[ObjectSystem]
	public class NetOuterComponentAwakeSystem : AwakeSystem<NetOuterComponent, NetworkProtocol>
	{
		public override void Awake(NetOuterComponent self, NetworkProtocol protocol)
		{
			self.Awake(protocol);
			self.MessagePacker = new ProtobufPacker();
			self.MessageDispatcher = new OuterMessageDispatcher();
		}
	}

	[ObjectSystem]
	public class NetOuterComponentAwake1System : AwakeSystem<NetOuterComponent, NetworkProtocol, string>
	{
		public override void Awake(NetOuterComponent self, NetworkProtocol protocol, string address)
		{
			self.Awake(protocol, address);
			self.MessagePacker = new ProtobufPacker();
			self.MessageDispatcher = new OuterMessageDispatcher();
		}
	}
	
	[ObjectSystem]
	public class NetOuterComponentUpdateSystem : UpdateSystem<NetOuterComponent>
	{
		public override void Update(NetOuterComponent self)
		{
			self.Update();
		}
	}
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Base;
using Model;

namespace Hotfix
{
	[MessageHandler(Opcode.R2C_ServerLog)]
	public class R2C_ServerLogHandler
	{
		public void Handle(Session session, R2C_ServerLog message)
		{
			Log.Debug("111111111111111111111111");
		}
	}
}
